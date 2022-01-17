using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class GroupUsersTrans :BaseTrans
    {
        public Guid GroupUserId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid SystemId { get; set; }
        public string Name { get; set; }
        public Guid MenuId { get; set; }
        public Guid MenuIdPai { get; set; }
        public bool C { get; set; }
        public bool R { get; set; }
        public bool U { get; set; }
        public bool D { get; set; }
        public List<GroupUsersTrans> Children { get; set; }
        public int Space { get; set; }
        public bool HasChildren { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
