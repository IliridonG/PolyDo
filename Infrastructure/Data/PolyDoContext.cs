using Microsoft.EntityFrameworkCore;
using Task = Domain.Entities.Tasks.Task;
using Domain.Entities.Tasks;

namespace Infrastructure.Data
{
    public class PolyDoContext : DbContext
    {
        public PolyDoContext(DbContextOptions<PolyDoContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
        public DbSet<List> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PolyDoContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
