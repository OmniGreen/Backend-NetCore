using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Uzx.Services.WebApi.Interfaces.Admin;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [Authorize]
    [Route("api/[controller]")]
    public class MenusController : ControllerBase
    { 
        private IMenusController _entityApp;
        public MenusController(IMenusController entityApp)
        {
            _entityApp = entityApp;    
        }


        /// <summary>
        /// Recupera todos os dados da tabela
        /// </summary>
        /// <returns>Retorna uma lista</returns>
        [Route("GetAllByUser")]
        [HttpPost]
        public async Task<List<MenusTrans>> GetAllByUser([FromBody]  UsersPermissionsTrans searchRecord)
        {
            // Retorna a lista
            try
            {
                // Retorna a lista
                return await _entityApp.GetAllByUser(searchRecord);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

    }
}