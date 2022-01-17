using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class CompanyOperatorsRepository : BaseRepository<CompanyOperators>, ICompanyOperatorsRepository
    {
        public CompanyOperatorsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
