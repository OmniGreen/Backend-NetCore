using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class CompanyOperatorsTrans : BaseTrans
    {
        public Guid CompanyOperatorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alt { get; set; }
        public string Icone { get; set; }
    }
}
