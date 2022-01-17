using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Domain.Entities._Base;
using Uzx.Application.Interfaces._Base;
using Uzx.Infra.TransferObjects._Base;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface INeighborhoodsApp : IBaseApp<Neighborhoods, NeighborhoodsTrans>
    {

    }
}
