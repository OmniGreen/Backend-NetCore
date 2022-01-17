using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class ClientsConfigurationsApp : BaseApp<ClientsConfigurations, ClientsConfigurationsTrans>, IClientsConfigurationsApp
    {
        public ClientsConfigurationsApp(IMapper mapper, IClientsConfigurationsRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
