using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TypeTransportsConfiguration : IEntityTypeConfiguration<TypeTransports>
    {
         public void Configure(EntityTypeBuilder<TypeTransports> builder)
        {
            builder.HasKey(s => s.TypeTransportId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");

        }
       
    }
}
