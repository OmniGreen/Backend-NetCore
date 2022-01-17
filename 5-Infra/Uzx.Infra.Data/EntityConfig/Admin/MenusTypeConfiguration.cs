using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class MenusTypeConfiguration : IEntityTypeConfiguration<MenusTypes>
    {
 public void Configure(EntityTypeBuilder<MenusTypes> builder)
        {
            builder.HasKey(s => s.MenusTypeId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
        }
       
    }
}
