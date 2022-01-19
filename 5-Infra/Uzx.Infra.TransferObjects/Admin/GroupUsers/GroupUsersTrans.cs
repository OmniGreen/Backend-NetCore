using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class GroupUsersTrans :BaseTrans
    {

        public Guid IdGroupUser { get; set; }
        public Guid IdClient { get; set; }
        public string NmGroupUser { get; set; }

    }
}
