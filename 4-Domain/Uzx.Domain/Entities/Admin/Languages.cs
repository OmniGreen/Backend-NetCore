using System;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
    public  class Languages : BaseEntityNaoVersionada
    {
        public  Guid LanguageId { get; set; }
        public  string Name { get; set; }
        public  string Country { get; set; }
        public  string FileName { get; set; }
        public  string Alt { get; set; }
        public  string Description { get; set; }
        public  string Image { get; set; }
    }
} 