using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class CompanyOperators : BaseEntityNaoVersionadaClient
    {
        public Guid CompanyOperatorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alt { get; set; }
        public string Icone { get; set; }
    }
} 