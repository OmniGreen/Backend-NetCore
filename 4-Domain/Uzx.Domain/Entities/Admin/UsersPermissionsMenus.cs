using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class UsersPermissionsMenus : BaseEntityNaoVersionada
    {
        public  Guid UserPermissionMenuId { get; set; }        
        public  Guid UserPermissionId { get; set; }
        public  Guid MenuId { get; set; }
        public  bool C { get; set; }
        public  bool R { get; set; }
        public  bool U { get; set; }
        public  bool D { get; set; }
    }
} 