using Microsoft.EntityFrameworkCore;

namespace TodoApi.Entities;
public class DatabaseContext : DbContext
{
    public DatabaseContext() { }
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<TodoItem> TodoItems { get; set; }
}