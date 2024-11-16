using TodoApi.Dtos;
using TodoApi.Entities;

namespace TodoApi.Services;

public class UserService : IUserService
{
    private readonly DatabaseContext _context;

    public UserService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<User> CreateUser(CreateUser dto)
    {
        try
        {
            User newUser = new()
            {
                Name = dto.Name,
                SureName = dto.SureName,
                UserName = dto.UserName,
                Email = dto.Email,
                Password = dto.Password
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return newUser;
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}