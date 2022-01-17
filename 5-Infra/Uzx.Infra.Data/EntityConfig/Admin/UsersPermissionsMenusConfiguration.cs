using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class UsersPermissionsMenusConfiguration : IEntityTypeConfiguration<UsersPermissionsMenus>
    {
         public void Configure(EntityTypeBuilder<UsersPermissionsMenus> builder)
        {
            builder.HasKey(s => s.UserPermissionMenuId);
            builder.Property(s=> s.UserPermissionId); //Guid
            builder.Property(s=> s.MenuId); //Guid
            builder.Property(s=> s.C); //Bool
            builder.Property(s=> s.R); //Bool
            builder.Property(s=> s.U); //Bool
            builder.Property(s=> s.D); //Bool
                   
        }
       
    }
}
