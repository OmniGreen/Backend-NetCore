using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class SocialMedias : BaseEntityNaoVersionada
    {
        public  Guid SocialMediaId { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
} 