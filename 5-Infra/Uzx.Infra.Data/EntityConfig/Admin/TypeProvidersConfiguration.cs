using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TypeProvidersConfiguration : IEntityTypeConfiguration<TypeProviders>
    {
         public void Configure(EntityTypeBuilder<TypeProviders> builder)
        {
            builder.HasKey(s => s.TypeProviderId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");

        }
    }
}
