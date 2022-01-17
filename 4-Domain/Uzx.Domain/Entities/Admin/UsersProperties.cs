using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class UsersProperties : BaseEntityNaoVersionada
    {
        public  Guid UserPropertieId { get; set; }
        public  Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime? DtBirth { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public  UsersTypes Type { get; set; }
    }
} 