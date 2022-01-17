﻿using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class UsersStatusApp : BaseApp<UsersStatus, UsersStatusTrans>, IUsersStatusApp
    {
        public UsersStatusApp(IMapper mapper, IUsersStatusRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
