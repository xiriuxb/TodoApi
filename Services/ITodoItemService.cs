using TodoApi.Dtos;
using TodoApi.Entities;

namespace TodoApi.Services;
public interface ITodoItemService
{
    Task<TodoItem> SaveTodoItem(CreateTodoItem dto);
    Task<TodoItem> FindTodoItem(int itemId);
    Task<IEnumerable<TodoItem>> FindMany();
}