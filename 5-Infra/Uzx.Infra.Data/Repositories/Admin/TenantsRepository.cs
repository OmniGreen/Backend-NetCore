﻿using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects.Admin;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class TenantsRepository : BaseRepository<Tenants>, ITenantsRepository
    {
        public TenantsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }  
    }
}
