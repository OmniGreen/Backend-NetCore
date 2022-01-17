using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class SystemsLanguagesTrans : BaseTrans
    {
        public  Guid SystemLanguageId { get; set; }
        public  Guid SystemId { get; set; }
        public  Guid LanguageId { get; set; }
        public  bool IsDefault { get; set; }
    }

    public  class listSytemsLanguagesTrans
    {
        public  List<SystemsLanguagesTrans> SystemsLanguages { get; set; }
    }
}
