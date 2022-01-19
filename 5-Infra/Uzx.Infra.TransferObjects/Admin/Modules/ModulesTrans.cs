using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class ModulesTrans: BaseTrans
    {
        public Guid IdModule { get; set; }
        public string NmModule { get; set; }
    }
}
