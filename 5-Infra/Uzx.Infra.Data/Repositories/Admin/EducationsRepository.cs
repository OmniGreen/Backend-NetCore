﻿using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class EducationsRepository : BaseRepository<Educations>, IEducationsRepository
    {
        public EducationsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }
    }
}
