using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : BaseController<Categories, CategoriesTrans>, ICategoriesController
    {
        private ICategoriesApp _serviceApp;
        //
        public CategoriesController(IMapper mapper, ICategoriesApp serviceApp)
            : base(mapper, serviceApp)
        {
            _serviceApp = serviceApp;
        }

        [HttpPost("GetByApp")]
        public async Task<List<CategoriesTrans>> GetByApp(CategoriesTrans searchRecord)
        {
            return await _serviceApp.GetByApp(searchRecord);
        }

        [HttpPost("GetByAppEvents")]
        public async Task<List<CategoriesTrans>> GetByAppEvents(CategoriesTrans searchRecord)
        {
            return await _serviceApp.GetByAppEvents(searchRecord);
        }
    }
}
