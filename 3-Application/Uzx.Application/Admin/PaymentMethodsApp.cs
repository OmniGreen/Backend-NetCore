using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;


namespace Uzx.Application.Admin
{
    public class PaymentMethodsApp : BaseApp<PaymentMethods, PaymentMethodsTrans>, IPaymentMethodsApp
    {
        IPaymentMethodsRepository _baseRepository;
        IMapper _mapper;
        public PaymentMethodsApp(IMapper mapper, IPaymentMethodsRepository baseRepository)
            : base(mapper, baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
