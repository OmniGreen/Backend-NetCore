using System;

namespace Uzx.Infra.TransferObjects.ServiceConfig
{

    /// <summary>
    ///  Tipo específico para exceções de localização de serviços
    /// </summary>
    class ServiceLocatorException : Exception
    {
        public  ServiceLocatorException(string message, Exception ex): base(message, ex){}
    }
}
