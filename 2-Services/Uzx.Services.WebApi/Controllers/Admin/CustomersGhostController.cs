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
using System;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersGhostController : BaseController<CustomersGhost, CustomersGhostTrans>, ICustomersGhostController
    {
        private ICustomersGhostApp _interfaceApp;
        private readonly IMapper _mapper;
        public readonly ICustomersGhostApp _serviceApp;
        //
        public CustomersGhostController(IMapper mapper, ICustomersGhostApp interfaceApp, ICustomersGhostApp serviceApp)
            : base(mapper, interfaceApp)
        {
            _interfaceApp = interfaceApp;
            _mapper = mapper;
            _serviceApp = serviceApp;
        }

        [HttpPost("GetByApp")]
        public async Task<List<CustomersGhostTrans>> GetByApp(CustomersGhostTrans searchRecord)
        {
            return await _serviceApp.GetByApp(searchRecord);
        }

        [HttpGet("GetByIdDetalhe/{id:guid}")]
        public async Task<CustomersGhostTrans> GetByIdDetalhe(Guid id)
        {
            return await _serviceApp.GetById2(id);
        }
    }
}
