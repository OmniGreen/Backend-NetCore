using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class SendMailTrans
    {
        public string To { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
    }
}