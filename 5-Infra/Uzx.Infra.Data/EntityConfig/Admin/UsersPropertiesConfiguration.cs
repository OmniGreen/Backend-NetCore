using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class UsersPropertiesConfiguration : IEntityTypeConfiguration<UsersProperties> {
        public void Configure (EntityTypeBuilder<UsersProperties> builder) {
            builder.HasKey (s => s.UserPropertieId);
            builder.Property (s => s.UserId); //Guid
            builder.Property (s => s.Name).HasColumnType ("varchar(200)");
            builder.Property (s => s.Surname).HasColumnType ("varchar(200)");
            builder.Property (s => s.Gender).HasColumnType ("varchar(200)");
            builder.Property (s => s.Cpf).HasColumnType ("varchar(13)");
            builder.Property (s => s.Rg).HasColumnType ("varchar(12)");
            builder.Property (s => s.DtBirth); //DateTime
            builder.Property (s => s.Nationality).HasColumnType ("varchar(200)");
            builder.Property (s => s.Phone).HasColumnType ("varchar(14)");
            builder.Property (s => s.CellPhone).HasColumnType ("varchar(14)");
            // public  UsersTypes Type { get; set; }

        }

    }
}
