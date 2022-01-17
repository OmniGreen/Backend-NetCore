using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CouponsConfiguration : IEntityTypeConfiguration<Coupons>
    {
        public void Configure(EntityTypeBuilder<Coupons> builder)
        {
            builder.HasKey(s => s.CouponId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.CustomerId); //Guid
            builder.Property(s => s.Code).HasColumnType("varchar(200)");
            builder.Property(s => s.Value).HasColumnType("varchar(200)");
            builder.Property(s => s.Quantity);
            builder.Property(s => s.DtStart);
            builder.Property(s => s.DtEnd);
        }

    }
}
