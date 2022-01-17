using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class StatesConfiguration : IEntityTypeConfiguration<States>
    {
 public void Configure(EntityTypeBuilder<States> builder)
        {
            builder.HasKey(s => s.StateId);
            builder.Property(s=> s.CountryId); //Guid
            builder.Property(s=> s.Name).HasColumnType("varchar(200)");
            builder.Property(s=> s.Acronym).HasColumnType("varchar(200)");
        }
       
    }
}
