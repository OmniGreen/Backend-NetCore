using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class HospitalsConfiguration : IEntityTypeConfiguration<Hospitals>
    {
        public void Configure(EntityTypeBuilder<Hospitals> builder)
        {
            builder.HasKey(s => s.HospitalId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");

        }

    }
}
