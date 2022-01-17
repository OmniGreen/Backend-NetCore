using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;


namespace Uzx.Infra.Data.EntityConfig.Admin
{
    public class EducationsConfiguration : IEntityTypeConfiguration<Educations>
    {
        public void Configure(EntityTypeBuilder<Educations> builder)
        {
            builder.HasKey(s => s.EducationId);
            builder.Property(s => s.Name).HasColumnType("varchar(200)");
            builder.Property(s => s.Description).HasColumnType("varchar(200)");


        }

    }
}
