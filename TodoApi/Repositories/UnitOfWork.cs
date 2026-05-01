namespace TodoApi.Repositories;

using TodoApi.Data;
using TodoApi.Interfaces;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public ITodoRepository Todos { get; }

    public UnitOfWork(AppDbContext context, ITodoRepository todoRepository)
    {
        _context = context;
        Todos = todoRepository;
    }

    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }
}