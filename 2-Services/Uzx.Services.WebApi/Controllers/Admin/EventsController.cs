using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : BaseController<Events, EventsTrans>, IEventsController
    {
        private IEventsApp _interfaceApp;
        private readonly IMapper _mapper;
        public readonly IEventsApp _serviceApp;
        //
        public EventsController(IMapper mapper, IEventsApp interfaceApp, IEventsApp serviceApp)
            : base(mapper, interfaceApp)
        {
            _interfaceApp = interfaceApp;
            _mapper = mapper;
            _serviceApp = serviceApp;
        }


        [HttpPost("GetByApp")]
        public async Task<List<EventsTrans>> GetByApp(EventsTrans searchRecord)
        {
            return await _serviceApp.GetByApp(searchRecord);
        }

        [HttpGet("GetByIdDetalhe/{id:guid}")]
        public async Task<EventsTrans> GetByIdDetalhe(Guid id)
        {
            return await _serviceApp.GetById2(id);
        }
    }
}
