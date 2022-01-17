using System;
  
namespace Uzx.Infra.TransferObjects._Base
{
    public  abstract class BaseEntityTONaoVersionada : BaseEntityTO
    {
        public  DateTime? DtLastUpdate { get; set; }

        public  Guid? UserIdUpdate { get; set; } 
    }
}
