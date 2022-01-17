using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class LanguagesApp : BaseApp<Languages, LanguagesTrans>, ILanguagesApp
    {
        public LanguagesApp(IMapper mapper, ILanguagesRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
