using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TransportsConfiguration : IEntityTypeConfiguration<Transports>
    {
 public void Configure(EntityTypeBuilder<Transports> builder)
        {
            builder.HasKey(s => s.TransportId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");

        }
       
    }
}
