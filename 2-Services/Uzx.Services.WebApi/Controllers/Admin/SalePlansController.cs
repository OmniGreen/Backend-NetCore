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
    public class SalePlansController : BaseController<SalePlans, SalePlansTrans>, ISalePlansController
    {
        private ISalePlansApp _interfaceApp;
        //
        public SalePlansController(IMapper mapper, ISalePlansApp interfaceApp)
            : base(mapper, interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
