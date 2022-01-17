using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class BreedsConfiguration : IEntityTypeConfiguration<Breeds>
    {
        public void Configure(EntityTypeBuilder<Breeds> builder)
        {
            builder.HasKey(s => s.BreedsId);

            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
        }

    }
}
