using Uzx.Domain.Entities._Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Uzx.Domain.Entities.Admin
{
    public class Users : BaseEntityNaoVersionadaClient
    {
        [Key]
        public Guid IdUser { get; set; }
        public Guid IdGroupUser { get; set; }
        public Guid IdClient { get; set; }
        public string NmLogin { get; set; }
        public string Password { get; set; }
        public string NmEmail { get; set; }
       
    }
} 
