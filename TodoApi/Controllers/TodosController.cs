using Microsoft.AspNetCore.Mvc;
using TodoApi.Services;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
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
        return Ok(_todoService.GetAll());
    }

    [HttpPost]
    public IActionResult Add([FromBody] string item)
    {
        _todoService.Add(item);
        return Ok();
    }
}