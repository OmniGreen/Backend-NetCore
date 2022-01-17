using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class UsersPermissionsTrans : BaseTrans
    {
        public string UserId { get; set; }
        public string ClientId { get; set; }
        public string SystemId { get; set; }
    }
}
