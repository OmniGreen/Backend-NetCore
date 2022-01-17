using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class UsersAccessConfiguration : IEntityTypeConfiguration<UsersAccess> 
    {
        public void Configure (EntityTypeBuilder<UsersAccess> builder) {
            builder.HasKey (s => s.UserAccessId);
            builder.Property (s => s.UserId); //Guid
            builder.Property (s => s.Login).HasColumnType ("varchar(200)");
            builder.Property (s => s.Password).HasColumnType ("varchar(200)");
            builder.Property (s => s.IsVerify); //Bool
            builder.Property (s => s.DTVerify); //DateTime
            builder.Property (s => s.IsActive); //Bool
            builder.Property (s => s.UserIdInsert);
            builder.Property (s => s.DtInsert);
            builder.Property (s => s.IsDeleted);       
            builder.Property (s => s.DtDeleted);
            builder.Property (s => s.UserIdDeleted);
            builder.Property (s => s.UserIdUpdate);
        }

    }
}
