using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class TreatmentsTrans : BaseTrans
    {
        public  Guid TreatmentId { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }
    }
}