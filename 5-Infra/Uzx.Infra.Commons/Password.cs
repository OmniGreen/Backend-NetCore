using System;

namespace Uzx.Infra.Commons
{
    public  class Password
    {
        public  string geraSenha()
        {
            Random r = new Random();
            return r.Next(100000, 999999).ToString();
        }
    }
}
