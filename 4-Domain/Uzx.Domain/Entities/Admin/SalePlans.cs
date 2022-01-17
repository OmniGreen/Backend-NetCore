using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{

    public class SalePlans : BaseEntityNaoVersionadaClient 
    {
        [Key]
        public Guid SalePlanId { get; set; }

        public string Name { get; set; }
 
        public string Description { get; set; }

        public int  DurationMounth { get; set; }

        public double Price { get; set; }

        public bool IsGuia { get; set; }
        public string PaymentLink { get; set; }
        public bool IsBanner { get; set; }
        public bool IsCoupons { get; set; }
        public bool IsEvents { get; set; }
        public bool IsDestaque { get; set; }
    }
}