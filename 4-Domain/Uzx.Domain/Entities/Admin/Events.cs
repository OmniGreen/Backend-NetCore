using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Events : BaseEntityNaoVersionadaClient
    {
        [Key]
        public Guid EventId { get; set; }
        public Guid CustomerId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Place{ get; set; }

        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }


        public Guid CategoryId { get; set; }
        public string Whats { get; set; }
        public string Site { get; set; }
        public string CompraOnline { get; set; }
        public string Imagem { get; set; }
        public string Street { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string LkFacebook { get; set; }
        public string LkTwitter { get; set; }
        public string LkGooglePlus { get; set; }
        public string LkLinkedin { get; set; }
        public string LkYoutube { get; set; }
        public string LkInstagram { get; set; }
    }
} 