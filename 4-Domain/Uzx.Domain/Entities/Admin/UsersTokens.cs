using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{

    public  class UsersTokens : BaseEntityNaoVersionada
    {
        public  Guid UserTokenId { get; set; }
        public  Guid UserId { get; set; }
        public string Token { get; set; }
    }
} 