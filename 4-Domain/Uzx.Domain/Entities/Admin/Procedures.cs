using System;
using Uzx.Domain.Entities._Base;


namespace Uzx.Domain.Entities.Admin
{
    public class Procedures : BaseEntityNaoVersionadaClient
    {
        public Guid ProcedureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
 