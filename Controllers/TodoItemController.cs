using Microsoft.AspNetCore.Mvc;
using TodoApi.Dtos;
using TodoApi.Entities;
using TodoApi.Services;

namespace TodoApi.Controllers;
[ApiController]
[Route("api/todo-item")]
public class TodoItemController : ControllerBase
{
    private readonly TodoItemService _service;

    public TodoItemController(TodoItemService service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<TodoItem[]>>> GetAll()
    {
        IEnumerable<TodoItem> list = await _service.FindMany();
        return Ok(list);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<TodoItem>> Post([FromBody] CreateTodoItem dto)
    {
        TodoItem res = await _service.SaveTodoItem(dto);
        return CreatedAtAction(nameof(GetOne), new { id = res.Id }, res);
    }

    [HttpGet("{itemId}")]
    [ProducesResponseType<TodoItem>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TodoItem>> GetOne([FromRoute] int itemId)
    {
        TodoItem res = await _service.FindTodoItem(itemId);
        return res == null ? NotFound() : Ok(res);
    }

}