using System;
using System.Threading.Tasks;
using Uzx.Domain.Entities._Base;
using Uzx.Application.Interfaces._Base; using Uzx.Infra.TransferObjects._Base;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface ILoginApp 
    {
        Task<LoginTrans> GetDataLogin(Guid UserId);
        Task<LoginTrans> GetDataLoginSite(Guid UserId);
        Task<LoginTokenTrans> LoginToken(LoginTokenTrans searchRecord);
        Task<LoginTokenTrans> LoginTokenSite(LoginTokenTrans searchRecord);
        bool activateAccess(string key);
        bool recoverPassword(LoginTrans searchRecord);
        Task<LoginTrans> Login(LoginReceiveTrans  searchRecord);
    }
}
    