using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class CustomersTrans : BaseTrans
    {
        public Guid? CustomerId { get; set; }

        public Guid? CategoryId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Amenities { get; set; }
        public string Specialties { get; set; }
        public string VideoLink { get; set; }
        public string PaymentMethods { get; set; }

        public bool IsDenied { get; set; }
        public string DeniedDescription { get; set; }

        public string Logo { get; set; }
        public bool? LogoIsVisible { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberIsVisible { get; set; }

        public string PhoneNumber2 { get; set; }
        public bool PhoneNumberIsVisible2 { get; set; }

        public string Whats { get; set; }
        public bool? WhatsIsVisible { get; set; }


        public string Site { get; set; }
        public bool? SiteIsVisible { get; set; }
        public string Email { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public Guid? SalePlanId { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public bool? EmailIsVisible { get; set; }

        public string Street { get; set; }
        public bool? AddressIsVisible { get; set; }

        public string LkFacebook { get; set; }
        public string LkTwitter { get; set; }
        public string LkGooglePlus { get; set; }
        public string LkLinkedin { get; set; }
        public string LkYoutube { get; set; }
        public string LkInstagram { get; set; }

        public Guid? NeighborhoodId { get; set; }
        public string Timetable { get; set; }
        public List<string> PaymentMethodsImages { get; set; }

        public string Images { get; set; }

        public Guid? UserSiteId { get; set; }
        public bool? IsGhost { get; set; }

        public bool IsDestaque { get; set; }
        public bool IsFree { get; set; }

    }
}