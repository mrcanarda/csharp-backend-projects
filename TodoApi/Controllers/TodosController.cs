// Controllers/TodosController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TodoApi.Services;
using TodoApi.Models; // add this

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // add this 
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        throw new Exception("Test exception");
        return Ok(_todoService.GetAll());
    }
[HttpPost]
public IActionResult Add([FromBody] CreateTodoDto dto)
{
//    Console.WriteLine("Add method called!"); // add this
    _todoService.Add(dto);
    var all = _todoService.GetAll();
    var created = all.Last();
    
    var response = new TodoResponseDto
    {
        Id = created.Id,
        Title = created.Title,
        IsCompleted = created.IsCompleted,
        CreatedAt = created.CreatedAt
    };
    
    return Created("", response);
}
}