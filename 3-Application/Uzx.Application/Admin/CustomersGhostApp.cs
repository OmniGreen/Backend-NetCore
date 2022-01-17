using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Uzx.Application.Admin
{
    public class CustomersGhostApp : BaseApp<CustomersGhost, CustomersGhostTrans>, ICustomersGhostApp
    {
        ICustomersGhostRepository _baseRepository;
        IMapper _mapper;
        public CustomersGhostApp(IMapper mapper, ICustomersGhostRepository baseRepository) 
            : base(mapper, baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomersGhostTrans>> GetByApp(CustomersGhostTrans searchRecord)
        {
            var mapperRecord = _mapper.Map<CustomersGhost>(searchRecord);

            return _mapper.Map<List<CustomersGhost>, List<CustomersGhostTrans>>(await _baseRepository.GetByApp(mapperRecord));
        }

        public async Task<CustomersGhostTrans> GetById2(Guid id)
        {
            var retorno = _mapper.Map<CustomersGhostTrans>(await _baseRepository.GetById(id));
            retorno.Category = await _baseRepository.GetCategoryName((Guid)retorno.CategoryId);
            retorno.IsDestaque = await _baseRepository.GetDestaque((Guid)retorno.SalePlanId);
            retorno.PaymentMethodsImages = await _baseRepository.GetPaymentMethodsByCustomer((Guid)retorno.CustomerGhostId);
            return retorno;
        }

    }
}
