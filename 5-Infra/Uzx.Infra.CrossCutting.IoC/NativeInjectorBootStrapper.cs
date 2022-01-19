using Uzx.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Uzx.Infra.Data.Repositories.Admin;
using Uzx.Application.Interfaces.Admin;
using Uzx.Application.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.Data.Repositories;
using Uzx.Domain.Entities.Admin;
using Uzx.Domain.Entities._Base;
using Uzx.Infra.TransferObjects._Base;
using Uzx.Application.Interfaces._Base;
using Uzx.Application._Base;

namespace Uzx.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)

        {
            // ASP.NET HttpContext dependency
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Domain Bus (Mediator)
            //services.AddScoped<IMediatorHandler, InMemoryBus>();


            // Application
            //services.AddScoped<IBaseController, BaseController>();

            //services.AddScoped(typeof(IClientsApp), typeof(ClientsApp));
            //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ILoginApp, LoginApp>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<UzxBaseDbContext>();


            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseApp<,>), typeof(BaseApp<,>));


            services.AddScoped<IBannersApp, BannersApp>();
            services.AddScoped<IBannersRepository, BannersRepository>();

            services.AddScoped<ICategoriesApp, CategoriesApp>();
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();


            services.AddScoped<IClientsApp, ClientsApp>();
            services.AddScoped<IClientsRepository, ClientsRepository>();

            services.AddScoped<IClientsSystemsApp, ClientsSystemsApp>();
            services.AddScoped<IClientsSystemsRepository, ClientsSystemsRepository>();

            services.AddScoped<ICouponsApp, CouponsApp>();
            services.AddScoped<ICouponsRepository, CouponsRepository>();

            services.AddScoped<ICustomersApp, CustomersApp>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();


            services.AddScoped<ICustomersGhostApp, CustomersGhostApp>();
            services.AddScoped<ICustomersGhostRepository, CustomersGhostRepository>();

            services.AddScoped<IEventsApp, EventsApp>();
            services.AddScoped<IEventsRepository, EventsRepository>();

            services.AddScoped<ISalePlansApp, SalePlansApp>();
            services.AddScoped<ISalePlansRepository, SalePlansRepository>();

            services.AddScoped<IPaymentMethodsApp, PaymentMethodsApp>();
            services.AddScoped<IPaymentMethodsRepository, PaymentMethodsRepository>();

            services.AddScoped<INeighborhoodsApp, NeighborhoodsApp>();
            services.AddScoped<INeighborhoodsRepository, NeighborhoodsRepository>();

            services.AddScoped<ITimetableApp, TimetableApp>();
            services.AddScoped<ITimetableRepository, TimetableRepository>();

            services.AddScoped<IUsersSiteApp, UsersSiteApp>();
            services.AddScoped<IUsersSiteRepository, UsersSiteRepository>();

            services.AddScoped<IMenusApp, MenusApp>();
            services.AddScoped<IMenusRepository, MenusRepository>();

            services.AddScoped<ILanguagesTraductionsApp, LanguagesTraductionsApp>();
            services.AddScoped<ILanguagesTraductionsRepository, LanguagesTraductionsRepository>();

            services.AddScoped<ILanguagesApp, LanguagesApp>();
            services.AddScoped<ILanguagesRepository, LanguagesRepository>();

            services.AddScoped<IMaritalStatusApp, MaritalStatusApp>();
            services.AddScoped<IMaritalStatusRepository, MaritalStatusRepository>();

            services.AddScoped<IModulesApp, ModulesApp>();
            services.AddScoped<IModulesRepository, ModulesRepository>();

            services.AddScoped<IModulesLanguagesApp, ModulesLanguagesApp>();
            services.AddScoped<IModulesLanguagesRepository, ModulesLanguagesRepository>();

            services.AddScoped<IModulesMenusApp, ModulesMenusApp>();
            services.AddScoped<IModulesMenusRepository, ModulesMenusRepository>();

            services.AddScoped<ITenantsApp, TenantsApp>();
            services.AddScoped<ITenantsRepository, TenantsRepository>();
            
            services.AddScoped<ITraductionsApp, TraductionsApp>();
            services.AddScoped<ITraductionsRepository, TraductionsRepository>();  
            
            services.AddScoped<IUsersApp, UsersApp>();
            services.AddScoped<IUsersRepository, UsersRepository>();  
            
            services.AddScoped<IUsersPermissionsApp, UsersPermissionsApp>();
            services.AddScoped<IUsersPermissionsRepository, UsersPermissionsRepository>(); 
            
            services.AddScoped<IUsersProfileApp, UsersProfileApp>();
            services.AddScoped<IUsersProfileRepository, UsersProfileRepository>();

       




            // Domain - Events
            // services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            // services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
            // services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            // services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            // services.AddScoped<IRequestHandler<RegisterNewCustomerCommand, bool>, CustomerCommandHandler>();
            // services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            // services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Data

            // services.AddScoped<IUnitOfWork, UnitOfWork>();
            // services.AddScoped<UzxBaseDbContext>();

            // Infra - Data EventSourcing
            // services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            // services.AddScoped<IEventStore, SqlEventStore>();
            // services.AddScoped<EventStoreSQLContext>();


        }
    }
}