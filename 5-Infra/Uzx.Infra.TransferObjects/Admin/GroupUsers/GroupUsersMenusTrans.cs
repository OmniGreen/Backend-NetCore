using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class GroupUsersMenusTrans: BaseTrans
    {
        public Guid IdGroupUser { get; set; }
        public Guid IdMenu { get; set; }
        public Guid IdModule { get; set; }
    }
}
