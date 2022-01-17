using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class FunctionsConfiguration : IEntityTypeConfiguration<Functions>
    {
        public void Configure(EntityTypeBuilder<Functions> builder)
        {
            builder.HasKey(s => s.FunctionId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");


        }
    }
}
