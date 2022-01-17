using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UsersSiteTrans : BaseTrans
  {

      public  Guid? UserSiteId { get; set; }
      public string Name { get; set; }
      public  string Email { get; set; }
      public string Whatsapp { get; set; }
      public  string Password { get; set; }

  }
}
