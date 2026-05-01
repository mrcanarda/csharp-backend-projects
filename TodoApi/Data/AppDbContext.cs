// 1. AppDbContext bizim "kütüphaneci" sınıfımız
// DbContext'ten kalıtım alıyor — EF Core'un tüm güçlerini kazanıyor
using Microsoft.EntityFrameworkCore.Design;
namespace TodoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TodoApi.Models;


public class AppDbContext : DbContext
{
    // 2. Constructor — kütüphaneci işe başlarken ayarları alıyor
    // DbContextOptions içinde "hangi veritabanına bağlan" bilgisi var
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // 3. DbSet = raftaki kitap koleksiyonu
    // Todos = SQL'deki "Todos" tablosu
    public DbSet<TodoItem> Todos { get; set; }
    public DbSet<User> Users {get; set;}
    public DbSet<Tag> Tags {get; set;}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<User>().HasData(
        new User { Id = 1, Username = "can", Email = "can@example.com" }
    );
}
}

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=TodoDb;User Id=sa;Password=TodoApi123!;TrustServerCertificate=True");

       return new AppDbContext(optionsBuilder.Options);

    }
}