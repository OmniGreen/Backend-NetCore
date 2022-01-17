using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    internal class AddressConfiguration : IEntityTypeConfiguration<Address> {
        public void Configure (EntityTypeBuilder<Address> builder) {

            builder.HasKey (s => s.AddressId);
            builder.Property (s => s.IsActive);
            builder.Property (s => s.UserIdInsert);
            builder.Property (s => s.DtInsert);
            builder.Property (s => s.IsDeleted);
            builder.Property (s => s.DtDeleted);
            builder.Property (s => s.UserIdDeleted);
            builder.Property (s => s.DtLastUpdate);
            builder.Property (s => s.UserIdUpdate);
            builder.Property (s => s.OwnerId);
            builder.Property (s => s.Country).HasColumnType ("varchar(100)");
            builder.Property (s => s.State).HasColumnType ("varchar(100)");
            builder.Property (s => s.City).HasColumnType ("varchar(100)");
            builder.Property (s => s.Neighborhood).HasColumnType ("varchar(100)");
            builder.Property (s => s.ZipCode).HasColumnType ("varchar(9)");
            builder.Property (s => s.Patio).HasColumnType ("varchar(100)");
            builder.Property (s => s.Number).HasColumnType ("varchar(10)");
            builder.Property (s => s.Complement).HasColumnType ("varchar(100)");

            //public AddressTypes AddressTypes { get; set; }

        }
    }
}
