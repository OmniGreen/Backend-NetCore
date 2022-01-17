using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class GroupUsersMenusConfiguration : IEntityTypeConfiguration<GroupUsersMenus> {
        public void Configure (EntityTypeBuilder<GroupUsersMenus> builder) {
            builder.HasKey (s => s.GroupUserMenuId);
            builder.Property (s => s.GroupUserId); //Guid
            builder.Property (s => s.SystemId); //Guid
            builder.Property (s => s.MenuId); //Guid

            //Properties Bool Type
            builder.Property (s => s.C);
            builder.Property (s => s.R);
            builder.Property (s => s.U);
            builder.Property (s => s.D);

        }

    }
}
