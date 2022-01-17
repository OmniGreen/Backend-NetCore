using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class NeighborhoodsConfiguration : IEntityTypeConfiguration<Neighborhoods> {
        public void Configure (EntityTypeBuilder<Neighborhoods> builder) {
            builder.HasKey (s => s.NeighborhoodId);
            builder.Property (s => s.Name).HasColumnType ("varchar(200)");
            builder.Property (s => s.Description).HasColumnType ("varchar(200)");

        }

    }
}
