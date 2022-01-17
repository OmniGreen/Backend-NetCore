using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class CitiesConfiguration : IEntityTypeConfiguration<Cities> {
        public void Configure (EntityTypeBuilder<Cities> builder) {
            builder.HasKey (s => s.CityId);
            builder.Property (s => s.StateId); //Guid
            builder.Property (s => s.ZipCode).HasColumnType ("varchar(9)");
            builder.Property (s => s.Name).HasColumnType ("varchar(200)");
        }

    }
}
