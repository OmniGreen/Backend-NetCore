using System;

namespace Uzx.Domain.Entities._Base
{
    public class BaseEntityNaoVersionadaClient : BaseEntity
    {
        //Informa a qual Cliente pertence o registro
        public Guid? ClientId { get; set; }
        //Informa a data da ultima alteração
        public DateTime? DtLastUpdate { get; set; }
        //Informa o id do usuário que realizou a ultima alteração
        public Guid? UserIdUpdate { get; set; }
    }
}
