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
    public class CompanyOperatorsController : BaseController<CompanyOperators, CompanyOperatorsTrans>, ICompanyOperatorsController
    {
        private ICompanyOperatorsApp _interfaceApp;
        //
        public CompanyOperatorsController(ICompanyOperatorsApp interfaceApp)
            : base(interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
