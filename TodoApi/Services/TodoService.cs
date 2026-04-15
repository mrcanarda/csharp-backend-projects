namespace TodoApi.Services;

public class TodoService : ITodoService
{
    private readonly List<string> _items = new();

    public List<string> GetAll() => _items;

    public void Add(string item) => _items.Add(item);
} 