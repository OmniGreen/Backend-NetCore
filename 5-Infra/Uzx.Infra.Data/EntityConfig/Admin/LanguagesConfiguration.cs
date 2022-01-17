using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class LanguagesConfiguration : IEntityTypeConfiguration<Languages>
    {
 public void Configure(EntityTypeBuilder<Languages> builder)
        {
            builder.HasKey(s => s.LanguageId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Country).HasColumnType("varchar(200)");
            builder.Property(s => s.FileName).HasColumnType("varchar(200)");
            builder.Property(s => s.Alt).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.Image).HasColumnType("varchar(200)");
           



        }
        
       
    }
}
