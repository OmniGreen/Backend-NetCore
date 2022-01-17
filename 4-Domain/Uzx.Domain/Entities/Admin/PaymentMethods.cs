using System;
using System.Collections.Generic;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin {
    public class PaymentMethods : BaseEntityNaoVersionadaClient {
        public Guid PaymentMethodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

    }
}
