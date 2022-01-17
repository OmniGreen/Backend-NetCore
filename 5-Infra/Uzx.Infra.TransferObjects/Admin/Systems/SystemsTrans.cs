using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class SystemsTrans : BaseTrans
    {
        public  Guid SystemId { get; set; }
        public  string Name { get; set; }
        public  string Alt { get; set; }
        public  string Description { get; set; }
        public  string Image { get; set; }
        public  bool IsAdmin { get; set; }
    }
}
