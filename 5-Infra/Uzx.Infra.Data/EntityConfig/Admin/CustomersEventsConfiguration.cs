using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CustomersEventsConfiguration : IEntityTypeConfiguration<CustomersEvents>
    {
        public void Configure(EntityTypeBuilder<CustomersEvents> builder)
        {
            builder.HasKey(s => s.CustomerId);
            builder.Property(s => s.EventId); //Guid

            

        }

    }
}
