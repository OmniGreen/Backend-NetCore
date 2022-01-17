using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Application.Interfaces._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface ICategoriesApp : IBaseApp<Categories, CategoriesTrans>
    {

        Task<List<CategoriesTrans>> GetByApp(CategoriesTrans searchRecord);
        Task<List<CategoriesTrans>> GetByAppEvents(CategoriesTrans searchRecord);
    }
}
