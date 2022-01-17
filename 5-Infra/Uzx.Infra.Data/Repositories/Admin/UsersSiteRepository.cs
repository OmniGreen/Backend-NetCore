using System.Linq;
using System.Threading.Tasks;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersSiteRepository : BaseRepository<UsersSite>, IUsersSiteRepository
    {
        public UsersSiteRepository(UzxBaseDbContext TTGContext)
            : base(TTGContext)
        { }

        public UsersSite GetByEmail(string email)
        {
            return _dbSet.Where(x=> x.Email == email).FirstOrDefault();
        }

    }
}
