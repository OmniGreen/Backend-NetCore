using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UsersTrans : BaseTrans
  {
      public  Guid UserId { get; set; }
      public string Name { get; set; }
      public string Login { get; set; }
      public string Surname { get; set; }
      public string Gender { get; set; }
      public string Cpf { get; set; }
      public string Rg { get; set; }
      public  DateTime? DtBirth { get; set; }
      public string Nationality { get; set; }
      public string Phone { get; set; }
      public string CellPhone { get; set; }
      public string Icone { get; set; }
        public UsersAccessTrans UsersAccess { get; set; }
    }
}
