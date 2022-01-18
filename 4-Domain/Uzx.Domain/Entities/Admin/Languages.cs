using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class Languages : BaseEntityNaoVersionada
    {
        public  Guid IdLanguage { get; set; }
        public  string NmLanguage { get; set; }
    }
} 