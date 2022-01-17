using System;
using System.Collections.Generic;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class GroupUsersRetorno
  {
    public string Name { get; set; }
    public  Guid GroupUserId { get; set; }
    public  Guid SystemId { get; set; }
    public bool IsActive { get; set; }
    public  List<GroupUsersTrans> ListUsersPermission { get; set; }
  }
}