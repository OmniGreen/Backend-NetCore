using System;
using System.Collections.Generic;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class SystemsMenusRetorno
    {
        public  string Name { get; set; }
        public Guid MenuId { get; set; }
        public Guid MenuIdPai { get; set; }
        public  List<SystemsMenusRetorno> Children;
        public  int Space { get; set; }
        public  bool HasChildren { get; set; }
    }
}
