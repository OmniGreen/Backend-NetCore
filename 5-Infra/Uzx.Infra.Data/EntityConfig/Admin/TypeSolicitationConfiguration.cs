using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class TypeSolicitationConfiguration : IEntityTypeConfiguration<TypeSolicitation>
    {
        public void Configure(EntityTypeBuilder<TypeSolicitation> builder)
        {
            builder.HasKey(s => s.TypeSolicitationId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");

        }
       
    }
}
