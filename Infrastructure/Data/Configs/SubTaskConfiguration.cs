using Microsoft.EntityFrameworkCore;
using Domain.Entities.Tasks.ValueObjects;
using SubTask = Domain.Entities.Tasks.Subtask;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configs
{
    public class SubTaskConfiguration : IEntityTypeConfiguration<SubTask>
    {
        public void Configure(EntityTypeBuilder<SubTask> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Id).HasConversion(c => c.Value, value => SubTaskId.Create(value)).ValueGeneratedOnAdd();
        }
    }
}
