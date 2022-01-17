using System;
using System.Collections.Generic;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UsersPermissionMenuRetorno
  {
    public Guid UsersPermissionId { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public Guid? ClientId { get; set; }
    public string ClientName { get; set; }
    public Guid SystemId { get; set; }
    public string SystemName { get; set; }
    public Guid GroupUserId { get; set; }
    public string GroupUsersName { get; set; }
    public  List<UsersPermissionsMenusTrans> PermissionMenu { get; set; }
  }
}