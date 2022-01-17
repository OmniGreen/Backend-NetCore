using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class StatusSolicitationConfiguration : IEntityTypeConfiguration<StatusSolicitation>
    {
  public void Configure(EntityTypeBuilder<StatusSolicitation> builder)
        {
            builder.HasKey(s => s.SatusSolicitationId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");
        }
       
    }
}
