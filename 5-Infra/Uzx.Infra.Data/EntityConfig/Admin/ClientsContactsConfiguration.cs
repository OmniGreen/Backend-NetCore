using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ClientsContactsConfiguration : IEntityTypeConfiguration<ClientsContacts>
    {
        public void Configure(EntityTypeBuilder<ClientsContacts> builder)
        {
            builder.HasKey(s => s.ClientContactId);
            builder.Property(s => s.ContactName).HasColumnType("varchar(200)");
            builder.Property(s => s.ContactEmail).HasColumnType("varchar(200)");
            builder.Property(s => s.ContactSector).HasColumnType("varchar(200)");


        }
    }
}
