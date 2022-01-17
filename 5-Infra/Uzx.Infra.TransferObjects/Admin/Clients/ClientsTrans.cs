using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class ClientsTrans : BaseTrans
    {
        public Guid ParentId { get; set; }
        public string Person { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Document1 { get; set; }
        public string Document2 { get; set; }
        public string Gender { get; set; }
        public DateTime? DtBirth { get; set; }
        public bool IsAdmin { get; set; }
        public List<ClientsSystemsTrans> ClientsSystems { get; set; }
    }
}
