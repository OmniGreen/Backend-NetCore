using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class ClientsNewsletterTrans : BaseTrans
    {
        public  Guid ClientNewsletterId { get; set; }
        public  string Email { get; set; }
    }
}
