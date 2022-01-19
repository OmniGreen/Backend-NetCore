using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class LanguagesTraductionsTrans: BaseTrans
    {
        public Guid IdLanguage { get; set; }
        public Guid IdTraduction { get; set; }
    }
}
