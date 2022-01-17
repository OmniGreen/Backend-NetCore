using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Admin
{
    public class AddressTypesApp : BaseApp, IAddressTypesApp
    {
        public AddressTypesApp(IMapper mapper, IBaseRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
