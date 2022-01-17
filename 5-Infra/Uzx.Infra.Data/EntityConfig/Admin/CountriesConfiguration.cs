using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CountriesConfiguration : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder.HasKey(s => s.CountryId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Acronym).HasColumnType("varchar(200)");


        }
    }
}
