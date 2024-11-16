using System.ComponentModel.DataAnnotations;

namespace TodoApi.Dtos;

public class RegisterUser
{
    [Required]
    [MaxLength(32)]
    public string UserName { get; set; } = String.Empty;
    [Required]
    [MaxLength(24)]
    public string Password { get; set; } = String.Empty;
}