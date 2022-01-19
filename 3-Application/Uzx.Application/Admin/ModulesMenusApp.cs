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
    public class ModulesMenusApp : BaseApp<ModulesMenus, ModulesMenusTrans>, IModulesMenusApp
    {
        public ModulesMenusApp(IMapper mapper, IModulesMenusRepository baseRepository)
            : base(mapper, baseRepository)
        {


        }

    }
}
