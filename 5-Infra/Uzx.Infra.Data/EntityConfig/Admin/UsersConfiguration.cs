using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(s => s.IdUser);
            builder.Property(s => s.IdGroupUser);
            builder.Property(s => s.IdClient);
            builder.Property(s => s.NmLogin).HasColumnType("varchar(200)");
            builder.Property(s => s.Password).HasColumnType("varchar(200)");
            builder.Property(s => s.NmEmail).HasColumnType("varchar(200)");
        }
    }
}
