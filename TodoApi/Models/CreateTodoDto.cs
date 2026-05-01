// Models/CreateTodoDto.cs
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class CreateTodoDto
{
    [Required(ErrorMessage = "Title is required.")]
    [MinLength(3, ErrorMessage = "Title must be at least 3 characters.")]
    [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
    public string? Title { get; set; }

    [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string? Description { get; set; }

    [Required]
    public int UserId {get; set;}
}
