using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {

        public EmailController()
        {
        }

        [HttpPost("sendMail")]
        public SendMailTrans SendMail([FromBody]SendMailTrans sendMail)
        {
            
            try
            {
                MailMessage _mailMessage = new MailMessage();

                _mailMessage.From = new MailAddress(" clickmoocanews@gmail.com");

                _mailMessage.CC.Add(sendMail.To);
                _mailMessage.Subject = sendMail.Subject;
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = sendMail.Message;

                SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32("587"));

                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential("clickmoocanews@gmail.com", "Tequila10!@#");

                _smtpClient.EnableSsl = true;
                _smtpClient.Send(_mailMessage);

                return sendMail;

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
