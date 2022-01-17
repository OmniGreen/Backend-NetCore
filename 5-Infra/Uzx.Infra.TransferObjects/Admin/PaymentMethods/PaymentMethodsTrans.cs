using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class PaymentMethodsTrans : BaseTrans 
    {
        public Guid? PaymentMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

    }
}
