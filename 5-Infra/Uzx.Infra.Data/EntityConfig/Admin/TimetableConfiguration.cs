using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class TimetableConfiguration : IEntityTypeConfiguration<Timetable> {
        public void Configure (EntityTypeBuilder<Timetable> builder) {
            builder.HasKey (s => s.TimetableId);


        }

    }
}
