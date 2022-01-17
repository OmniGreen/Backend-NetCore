using System.Collections.Generic;

namespace Uzx.Infra.TransferObjects.ServiceConfig
{
    public  class Services
    {
        public  Services()
        {
            service = new Service();
        }

        public  Service service { get; set; }
    }

    public  class Service
    {
        public  Service()
        {
            endpoints = new List<string>();
        }

        public  string name { get; set; }
        public  string qualifier { get; set; }
        public  List<string> endpoints { get; set; }
    }
}
