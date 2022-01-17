using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class ClientsSystemsConfiguration : IEntityTypeConfiguration<ClientsSystems> {
        public void Configure (EntityTypeBuilder<ClientsSystems> builder) {
            builder.HasKey (s => s.ClientSystemId);
            builder.Property (s => s.SystemId); //Guid
            //public  Systems System { get; set; }

        }
    }
}
