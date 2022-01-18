using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.EntityConfig.Admin;

namespace Uzx.Infra.Data.Context
{
    public class UzxBaseDbContext : DbContext
    {
        public UzxBaseDbContext()
        {
        }

        public UzxBaseDbContext(DbContextOptions<UzxBaseDbContext> options) : base(options) { }

        #region Users
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersSite> UsersSite { get; set; }

        public DbSet<UsersTypes> UsersTypes { get; set; }
        public DbSet<UsersProfile> UsersAccess { get; set; }
        public DbSet<UsersStatus> UsersStatus { get; set; }
        public DbSet<UsersTokens> UsersTokens { get; set; }

        #endregion

        #region Menu

        public DbSet<Menus> Menus { get; set; }

        public DbSet<MenusTypes> MenusType { get; set; }

        #endregion

        #region GroupUsers
        public DbSet<GroupUsers> GroupUsers { get; set; }
        public DbSet<GroupUsersMenus> GroupUsersMenus { get; set; }

        #endregion

        #region Authentication

        #endregion

        #region Address
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressTypes> AddressTypes { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Cities> Cities { get; set; }
        
        #endregion

        #region Clients
        public DbSet<Clients> Clients { get; set; }
        public DbSet<ClientsConfigurations> ClientsConfigurations { get; set; }
        public DbSet<ClientsNewsletter> ClientsNewsletter { get; set; }

        #endregion

        #region ClientsContacts
        public DbSet<ClientsContacts> ClientsContacts { get; set; }

        #endregion

        #region ClientsSystems
        public DbSet<ClientsSystems> ClientsSystems { get; set; }
        #endregion

        #region Systems
        public DbSet<Systems> Systems { get; set; }
        public DbSet<SystemsMenus> SystemsMenus { get; set; }
        public DbSet<SystemsLanguages> SystemsLanguages { get; set; }
        #endregion

        #region Languages
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Traductions> Traductions { get; set; }
        public DbSet<LanguagesTraductions> LanguagesTraductions { get; set; }
        #endregion

        #region Permissions
        public DbSet<UsersPermissions> UsersPermissions { get; set; }
        public DbSet<UsersPermissionsMenus> UsersPermissionsMenus { get; set; }
        #endregion

        #region ClientsOperators
        public DbSet<ClientsOperators> ClientsOperators { get; set; }
        #endregion

        #region CompanyOperators
        public DbSet<CompanyOperators> CompanyOperators { get; set; }
        #endregion

        #region MaritalStatus
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        #endregion

        #region Kinship
        public DbSet<Kinship> Kinship { get; set; }
        #endregion

        #region Department
        public DbSet<Departments> Departments { get; set; }

        #endregion
        #region Modules
        public DbSet<Modules> Modules { get; set; }
        public DbSet<ModulesLanguages> ModulesLanguages { get; set; }
        public DbSet<ModulesMenus> ModulesMenu { get; set; }
        #endregion

        #region Tenants
        public DbSet<Tenants> Tenants { get; set; }
        #endregion

        #region FamilyType
        public DbSet<FamilyType> FamilyType { get; set; }
        #endregion
        public DbSet<PaymentMethods> PaymentMethods { get; set; }
        public DbSet<Breeds> Breeds { get; set; }
        public DbSet<Cids> Cids { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Educations> Educations { get; set; }
        public DbSet<Functions> Functions { get; set; }
        public DbSet<Higher> Higher { get; set; }
        public DbSet<Hospitals> Hospitals { get; set; }
        public DbSet<Offices> Offices { get; set; }
        public DbSet<Plans> Plans { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<Responsabilities> Resposabilities { get; set; }
        public DbSet<Shifts> Shifts { get; set; }
        public DbSet<Specialities> Specialities { get; set; }
        public DbSet<TransportLines> TransportLines { get; set; }
        public DbSet<Transports> Transports { get; set; }
        public DbSet<TypeProviders> TypeProviders { get; set; }
        public DbSet<TypeTransports> TypeTransports { get; set; }
        public DbSet<Unions> Unions { get; set; }
        public DbSet<StatusSolicitation> StatusSolicitation { get; set; }
        public DbSet<Procedures> Procedures { get; set; }
        public DbSet<Treatments> Treatments { get; set; }
        public DbSet<TypeSolicitation> TypeSolicitation { get; set; }

        public DbSet<Agents> Agents { get; set; }



        public DbSet<Categories> Categories { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventsSocialMedias> EventsSocialMedias { get; set; }
        public DbSet<Banners> Banners { get; set; }
        public DbSet<SalePlans> SalePlans { get; set; }
        public DbSet<SocialMedias> SocialMedias { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CustomersGhost> CustomersGhost { get; set; }
        public DbSet<CustomersSocialMedias> CustomersSocialMedias { get; set; }
        public DbSet<CustomersSalePlans> CustomersSalePlans { get; set; }
        public DbSet<CustomersEvents> CustomersEvents { get; set; }
        public DbSet<CustomersBanners> CustomersBanners { get; set; }
        public DbSet<CustomersCoupons> CustomersCoupons { get; set; }


        // protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
        //     optionsBuilder.UseSqlServer (@"Server=ttgsqldev.clxktxu4sghw.us-east-1.rds.amazonaws.com,7433;Database=ttgsqldev;User ID=usrttgsql;Password=SidneyMagal123**;");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //return;
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new AddressTypesConfiguration());
            modelBuilder.ApplyConfiguration(new AgentsConfiguration());
            modelBuilder.ApplyConfiguration(new BreedsConfiguration());
            modelBuilder.ApplyConfiguration(new CidsConfiguration());
            modelBuilder.ApplyConfiguration(new CitiesConfiguration());
            modelBuilder.ApplyConfiguration(new ClientsContactsConfiguration());
            modelBuilder.ApplyConfiguration(new ClientsNewsletterConfiguration());
            modelBuilder.ApplyConfiguration(new ClientsOperatorsConfiguration());
            modelBuilder.ApplyConfiguration(new ClientsSystemsConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyOperatorsConfiguration());
            modelBuilder.ApplyConfiguration(new CostCenterConfiguration());
            modelBuilder.ApplyConfiguration(new CountriesConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorsConfiguration());
            modelBuilder.ApplyConfiguration(new EducationsConfiguration());
            modelBuilder.ApplyConfiguration(new FamilyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FunctionsConfiguration());
            modelBuilder.ApplyConfiguration(new HigherConfiguration());
            modelBuilder.ApplyConfiguration(new HospitalsConfiguration());
            modelBuilder.ApplyConfiguration(new kinshipConfiguration());
            modelBuilder.ApplyConfiguration(new MenusTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OfficesConfiguration());
            modelBuilder.ApplyConfiguration(new PlansConfiguration());
            modelBuilder.ApplyConfiguration(new ProceduresConfiguration());
            modelBuilder.ApplyConfiguration(new ProvidersConfiguration());
            modelBuilder.ApplyConfiguration(new ResponsabilitiesConfiguration());
            modelBuilder.ApplyConfiguration(new ShiftsConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialitiesConfiguration());
            modelBuilder.ApplyConfiguration(new StatesConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new StatusSolicitationConfiguration());
            modelBuilder.ApplyConfiguration(new SystemsConfiguration());
            modelBuilder.ApplyConfiguration(new SystemsLanguagesConfiguration());
            modelBuilder.ApplyConfiguration(new SystemsMenusConfiguration());
            modelBuilder.ApplyConfiguration(new TransportLinesConfiguration());
            modelBuilder.ApplyConfiguration(new TransportsConfiguration());
            modelBuilder.ApplyConfiguration(new TreatmentsConfiguration());
            modelBuilder.ApplyConfiguration(new TypeProvidersConfiguration());
            modelBuilder.ApplyConfiguration(new TypeSolicitationConfiguration());
            modelBuilder.ApplyConfiguration(new TypeTransportsConfiguration());
            modelBuilder.ApplyConfiguration(new UnionsConfiguration());
            //modelBuilder.ApplyConfiguration(new UsersAccessConfiguration());
            modelBuilder.ApplyConfiguration(new UsersPropertiesConfiguration());
            modelBuilder.ApplyConfiguration(new UsersStatusConfiguration());
            modelBuilder.ApplyConfiguration(new UsersTokensConfiguration());
            modelBuilder.ApplyConfiguration(new UsersTypesConfiguration());

            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new CouponsConfiguration());
            modelBuilder.ApplyConfiguration(new EventsConfiguration());
            modelBuilder.ApplyConfiguration(new EventsSocialMediasConfiguration());
            modelBuilder.ApplyConfiguration(new BannersConfiguration());
            modelBuilder.ApplyConfiguration(new SalePlansConfiguration());
            modelBuilder.ApplyConfiguration(new SocialMediasConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersSalePlansConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersSocialMediaConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersEventsConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersBannersConfiguration());
            modelBuilder.ApplyConfiguration(new CustomersCouponsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersPermissionsMenusConfiguration());
            modelBuilder.ApplyConfiguration(new ClientsConfiguration());
            modelBuilder.ApplyConfiguration(new GroupUsersConfiguration());
            modelBuilder.ApplyConfiguration(new GroupUsersMenusConfiguration());
            modelBuilder.ApplyConfiguration(new LanguagesConfiguration());
            modelBuilder.ApplyConfiguration(new LanguagesTraductionsConfiguration());
            modelBuilder.ApplyConfiguration(new MaritalStatusConfiguration());
            modelBuilder.ApplyConfiguration(new MenusConfiguration());
            modelBuilder.ApplyConfiguration(new ModulesConfiguration());
            modelBuilder.ApplyConfiguration(new ModulesLanguagesConfiguration());
            modelBuilder.ApplyConfiguration(new ModulesMenusConfiguration());
            modelBuilder.ApplyConfiguration(new TenantsConfiguration());
            modelBuilder.ApplyConfiguration(new TraductionsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new UsersPermissionsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersProfileConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



            //modelBuilder.Entity<Clients>().ToTable("tbClients");
            //modelBuilder.Entity<Agents>().ToTable("tbAgents");
            //  modelBuilder.Entity<ClientsContacts>().ToTable("tbClientsContacts");
            //  modelBuilder.Entity<ClientsConfigurations>().ToTable("tbClientsConfigurations");
            //  modelBuilder.Entity<ClientsSystems>().ToTable("tbClientsSystems");
            //  modelBuilder.Entity<Users>().ToTable("tbUsers");
            //  modelBuilder.Entity<UsersTypes>().ToTable("tbUsesrTypes");
            //  modelBuilder.Entity<UsersAccess>().ToTable("tbUsersAccess");
            //  modelBuilder.Entity<UsersStatus>().ToTable("tbUsersStatus");
            //  modelBuilder.Entity<UsersTokens>().ToTable("tbUsersTokens");
            //  modelBuilder.Entity<UsersPermissionsMenus>().ToTable("tbUsersPermissionsMenus");
            //  modelBuilder.Entity<UsersPermissions>().ToTable("tbUsersPermissions");

            //  modelBuilder.Entity<GroupUsers>().ToTable("tbGroupsUsers");
            //  modelBuilder.Entity<GroupUsersMenus>().ToTable("tbGroupUsersMenu");

            //  modelBuilder.Entity<Menus>().ToTable("tbMenus");

            //  modelBuilder.Entity<Address>().ToTable("tbAddress");
            //  modelBuilder.Entity<AddressTypes>().ToTable("tbAddressTypes");
            //  modelBuilder.Entity<Countries>().ToTable("tbCountries");
            //  modelBuilder.Entity<States>().ToTable("tbStates");
            //  modelBuilder.Entity<Cities>().ToTable("tbCities");

            //  modelBuilder.Entity<Systems>().ToTable("tbSystems");
            //  modelBuilder.Entity<SystemsMenus>().ToTable("tbSystemsMenus");
            //  modelBuilder.Entity<SystemsLanguages>().ToTable("tbSystemsLanguages");

            //  modelBuilder.Entity<Languages>().ToTable("tbLanguages");


            //base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }

    }

}
