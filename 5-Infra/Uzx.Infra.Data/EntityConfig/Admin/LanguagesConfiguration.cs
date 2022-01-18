using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class LanguagesConfiguration : IEntityTypeConfiguration<Languages>
    {
        public void Configure(EntityTypeBuilder<Languages> builder)
        {
            builder.HasKey(s => s.IdLanguage);
            builder.Property(s => s.NmLanguage).HasColumnType("varchar(200)");
        }


    }
}
