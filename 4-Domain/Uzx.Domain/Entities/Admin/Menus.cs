using System;
using System.Collections.Generic;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin {
    public class Menus : BaseEntityNaoVersionadaClient {
        public Guid IdMenu { get; set; }
        public string NmMenu { get; set; }
    }
}