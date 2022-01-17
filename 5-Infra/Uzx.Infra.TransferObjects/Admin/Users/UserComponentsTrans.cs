using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class UserComponentsTrans : BaseFind
    {
        public  UsersTrans Users { get; set; }
        public  UsersAccessTrans UsersAccess { get; set; }
    }
}