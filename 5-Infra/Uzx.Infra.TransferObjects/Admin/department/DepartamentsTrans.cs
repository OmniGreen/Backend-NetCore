using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class DepartmentsTrans : BaseTrans
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}