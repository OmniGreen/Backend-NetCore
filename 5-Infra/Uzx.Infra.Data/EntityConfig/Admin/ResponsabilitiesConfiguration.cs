using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ResponsabilitiesConfiguration : IEntityTypeConfiguration<Responsabilities>
    { public void Configure(EntityTypeBuilder<Responsabilities> builder)
        {
            builder.HasKey(s => s.ResponsabilityId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");
            builder.Property(s=> s.Code).HasColumnType("varchar(200)");

        }
       
    }
}
