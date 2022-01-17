using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Clients : BaseEntityNaoVersionada
    {
        [Key]
         public Guid ClientId { get; set; }

        public Guid ParentId { get; set; }

        public Guid? AgentId { get; set; }

        public string Person { get; set; }

        public string Name1 { get; set; }

        public string Name2 { get; set; }
        public string Document1 { get; set; }

        public string Document2 { get; set; }

        public string Gender { get; set; }

        public DateTime? DtBirth { get; set; }

        public bool IsAdmin { get; set; }

        // public virtual List<ClientsSystems> ClientsSystems { get; set; }
    }


     
}
