using System;
using Uzx.Infra.TransferObjects.Interfaces._Base;

namespace Uzx.Infra.TransferObjects._Base
{
    public class BaseTrans 
    {
        public Guid? ClientId { get; set; }
        public bool? IsActive { get; set; }

        public FindItens FindItens { get; set; }
    }

    public class FindItens
    {
        public FindItens()
        {
            Page = 1;
            NumberOfRecords = 10;
        }

        /// <summary>
        /// Número da pagina
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// QuantIdade de registros por pagina
        /// </summary>
        public int NumberOfRecords { get; set; }

        /// <summary>
        /// QuantIdade total de registros
        /// </summary>
        public int NumberOfRecordsTotal { get; set; }

        public int InitialIndex
        {
            set { }
            get
            {
                if (Page == 0)
                    Page = 1;
                return (Page - 1) * NumberOfRecords;
            }

        }

        
    }
}
