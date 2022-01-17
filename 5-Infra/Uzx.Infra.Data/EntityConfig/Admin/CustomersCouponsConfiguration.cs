using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CustomersCouponsConfiguration : IEntityTypeConfiguration<CustomersCoupons>
    {
        public void Configure(EntityTypeBuilder<CustomersCoupons> builder)
        {
            builder.HasKey(s => s.CustomerId);
            builder.Property(s => s.CouponId); //Guid
        }

    }
}
