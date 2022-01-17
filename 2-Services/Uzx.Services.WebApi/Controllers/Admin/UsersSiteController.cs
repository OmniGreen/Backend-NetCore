using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using System.Threading.Tasks;
using System.Net.Mail;
using System;
using System.Net;
using Uzx.Infra.Commons.Authentication;
using System.Linq;
using System.Security.Cryptography;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersSiteController : BaseController<UsersSite, UsersSiteTrans>, IUsersSiteController
    {
        private IUsersSiteApp _interfaceApp;
        //
        public UsersSiteController(IMapper mapper, IUsersSiteApp interfaceApp)
             : base(mapper, interfaceApp)
        {
            _interfaceApp = interfaceApp;
        }

        [HttpPost("resetPassword")]
        public async Task<UsersSite> ResetPassword([FromBody]UsersSiteTrans trans)
        {
            try
            {
             var register = await GetByFilter(trans);
                var user = register.FirstOrDefault();

                dynamic password = CodeFirstCrypto.GenerateSalt();
                dynamic hashedPassword = CodeFirstCrypto.EncryptStringAES(password);
               
                user.Password = hashedPassword;

                    MailMessage _mailMessage = new MailMessage();

                _mailMessage.From = new MailAddress(" clickmoocanews@gmail.com");

                _mailMessage.CC.Add(trans.Email);
                _mailMessage.Subject = "Recuperação de Senha.";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = "Olá, vimos que solicitou a recuperação da sua senha. Após logar, recomendamos trocar a sua senha.  Nova Senha: " + password;

                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("clickmoocanews@gmail.com", "Tequila10!@#");

                _smtpClient.EnableSsl = true;
                _smtpClient.Send(_mailMessage);

                await _interfaceApp.Update(user);

                return user;

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
