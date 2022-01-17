using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class UsersPermissionsConfiguration : IEntityTypeConfiguration<UsersPermissions>
    {
        public void Configure(EntityTypeBuilder<UsersPermissions> builder)
        {
            builder.HasKey(s => s.UserPermissionId);
            builder.Property(s=> s.UserId); //Guid
            builder.Property(s=> s.SystemId); //Guid
            builder.Property(s=> s.GroupUserId); //Guid
            // public  IEnumerable<Clients> Clients { get; set; }
             // public IEnumerable<Systems> Systems { get; set; }
            // public IEnumerable<GroupUsers> GroupUsers { get; set; }
        
        }
       
    }
}
