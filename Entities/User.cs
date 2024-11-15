using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Entities;

public class User{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(32)]
    public string Name { get; set; } = String.Empty;
    [Required]
    [MaxLength(32)]
    public string SureName { get; set; } = String.Empty;
    [Required]
    [MaxLength(32)]
    public string UserName { get; set; } = String.Empty;
    [Required]
    [MaxLength(512)]
    public string Password { get; set; } = String.Empty;
    [EmailAddress]
    [MaxLength(64)]
    public string? Email { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime UpdatedAt { get; set; }

    public ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();

}