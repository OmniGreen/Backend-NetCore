using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class SalePlansTrans : BaseTrans
    {
        public Guid? SalePlanId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PaymentLink { get; set; }

        public int DurationMounth { get; set; }

        public double Price { get; set; }
        public bool? IsGuia { get; set; }
        public bool? IsBanner { get; set; }
        public bool? IsCoupons { get; set; }
        public bool? IsEvents { get; set; }
        public bool? IsDestaque { get; set; }
    }
}