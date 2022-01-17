using NetDevPack.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class CustomersSalePlans : BaseEntityNaoVersionada
    {
        [Key]
        public Guid CustomerId { get; set; }
        public Guid SalePlanId { get; set; }

        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }

    }
}
