using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Uzx.Application.Admin
{
    public class CategoriesApp : BaseApp<Categories, CategoriesTrans>, ICategoriesApp
    {
        ICategoriesRepository _baseRepository;
        IMapper _mapper;
        public CategoriesApp(IMapper mapper, ICategoriesRepository baseRepository) 
            : base(mapper, baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoriesTrans>> GetByApp(CategoriesTrans searchRecord)
        {
            var mapperRecord = _mapper.Map<Categories>(searchRecord);

            return _mapper.Map<List<Categories>, List<CategoriesTrans>>(await _baseRepository.GetByApp(mapperRecord));
        }

        public async Task<List<CategoriesTrans>> GetByAppEvents(CategoriesTrans searchRecord)
        {
            var mapperRecord = _mapper.Map<Categories>(searchRecord);

            return _mapper.Map<List<Categories>, List<CategoriesTrans>>(await _baseRepository.GetByAppEvents(mapperRecord));
        }
    }
}
