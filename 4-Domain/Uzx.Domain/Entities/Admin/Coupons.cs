using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Coupons : BaseEntityNaoVersionadaClient
    {
        [Key]
        public Guid CouponId { get; set; }

        public Guid CustomerId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public int Quantity { get; set; }

        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
    }
} 