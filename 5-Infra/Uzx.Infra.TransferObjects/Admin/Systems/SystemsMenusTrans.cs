using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class SystemsMenusTrans : BaseTrans
    {
        public  Guid SystemMenuId { get; set; }
        public  Guid SystemId { get; set; }
        public  Guid MenuId { get; set; }
        public bool HasMenus { get; set; }
        public string Name { get; set; }
        public List<NeighborhoodsTrans> ListMenus { get; set; }
    }

    public  class listSytemsMenusTrans
    {
        public  List<SystemsMenusTrans> systemsMenu { get; set; }
    }
}
