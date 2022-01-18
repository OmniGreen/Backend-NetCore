using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TenantsConfiguration : IEntityTypeConfiguration<Tenants>
    {
        public void Configure(EntityTypeBuilder<Tenants> builder)
        {
            builder.HasKey(s => s.IdTenant);
            builder.Property(s => s.NmTenant).HasColumnType("varchar(200)");
        }

    }
}
