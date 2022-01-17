using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class CouponsTrans : BaseTrans
    {
        public Guid? CouponId { get; set; }

        public Guid? CustomerId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public int Quantity { get; set; }

        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

    }
}