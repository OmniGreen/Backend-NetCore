using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModulesMenusController : BaseController<ModulesMenus, ModulesMenusTrans>, IModulesMenusController
    {
        private IModulesMenusApp _interfaceApp;
        //
        public ModulesMenusController(IMapper mapper, IModulesMenusApp interfaceApp)
            : base(mapper, interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
