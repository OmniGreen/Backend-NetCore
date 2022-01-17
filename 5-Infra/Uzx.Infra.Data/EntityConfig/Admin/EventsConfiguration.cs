using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class EventsConfiguration : IEntityTypeConfiguration<Events>
    {
        public void Configure(EntityTypeBuilder<Events> builder)
        {
            builder.HasKey(s => s.EventId);
            builder.Property(s => s.Title).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.PhoneNumber).HasColumnType("varchar(200)");
            builder.Property(s => s.Email).HasColumnType("varchar(200)");
            builder.Property(s => s.Place).HasColumnType("varchar(500)");
            builder.Property(s => s.CustomerId);
            builder.Property(s => s.DtStart);
            builder.Property(s => s.DtEnd);
            builder.Property(s => s.IsActive);
            builder.Property(s => s.CategoryId);
        }

    }
}
