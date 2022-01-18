using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class GroupUsersConfiguration : IEntityTypeConfiguration<GroupUsers> {
        public void Configure(EntityTypeBuilder<GroupUsers> builder)
        {
            builder.HasKey(s => s.IdGroupUser);
            builder.Property(s => s.IdClient); //Guid
            builder.Property(s => s.NmGroupUser).HasColumnType("varchar(200)");

        }

    }
}
