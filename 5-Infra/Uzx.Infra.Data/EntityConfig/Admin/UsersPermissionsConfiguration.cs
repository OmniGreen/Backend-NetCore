using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class UsersPermissionsConfiguration : IEntityTypeConfiguration<UsersPermissions>
    {
        public void Configure(EntityTypeBuilder<UsersPermissions> builder)
        {
            builder.HasKey(s => s.IdUser);
            builder.Property(s => s.IdMenu);

            //Properties Bool Type
            builder.Property(s => s.C);
            builder.Property(s => s.R);
            builder.Property(s => s.U);
            builder.Property(s => s.D);
        }

    }
}
