using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class AgentsConfiguration : IEntityTypeConfiguration<Agents>
    {
        public void Configure(EntityTypeBuilder<Agents> builder)
        {
            builder.HasKey(s => s.AgentId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");

            // public virtual IEnumerable<Clients> Clients { get; set; }
        }

    }
}
