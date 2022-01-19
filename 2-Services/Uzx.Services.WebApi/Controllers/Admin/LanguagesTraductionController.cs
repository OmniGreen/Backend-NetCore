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
    public class LanguagesTraductionController : BaseController<LanguagesTraductions, LanguagesTraductionsTrans>, ILanguagesTraductionsController
    {
        private ILanguagesTraductionsApp _interfaceApp;
        //
        public LanguagesTraductionController(IMapper mapper, ILanguagesTraductionsApp interfaceApp)
            : base(mapper, interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
