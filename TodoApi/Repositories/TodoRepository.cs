namespace TodoApi.Repositories;

using TodoApi.Data;
using TodoApi.Interfaces;
using TodoApi.Models;

public class TodoRepository : ITodoRepository
{
    private readonly AppDbContext _context;

    public TodoRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<TodoItem> GetAll() => _context.Todos.ToList();

    public TodoItem? GetById(int id) => _context.Todos.FirstOrDefault(t => t.Id == id);

    public void Add(TodoItem item) => _context.Todos.Add(item);

    public void Update(TodoItem item) => _context.Todos.Update(item);

    public void Delete(TodoItem item) => _context.Todos.Remove(item);

    public void Save() => _context.SaveChanges();
}