using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface ITenantsApp : IBaseApp<Tenants, TenantsTrans>
    {
    }
}
