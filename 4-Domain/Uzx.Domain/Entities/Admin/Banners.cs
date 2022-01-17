using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{

    public class Banners : BaseEntityNaoVersionadaClient 
    {
        [Key]
        public Guid BannerId { get; set; }
        public Guid CustomerId { get; set; }

        public string Title { get; set; }
 
        public string Description { get; set; }
        public string NameBanner { get; set; }
        public string Page { get; set; }
        public string Position { get; set; }

        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }

    }
}