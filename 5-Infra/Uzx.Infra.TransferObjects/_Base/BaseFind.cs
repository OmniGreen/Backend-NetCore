using System;

namespace Uzx.Infra.TransferObjects._Base
{
    public class BaseFind
    {
        public BaseFind()
        {
            Page = 1;
            QtdRegistros = 10;
        }
        /// <summary>
        /// Identificação do Cliente
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// Número da pagina
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// QuantIdade de registros por pagina
        /// </summary>
        public int QtdRegistros { get; set; }


        public int InitialIndex
        {
            set { }
            get
            {
                if (Page == 0)
                    Page = 1;
                return (Page - 1) * QtdRegistros;
            }
            
        }

        public int QtdTotalRegistros { get; set; }
    }
    public class BaseFind<T> : BaseFind
    {
        public T List { get; set; }
    }
}
