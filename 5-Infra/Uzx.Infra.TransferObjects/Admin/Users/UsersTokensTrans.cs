using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UsersTokensTrans : BaseTrans
  {
      public  bool IsClient { get; set; }
      public  Guid UserAccessId { get; set; }
      public  Guid UserId { get; set; }
      public  string Login { get; set; }
      public  string Password { get; set; }
      public  bool IsVerify { get; set; }
      public  DateTime? DTVerify { get; set; }
  }
}
