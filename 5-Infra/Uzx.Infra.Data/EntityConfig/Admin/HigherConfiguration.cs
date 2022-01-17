using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class HigherConfiguration : IEntityTypeConfiguration<Higher>
    {
        public void Configure(EntityTypeBuilder<Higher> builder)
        {
            builder.HasKey(s => s.HigherId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");

        }

    }
}
