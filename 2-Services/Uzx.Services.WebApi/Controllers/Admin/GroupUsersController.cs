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
    public class GroupUsersController: BaseController<GroupUsers, GroupUsersTrans>, IGroupUsersController
    {
        private IGroupUsersApp _interfaceApp;
        //
        public GroupUsersController(IGroupUsersApp interfaceApp)
            : base(interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }
    }
}
