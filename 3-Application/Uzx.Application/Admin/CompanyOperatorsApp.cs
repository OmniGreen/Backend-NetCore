using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Admin
{
    public class CompanyOperatorsApp : BaseApp<CompanyOperators, CompanyOperatorsTrans>, ICompanyOperatorsApp
    {
        public CompanyOperatorsApp(IMapper mapper, IBaseRepository<CompanyOperators> baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
