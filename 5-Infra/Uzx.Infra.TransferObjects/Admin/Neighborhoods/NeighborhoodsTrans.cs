using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class NeighborhoodsTrans :BaseTrans 
    {
        public Guid? NeighborhoodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
     
    }
}
