using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class ClientsOperatorsConfiguration : IEntityTypeConfiguration<ClientsOperators> {
        public void Configure (EntityTypeBuilder<ClientsOperators> builder) {
            builder.HasKey (s => s.ClientOperatorId);
            builder.Property (s => s.OperatorId); //Guid

        }

    }
}
