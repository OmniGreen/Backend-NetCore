using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class GroupUsers : BaseEntity
    {
        public  Guid GroupUserId { get; set; }
        public  Guid SystemId { get; set; }
        public  string Name { get; set; }
    }
} 