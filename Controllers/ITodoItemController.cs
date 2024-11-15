using Microsoft.AspNetCore.Mvc;
using TodoApi.Dtos;
using TodoApi.Entities;

namespace TodoApi.Controllers;

public interface ITodoItemController
{
    Task<ActionResult<IEnumerable<TodoItem[]>>> GetAll();
    Task<ActionResult<TodoItem>> Post(CreateTodoItem dto);
    Task<ActionResult<TodoItem>> GetOne(int itemId);
}