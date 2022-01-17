using System;
using System.Collections.Generic;


namespace Uzx.Infra.TransferObjects.Interfaces._Base
{
    public interface IBaseEntity
    {
        Guid? ClientId { get; set; }
        bool IsActive { get; set; }

        //DateTime DtInsert { get; set; }

        //bool IsDeleted { get; set; }

        //DateTime? DtDeleted { get; set; }

        //Guid? UserIdInsert { get; set; }

        //Guid? UserIdDeleted { get; set; }
    }
}
