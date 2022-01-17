using System;

namespace Uzx.Domain.Entities._Base

{
    public class BaseEntity 
    {
        //Informa se o regIstro esta ativo ou inativo
        public bool IsActive { get; set; }
        //propriedades referentes a controle de inclusão
        //Informa o id do usuário que inseriu o regIstro
        public Guid? UserIdInsert { get; set; }
        //Informa a data que foi inserido o regIstro
        public DateTime DtInsert { get; set; }
        //propriedades referentes a controle de exclusão
        //Informa se o regIstro esta excluido
        public bool IsDeleted { get; set; }
        //Informa a data de exclusão do regIstro
        public DateTime? DtDeleted { get; set; }
        //Informa o id do usuário que excluiu o regIstro
        public Guid? UserIdDeleted { get; set; }
    }
}
