using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class kinshipConfiguration : IEntityTypeConfiguration<Kinship>
    {
        public void Configure(EntityTypeBuilder<Kinship> builder)
        {
            builder.HasKey(s => s.KinshipId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
        }

    }
}
