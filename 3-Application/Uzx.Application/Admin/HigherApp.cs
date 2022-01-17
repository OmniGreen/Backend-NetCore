using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class HigherApp : BaseApp<Higher, HigherTrans>, IHigherApp
    {
        public HigherApp(IMapper mapper, IHigherRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
