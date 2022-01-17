using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TransportLinesConfiguration : IEntityTypeConfiguration<TransportLines>
    {
         public void Configure(EntityTypeBuilder<TransportLines> builder)
        {
            builder.HasKey(s => s.TransportLineId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");

        }
       
    }
}
