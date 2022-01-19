using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UsersTrans : BaseTrans
  {
        public Guid IdUser { get; set; }
        public Guid IdGroupUser { get; set; }
        public Guid IdClient { get; set; }
        public string NmLogin { get; set; }
        public string Password { get; set; }
        public string NmEmail { get; set; }
        public UsersAccessTrans UsersAccess { get; set; }
    }
}
