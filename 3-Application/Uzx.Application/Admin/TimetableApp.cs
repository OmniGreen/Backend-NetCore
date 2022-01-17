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
    public class TimetableApp : BaseApp<Timetable, TimetableTrans>, ITimetableApp
    {
        ITimetableRepository _baseRepository;
        IMapper _mapper;
        public TimetableApp(IMapper mapper, ITimetableRepository baseRepository)
            : base(mapper, baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

    }
}
