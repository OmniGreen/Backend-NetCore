using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class LanguagesFind : BaseFind<List<LanguagesTrans>>
    { 
        public  string Name { get; set; }
        public  int Active { get; set; }
        public  Guid SystemId { get; set; }
 
    }
}
