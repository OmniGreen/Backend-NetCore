using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class TenantsTrans: BaseTrans
    {
        public Guid IdTenant { get; set; }
        public string NmTenant { get; set; }
    }
}
