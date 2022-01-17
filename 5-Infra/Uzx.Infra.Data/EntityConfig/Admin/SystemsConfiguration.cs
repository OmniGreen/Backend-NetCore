using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class SystemsConfiguration : IEntityTypeConfiguration<Systems>
    { public void Configure(EntityTypeBuilder<Systems> builder)
        {
            builder.HasKey(s => s.SystemId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Alt).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");
            builder.Property(s=> s.Image).HasColumnType("varchar(200)");
            builder.Property(s=> s.IsAdmin); //Bool
        }
       
    }
}
