using System;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class LanguagesTrans:BaseTrans
    {
        public Guid IdLanguage { get; set; }
        public string NmLanguage { get; set; }
    }
}
