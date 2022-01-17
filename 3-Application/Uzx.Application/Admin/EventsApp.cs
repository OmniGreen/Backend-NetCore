using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Uzx.Application.Admin
{
    public class EventsApp : BaseApp<Events, EventsTrans>, IEventsApp
    {
        IEventsRepository _baseRepository;
        IMapper _mapper;
        public EventsApp(IMapper mapper, IEventsRepository baseRepository)
            : base(mapper, baseRepository)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }


        public async Task<List<EventsTrans>> GetByApp(EventsTrans searchRecord)
        {
            var mapperRecord = _mapper.Map<Events>(searchRecord);

            return _mapper.Map<List<Events>, List<EventsTrans>>(await _baseRepository.GetByApp(mapperRecord));
        }

        public async Task<EventsTrans> GetById2(Guid id)
        {
            var retorno = _mapper.Map<EventsTrans>(await _baseRepository.GetById(id));

            return retorno;
        }
    }
}
