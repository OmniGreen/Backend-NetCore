using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class CategoriesTrans : BaseTrans
    {
        public Guid? CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public bool? IsDestaque { get; set; }
        public bool? IsEvent { get; set; }
        public Guid? CategoryParentId { get; set; }

    }
}