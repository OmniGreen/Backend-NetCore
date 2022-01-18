using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TraductionsConfiguration : IEntityTypeConfiguration<Traductions>
    {
        public void Configure(EntityTypeBuilder<Traductions> builder)
        {
            builder.HasKey(s => s.IdTraduction);
            builder.Property(s => s.NmTraduction).HasColumnType("varchar(200)");
        }

    }
}
