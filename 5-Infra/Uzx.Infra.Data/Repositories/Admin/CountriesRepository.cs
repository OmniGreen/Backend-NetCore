using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class CountriesRepository : BaseRepository<Countries>, ICountriesRepository
    {
        public CountriesRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
