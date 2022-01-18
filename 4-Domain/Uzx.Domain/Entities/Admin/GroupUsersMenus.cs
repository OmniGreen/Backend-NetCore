using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class GroupUsersMenus : BaseEntity
    {
        public  Guid IdGroupUser { get; set; }
        public  Guid IdMenu { get; set; }
        public  Guid IdModule { get; set; }
     
    }
} 