// Services/TodoService.cs
using TodoApi.Data;
using TodoApi.Models;
using Microsoft.EntityFrameworkCore;


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
        CreatedAt = DateTime.UtcNow,
        UserId = dto.UserId
    };

    _context.Todos.Add(item);
    _context.SaveChanges();
}

public List<TodoItem> GetCompleted()
{
    return _context.Todos.Where(t => t.IsCompleted == true).ToList();
}

public TodoItem? GetById(int id)
{
    return _context.Todos.FirstOrDefault(t => t.Id == id);
}
public async Task<List<TodoItem>> GetAllAsync()
{
    return await _context.Todos.ToListAsync();
}

public async Task<TodoItem?> GetByIdAsync(int id)
{
    return await _context.Todos.FirstOrDefaultAsync(t => t.Id == id);
}

public async Task AddAsync(CreateTodoDto dto)
{
    var item = new TodoItem
    {
        Title = dto.Title,
        Description = dto.Description,
        IsCompleted = false,
        CreatedAt = DateTime.UtcNow,
        UserId = dto.UserId
    };

    await _context.Todos.AddAsync(item);
    await _context.SaveChangesAsync();
}

}

