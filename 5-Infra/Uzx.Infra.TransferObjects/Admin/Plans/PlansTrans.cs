using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class PlansTrans : BaseTrans
    {
        public Guid PlanId { get; set; }
        public Guid CompanyOperatorId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string Code { get; set; }
    }
}