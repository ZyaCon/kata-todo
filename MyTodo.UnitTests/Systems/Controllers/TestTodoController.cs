using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MyTodo.API.Controllers;
using MyTodo.API.Models;
using MyTodo.API.Services;

namespace MyTodo.UnitTests.Systems.Controllers;

public class TestTodoController
{
    [Fact]
    public async Task Get_OnSuccess_ReturnStatusCode200()
    {
        // Arrange
        var mockTodoService = new Mock<ITodoService>();
        var sut = new TodoController(mockTodoService.Object);

        // Act
        var result = (OkObjectResult)await sut.Get();

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_InvokesTodoServiceExactlyOnce()
    {
        // Arrange
        var mockTodoService = new Mock<ITodoService>();
        mockTodoService
            .Setup(service => service.GetAllTodos())
            .ReturnsAsync(new List<Todo>());

        var sut = new TodoController(mockTodoService.Object);

        // Act
        var result = await sut.Get();

        // Assert
        mockTodoService.Verify(
            service => service.GetAllTodos(),
            Times.Once());
    }

    [Fact]
    public async Task Get_OnSuccess_ReturnsListOfTodos()
    {
        // Arrange
        var mockTodoService = new Mock<ITodoService>();
        mockTodoService
            .Setup(service => service.GetAllTodos())
            .ReturnsAsync(new List<Todo>());

        var sut = new TodoController(mockTodoService.Object);

        // Act
        // Assert
    }
}