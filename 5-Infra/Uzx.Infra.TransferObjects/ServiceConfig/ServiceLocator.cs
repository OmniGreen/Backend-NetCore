namespace Uzx.Infra.TransferObjects.ServiceConfig
{
    /// <summary>
    ///     Classe responsável por buscar no serviço de configurações os endpoints
    /// </summary>
    public  class ServiceLocator
    {
        private string Token;
        private string PlatId;
        private string Uri;

        /// <summary>
        ///     Construtor do serviceLocator que devolve endpoints para os serviços.
        /// </summary>
        /// <param name="platId">plataforma que será usado como filtro de configurações de serviço</param>
        /// <param name="token">token de autenticação</param>
        /// <param name="uri">uri com o endereço do ServiceLocator</param>
        public  ServiceLocator(string platId, string token, string uri)
        {
            this.PlatId = platId;
            this.Token = token;

            if (uri.EndsWith("/"))
            {
                this.Uri = uri;                
            }
            else
            {
                this.Uri = uri + "/";
            }       
        }

        ///<summary>
        ///    Método que localiza a uri de um dado serviço
        ///</summary>
        ///<param name="serviceName">Name do serviço que queremos obter a uri</param>
        ///<returns>uri do serviço com esse Name para a plataforma</returns> 
        //public  string GetServiceUri(string serviceName)
        //{
        //    try
        //    {
        //        Services services = RestConsumer.Get<Services>(string.Concat(this.Uri, serviceName, "/", this.PlatId), this.Token);
        //        return services.service.endpoints[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        string message = "Erro localizando servico: " + serviceName + "." + this.ToString();
        //        throw new ServiceLocatorException(message, ex);
        //    }
        //}


        public  override string ToString()
        {
            string representation = "[ServiceLocator(";
            representation += "Uri: " + Uri + ",";
            representation += "PlatId: " + PlatId + ",";
            representation += "Token: " + Token;
            representation += ")]";

            return representation;
        }
        
    }
}