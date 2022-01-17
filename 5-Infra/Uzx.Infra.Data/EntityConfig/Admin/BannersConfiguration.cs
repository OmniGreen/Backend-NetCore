using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class BannersConfiguration : IEntityTypeConfiguration<Banners>
    {
        public void Configure(EntityTypeBuilder<Banners> builder)
        {
            builder.HasKey(s => s.BannerId);
            builder.Property(s => s.Title).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.Page).HasColumnType("varchar(200)");
            builder.Property(s => s.Position).HasColumnType("varchar(200)");
            builder.Property(s => s.NameBanner).HasColumnType("varchar(500)");

            builder.Property(s => s.CustomerId);
            builder.Property(s => s.DtStart);
            builder.Property(s => s.DtEnd);
    }

    }
}

