using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CustomersSocialMediaConfiguration : IEntityTypeConfiguration<CustomersSocialMedias>
    {
        public void Configure(EntityTypeBuilder<CustomersSocialMedias> builder)
        {
            builder.HasKey(s => s.CustomerId);
            builder.Property(s => s.SocialMediaId); //Guid

            builder.Property(s => s.Url).HasColumnType("varchar(500)");

        }

    }
}
