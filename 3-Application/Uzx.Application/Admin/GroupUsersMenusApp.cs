using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class GroupUsersMenusApp : BaseApp<GroupUsersMenus, GroupUsersMenuTrans>, IGroupUsersMenusApp
    {
        public GroupUsersMenusApp(IMapper mapper, IGroupUsersMenusRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
