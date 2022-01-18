using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class UsersProfileConfiguration : IEntityTypeConfiguration<UsersProfile>
    {
        public void Configure(EntityTypeBuilder<UsersProfile> builder)
        {
            builder.HasKey(s => s.IdUserProfile);
            builder.Property(s => s.IdUser); //Guid
            builder.Property(s => s.NmUser).HasColumnType("varchar(200)");
            builder.Property(s => s.NmSurname).HasColumnType("varchar(200)");
            builder.Property(s => s.DtBirth); //DateTime
            builder.Property(s => s.NbCPF).HasColumnType("varchar(14)");
            builder.Property(s => s.NbRG).HasColumnType("varchar(12)");
            builder.Property(s => s.NmMother).HasColumnType("varchar(200)");
            builder.Property(s => s.NmFather).HasColumnType("varchar(200)");
            builder.Property(s => s.IdMaritalStatus); //Guid
            builder.Property(s => s.NbPis).HasColumnType("varchar(50)");
        }

    }
}
