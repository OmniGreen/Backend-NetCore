using System;

namespace Uzx.Infra.TransferObjects.Geral
{
    /// <summary>
    /// Classe utilizada para retornar erros, avIsos, alertas ou êxitos.
    /// </summary>
    public  class HTTPMessageResponse
    {
        
        public  Guid id { get; set; }
        public  ResponseType type { get; set; }
        public  string message { get; set; }  
        
    }
    public  enum ResponseType { Success, Error, Alert, Information }
}
