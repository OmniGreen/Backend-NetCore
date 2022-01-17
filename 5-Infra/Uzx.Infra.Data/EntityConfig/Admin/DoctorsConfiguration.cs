using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class DoctorsConfiguration : IEntityTypeConfiguration<Doctors>
    {
        public void Configure(EntityTypeBuilder<Doctors> builder)
        {
            builder.HasKey(s => s.DoctorsId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");



        }

    }
}
