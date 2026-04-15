using TodoApi.Models;

namespace TodoApi.Services;

public class TodoService : ITodoService
{
    private readonly List<TodoItem> _todos = new();
    private int _nextId = 1;

    public List<TodoItem> GetAll() => _todos;

    public void Add(CreateTodoDto dto)
    {
        var item = new TodoItem
        {
            Id = _nextId++,
            Title = dto.Title,
            Description = dto.Description,
            IsCompleted = false,
            CreatedAt = DateTime.UtcNow
        };

        _todos.Add(item);
    }
}