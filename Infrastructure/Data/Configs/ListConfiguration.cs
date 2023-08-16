using Microsoft.EntityFrameworkCore;
using List = Domain.Entities.Tasks.List;
using Domain.Entities.Tasks.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configs
{
    public class ListConfiguration : IEntityTypeConfiguration<List>
    {
        public void Configure(EntityTypeBuilder<List> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Id).HasConversion(c => c.Value, value => ListId.Create(value)).ValueGeneratedOnAdd();
        }
    }
}
