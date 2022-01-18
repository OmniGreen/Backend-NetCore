using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class MenusConfiguration : IEntityTypeConfiguration<Menus>
    {
        public void Configure(EntityTypeBuilder<Menus> builder)
        {
            builder.HasKey(s => s.IdMenu);
            builder.Property(s => s.NmMenu).HasColumnType("varchar(200)");
        }

    }
}
