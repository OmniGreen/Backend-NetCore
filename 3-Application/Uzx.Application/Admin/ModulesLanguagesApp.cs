using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;


namespace Uzx.Application.Admin
{
    public class ModulesLanguagesApp : BaseApp<ModulesLanguages, ModulesLanguagesTrans>, IModulesLanguagesApp
    {
        public ModulesLanguagesApp(IMapper mapper, IModulesLanguagesRepository baseRepository) 
            : base(mapper, baseRepository)
        {
            
        
        }

    }
}
