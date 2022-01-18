using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class GroupUsers : BaseEntity
    {
        public  Guid IdGroupUser { get; set; }
        public  Guid IdClient { get; set; }
        public  string NmGroupUser { get; set; }

    }
} 