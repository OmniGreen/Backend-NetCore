using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class UsersAccess : BaseEntityNaoVersionada
    {
        public  Guid UserAccessId { get; set; }
        public  Guid UserId { get; set; }
        public  string Login { get; set; }
        public  string Password { get; set; }
        public  bool IsVerify { get; set; }
        public  DateTime? DTVerify { get; set; }
    }
} 