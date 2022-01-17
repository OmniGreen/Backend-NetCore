using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class ClientsConfigurationsTrans : BaseTrans
    {
        public  Guid ClientConfigurationId { get; set; }
        public  string DataBaseIP { get; set; }
        public  string DataBaseName { get; set; }
        public  string AccessPort { get; set; }
        public  string DataBaseLogin { get; set; }
        public  string DataBasePassword { get; set; }
        public  string FilePath { get; set; }
        public  string SmtpServer { get; set; }
        public  string SmtpPort { get; set; }
        public  bool EnableSsl { get; set; }
        public  string SmtpUser { get; set; }
        public  string SmtpPass { get; set; }
    }
}
