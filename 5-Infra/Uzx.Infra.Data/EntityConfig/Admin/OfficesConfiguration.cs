using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class OfficesConfiguration : IEntityTypeConfiguration<Offices>
    {
 public void Configure(EntityTypeBuilder<Offices> builder)
        {
            builder.HasKey(s => s.OfficeId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");

        }
       
    }
}
