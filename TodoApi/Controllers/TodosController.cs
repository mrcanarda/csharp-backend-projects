using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodosController : ControllerBase
{
    // Temporary in-memory list — will replace with DB later
    private static List<TodoItem> _todos = new();
    private static int _nextId = 1;

    // GET api/todos
    [HttpGet]
    public ActionResult<List<TodoItem>> GetAll()
    {
        return Ok(_todos);
    }

    // GET api/todos/1
    [HttpGet("{id}")]
    public ActionResult<TodoItem> GetById(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
            return NotFound();
        return Ok(todo);
    }

    // POST api/todos
    [HttpPost]
    public ActionResult<TodoItem> Create(TodoItem todo)
    {
        todo.Id = _nextId++;
        todo.CreatedAt = DateTime.UtcNow;
        _todos.Add(todo);
        return CreatedAtAction(nameof(GetById), new { id = todo.Id }, todo);
    }

    // PUT api/todos/1
    [HttpPut("{id}")]
    public ActionResult Update(int id, TodoItem updated)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
            return NotFound();

        todo.Title = updated.Title;
        todo.Description = updated.Description;
        todo.IsCompleted = updated.IsCompleted;

        return NoContent();
    }

    // DELETE api/todos/1
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo == null)
            return NotFound();

        _todos.Remove(todo);
        return NoContent();
    }
}