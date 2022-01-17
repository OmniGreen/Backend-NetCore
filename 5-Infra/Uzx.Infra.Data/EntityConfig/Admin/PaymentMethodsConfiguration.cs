using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class PaymentMethodsConfiguration : IEntityTypeConfiguration<PaymentMethods> {
        public void Configure (EntityTypeBuilder<PaymentMethods> builder) {
            builder.HasKey (s => s.PaymentMethodId);
            builder.Property (s => s.Name).HasColumnType ("varchar(200)");
            builder.Property (s => s.Description).HasColumnType ("varchar(200)");

        }

    }
}
