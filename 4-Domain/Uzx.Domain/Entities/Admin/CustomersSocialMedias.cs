using NetDevPack.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class CustomersSocialMedias : BaseEntityNaoVersionada
    {
        [Key]
        public Guid CustomerId { get; set; }
        public Guid SocialMediaId { get; set; }
        public string Url { get; private set; }
       
    }
}
