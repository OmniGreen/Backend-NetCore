using AutoMapper;
using Uzx.Application.ViewModels;
using Uzx.Domain.Entities._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects._Base;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            
            CreateMap<BaseEntity, BaseTrans>();

            CreateMap<Banners, BannersTrans>();
            CreateMap<BannersTrans, Banners>();

            CreateMap<Categories, CategoriesTrans>();
            CreateMap<CategoriesTrans, Categories>();

            CreateMap<Clients, ClientsTrans>();
            CreateMap<ClientsTrans, Clients>();

            CreateMap<Coupons, CouponsTrans>();
            CreateMap<CouponsTrans, Coupons>();

            CreateMap<ClientsSystems, ClientsSystemsTrans>();
            CreateMap<ClientsSystemsTrans, ClientsSystems>();

            CreateMap<Customers, CustomersTrans>();
            CreateMap<CustomersTrans, Customers>();

            CreateMap<CustomersGhost, CustomersGhostTrans>();
            CreateMap<CustomersGhostTrans, CustomersGhost>();

            CreateMap<Events, EventsTrans>();
            CreateMap<EventsTrans, Events>();

            CreateMap<SalePlans, SalePlansTrans>();
            CreateMap<SalePlansTrans, SalePlans>();

            CreateMap<PaymentMethods, PaymentMethodsTrans>();
            CreateMap<PaymentMethodsTrans, PaymentMethods>();

            CreateMap<Neighborhoods, NeighborhoodsTrans>();
            CreateMap<NeighborhoodsTrans, Neighborhoods>();

            CreateMap<Timetable, TimetableTrans>();
            CreateMap<TimetableTrans, Timetable>();

            CreateMap<UsersSite, UsersSiteTrans>();
            CreateMap<UsersSiteTrans, UsersSite>();

            CreateMap<Users, UsersTrans>();
            CreateMap<UsersTrans, Users>();

        }
    }
}
