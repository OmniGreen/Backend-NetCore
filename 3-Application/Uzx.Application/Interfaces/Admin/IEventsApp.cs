using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uzx.Application.Interfaces._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces.Admin
{
    public interface IEventsApp : IBaseApp<Events, EventsTrans>
    {

        Task<List<EventsTrans>> GetByApp(EventsTrans searchRecord);
        Task<EventsTrans> GetById2(Guid id);
    }
}
