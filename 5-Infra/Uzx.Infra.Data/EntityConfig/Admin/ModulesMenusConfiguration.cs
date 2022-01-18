using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ModulesMenusConfiguration : IEntityTypeConfiguration<ModulesMenus>
    {
        public void Configure(EntityTypeBuilder<ModulesMenus> builder)
        {
            builder.HasKey(s => s.IdModule);
            builder.Property(s => s.IdMenu);
        }

    }
}
