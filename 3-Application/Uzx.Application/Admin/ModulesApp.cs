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
    public class ModulesApp : BaseApp<Modules, ModulesTrans>, IModulesApp
    {
        public ModulesApp(IMapper mapper, IModulesRepository baseRepository) 
            : base(mapper, baseRepository)
        {
            
        
        }

    }
}
