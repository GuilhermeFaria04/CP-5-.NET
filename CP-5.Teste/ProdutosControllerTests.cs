using Xunit;
using CP_5.Controllers;
using CP_5.Models;
using MongoDB.Driver;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace CP_5.Tests
{
	public class ProdutosControllerTests
	{
		private readonly ProdutosController _controller;
		private readonly Mock<IMongoCollection<Produto>> _mockCollection;

		public ProdutosControllerTests()
		{
			_mockCollection = new Mock<IMongoCollection<Produto>>();
			_controller = new ProdutosController(_mockCollection.Object);
		}

		[Fact]
		public async Task Get_ReturnsOkResult()
		{
			// Arrange
			var produtos = new List<Produto>
			{
				new Produto { Id = "1", Nome = "Produto Teste", Preco = 10.0m}
			};
			_mockCollection.Setup(c => c.FindAsync(It.IsAny<FilterDefinition<Produto>>(), null, default))
				.ReturnsAsync(produtos.ToAsyncEnumerable().GetAsyncEnumerator());

			// Act
			var result = await _controller.Get();

			// Assert
			Assert.IsType<OkObjectResult>(result);
		}
	}
}
