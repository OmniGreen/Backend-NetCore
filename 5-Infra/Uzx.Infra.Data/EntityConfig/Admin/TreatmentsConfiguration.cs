using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TreatmentsConfiguration : IEntityTypeConfiguration<Treatments>
    {
 public void Configure(EntityTypeBuilder<Treatments> builder)
        {
            builder.HasKey(s => s.TreatmentId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");

        }
       
    }
}
