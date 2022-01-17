using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Interfaces._Base;

namespace Uzx.Infra.Data.Interfaces.Admin
{
    public interface IUsersSiteRepository : IBaseRepository<UsersSite>
    {
       public UsersSite GetByEmail(string email);

    }
}
 