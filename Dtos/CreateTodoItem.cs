using System.ComponentModel.DataAnnotations;

namespace TodoApi.Dtos;

public class CreateTodoItem {
    [Required]
    [MaxLength(128)]
    public string Title { get; set; }
    [MaxLength(1024)]
    public string? Description { get; set; }
    [Required]
    public DateTime? DueDate { get; set; }
}