using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class CityFind : BaseFind<List<CitiesTrans>>
    {
    public  Guid StateId { get; set; }

    public string ZipCode { get; set; }

    public string Name { get; set; }
  }
}
