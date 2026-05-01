namespace TodoApi.Interfaces;

using TodoApi.Models;

public interface ITodoRepository
{
    List<TodoItem> GetAll();
    TodoItem? GetById(int id);
    void Add(TodoItem item);
    void Update(TodoItem item);
    void Delete(TodoItem item);
    void Save();
}