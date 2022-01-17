using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CustomersBannersConfiguration : IEntityTypeConfiguration<CustomersBanners>
    {
        public void Configure(EntityTypeBuilder<CustomersBanners> builder)
        {
            builder.HasKey(s => s.CustomerId);
            builder.Property(s => s.BannerId); //
        }

    }
}
