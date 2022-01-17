using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class UsersFind : BaseFind<List<UsersTrans>>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public int Active { get; set; }

    }
}
