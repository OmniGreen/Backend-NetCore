using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using Uzx.Application.Interfaces._Base;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimetableController : BaseController<Timetable, TimetableTrans>, ITimetableController
    {
        private ITimetableApp _interfaceApp;
        private readonly IMapper _mapper;
        public readonly ITimetableApp _serviceApp;
        //
        public TimetableController(IMapper mapper, ITimetableApp interfaceApp, ITimetableApp serviceApp)
            : base(mapper, interfaceApp)
        {
            _interfaceApp = interfaceApp;
            _mapper = mapper;
            _serviceApp = serviceApp;
        }


    }
}