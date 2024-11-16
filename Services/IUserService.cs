using TodoApi.Dtos;
using TodoApi.Entities;

namespace TodoApi.Services;

public interface IUserService
{
    Task<User> CreateUser(CreateUser dto);
}