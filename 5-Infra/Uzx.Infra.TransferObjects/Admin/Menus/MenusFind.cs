using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class MenusFind : BaseFind<List<MenusTrans>>
    {
        public string Name { get; set; }
        public int Active { get; set; }
    }
}
