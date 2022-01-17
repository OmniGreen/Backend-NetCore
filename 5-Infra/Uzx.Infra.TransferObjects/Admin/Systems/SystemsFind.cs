using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class SystemsFind : BaseFind<List<SystemsTrans>>
    {
        public  string Name { get; set; }
        public  int Active { get; set; }
    }
}
