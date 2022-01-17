using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class SalePlansConfiguration : IEntityTypeConfiguration<SalePlans>
    {
        public void Configure(EntityTypeBuilder<SalePlans> builder)
        {
            builder.HasKey(s => s.SalePlanId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.PaymentLink).HasColumnType("varchar(200)");
            builder.Property(s => s.DurationMounth);

        }

    }
}
