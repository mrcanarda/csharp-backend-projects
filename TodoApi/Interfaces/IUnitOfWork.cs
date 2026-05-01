namespace TodoApi.Repositories;  // ✅ 

using TodoApi.Data;
using TodoApi.Interfaces; 

public interface IUnitOfWork
{
    ITodoRepository Todos {get; }
    Task<int> CompleteAsync();

}