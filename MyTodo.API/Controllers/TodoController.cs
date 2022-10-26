using Microsoft.AspNetCore.Mvc;
using MyTodo.API.Services;

namespace MyTodo.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    //private readonly ILogger<TodoController> _logger;

    //public TodoController(ILogger<TodoController> logger)
    //{
    //    _logger = logger;
    //}
    private readonly ITodoService _todoService;
    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet(Name = "GetTodos")]
    public async Task <IActionResult> Get()
    {
        var todos = await _todoService.GetAllTodos();
        return Ok(todos);
    }
}
