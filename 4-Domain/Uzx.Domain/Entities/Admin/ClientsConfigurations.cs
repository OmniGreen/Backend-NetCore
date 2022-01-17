using System;
using System.ComponentModel.DataAnnotations;
using Uzx.Domain.Entities._Base;

namespace Uzx.Domain.Entities.Admin
{
   public  class ClientsConfigurations : BaseEntityNaoVersionadaClient
    {
        [Key]
        public  Guid ClientConfigurationId { get; set; }
        public  string DataBaseIP { get; set; }
        public  string DataBaseName { get; set; }
        public  string AccessPort { get; set; }
        public  string DataBaseLogin { get; set; }
        public  string DataBasePassword { get; set; }
        public  string FilePath { get; set; }
        public  int LevelFields { get; set; }
        public  bool IsCampaingSave { get; set; }
        public  string smtpServer { get; set; }
        public  string smtpPort { get; set; }
        public  bool enableSsl { get; set; }
        public  string smtpUser { get; set; }
        public  string smtpPass { get; set; }
        
    }
} 