using System;
using Uzx.Infra.TransferObjects.Interfaces._Base;
 

namespace Uzx.Infra.TransferObjects._Base
{
    public  class BaseEntityTO : IBaseEntity
    {
        public Guid? ClientId { get; set; }
        public  bool IsActive { get; set; }
        //public  DateTime DtInsert { get; set; }
        //public  bool IsDeleted { get; set; }        
        //public  DateTime? DtDeleted { get; set; }
        //public  Guid? UserIdInsert { get; set; }
        //public  Guid? UserIdDeleted { get; set; }
    }
}
