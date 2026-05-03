namespace TodoApi.Models;

using Microsoft.EntityFrameworkCore;

[Index(nameof(Title))]
[Index(nameof(UserId))]
public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int UserId { get; set; }
    public User? User { get; set; }

    public List<Tag> Tags { get; set; } = new();
}