using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class GroupUsersConfiguration : IEntityTypeConfiguration<GroupUsers> {
        public void Configure (EntityTypeBuilder<GroupUsers> builder) {
            builder.HasKey (s => s.GroupUserId);
            builder.Property (s => s.SystemId); //Guid
            builder.Property (s => s.Name).HasColumnType ("varchar(200)");

        }

    }
}
