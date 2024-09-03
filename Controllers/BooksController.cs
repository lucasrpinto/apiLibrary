using apiLibrary.Communication.Requests;
using apiLibrary.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace apiLibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    // Reponsável por fazer a busca de um livro somente
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromHeader] int id)
    {
        var response = new Book()
        {
            Id = 1,
            Title = "Breves Repostas para Grandes Questões",
            Author = "Stephan Hawkink",
            Genre = "Autobiografia/Biografia",
            Price = 40.70m,
            Stock = 15

        };

        if (id != 1)
            return NotFound("Book not found");

        return Ok(response);
    }
    
    
    // Responsável por buscar todos os livros criados
    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Title = "Breves Repostas para Grandes Questões",
                Author = "Stephan Hawkink",
                Genre = "Autobiografia/Biografia",
                Price = 40.70m,
                Stock = 15
            },

            new Book
            {
                Id = 2,
                Title = "Ilha Misteriosa",
                Author = "Julio Verne",
                Genre = "Ficção",
                Price = 30.50m,
                Stock = 13
            }
        };
        return Ok(response);
    }

    
    // Reponsável pela criação dos cadastro de livros
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody]RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = 2,
            Author = request.Author,
            Genre = request.Genre,
            Price = request.Price,
            Stock = request.Stock,
            Title = request.Title,
        };
        return Created(string.Empty, response);
    } 

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody]RequestRegisterBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

}
