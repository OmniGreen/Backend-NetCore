using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Admin
{
    public class CostCenterApp : BaseApp<CostCenter, CostCenterTrans>, ICostCenterApp
    {
        public CostCenterApp(IMapper mapper, IBaseRepository<CostCenter> baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
