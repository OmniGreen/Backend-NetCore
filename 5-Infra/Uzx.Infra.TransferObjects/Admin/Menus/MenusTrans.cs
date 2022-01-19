using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class MenusTrans :BaseTrans 
    {
        public Guid IdMenu { get; set; }
        public string NmMenu { get; set; }
    }
}
