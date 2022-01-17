using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class UsersPermissionsMenusTrans :BaseTrans
    {
        public Guid UserPermissionMenuId { get; set; }
        public Guid UserPermissionId { get; set; }
        public Guid MenuId { get; set; }
        public bool C { get; set; }
        public bool R { get; set; }
        public bool U { get; set; }
        public bool D { get; set; }
    }
}
