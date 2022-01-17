using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uzx.Infra.TransferObjects.Admin;
using System.Security.Claims;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    { 
        private ILoginApp _loginApp;
        private readonly IMapper _mapper;
        public LoginController(IMapper mapper, ILoginApp loginApp)
        {
            _loginApp = loginApp;    
        }


       [HttpPost]
        public async Task<LoginTokenTrans> Post(LoginTokenTrans searchRecord)
        {
            var result = await _loginApp.LoginToken(searchRecord);
          
            return result;
        }


        [HttpPost("LoginSite")]
        public async Task<LoginTokenTrans> LoginSite(LoginTokenTrans searchRecord)
        {
            var result = await _loginApp.LoginTokenSite(searchRecord);

            return result;
        }

        [HttpGet("GetDataLogin")]
        
        public async Task<LoginTrans> GetDataLogin()
        {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;

            //Guid UserId = new Guid(principal.Claims.Where(c => c.Type == ClaimTypes).Select(c => c.Value).SingleOrDefault());
            Guid UserId = new Guid(principal.Claims.Where(c => c.Type == "UserId").Single().Value);

            var result = await _loginApp.GetDataLogin(UserId);

            return result;
        }


        [HttpGet("GetDataLoginSite")]

        public async Task<LoginTrans> GetDataLoginSite()
        {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;

            //Guid UserId = new Guid(principal.Claims.Where(c => c.Type == ClaimTypes).Select(c => c.Value).SingleOrDefault());
            Guid UserId = new Guid(principal.Claims.Where(c => c.Type == "UserId").Single().Value);

            var result = await _loginApp.GetDataLoginSite(UserId);

            return result;
        }



    }
}