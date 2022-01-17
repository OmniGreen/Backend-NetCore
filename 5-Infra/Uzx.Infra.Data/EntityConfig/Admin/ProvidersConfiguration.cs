using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ProvidersConfiguration : IEntityTypeConfiguration<Providers>
    {
        public void Configure(EntityTypeBuilder<Providers> builder)
        {
            builder.HasKey(s => s.ProviderId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");
        }
       
    }
}
