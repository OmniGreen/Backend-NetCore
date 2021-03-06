using System;
using System.Collections.Generic;
using Uzx.Application.EventSourcedNormalizers;
using Uzx.Application.ViewModels;

namespace Uzx.Application.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        void Register(CustomerViewModel customerViewModel);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel GetById(Guid id);
        void Update(CustomerViewModel customerViewModel);
        void Remove(Guid id);
        IList<CustomerHistoryData> GetAllHistory(Guid id);
    }
}
