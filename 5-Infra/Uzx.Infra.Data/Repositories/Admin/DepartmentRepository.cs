using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class DepartmentRepository : BaseRepository<Departments>, IDepartmentsRepository
    {
        public DepartmentRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
