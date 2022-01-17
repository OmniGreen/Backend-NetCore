using Uzx.Application.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface IStatusApp : IBaseApp<Status, StatusTrans>
    {
    }
}
