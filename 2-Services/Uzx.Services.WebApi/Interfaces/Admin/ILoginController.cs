using System;
using System.Threading.Tasks;
    using Uzx.Domain.Entities._Base;
using Uzx.Services.WebApi.Interfaces._Base;using Uzx.Infra.TransferObjects._Base;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Services.WebApi.Interfaces.Admin
{
    public interface ILoginController 
    {
        Task<LoginTrans> GetDataLogin(Guid UserId);
        Task<LoginTokenTrans> LoginToken(LoginTokenTrans searchRecord);
        bool activateAccess(string key);
        bool recoverPassword(LoginTrans searchRecord);
        Task<LoginTrans> Login(LoginReceiveTrans  searchRecord);
    }
}
    