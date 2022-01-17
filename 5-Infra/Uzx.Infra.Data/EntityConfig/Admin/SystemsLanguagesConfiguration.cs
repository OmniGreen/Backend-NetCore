using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class SystemsLanguagesConfiguration : IEntityTypeConfiguration<SystemsLanguages>
    {
         public void Configure(EntityTypeBuilder<SystemsLanguages> builder)
        {
            builder.HasKey(s => s.SystemLanguageId);
            builder.Property(s=> s.SystemId); //Guid
            builder.Property(s=> s.LanguageId); //Guid
            builder.Property(s=> s.IsDefault); //Bool
        }
       
    }
}
