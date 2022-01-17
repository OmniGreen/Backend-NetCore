using Microsoft.AspNetCore.Mvc;
using Uzx.Application.Interfaces.Admin;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Services.WebApi.Interfaces.Admin;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressTypesController : BaseController<AddressTypes, AddressTypesTrans>, IAddressTypesController
    {
        private IAddressTypesApp _interfaceApp;
        //
        public AddressTypesController(IAddressTypesApp interfaceApp)
            : base(interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
 