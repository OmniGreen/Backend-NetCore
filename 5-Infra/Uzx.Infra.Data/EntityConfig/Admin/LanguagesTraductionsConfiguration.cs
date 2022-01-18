using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class LanguagesTraductionsConfiguration : IEntityTypeConfiguration<LanguagesTraductions>
    {
        public void Configure(EntityTypeBuilder<LanguagesTraductions> builder)
        {
            builder.HasKey(s => s.IdLanguage);
            builder.Property(s => s.IdTraduction); //Guid

        }
    }
}
