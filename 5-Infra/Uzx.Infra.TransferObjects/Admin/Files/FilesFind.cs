using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class FilesFind : BaseFind<List<FilesOperatorTrans>>
    {
        public  int Tratado { get; set; }
        public  int Active { get; set; }
    }
}