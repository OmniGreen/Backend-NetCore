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
    public class AddressController : BaseController<Address, AddressTrans>, IAddressController
    {
        private IAddressApp _interfaceApp;
        //
        public AddressController(IAddressApp interfaceApp)
            : base(interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
} 
