using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
 public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(s => s.StatusId);
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Description).HasColumnType("varchar(200)");
        }
       
    }
}
