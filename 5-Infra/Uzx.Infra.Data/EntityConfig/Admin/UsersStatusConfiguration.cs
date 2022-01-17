using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class UsersStatusConfiguration : IEntityTypeConfiguration<UsersStatus>
    {
         public void Configure(EntityTypeBuilder<UsersStatus> builder)
        {
            builder.HasKey(s => s.UserStatusId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");

        }
       
    }
}
