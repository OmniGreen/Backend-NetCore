using NetDevPack.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class CustomersEvents : BaseEntityNaoVersionada
    {
        [Key]
        public Guid CustomerId { get; set; }
        public Guid EventId { get; set; }

    }
}
