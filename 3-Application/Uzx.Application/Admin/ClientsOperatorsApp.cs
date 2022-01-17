using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class ClientsOperatorsApp : BaseApp<ClientsOperators, ClientsOperatorsTrans>, IClientsOperatorsApp
    {
        public ClientsOperatorsApp(IMapper mapper, IClientsOperatorsRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
