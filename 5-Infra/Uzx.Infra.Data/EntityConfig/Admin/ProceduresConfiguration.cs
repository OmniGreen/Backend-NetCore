using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class ProceduresConfiguration : IEntityTypeConfiguration<Procedures>
    {
 public void Configure(EntityTypeBuilder<Procedures> builder)
        {
            builder.HasKey(s => s.ProcedureId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");
        }
       
    }
}
