using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class FamilyTypeApp : BaseApp<FamilyType, FamilyTypeTrans>, IFamilyTypeApp
    {
        public FamilyTypeApp(IMapper mapper, IFamilyTypeRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
