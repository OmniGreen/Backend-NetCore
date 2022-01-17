using NetDevPack.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class CustomersCoupons : BaseEntityNaoVersionada
    {
        [Key]
        public Guid CustomerId { get; set; }
        public Guid CouponId { get; set; }

    }
}
