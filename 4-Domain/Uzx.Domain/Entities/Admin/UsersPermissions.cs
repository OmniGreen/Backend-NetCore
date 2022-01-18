using System;
using System.Collections.Generic;
using Uzx.Domain.Entities._Base;


namespace Uzx.Domain.Entities.Admin
{
    public  class UsersPermissions : BaseEntityNaoVersionadaClient
    {
        public  Guid IdUser { get; set; }
        public  Guid IdMenu { get; set; }
        public  bool C{ get; set; }          
        public  bool R{ get; set; }         
        public  bool U{ get; set; }           
        public  bool D{ get; set; }               
       
    }
} 