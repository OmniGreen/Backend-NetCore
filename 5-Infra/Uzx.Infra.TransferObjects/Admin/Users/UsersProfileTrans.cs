using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UsersProfileTrans : BaseTrans
  {
        public Guid IdUserProfile { get; set; }
        public Guid IdUser { get; set; }
        public string NmUser { get; set; }
        public string NmSurname { get; set; }
        public DateTime DtBirth { get; set; }
        public string NbCPF { get; set; }
        public string NbRG { get; set; }
        public string NmMother { get; set; }
        public string NmFather { get; set; }
        public Guid IdMaritalStatus { get; set; }
        public string NbPis { get; set; }
    }
}
