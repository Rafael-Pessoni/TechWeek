using Microsoft.EntityFrameworkCore;

namespace ToDoList.Model
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Interessado> Interessados { get; set; }
    }
}
