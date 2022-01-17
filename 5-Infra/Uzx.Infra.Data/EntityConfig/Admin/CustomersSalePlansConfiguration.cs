using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CustomersSalePlansConfiguration : IEntityTypeConfiguration<CustomersSalePlans>
    {
        public void Configure(EntityTypeBuilder<CustomersSalePlans> builder)
        {
            builder.HasKey(s => s.CustomerId);
            builder.Property(s => s.SalePlanId); //
            builder.Property(s => s.DtStart); //
            builder.Property(s => s.DtEnd); //
        }

    }
}

