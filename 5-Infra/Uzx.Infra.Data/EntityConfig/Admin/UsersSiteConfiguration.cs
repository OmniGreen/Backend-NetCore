using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class UsersSiteConfiguration : IEntityTypeConfiguration<UsersSite> 
    {
        public void Configure (EntityTypeBuilder<UsersSite> builder) {
            builder.HasKey (s => s.UserSiteId);
            builder.Property(s => s.Whatsapp).HasColumnType("varchar(20)");
        }

    }
}
