using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class GroupUsersMenus : BaseEntity
    {
        public  Guid GroupUserMenuId { get; set; }
        public  Guid GroupUserId { get; set; }
        public  Guid SystemId { get; set; }
        public  Guid MenuId { get; set; }
        public  bool C { get; set; }
        public  bool R { get; set; }
        public  bool U { get; set; }
        public  bool D { get; set; }
    }
} 