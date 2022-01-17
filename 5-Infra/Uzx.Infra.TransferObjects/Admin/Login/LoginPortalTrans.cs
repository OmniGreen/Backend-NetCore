
namespace Uzx.Infra.TransferObjects.Admin
{
    public  class LoginPortalTrans
    {
        public   virtual string Login { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public bool Logado { get; set; }
        public bool IsCampanha { get; set; }
        public bool IsCampanhaFinalizada { get; set; }
        public bool IsNutricao { get; set; }
        public double totNutricao { get; set; }
        public bool IsCampaingSave { get; set; }
                public  ClientsOperatorsTrans Client { get; set; }     
    }
}
