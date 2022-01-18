using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;


namespace Uzx.Application.Admin
{
    public class MenusApp : BaseApp<Menus, MenusTrans>, IMenusApp
    {
        private readonly IMenusRepository _menusRepository;
        public MenusApp(IMapper mapper, IMenusRepository menuRepository) 
            : base(mapper,menuRepository)
        {
            _menusRepository = menuRepository;    
        
        }

        //public async Task<List<MenusTrans>> GetAllByUser(UsersPermissionsTrans searchRecord)
        //{
        //    return await _menusRepository.GetAllByUser(searchRecord);
        //}
    }
}
