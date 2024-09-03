# API de Livraria Online

Esta é uma API básica desenvolvida em C# para simular uma livraria online. O objetivo é fornecer um exemplo de implementação de operações CRUD (Create, Read, Update, Delete) para livros, sem a necessidade de conexão com um banco de dados.

## Funcionalidades

- **Criar Livro**: Adicionar um novo livro à livraria.
- **Visualizar Livros**: Obter a lista de todos os livros cadastrados ou visualizar um livro específico pelo seu ID.
- **Editar Livro**: Atualizar as informações de um livro existente.
- **Excluir Livro**: Remover um livro do catálogo.

## Estrutura do Projeto

O projeto segue uma estrutura simples e organizada:

- **Controllers**: Contém os controllers que gerenciam as requisições HTTP e responses da API.
- **Communication**: 
  - **Requests**: Contém as classes de modelos que definem os dados esperados nas requisições (ex: `RequestRegisterBookJson`).
  - **Responses**: Contém as classes de modelos que definem os dados retornados nas respostas da API.


- **Response**: Status 204 No Content se a exclusão for bem-sucedida, ou 404 Not Found se o livro não existir.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET Core
- **Ferramentas**: Visual Studio, Swagger para documentação da API

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/apiLibrary.git
