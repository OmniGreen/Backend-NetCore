using Uzx.Domain.Entities.Admin;
using Uzx.Services.WebApi.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Services.WebApi.Interfaces.Admin
{
    public interface IUsersController : IBaseController<Users, UsersTrans>
    {
    }
}
