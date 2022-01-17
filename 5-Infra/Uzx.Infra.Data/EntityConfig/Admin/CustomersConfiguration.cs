using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Infra.Data.EntityConfig.Admin {
    public class CustomersConfiguration : IEntityTypeConfiguration<Customers> {
        public void Configure (EntityTypeBuilder<Customers> builder) {
            builder.HasKey (s => s.CustomerId);
            builder.Property (s => s.CategoryId); //Guid
            
            builder.Property (s => s.Name).HasColumnType ("varchar(200)");
            builder.Property (s => s.Logo).HasColumnType ("varchar(200)");
            builder.Property (s => s.PhoneNumber).HasColumnType ("varchar(200)");
            builder.Property (s => s.Site).HasColumnType ("varchar(200)");
            builder.Property (s => s.Email).HasColumnType ("varchar(200)");
            
            builder.Property (s => s.LogoIsVisible); 
            builder.Property (s => s.PhoneNumberIsVisible); 
            builder.Property(s => s.SiteIsVisible);  
            builder.Property(s => s.EmailIsVisible); 

            builder.Property (s => s.AddressIsVisible);
            builder.Property(s => s.UserIdInsert);
            builder.Property (s => s.IsDeleted);       
            builder.Property (s => s.DtDeleted);
            builder.Property (s => s.UserIdDeleted);
            builder.Property (s => s.UserIdUpdate);






    }

    }
}
