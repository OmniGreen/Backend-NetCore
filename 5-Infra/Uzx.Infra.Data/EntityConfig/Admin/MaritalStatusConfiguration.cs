using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class MaritalStatusConfiguration : IEntityTypeConfiguration<MaritalStatus>
    {
 public void Configure(EntityTypeBuilder<MaritalStatus> builder)
        {
            builder.HasKey(s => s.IdMaritalStatus);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");  
        
        }
       
    }
}
