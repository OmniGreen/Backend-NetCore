using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class UsersTokensConfiguration : IEntityTypeConfiguration<UsersTokens>
    {
         public void Configure(EntityTypeBuilder<UsersTokens> builder)
        {
            builder.HasKey(s => s.UserTokenId);
            builder.Property(s=> s.UserId); //Guid
            builder.Property(s=> s.Token).HasColumnType("varchar(200)");
        }
       
    }
}
