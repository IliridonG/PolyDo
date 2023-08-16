using Microsoft.EntityFrameworkCore;
using Task = Domain.Entities.Tasks.Task;
using Domain.Entities.Tasks.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configs
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder) 
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(c => c.Value, value => TaskId.Create(value)).ValueGeneratedOnAdd();
        }
    }
}
