using System.Collections.Generic;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class LoginTrans
    {
        public   virtual string Login { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public bool Logado { get; set; }
        public bool IsCampanha { get; set; }         
        public bool IsNutricao { get; set; }
        public double totNutricao { get; set; }
        public bool IsAdmin { get; set; }          
        public UsersTrans Users { get; set; }
        public UsersSiteTrans UsersSite { get; set; }
        public  List<ClientData> Clients {get; set;}
     
    }


    public  class ClientData
    {
        public  ClientsOperatorsTrans Client { get; set; }

        public  List<SystemsData> Systems { get; set; }

    }

    public  class SystemsData
    {
        public  SystemsTrans System { get; set; }
        public  List<LanguagesTrans> Languages { get; set; }
    
    }
}
