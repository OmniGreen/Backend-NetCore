using System;
using System.Collections.Generic;
using System.Text;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Modules : BaseEntityNaoVersionada
    {
        public Guid IdModule { get; set; }
        public string NmModule{ get; set; }
    }
}
