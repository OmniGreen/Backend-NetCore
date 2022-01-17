using System;
using Uzx.Domain.Entities._Base;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class SystemsLanguages : BaseEntity
    {
        public  Guid SystemLanguageId { get; set; }
       
        public  Guid SystemId { get; set; }

        public  Guid LanguageId { get; set; } 

        public  bool IsDefault { get; set; }
    }
} 