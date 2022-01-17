using System;
using Uzx.Domain.Entities.Admin;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Uzx.Infra.Commons.Authentication
{
    public  class TokenAccess
    {
        public static class Settings
        {
            public static string Secret = "fedaf7d8863b48e197b9287d492b708e";
        }

        public  string CreateConnectionDB(Guid ClientId, Guid UserId)
        {
            string retorno = string.Empty;

            //ClientsConfigurationsRepository _repo = new ClientsConfigurationsRepository();
            //ClientsConfigurationsTrans singleRecord = new ClientsConfigurationsTrans();

            //singleRecord = _repo.GetRecordByClientId(ClientId);
            //if (singleRecord.DataBaseIP == null || singleRecord.DataBaseIP == string.Empty)
            //{
               // retorno = ConfigurationManager.ConnectionStrings["BaseDbContext"].ConnectionString;
            //}
            //else
            //{
            //    retorno = "Data Source=" + singleRecord.DataBaseIP + ";Initial Catalog=" + singleRecord.DataBaseName + ";User Id=" + singleRecord.DataBaseLogin + ";Password=" + singleRecord.DataBasePassword + ";";
            //}
            return retorno;
        }

        public  string CreateConnectionDB()
        {
            string retorno = string.Empty;
            //retorno = System.Configuration.ConfigurationManager.ConnectionStrings["BaseDbContext"].ConnectionString;

            return retorno;
        }

        public static string GenerateToken(string Login, string UserId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                   new Claim(ClaimTypes.Name, Login.ToString()),
                    new Claim("UserId", UserId.ToString()),
                    new Claim(ClaimTypes.Role, "user")
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

}
