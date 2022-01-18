using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class GroupUsersMenusConfiguration : IEntityTypeConfiguration<GroupUsersMenus> {
        public void Configure (EntityTypeBuilder<GroupUsersMenus> builder) {
            builder.HasKey (s => s.IdGroupUser);
            builder.Property (s => s.IdMenu); //Guid
            builder.Property (s => s.IdModule); //Guid
        }

    }
}
