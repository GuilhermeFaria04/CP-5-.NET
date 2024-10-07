# CRUD WebAPI em .NET com MongoDB

## Objetivo

Este projeto tem como objetivo desenvolver uma WebAPI em .NET para realizar operações CRUD (Create, Read, Update, Delete) em uma entidade. A aplicação utiliza o MongoDB como sistema de banco de dados para armazenamento dos dados.

## Tecnologias Utilizadas

- [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MongoDB](https://www.mongodb.com/)
- [xUnit](https://xunit.net/) para testes unitários


## Requisitos

- Implementar o endpoint de inclusão dos dados.
- Implementar o endpoint de alteração dos dados.
- Implementar o endpoint de exclusão dos dados.
- Implementar o endpoint de consulta dos dados.
- Utilizar o MongoDB para armazenamento dos dados.
- Trabalhar com chamadas assíncronas dos dados.
- Ter um projeto de testes unitários utilizando xUnit.

## Endpoints da API

### 1. Inclusão de Dados

- **Método**: POST
- **Endpoint**: `/api/produtos`
- **Descrição**: Cria um novo produto.

### 2. Alteração de Dados

- **Método**: PUT
- **Endpoint**: `/api/produtos/{id}`
- **Descrição**: Atualiza as informações de um produto existente.

### 3. Exclusão de Dados

- **Método**: DELETE
- **Endpoint**: `/api/produtos/{id}`
- **Descrição**: Remove um produto existente.

### 4. Consulta de Dados

- **Método**: GET
- **Endpoint**: `/api/produtos`
- **Descrição**: Retorna todos os produtos.

## Configuração do MongoDB

Para configurar o MongoDB, você deve adicionar as configurações de conexão no arquivo `appsettings.json`:

```json
{
  "MongoDBSettings": {
    "ConnectionString": "sua_string_de_conexao",
    "DatabaseName": "seu_nome_do_banco"
  }
}
```

## Como Executar o Projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/SeuUsuario/SeuRepositorio.git
   ```


