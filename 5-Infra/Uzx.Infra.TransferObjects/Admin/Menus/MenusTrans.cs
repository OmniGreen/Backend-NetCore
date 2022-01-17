using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class MenusTrans :BaseTrans 
    {
        public Guid MenuId { get; set; }
        public string Name { get; set; }
        public string NameLink { get; set; }
        public Guid MenusTypeId { get; set; }
        public Guid MenuIdPai { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string Link { get; set; }
        public string TaRget { get; set; }
        public string Icone { get; set; }
        public string Alt { get; set; }
        public List<MenusTrans> Children { get; set; }
        public bool HasChildren { get; set; }
        public int Space { get; set; }
        public int Nivel { get; set; }
    }
}
