using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class UsersSite : BaseEntityNaoVersionada
    {  
        public  Guid UserSiteId { get; set; }
        public  string Name { get; set; }
        public  string Email { get; set; }
        public string Whatsapp { get; set; }
        public string Password { get; set; }
    }
} 