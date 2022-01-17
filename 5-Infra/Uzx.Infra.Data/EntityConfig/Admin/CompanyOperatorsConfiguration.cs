using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class CompanyOperatorsConfiguration : IEntityTypeConfiguration<CompanyOperators>
    {
        public void Configure(EntityTypeBuilder<CompanyOperators> builder)
        {
            builder.HasKey(s => s.CompanyOperatorId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");
            builder.Property(s => s.Alt).HasColumnType("varchar(200)");
            builder.Property(s => s.Icone).HasColumnType("varchar(200)");

        }

    }
}
