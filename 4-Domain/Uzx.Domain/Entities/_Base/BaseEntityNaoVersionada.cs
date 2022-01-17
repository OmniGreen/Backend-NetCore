using System;

namespace Uzx.Domain.Entities._Base
{
    public class BaseEntityNaoVersionada : BaseEntity
    {
        //Informa a data da ultima alteração
        public DateTime? DtLastUpdate { get; set; }

        //Informa o id do usuário que realizou a ultima alteração
        public Guid? UserIdUpdate { get; set; }
    }
}
