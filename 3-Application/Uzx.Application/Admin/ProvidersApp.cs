using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class ProvidersApp : BaseApp<Providers, ProvidersTrans>, IProvidersApp
    {
        public ProvidersApp(IMapper mapper, IProvidersRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
