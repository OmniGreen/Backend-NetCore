using System;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class LanguagesTrans:BaseTrans
    {
        public  Guid LanguageId { get; set; }
        public  string Name { get; set; }
        public  string Country { get; set; }
        public  string FileName { get; set; }
        public  string Alt { get; set; }
        public  string Description { get; set; }
        public  string Image { get; set; }
        public  bool IsDefault { get; set; }      
    }
}
