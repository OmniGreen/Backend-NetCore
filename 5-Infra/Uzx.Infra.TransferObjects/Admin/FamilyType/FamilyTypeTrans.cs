using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class FamilyTypeTrans : BaseTrans
    {
        public  Guid FamilyTypeId { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }
    }
}