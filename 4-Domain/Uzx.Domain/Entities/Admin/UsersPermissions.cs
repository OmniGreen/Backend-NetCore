using System;
using System.Collections.Generic;
using Uzx.Domain.Entities._Base;


namespace Uzx.Domain.Entities.Admin
{
    public  class UsersPermissions : BaseEntityNaoVersionadaClient
    {
        public  Guid UserPermissionId { get; set; }
        public  Guid UserId { get; set; }
        public  Guid SystemId { get; set; }        
        public  Guid GroupUserId { get; set; }
        // public  IEnumerable<Clients> Clients { get; set; }
        // public IEnumerable<Systems> Systems { get; set; }
        // public IEnumerable<GroupUsers> GroupUsers { get; set; }
    }
} 