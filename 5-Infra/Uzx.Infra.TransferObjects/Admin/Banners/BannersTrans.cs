using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public class BannersTrans : BaseTrans
    {
        public Guid? BannerId { get; set; }
        public Guid? CustomerId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string NameBanner { get; set; }
        public string Page { get; set; }
        public string Position { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }

    }
}