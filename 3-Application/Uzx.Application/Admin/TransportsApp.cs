using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class TransportsApp : BaseApp<Transports, TransportsTrans>, ITransportsApp
    {
        public TransportsApp(IMapper mapper, ITransportsRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
