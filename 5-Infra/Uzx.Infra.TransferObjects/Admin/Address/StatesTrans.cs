using System;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class StatesTrans : BaseTrans
  {
      public  Guid StateId { get; set; }
      public  Guid CountryId { get; set; }
      public string Name { get; set; }
      public string Acronym { get; set; }
  }
}
