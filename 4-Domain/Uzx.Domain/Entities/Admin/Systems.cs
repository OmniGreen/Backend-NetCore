using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Systems : BaseEntityNaoVersionada
    {
        public Guid SystemId { get; set; }
        public string Name { get; set; }
        public string Alt { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsAdmin { get; set; }
    }
} 