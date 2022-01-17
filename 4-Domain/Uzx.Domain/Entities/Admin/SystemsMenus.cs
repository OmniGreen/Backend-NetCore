using System;

using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class SystemsMenus : BaseEntityNaoVersionada
    {
        public  Guid SystemMenuId { get; set; }

        public  Guid SystemId { get; set; }

        public  Guid MenuId { get; set; }
    }
} 