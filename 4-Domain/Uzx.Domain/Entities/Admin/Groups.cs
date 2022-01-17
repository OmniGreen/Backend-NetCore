using Uzx.Domain.Entities._Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Uzx.Domain.Entities.Admin
{
    public class Groups
    {
        [Key]
        public Guid GroupId { get; set; }
    } 
}
