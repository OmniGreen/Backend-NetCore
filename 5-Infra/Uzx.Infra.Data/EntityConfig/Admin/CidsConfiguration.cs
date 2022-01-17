using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CidsConfiguration : IEntityTypeConfiguration<Cids>
    {
        public void Configure(EntityTypeBuilder<Cids> builder)
        {
            builder.HasKey(s => s.CidsId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
        }

    }
}
