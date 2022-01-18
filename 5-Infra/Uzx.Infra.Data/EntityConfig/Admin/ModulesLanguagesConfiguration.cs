using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ModulesLanguagesConfiguration : IEntityTypeConfiguration<ModulesLanguages>
    {
        public void Configure(EntityTypeBuilder<ModulesLanguages> builder)
        {
            builder.HasKey(s => s.IdModule);
            builder.Property(s => s.IdLanguage);
        }

    }
}
