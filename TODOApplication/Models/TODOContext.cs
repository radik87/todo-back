using Microsoft.EntityFrameworkCore;

namespace TODOApplication.Models
{
    public class TODOContext : DbContext
    {
        public DbSet<TaskTodo> TaskTodos { get; set; }

        public TODOContext(DbContextOptions<TODOContext> options)
            : base(options)
        {
            Database.Migrate();
        }
    }
}
