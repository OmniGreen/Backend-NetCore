using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public class Categories : BaseEntityNaoVersionadaClient
    {
        [Key]
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
        public bool IsDestaque { get; set; }
        public bool IsEvent { get; set; }

        public Guid CategoryParentId { get; set; }
    }
} 
