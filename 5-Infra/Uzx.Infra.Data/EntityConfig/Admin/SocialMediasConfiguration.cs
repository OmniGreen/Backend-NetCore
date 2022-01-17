using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class SocialMediasConfiguration : IEntityTypeConfiguration<SocialMedias>
    {
        public void Configure(EntityTypeBuilder<SocialMedias> builder)
        {
            builder.HasKey(s => s.SocialMediaId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.Icon).HasColumnType("varchar(200)");
    }

    }
}

