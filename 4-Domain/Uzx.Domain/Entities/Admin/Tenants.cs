using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Tenants : BaseEntityNaoVersionada
    {
        public Guid IdTenant { get; set; }
        public string NmTenant { get; set; }
    }
    
}
