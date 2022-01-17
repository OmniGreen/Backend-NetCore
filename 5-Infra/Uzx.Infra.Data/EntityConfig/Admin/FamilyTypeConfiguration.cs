using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class FamilyTypeConfiguration : IEntityTypeConfiguration<FamilyType>
    {
        public void Configure(EntityTypeBuilder<FamilyType> builder)
        {
            builder.HasKey(s => s.FamilyTypeId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");

        }

    }
}
