using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TodoApi.Services;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;
    private readonly ILogger<TodoController> _logger;

    public TodoController(ITodoService todoService, ILogger<TodoController> logger)
    {
        _todoService = todoService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        _logger.LogInformation("GetAll called");
        return Ok(_todoService.GetAll());
    }

    [HttpPost]
    public IActionResult Add([FromBody] CreateTodoDto dto)
    {
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

    [HttpGet("completed")]
    public IActionResult GetCompleted()
    {
        return Ok(_todoService.GetCompleted());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var todo = _todoService.GetById(id);
        if (todo == null) return NotFound();
        return Ok(todo);
    }
}