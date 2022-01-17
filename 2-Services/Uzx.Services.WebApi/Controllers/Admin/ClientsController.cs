using Microsoft.AspNetCore.Mvc;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Application.Interfaces.Admin;
using Uzx.Services.WebApi.Interfaces.Admin;
using AutoMapper;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : BaseController<Clients, ClientsTrans>, IClientsController
    {
        private IClientsApp _clientsApp;
        //
        public ClientsController(IMapper mapper, IClientsApp clientsApp) 
            : base(mapper, clientsApp)
        {
            _clientsApp = clientsApp;    
        }


        
        //[HttpPost("List")]
        //public ClientsFind List(ClientsFind searchRecord)
        //{
        //    // Retorna a lista
        //    return _clientsApp.List(searchRecord);
        //}


    }
}