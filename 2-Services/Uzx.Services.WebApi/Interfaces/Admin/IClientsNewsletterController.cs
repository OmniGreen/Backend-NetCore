using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Services.WebApi.Interfaces._Base;


namespace Uzx.Services.WebApi.Interfaces.Admin
{
    public interface IClientsNewsletterController: IBaseController<ClientsNewsletter, ClientsNewsletterTrans>
    {
    }
}
