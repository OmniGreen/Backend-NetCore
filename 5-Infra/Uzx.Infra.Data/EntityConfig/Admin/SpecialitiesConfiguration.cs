using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class SpecialitiesConfiguration : IEntityTypeConfiguration<Specialities>
    {
 public void Configure(EntityTypeBuilder<Specialities> builder)
        {
            builder.HasKey(s => s.SpecialityId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");
        }
       
    }
}
