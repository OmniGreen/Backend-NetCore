using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class ClientsApp : BaseApp<Clients, ClientsTrans>, IClientsApp
    {
         private IClientsRepository _clientsRepo;
        public ClientsApp(IMapper mapper, IClientsRepository repo)
            : base(mapper, repo)
        {
            _clientsRepo = repo;
        }

        public ClientsFind List(ClientsFind searchRecord)
        {
            return _clientsRepo.List(searchRecord);
        }
    }
}
