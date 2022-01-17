using Uzx.Domain.Entities._Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Uzx.Domain.Entities.Admin
{
    public class Users : BaseEntityNaoVersionadaClient
    {
        [Key]
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime? DtBirth { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Icone { get; set; }
    }
} 
