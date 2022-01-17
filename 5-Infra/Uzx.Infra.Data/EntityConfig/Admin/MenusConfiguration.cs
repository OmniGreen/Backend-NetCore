using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class MenusConfiguration : IEntityTypeConfiguration<Menus> {
        public void Configure (EntityTypeBuilder<Menus> builder) {
            builder.HasKey (s => s.MenuId);
            builder.Property (s => s.Name).HasColumnType ("varchar(200)");
            builder.Property (s => s.MenusTypeId); //Guid
            builder.Property (s => s.MenuIdPai); //Guid
            builder.Property (s => s.Description).HasColumnType ("varchar(200)");
            builder.Property (s => s.Link).HasColumnType ("varchar(200)");
            builder.Property (s => s.Target).HasColumnType ("varchar(200)");
            builder.Property (s => s.Icone).HasColumnType ("varchar(200)");
            builder.Property (s => s.Alt).HasColumnType ("varchar(200)");

            //  public List<Menus> Children;

        }

    }
}
