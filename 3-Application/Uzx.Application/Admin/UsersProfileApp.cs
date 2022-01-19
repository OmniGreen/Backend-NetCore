using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class UsersProfileApp : BaseApp<UsersProfile, UsersProfileTrans>, IUsersProfileApp
    {
        public UsersProfileApp(IMapper mapper, IUsersProfileRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
