﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Services.WebApi.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Domain.Entities.Admin;

namespace Uzx.Services.WebApi.Interfaces.Admin
{
    public interface IMenusController : IBaseController<Menus, MenusTrans>
    {
        Task<List<MenusTrans>> GetAllByUser(UsersPermissionsTrans searchRecord);
    }
}
