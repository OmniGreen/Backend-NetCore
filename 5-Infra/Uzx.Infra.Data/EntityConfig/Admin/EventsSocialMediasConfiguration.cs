using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class EventsSocialMediasConfiguration : IEntityTypeConfiguration<EventsSocialMedias>
    {
        public void Configure(EntityTypeBuilder<EventsSocialMedias> builder)
        {
            builder.HasKey(s => s.EventId);
            builder.Property(s => s.Url).HasColumnType("varchar(500)");
            builder.Property(s => s.SocialMediaId);

        }

    }
}
