using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class GroupUsersMenuTrans: BaseTrans
    {
        public Guid GroupUserId { get; set; }
        public Guid SystemId { get; set; }
    }
}
