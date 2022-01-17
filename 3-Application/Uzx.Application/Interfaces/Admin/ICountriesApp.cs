using Uzx.Application.Interfaces._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface ICountriesApp : IBaseApp<Countries, CountriesTrans>
    {
    }
}
