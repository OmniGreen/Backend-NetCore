using Uzx.Application._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;
using AutoMapper;
using Uzx.Infra.Data.Interfaces.Admin;

namespace Uzx.Application.Admin
{
    public class DoctorsApp : BaseApp<Doctors, DoctorsTrans>, IDoctorsApp
    {
        public DoctorsApp(IMapper mapper, IDoctorsRepository baseRepository) 
            : base(mapper, baseRepository)
        {

        }
    }
}
