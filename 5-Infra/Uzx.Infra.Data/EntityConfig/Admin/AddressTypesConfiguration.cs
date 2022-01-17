using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class AddressTypesConfiguration : IEntityTypeConfiguration<AddressTypes>
    {
        public void Configure(EntityTypeBuilder<AddressTypes> builder)
        {
            builder.HasKey(s => s.AdressTypesId);

            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");


        }

    }
}
