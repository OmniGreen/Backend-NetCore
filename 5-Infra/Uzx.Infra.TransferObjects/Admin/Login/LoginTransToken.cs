using System;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class LoginTransToken
    {
        public   virtual string Login { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public bool Logado { get; set; }
        public bool IsCampanha { get; set; }         
        public bool IsNutricao { get; set; }
        public double totNutricao { get; set; }
        public bool IsAdmin { get; set; }          
        public Guid UserId{ get; set; }
        public Guid? ClientId { get; set; }
        public Guid ColaboratorId { get; set; } 
     
    }

}
