using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ModulesConfiguration : IEntityTypeConfiguration<Modules>
    {
        public void Configure(EntityTypeBuilder<Modules> builder)
        {
            builder.HasKey(s => s.IdModule);
            builder.Property(s => s.NmModule).HasColumnType("varchar(200)");

        }

    }
}
