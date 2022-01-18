﻿using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class UsersProfileRepository : BaseRepository<UsersProfile>, IUsersProfileRepository
    {
        public UsersProfileRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
