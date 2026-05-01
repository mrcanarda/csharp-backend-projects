using TodoApi.Models;

namespace TodoApi.Services;

public interface ITodoService
{
    List<TodoItem> GetAll();
    void Add(CreateTodoDto dto);
    List<TodoItem> GetCompleted();
    TodoItem? GetById(int id);
}