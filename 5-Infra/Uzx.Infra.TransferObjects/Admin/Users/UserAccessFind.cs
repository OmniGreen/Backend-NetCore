using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UsersAccessFind : BaseFind<List<UsersAccessTrans>>
  {
    public  Guid UserId { get; set; }

    public  bool IsClient { get; set; }
  }
}
