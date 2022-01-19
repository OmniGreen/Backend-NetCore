using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class ModulesLanguagesTrans: BaseTrans
    {
        public Guid IdModule { get; set; }
        public Guid IdLanguage { get; set; }
    }
}
