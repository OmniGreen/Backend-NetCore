using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Infra.Data.Interfaces.Admin
{
    public interface IClientsRepository : IBaseRepository<Clients>
    {
        public ClientsFind List(ClientsFind searchRecord);
    }
}
 