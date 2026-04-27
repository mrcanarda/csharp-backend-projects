// Services/TodoService.cs
using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Services;

public class TodoService : ITodoService
{
    // private readonly List<TodoItem> _todos = new();
    // private int _nextId = 1;

    private readonly AppDbContext _context; 

    public TodoService(AppDbContext context)
    {
        _context = context;
    }

    // public List<TodoItem> GetAll() => _todos;

    public List<TodoItem> GetAll() => _context.Todos.ToList();

public void Add(CreateTodoDto dto)
{
    var item = new TodoItem
    {
        Title = dto.Title,
        Description = dto.Description,
        IsCompleted = false,
        CreatedAt = DateTime.UtcNow
    };

    _context.Todos.Add(item);
    _context.SaveChanges();
}
}