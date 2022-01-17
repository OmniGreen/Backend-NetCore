using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Uzx.Application.Admin
{
    public class CustomersApp : BaseApp<Customers, CustomersTrans>, ICustomersApp
    {
        ICustomersRepository _baseRepository;
        IMapper _mapper;
        public CustomersApp(IMapper mapper, ICustomersRepository baseRepository)
            : base(mapper, baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomersTrans>> GetByApp(CustomersTrans searchRecord)
        {
            var mapperRecord = _mapper.Map<Customers>(searchRecord);
            List<CustomersTrans> lstResto;
            List<CustomersTrans> lstTudo;
            var lstDestaque = _mapper.Map<List<Customers>, List<CustomersTrans>>(await _baseRepository.GetByApp(mapperRecord, true, 50));
            lstTudo = lstDestaque.OrderByDescending(z => Guid.NewGuid()).ToList();
            if (lstTudo.Count <= 50)
            {
                lstResto = _mapper.Map<List<Customers>, List<CustomersTrans>>(await _baseRepository.GetByApp(mapperRecord, false, 50 - lstTudo.Count));

                foreach (var item in lstResto)
                {
                    var vlr = await _baseRepository.GetFree((Guid)item.SalePlanId);
                    item.IsFree = (vlr == 0);
                }

                lstTudo.AddRange(lstResto.OrderBy(z => Guid.NewGuid()).ToList()) ;
            }
            return lstTudo.Take(50).ToList();
        }

        public async Task<CustomersTrans> GetById2(Guid id)
        {
            var retorno = _mapper.Map<CustomersTrans>(await _baseRepository.GetById(id));
            var vlr = await _baseRepository.GetFree((Guid)retorno.SalePlanId);
            retorno.Category = await _baseRepository.GetCategoryName((Guid)retorno.CategoryId);
            retorno.IsDestaque = await _baseRepository.GetDestaque((Guid)retorno.SalePlanId);
            retorno.IsFree = (vlr == 0);
            retorno.PaymentMethodsImages = await _baseRepository.GetPaymentMethodsByCustomer((Guid)retorno.CustomerId);
            return retorno;
        }
    }
}
