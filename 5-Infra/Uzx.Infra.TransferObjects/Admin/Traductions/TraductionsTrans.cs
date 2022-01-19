using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class TraductionsTrans: BaseTrans
    {
        public Guid IdTraduction { get; set; }
        public string NmTraduction { get; set; }
    }
}
