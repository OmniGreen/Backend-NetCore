using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class FunctionsApp : BaseApp<Functions, FunctionsTrans>, IFunctionsApp
    {
        public FunctionsApp(IMapper mapper, IFunctionsRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
