using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class UsersPermissionsTrans : BaseTrans
    {
        public Guid IdUser { get; set; }
        public Guid IdMenu { get; set; }
        public bool C { get; set; }
        public bool R { get; set; }
        public bool U { get; set; }
        public bool D { get; set; }
    }
}
