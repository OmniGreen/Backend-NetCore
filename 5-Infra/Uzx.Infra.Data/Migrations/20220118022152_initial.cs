using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "varchar(100)", nullable: true),
                    State = table.Column<string>(type: "varchar(100)", nullable: true),
                    City = table.Column<string>(type: "varchar(100)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(100)", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(9)", nullable: true),
                    Patio = table.Column<string>(type: "varchar(100)", nullable: true),
                    Number = table.Column<string>(type: "varchar(10)", nullable: true),
                    Complement = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    AdressTypesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.AdressTypesId);
                });

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentId);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    BannerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    NameBanner = table.Column<string>(type: "varchar(500)", nullable: true),
                    Page = table.Column<string>(type: "varchar(200)", nullable: true),
                    Position = table.Column<string>(type: "varchar(200)", nullable: true),
                    DtStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.BannerId);
                });

            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    BreedsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.BreedsId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Color = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsDestaque = table.Column<bool>(type: "bit", nullable: false),
                    IsEvent = table.Column<bool>(type: "bit", nullable: false),
                    CategoryParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cids",
                columns: table => new
                {
                    CidsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cids", x => x.CidsId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(9)", nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTenant = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Person = table.Column<string>(type: "varchar(200)", nullable: true),
                    Name1 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Name2 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Document1 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Document2 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(200)", nullable: true),
                    DtBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsConfigurations",
                columns: table => new
                {
                    ClientConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataBaseIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataBaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataBaseLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataBasePassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelFields = table.Column<int>(type: "int", nullable: false),
                    IsCampaingSave = table.Column<bool>(type: "bit", nullable: false),
                    smtpServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    smtpPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enableSsl = table.Column<bool>(type: "bit", nullable: false),
                    smtpUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    smtpPass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsConfigurations", x => x.ClientConfigurationId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsContacts",
                columns: table => new
                {
                    ClientContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactName = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContactEmail = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContactSector = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsContacts", x => x.ClientContactId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsNewsletter",
                columns: table => new
                {
                    ClientNewsletterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsNewsletter", x => x.ClientNewsletterId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsOperators",
                columns: table => new
                {
                    ClientOperatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsOperators", x => x.ClientOperatorId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyOperators",
                columns: table => new
                {
                    CompanyOperatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Alt = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icone = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyOperators", x => x.CompanyOperatorId);
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                columns: table => new
                {
                    CostCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.CostCenterId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Acronym = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Code = table.Column<string>(type: "varchar(200)", nullable: true),
                    Value = table.Column<string>(type: "varchar(200)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DtStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amenities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "varchar(200)", nullable: true),
                    LogoIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    PhoneNumberIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    IsDenied = table.Column<bool>(type: "bit", nullable: false),
                    DeniedDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberIsVisible2 = table.Column<bool>(type: "bit", nullable: false),
                    Whats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Site = table.Column<string>(type: "varchar(200)", nullable: true),
                    SiteIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DtEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    LkFacebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkGooglePlus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkLinkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkYoutube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkInstagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeighborhoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Timetable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsGhost = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersBanners",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BannerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersBanners", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersCoupons",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersCoupons", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersEvents",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersEvents", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersGhost",
                columns: table => new
                {
                    CustomerGhostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeniedDescription = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsDenied = table.Column<bool>(type: "bit", nullable: false),
                    Amenities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethods = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "varchar(200)", nullable: true),
                    LogoIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    PhoneNumberIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberIsVisible2 = table.Column<bool>(type: "bit", nullable: false),
                    Whats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Site = table.Column<string>(type: "varchar(200)", nullable: true),
                    SiteIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DtEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressIsVisible = table.Column<bool>(type: "bit", nullable: false),
                    LkFacebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkGooglePlus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkLinkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkYoutube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkInstagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeighborhoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Timetable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsGhost = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersGhost", x => x.CustomerGhostId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersSalePlans",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DtStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersSalePlans", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersSocialMedias",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialMediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "varchar(500)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersSocialMedias", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorsId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Place = table.Column<string>(type: "varchar(500)", nullable: true),
                    DtStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Whats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompraOnline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkFacebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkGooglePlus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkLinkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkYoutube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LkInstagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "EventsSocialMedias",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialMediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "varchar(500)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsSocialMedias", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "FamilyType",
                columns: table => new
                {
                    FamilyTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyType", x => x.FamilyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    FunctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.FunctionId);
                });

            migrationBuilder.CreateTable(
                name: "GroupUsers",
                columns: table => new
                {
                    IdGroupUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmGroupUser = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUsers", x => x.IdGroupUser);
                });

            migrationBuilder.CreateTable(
                name: "GroupUsersMenus",
                columns: table => new
                {
                    IdGroupUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMenu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdModule = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUsersMenus", x => x.IdGroupUser);
                });

            migrationBuilder.CreateTable(
                name: "Higher",
                columns: table => new
                {
                    HigherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Higher", x => x.HigherId);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "Kinship",
                columns: table => new
                {
                    KinshipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kinship", x => x.KinshipId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    IdLanguage = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmLanguage = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.IdLanguage);
                });

            migrationBuilder.CreateTable(
                name: "LanguagesTraductions",
                columns: table => new
                {
                    IdLanguage = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTraduction = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagesTraductions", x => x.IdLanguage);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    IdMaritalStatus = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.IdMaritalStatus);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    IdMenu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmMenu = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "MenusType",
                columns: table => new
                {
                    MenusTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenusType", x => x.MenusTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    IdModule = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmModule = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.IdModule);
                });

            migrationBuilder.CreateTable(
                name: "ModulesLanguages",
                columns: table => new
                {
                    IdModule = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLanguage = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesLanguages", x => x.IdModule);
                });

            migrationBuilder.CreateTable(
                name: "ModulesMenu",
                columns: table => new
                {
                    IdModule = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMenu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesMenu", x => x.IdModule);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodId);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyOperatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Code = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureId);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderId);
                });

            migrationBuilder.CreateTable(
                name: "Resposabilities",
                columns: table => new
                {
                    ResponsabilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Code = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resposabilities", x => x.ResponsabilityId);
                });

            migrationBuilder.CreateTable(
                name: "SalePlans",
                columns: table => new
                {
                    SalePlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    DurationMounth = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsGuia = table.Column<bool>(type: "bit", nullable: false),
                    PaymentLink = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsBanner = table.Column<bool>(type: "bit", nullable: false),
                    IsCoupons = table.Column<bool>(type: "bit", nullable: false),
                    IsEvents = table.Column<bool>(type: "bit", nullable: false),
                    IsDestaque = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalePlans", x => x.SalePlanId);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    SpecialityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.SpecialityId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Acronym = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "StatusSolicitation",
                columns: table => new
                {
                    SatusSolicitationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusSolicitation", x => x.SatusSolicitationId);
                });

            migrationBuilder.CreateTable(
                name: "StoredEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "varchar(100)", nullable: true),
                    AggregateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Systems",
                columns: table => new
                {
                    SystemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Alt = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Image = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems", x => x.SystemId);
                });

            migrationBuilder.CreateTable(
                name: "SystemsLanguages",
                columns: table => new
                {
                    SystemLanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemsLanguages", x => x.SystemLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "SystemsMenus",
                columns: table => new
                {
                    SystemMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemsMenus", x => x.SystemMenuId);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    IdTenant = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmTenant = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.IdTenant);
                });

            migrationBuilder.CreateTable(
                name: "Timetable",
                columns: table => new
                {
                    TimetableId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    hrs24 = table.Column<bool>(type: "bit", nullable: false),
                    AllDays = table.Column<bool>(type: "bit", nullable: false),
                    AllDaysIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllDaysOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monday = table.Column<bool>(type: "bit", nullable: false),
                    MondayIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MondayOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    TuesdayIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TuesdayOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false),
                    WednesdayIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WednesdayOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    ThursdayIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThursdayOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    FridayIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FridayOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saturday = table.Column<bool>(type: "bit", nullable: false),
                    SaturdayIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaturdayOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sunday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SundayIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SundayOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetable", x => x.TimetableId);
                });

            migrationBuilder.CreateTable(
                name: "Traductions",
                columns: table => new
                {
                    IdTraduction = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmTraduction = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traductions", x => x.IdTraduction);
                });

            migrationBuilder.CreateTable(
                name: "TransportLines",
                columns: table => new
                {
                    TransportLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportLines", x => x.TransportLineId);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    TransportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.TransportId);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.TreatmentId);
                });

            migrationBuilder.CreateTable(
                name: "TypeProviders",
                columns: table => new
                {
                    TypeProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeProviders", x => x.TypeProviderId);
                });

            migrationBuilder.CreateTable(
                name: "TypeSolicitation",
                columns: table => new
                {
                    TypeSolicitationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSolicitation", x => x.TypeSolicitationId);
                });

            migrationBuilder.CreateTable(
                name: "TypeTransports",
                columns: table => new
                {
                    TypeTransportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTransports", x => x.TypeTransportId);
                });

            migrationBuilder.CreateTable(
                name: "Unions",
                columns: table => new
                {
                    UnionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unions", x => x.UnionId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGroupUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmLogin = table.Column<string>(type: "varchar(200)", nullable: true),
                    Password = table.Column<string>(type: "varchar(200)", nullable: true),
                    NmEmail = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "UsersAccess",
                columns: table => new
                {
                    IdUserProfile = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NmUser = table.Column<string>(type: "varchar(200)", nullable: true),
                    NmSurname = table.Column<string>(type: "varchar(200)", nullable: true),
                    DtBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NbCPF = table.Column<string>(type: "varchar(14)", nullable: true),
                    NbRG = table.Column<string>(type: "varchar(12)", nullable: true),
                    NmMother = table.Column<string>(type: "varchar(200)", nullable: true),
                    NmFather = table.Column<string>(type: "varchar(200)", nullable: true),
                    IdMaritalStatus = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NbPis = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAccess", x => x.IdUserProfile);
                });

            migrationBuilder.CreateTable(
                name: "UsersPermissions",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMenu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    C = table.Column<bool>(type: "bit", nullable: false),
                    R = table.Column<bool>(type: "bit", nullable: false),
                    U = table.Column<bool>(type: "bit", nullable: false),
                    D = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPermissions", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "UsersPermissionsMenus",
                columns: table => new
                {
                    UserPermissionMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserPermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    C = table.Column<bool>(type: "bit", nullable: false),
                    R = table.Column<bool>(type: "bit", nullable: false),
                    U = table.Column<bool>(type: "bit", nullable: false),
                    D = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPermissionsMenus", x => x.UserPermissionMenuId);
                });

            migrationBuilder.CreateTable(
                name: "UsersSite",
                columns: table => new
                {
                    UserSiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Whatsapp = table.Column<string>(type: "varchar(20)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSite", x => x.UserSiteId);
                });

            migrationBuilder.CreateTable(
                name: "UsersStatus",
                columns: table => new
                {
                    UserStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersStatus", x => x.UserStatusId);
                });

            migrationBuilder.CreateTable(
                name: "UsersTokens",
                columns: table => new
                {
                    UserTokenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTokens", x => x.UserTokenId);
                });

            migrationBuilder.CreateTable(
                name: "UsersTypes",
                columns: table => new
                {
                    UserTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTypes", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsSystems",
                columns: table => new
                {
                    ClientSystemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SystemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsSystems", x => x.ClientSystemId);
                    table.ForeignKey(
                        name: "FK_ClientsSystems_Systems_SystemId",
                        column: x => x.SystemId,
                        principalTable: "Systems",
                        principalColumn: "SystemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersProperties",
                columns: table => new
                {
                    UserPropertieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Surname = table.Column<string>(type: "varchar(200)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(200)", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(13)", nullable: true),
                    Rg = table.Column<string>(type: "varchar(12)", nullable: true),
                    DtBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "varchar(200)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(14)", nullable: true),
                    CellPhone = table.Column<string>(type: "varchar(14)", nullable: true),
                    TypeUserTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProperties", x => x.UserPropertieId);
                    table.ForeignKey(
                        name: "FK_UsersProperties_UsersTypes_TypeUserTypeId",
                        column: x => x.TypeUserTypeId,
                        principalTable: "UsersTypes",
                        principalColumn: "UserTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IdTenant", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("4b461a7f-faa4-4630-84f6-ffbc0391d0dd"), null, null, null, null, null, new DateTime(2022, 1, 17, 23, 21, 52, 110, DateTimeKind.Local).AddTicks(8730), null, null, new Guid("00000000-0000-0000-0000-000000000000"), true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.CreateIndex(
                name: "IX_ClientsSystems_SystemId",
                table: "ClientsSystems",
                column: "SystemId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProperties_TypeUserTypeId",
                table: "UsersProperties",
                column: "TypeUserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Breeds");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cids");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ClientsConfigurations");

            migrationBuilder.DropTable(
                name: "ClientsContacts");

            migrationBuilder.DropTable(
                name: "ClientsNewsletter");

            migrationBuilder.DropTable(
                name: "ClientsOperators");

            migrationBuilder.DropTable(
                name: "ClientsSystems");

            migrationBuilder.DropTable(
                name: "CompanyOperators");

            migrationBuilder.DropTable(
                name: "CostCenter");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomersBanners");

            migrationBuilder.DropTable(
                name: "CustomersCoupons");

            migrationBuilder.DropTable(
                name: "CustomersEvents");

            migrationBuilder.DropTable(
                name: "CustomersGhost");

            migrationBuilder.DropTable(
                name: "CustomersSalePlans");

            migrationBuilder.DropTable(
                name: "CustomersSocialMedias");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventsSocialMedias");

            migrationBuilder.DropTable(
                name: "FamilyType");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "GroupUsers");

            migrationBuilder.DropTable(
                name: "GroupUsersMenus");

            migrationBuilder.DropTable(
                name: "Higher");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Kinship");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "LanguagesTraductions");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MenusType");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "ModulesLanguages");

            migrationBuilder.DropTable(
                name: "ModulesMenu");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Resposabilities");

            migrationBuilder.DropTable(
                name: "SalePlans");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "StatusSolicitation");

            migrationBuilder.DropTable(
                name: "StoredEvent");

            migrationBuilder.DropTable(
                name: "SystemsLanguages");

            migrationBuilder.DropTable(
                name: "SystemsMenus");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Timetable");

            migrationBuilder.DropTable(
                name: "Traductions");

            migrationBuilder.DropTable(
                name: "TransportLines");

            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "TypeProviders");

            migrationBuilder.DropTable(
                name: "TypeSolicitation");

            migrationBuilder.DropTable(
                name: "TypeTransports");

            migrationBuilder.DropTable(
                name: "Unions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersAccess");

            migrationBuilder.DropTable(
                name: "UsersPermissions");

            migrationBuilder.DropTable(
                name: "UsersPermissionsMenus");

            migrationBuilder.DropTable(
                name: "UsersProperties");

            migrationBuilder.DropTable(
                name: "UsersSite");

            migrationBuilder.DropTable(
                name: "UsersStatus");

            migrationBuilder.DropTable(
                name: "UsersTokens");

            migrationBuilder.DropTable(
                name: "Systems");

            migrationBuilder.DropTable(
                name: "UsersTypes");
        }
    }
}
