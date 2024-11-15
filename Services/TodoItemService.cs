using Microsoft.EntityFrameworkCore;
using TodoApi.Dtos;
using TodoApi.Entities;

namespace TodoApi.Services;

public class TodoItemService : ITodoItemsService
{
    private readonly DatabaseContext _context;

    public TodoItemService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<TodoItem> SaveTodoItem(CreateTodoItem dto)
    {
        try
        {
            TodoItem newTodoItem =
                new TodoItem
                {
                    Title = dto.Title.Trim(),
                    IsCompleted = false,
                    DueDate = dto.DueDate,
                    Description = dto.Description,
                };
            _context.TodoItems.Add(newTodoItem);
            await _context.SaveChangesAsync();

            return newTodoItem;
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public async Task<TodoItem> FindTodoItem(int itemId)
    {
        try
        {
            TodoItem? todoItem = await
                _context.TodoItems.FirstOrDefaultAsync(tI => tI.Id == itemId);
            return todoItem;
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<TodoItem>> FindMany(){
        try
        {
            var items = await _context.TodoItems.ToListAsync();
            return items;
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}
