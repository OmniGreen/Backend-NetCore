using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Threading.Tasks;
using Uzx.Infra.Commons.Authentication;
using System.Collections.Generic;
using System;

namespace Uzx.Application.Admin
{
    public class UsersSiteApp : BaseApp<UsersSite, UsersSiteTrans>, IUsersSiteApp
    {
        public readonly IUsersSiteRepository _baseRepo;
        public UsersSiteApp(IMapper mapper, IUsersSiteRepository baseRepository)
            : base(mapper, baseRepository)
        {
            _baseRepo = baseRepository;
        }

     

        public Task<UsersSite> Update(UsersSite single)
        {
            dynamic password = CodeFirstCrypto.DecryptStringAES(single.Password);
            dynamic hashedPassword = CodeFirstCrypto.HashPassword(password);

            single.Password = hashedPassword;

            return _baseRepository.Update(single);
        }
        public async Task<UsersSite> Register(UsersSite single)
        {
            var tem = _baseRepo.GetByEmail(single.Email);
            if (tem != null)
            {
                return single;
            }
            else
            {
                dynamic password = CodeFirstCrypto.DecryptStringAES(single.Password);
                dynamic hashedPassword = CodeFirstCrypto.HashPassword(password);

                single.Password = hashedPassword;
                return await _baseRepository.Add(single);

                
            }
             
        }

    }
}
