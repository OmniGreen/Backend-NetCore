using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Traductions: BaseEntityNaoVersionada
    {
        public Guid IdTraduction { get; set; }
        public string NmTraduction { get; set; }
    }
}
