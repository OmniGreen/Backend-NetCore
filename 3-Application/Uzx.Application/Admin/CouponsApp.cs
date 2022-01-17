using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class CouponsApp : BaseApp<Coupons, CouponsTrans>, ICouponsApp
    {
        public CouponsApp(IMapper mapper, ICouponsRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
