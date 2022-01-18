using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class LanguagesTraductions: BaseEntityNaoVersionada
    {
        public Guid IdLanguage { get; set; }
        public Guid IdTraduction { get; set; }
    }
}
