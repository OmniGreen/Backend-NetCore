using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;


namespace Uzx.Application.Admin
{
    public class NeighborhoodsApp : BaseApp<Neighborhoods, NeighborhoodsTrans>, INeighborhoodsApp
    {
        INeighborhoodsRepository _baseRepository;
        IMapper _mapper;
        public NeighborhoodsApp(IMapper mapper, INeighborhoodsRepository baseRepository)
            : base(mapper, baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
    }
}
