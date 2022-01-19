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
    public class LanguagesController : BaseController<Languages, LanguagesTrans>, ILanguagesController
    {
        private ILanguagesApp _interfaceApp;
        //
        public LanguagesController(IMapper mapper,ILanguagesApp interfaceApp)
            : base(mapper,interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
