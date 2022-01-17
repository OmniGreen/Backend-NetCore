using System;
using System.Collections.Generic;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class UsersPermissionMenuTrans
    {
        public string Name { get; set; }
        public Guid MenuId { get; set; }
        public Guid MenuIdPai { get; set; }
        public bool C { get; set; }
        public bool R { get; set; }
        public bool U { get; set; }
        public bool D { get; set; }
        public List<UsersPermissionMenuTrans> Children;
        public int Space { get; set; }
        public bool HasChildren { get; set; }
    }
}