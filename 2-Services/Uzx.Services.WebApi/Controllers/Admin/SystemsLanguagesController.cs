using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemsLanguagesController: BaseController<SystemsLanguages, SystemsLanguagesTrans>, ISystemsLanguagesController

    {
        private ISystemsLanguagesApp _interfaceApp;
        //
        public SystemsLanguagesController(ISystemsLanguagesApp interfaceApp)
            : base(interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
