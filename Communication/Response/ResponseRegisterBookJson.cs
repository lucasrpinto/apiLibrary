namespace apiLibrary.Communication.Response;

public class ResponseRegisterBookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public decimal Price { get; set; } = decimal.Zero;
    public int Stock { get; set; }
}
