
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Entities;

public class TodoItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(128)]
    public string Title { get; set; } = String.Empty;
    [MaxLength(1024)]
    public string? Description { get; set; }
    [Required]
    public bool IsCompleted { get; set; }
    [Precision(5)]
    public DateTime? DueDate { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }
}