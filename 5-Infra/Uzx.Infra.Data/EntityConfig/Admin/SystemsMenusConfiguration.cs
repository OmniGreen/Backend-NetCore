using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class SystemsMenusConfiguration : IEntityTypeConfiguration<SystemsMenus>
    {
         public void Configure(EntityTypeBuilder<SystemsMenus> builder)
        {
            builder.HasKey(s => s.SystemMenuId);
            builder.Property(s=> s.SystemId); //Guid
            builder.Property(s=> s.MenuId); //Guid
        }
       
    }
}
