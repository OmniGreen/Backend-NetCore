using System;
using System.Net;
using System.Net.Mail;


namespace Uzx.Infra.Commons
{
    public  class Email
    {
        public  Guid ClientId { get; set; }
        public  Guid UserId { get; set; }
        public  string Name { get; set; }
        public  string Address { get; set; }
        public  string Password { get; set; }
        public  string Phone { get; set; }
        public  string Subject { get; set; }
        public  string Message { get; set; }
        MailAddress from, to;
        SmtpClient smtp;

        public  Email()
        {
           /* from = new MailAddress(ConfigurationManager.AppSettings["smtpUser"], "");
            smtp = new SmtpClient
            {
                Host = ConfigurationManager.AppSettings["smtpServer"],
                Port = Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]),
                EnableSsl = ConfigurationManager.AppSettings["EnableSsl"] == "true" ? true : false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["smtpUser"], ConfigurationManager.AppSettings["smtpPass"])
            };
            */
        }

        /// <summary>
        /// Envia e-mail de contato realizado pelo site.
        /// </summary>
        public  void sendEmail()
        {
           // to = new MailAddress(ConfigurationManager.AppSettings["smtpUser"], "Contato via Site");

            using (MailMessage message = new MailMessage(from, to)
            {
                Subject = this.Subject,
                Body = this.Message
            })
            {
                smtp.Send(message);
            }
        }

        /// <summary>
        /// Método utilizado para enviar e-mail para cliente.
        /// </summary>
        /// <param name="clientAddress">Endereço de e-mail do cliente.</param>
        /// <param name="clientName">Name do cliente.</param>
        /// <param name="subject">Assunto do e-mail.</param>
        /// <param name="body">Corpo do e-mail.</param>
        /// <param name="messageType">Tipo de mensagem.</param>
        public  void sendEmail(string clientAddress, string clientName, string subject, string body, string website)
        {
            to = new MailAddress(clientAddress, clientName);
            using (MailMessage message = new MailMessage(to, from)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
