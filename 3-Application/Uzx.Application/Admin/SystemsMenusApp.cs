using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class SystemsMenusApp : BaseApp<SystemsMenus, SystemsMenusTrans>, ISystemsMenusApp
    {
        public SystemsMenusApp(IMapper mapper, ISystemsMenusRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
