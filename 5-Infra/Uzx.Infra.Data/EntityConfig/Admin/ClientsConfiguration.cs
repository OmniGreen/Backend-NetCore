using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class ClientsConfiguration : IEntityTypeConfiguration<Clients> {
        public void Configure (EntityTypeBuilder<Clients> builder) {
            builder.HasKey (s => s.ClientId);
            builder.Property (s => s.ParentId); //Guid
            builder.Property (s => s.AgentId); //Guid
            builder.Property (s => s.Person).HasColumnType ("varchar(200)");
            builder.Property (s => s.Name1).HasColumnType ("varchar(200)");
            builder.Property (s => s.Name2).HasColumnType ("varchar(200)");
            builder.Property (s => s.Document1).HasColumnType ("varchar(200)");
            builder.Property (s => s.Document2).HasColumnType ("varchar(200)");
            builder.Property (s => s.Gender).HasColumnType ("varchar(200)");
            builder.Property (s => s.DtBirth); //DateTime
            builder.Property (s => s.IsAdmin); //Bool 
            builder.Property (s => s.UserIdInsert);
            builder.Property (s => s.DtInsert);
            builder.Property (s => s.IsDeleted);       
            builder.Property (s => s.DtDeleted);
            builder.Property (s => s.UserIdDeleted);
            builder.Property (s => s.UserIdUpdate);

            // public virtual List<ClientsSystems> ClientsSystems { get; set; }
        }

    }
}
