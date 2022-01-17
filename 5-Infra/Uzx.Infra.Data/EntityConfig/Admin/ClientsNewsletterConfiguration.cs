using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ClientsNewsletterConfiguration : IEntityTypeConfiguration<ClientsNewsletter>
    {
        public void Configure(EntityTypeBuilder<ClientsNewsletter> builder)
        {
            builder.HasKey(s => s.ClientNewsletterId);
            builder.Property(s => s.Email).HasColumnType("varchar(200)");

        }

    }
}
