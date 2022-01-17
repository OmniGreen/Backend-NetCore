using System;
using System.Collections.Generic;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin {
    public class Menus : BaseEntityNaoVersionadaClient {
        public Guid MenuId { get; set; }
        public string Name { get; set; }
        public Guid MenusTypeId { get; set; }
        public Guid MenuIdPai { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Target { get; set; }
        public string Icone { get; set; }
        public string Alt { get; set; }

        public List<Menus> Children;

    }
}
