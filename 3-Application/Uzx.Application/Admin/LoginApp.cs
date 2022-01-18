using System;
using System.Threading.Tasks;
using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Admin
{
    public class LoginApp : ILoginApp
    {
        private ILoginRepository loginRepository; 
        public LoginApp(ILoginRepository _loginRepository)
        {
            loginRepository = _loginRepository;
        }

        public bool activateAccess(string key) 
        {
            throw new NotImplementedException();
        }

        //public Task<LoginTrans> GetDataLogin(Guid UserID)
        //{
        //    return loginRepository.GetDataLogin(UserID);
        //}

        //public Task<LoginTrans> GetDataLoginSite(Guid UserID)
        //{
        //    return loginRepository.GetDataLoginSite(UserID);
        //}

        //public Task<LoginTrans> Login(LoginReceiveTrans searchRecord)
        //{
        //    return loginRepository.Login(searchRecord);

          
        //}

        //public Task<LoginTokenTrans> LoginToken(LoginTokenTrans searchRecord)
        //{
        //    return loginRepository.LoginToken(searchRecord);
        //}

        //public Task<LoginTokenTrans> LoginTokenSite(LoginTokenTrans searchRecord)
        //{
        //    return loginRepository.LoginTokenSite(searchRecord);
        //}

        public bool recoverPassword(LoginTrans searchRecord)
        {
            throw new NotImplementedException();
        }
    }
}
