using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class PlansConfiguration : IEntityTypeConfiguration<Plans>
    { public void Configure(EntityTypeBuilder<Plans> builder)
        {
            builder.HasKey(s => s.PlanId);
            builder.Property(s => s.CompanyOperatorId); //Guid
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.Code).HasColumnType("varchar(200)");
        }
       
    }
}
