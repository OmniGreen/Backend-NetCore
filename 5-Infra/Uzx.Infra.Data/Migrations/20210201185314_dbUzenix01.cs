using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class dbUzenix01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "varchar(100)", nullable: true),
                    State = table.Column<string>(type: "varchar(100)", nullable: true),
                    City = table.Column<string>(type: "varchar(100)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(100)", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(9)", nullable: true),
                    Patio = table.Column<string>(type: "varchar(100)", nullable: true),
                    Number = table.Column<string>(type: "varchar(10)", nullable: true),
                    Complement = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    AdressTypesId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.AdressTypesId);
                });

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentId);
                });

            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    BreedsId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.BreedsId);
                });

            migrationBuilder.CreateTable(
                name: "Cids",
                columns: table => new
                {
                    CidsId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cids", x => x.CidsId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    StateId = table.Column<Guid>(type: "uuid", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(9)", nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: false),
                    AgentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Person = table.Column<string>(type: "varchar(200)", nullable: true),
                    Name1 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Name2 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Document1 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Document2 = table.Column<string>(type: "varchar(200)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(200)", nullable: true),
                    DtBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsConfigurations",
                columns: table => new
                {
                    ClientConfigurationId = table.Column<Guid>(type: "uuid", nullable: false),
                    DataBaseIP = table.Column<string>(type: "varchar(200)", nullable: true),
                    DataBaseName = table.Column<string>(type: "varchar(200)", nullable: true),
                    AccessPort = table.Column<string>(type: "varchar(200)", nullable: true),
                    DataBaseLogin = table.Column<string>(type: "varchar(200)", nullable: true),
                    DataBasePassword = table.Column<string>(type: "varchar(200)", nullable: true),
                    FilePath = table.Column<string>(type: "varchar(200)", nullable: true),
                    LevelFields = table.Column<int>(type: "integer", nullable: false),
                    IsCampaingSave = table.Column<bool>(type: "boolean", nullable: false),
                    smtpServer = table.Column<string>(type: "varchar(200)", nullable: true),
                    smtpPort = table.Column<string>(type: "varchar(200)", nullable: true),
                    enableSsl = table.Column<bool>(type: "boolean", nullable: false),
                    smtpUser = table.Column<string>(type: "varchar(200)", nullable: true),
                    smtpPass = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsConfigurations", x => x.ClientConfigurationId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsContacts",
                columns: table => new
                {
                    ClientContactId = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactName = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContactEmail = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContactSector = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsContacts", x => x.ClientContactId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsNewsletter",
                columns: table => new
                {
                    ClientNewsletterId = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsNewsletter", x => x.ClientNewsletterId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsOperators",
                columns: table => new
                {
                    ClientOperatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    OperatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsOperators", x => x.ClientOperatorId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyOperators",
                columns: table => new
                {
                    CompanyOperatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Alt = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icone = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyOperators", x => x.CompanyOperatorId);
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                columns: table => new
                {
                    CostCenterId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.CostCenterId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Acronym = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorsId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorsId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "FamilyType",
                columns: table => new
                {
                    FamilyTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyType", x => x.FamilyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    FunctionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.FunctionId);
                });

            migrationBuilder.CreateTable(
                name: "GroupUsers",
                columns: table => new
                {
                    GroupUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUsers", x => x.GroupUserId);
                });

            migrationBuilder.CreateTable(
                name: "GroupUsersMenus",
                columns: table => new
                {
                    GroupUserMenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    C = table.Column<bool>(type: "boolean", nullable: false),
                    R = table.Column<bool>(type: "boolean", nullable: false),
                    U = table.Column<bool>(type: "boolean", nullable: false),
                    D = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUsersMenus", x => x.GroupUserMenuId);
                });

            migrationBuilder.CreateTable(
                name: "Higher",
                columns: table => new
                {
                    HigherId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Higher", x => x.HigherId);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "Kinship",
                columns: table => new
                {
                    KinshipId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kinship", x => x.KinshipId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Country = table.Column<string>(type: "varchar(200)", nullable: true),
                    FileName = table.Column<string>(type: "varchar(200)", nullable: true),
                    Alt = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Image = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    MaritalStatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.MaritalStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    MenusTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuIdPai = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Link = table.Column<string>(type: "varchar(200)", nullable: true),
                    Target = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icone = table.Column<string>(type: "varchar(200)", nullable: true),
                    Alt = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "MenusType",
                columns: table => new
                {
                    MenusTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenusType", x => x.MenusTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyOperatorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Code = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureId);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderId);
                });

            migrationBuilder.CreateTable(
                name: "Resposabilities",
                columns: table => new
                {
                    ResponsabilityId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Code = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resposabilities", x => x.ResponsabilityId);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    SpecialityId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.SpecialityId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Acronym = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "StatusSolicitation",
                columns: table => new
                {
                    SatusSolicitationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusSolicitation", x => x.SatusSolicitationId);
                });

            migrationBuilder.CreateTable(
                name: "StoredEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: true),
                    User = table.Column<string>(type: "text", nullable: true),
                    Action = table.Column<string>(type: "varchar(100)", nullable: true),
                    AggregateId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoredEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Systems",
                columns: table => new
                {
                    SystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Alt = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Image = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems", x => x.SystemId);
                });

            migrationBuilder.CreateTable(
                name: "SystemsLanguages",
                columns: table => new
                {
                    SystemLanguageId = table.Column<Guid>(type: "uuid", nullable: false),
                    SystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemsLanguages", x => x.SystemLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "SystemsMenus",
                columns: table => new
                {
                    SystemMenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    SystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemsMenus", x => x.SystemMenuId);
                });

            migrationBuilder.CreateTable(
                name: "TransportLines",
                columns: table => new
                {
                    TransportLineId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportLines", x => x.TransportLineId);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    TransportId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.TransportId);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    TreatmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.TreatmentId);
                });

            migrationBuilder.CreateTable(
                name: "TypeProviders",
                columns: table => new
                {
                    TypeProviderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeProviders", x => x.TypeProviderId);
                });

            migrationBuilder.CreateTable(
                name: "TypeSolicitation",
                columns: table => new
                {
                    TypeSolicitationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSolicitation", x => x.TypeSolicitationId);
                });

            migrationBuilder.CreateTable(
                name: "TypeTransports",
                columns: table => new
                {
                    TypeTransportId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTransports", x => x.TypeTransportId);
                });

            migrationBuilder.CreateTable(
                name: "Unions",
                columns: table => new
                {
                    UnionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unions", x => x.UnionId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Surname = table.Column<string>(type: "varchar(200)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(200)", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(13)", nullable: true),
                    Rg = table.Column<string>(type: "varchar(12)", nullable: true),
                    DtBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Nationality = table.Column<string>(type: "varchar(200)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(14)", nullable: true),
                    CellPhone = table.Column<string>(type: "varchar(14)", nullable: true),
                    Icone = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UsersAccess",
                columns: table => new
                {
                    UserAccessId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "varchar(200)", nullable: true),
                    Password = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsVerify = table.Column<bool>(type: "boolean", nullable: false),
                    DTVerify = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAccess", x => x.UserAccessId);
                });

            migrationBuilder.CreateTable(
                name: "UsersPermissions",
                columns: table => new
                {
                    UserPermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    SystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPermissions", x => x.UserPermissionId);
                });

            migrationBuilder.CreateTable(
                name: "UsersPermissionsMenus",
                columns: table => new
                {
                    UserPermissionMenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserPermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    C = table.Column<bool>(type: "boolean", nullable: false),
                    R = table.Column<bool>(type: "boolean", nullable: false),
                    U = table.Column<bool>(type: "boolean", nullable: false),
                    D = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPermissionsMenus", x => x.UserPermissionMenuId);
                });

            migrationBuilder.CreateTable(
                name: "UsersStatus",
                columns: table => new
                {
                    UserStatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersStatus", x => x.UserStatusId);
                });

            migrationBuilder.CreateTable(
                name: "UsersTokens",
                columns: table => new
                {
                    UserTokenId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Token = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTokens", x => x.UserTokenId);
                });

            migrationBuilder.CreateTable(
                name: "UsersTypes",
                columns: table => new
                {
                    UserTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTypes", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ClientsSystems",
                columns: table => new
                {
                    ClientSystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    SystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
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
                    UserPropertieId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Surname = table.Column<string>(type: "varchar(200)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(200)", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(13)", nullable: true),
                    Rg = table.Column<string>(type: "varchar(12)", nullable: true),
                    DtBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Nationality = table.Column<string>(type: "varchar(200)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(14)", nullable: true),
                    CellPhone = table.Column<string>(type: "varchar(14)", nullable: true),
                    TypeUserTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
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
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, null, null, null, null, new DateTime(2021, 2, 1, 15, 53, 13, 718, DateTimeKind.Local).AddTicks(3002), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(6740), true, false, "Administradores", new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("e0d70980-c014-4f54-9676-71bccf1009ab"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4918), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("7904522d-f9ca-4735-9495-aec66a31ff7d"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4880), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("2eb562e6-c21e-4326-bbba-15196cdb4540"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4862), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("1848adbe-0e45-44fd-a4b7-1cf7cd669843"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4845), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("8fb18f8b-c07a-4399-9ced-0630644318b5"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4826), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("33404e06-3426-4c5c-8f26-bc6c93c9bfd6"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4807), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("55de40d5-958f-4e81-934a-8757a088343a"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("c3b9095e-fe10-4648-b4c5-6cf145e0e7d2"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4789), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("2f465dfe-3a6c-406e-a405-2113b2aa11a4"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4772), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("19dd981c-3c7e-47a4-9d68-db5a47f5d52f"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4754), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("064a7434-28d8-4697-a9e7-52ab22c01f16"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4737), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("6a06ba84-557a-42f0-a323-ff486966ae38"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4720), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("c3b2dd53-a49c-4772-81c0-b47fe7ba49e8"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4702), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("345670d9-088f-4438-9792-87ab3c8d5e32"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4683), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("51585175-d0e0-4246-9263-e3cdf278f766"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4661), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("9ed3c04d-5056-41da-9b35-1b2e93a29d41"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4644), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("3da018f3-d91f-49f1-af95-415be4305329"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("a5c82b2c-c369-4f87-8e58-3e1e386392d2"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4626), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("e00e9432-231b-401f-a031-745ac31cb733"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("5b88d341-a20c-4b79-9df8-6eb966cd7e3e"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4605), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("4123d725-6c83-474c-8a0f-19cb2caad5a9"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4558), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("3bc4dba6-dc6e-40a4-b9c0-d298354da918"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4540), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("f9bf76a4-3d22-4aff-bec6-4e8ea0729b2f"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4518), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("69fe413b-c40b-43df-a5c9-8313a885a736"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4314), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("b27ff508-2c0d-453c-9b3c-63688388759f"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4936), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("9cd3f2a6-7af4-451e-bc2f-c4742ed407cf"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5689), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b2df024f-08f3-4c1d-a290-913477944a28"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5604), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5349fff1-bf54-46ed-a5f4-36406f6a7ef5"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(3628), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1771), null, "", true, false, "groupusers/details", new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1735), null, "", true, false, "groupusers/list", new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1699), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1663), null, "", true, false, "systems/details", new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1625), null, "", true, false, "systems/list", new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1566), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("55de40d5-958f-4e81-934a-8757a088343a"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1528), null, "", true, false, "languages/details", new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1492), null, "", true, false, "languages/list", new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1454), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1418), null, "", true, false, "clients/details", new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1381), null, "", true, false, "clients/list", new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1282), null, "", true, false, "menus/details", new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1243), null, "", true, false, "menus/list", new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1206), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3da018f3-d91f-49f1-af95-415be4305329"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1170), null, "", true, false, "users/details", new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e00e9432-231b-401f-a031-745ac31cb733"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1130), null, "", true, false, "users/list", new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1090), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(997), null, "", true, false, "companyoperators/details", new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(930), null, "", true, false, "companyoperators/list", new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(852), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(9119), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1344), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 1, 15, 53, 13, 719, DateTimeKind.Local).AddTicks(9716), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("82629ade-64e4-4c27-b24c-fc225bf30a5a"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5708), true, true, false, new Guid("9cd3f2a6-7af4-451e-bc2f-c4742ed407cf"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null },
                    { new Guid("716c7e89-b5b2-42d5-aab2-c0841ca039ba"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5409), true, true, false, new Guid("5349fff1-bf54-46ed-a5f4-36406f6a7ef5"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null },
                    { new Guid("97667267-f8e8-4cbc-acab-38aa9ceb8017"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5668), true, true, false, new Guid("b2df024f-08f3-4c1d-a290-913477944a28"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("0dd69290-06a5-49cd-96ae-3f3a687c2c08"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1604), null, true, false, new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5c65b4d8-7819-403d-8505-3b7b9a1deb07"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1753), null, true, false, new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("84dcdab6-cb3e-4d65-af96-c872005bdd1d"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1717), null, true, false, new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("921d94d4-9fdc-43d8-8f71-38d1f1349d7e"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1681), null, true, false, new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("93ed5480-e4cd-4743-b431-d1772900fd05"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1642), null, true, false, new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("462cf482-a45b-4fd5-b296-6d41cf868855"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1546), null, true, false, new Guid("55de40d5-958f-4e81-934a-8757a088343a"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d7c9afa5-4936-45f4-9846-8d77e4d0a050"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1510), null, true, false, new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bb1852f-420a-4303-868e-0004b192c9c0"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1472), null, true, false, new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("678ec6f0-f33d-4006-b4ac-9e656dccaf38"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1436), null, true, false, new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c3cb66c7-dbef-4b20-8187-a7b84b2838ef"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1399), null, true, false, new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b6f0f2b5-3f1e-43a1-b1f9-0146337e5d8c"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1362), null, true, false, new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24b1764f-5c54-405f-af3a-07e81a640b00"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1299), null, true, false, new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef57f52e-692a-41a7-b9be-8f9293564942"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1262), null, true, false, new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b676dd5a-b94f-48c1-951f-eb06dce438cb"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1223), null, true, false, new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("730c9a29-211b-42cc-a72c-b508c7cdd873"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1187), null, true, false, new Guid("3da018f3-d91f-49f1-af95-415be4305329"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6cb4f341-c29b-4703-b6c5-2ae508b96f89"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1148), null, true, false, new Guid("e00e9432-231b-401f-a031-745ac31cb733"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("873cac77-417d-4183-935e-ced1bf979bf8"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1110), null, true, false, new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f892c909-f996-41bf-94f5-0e7429ffc329"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1016), null, true, false, new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9ceae6a7-6041-442f-9e41-7838a728eb8e"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(948), null, true, false, new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0e77bff5-18a0-4dbf-bd2f-0f3847f80eed"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(899), null, true, false, new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d20d558-2c89-4932-82ce-636c902a74fd"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(394), null, true, false, new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ee387c0-c8b5-4dc1-a020-e00ab6ef9354"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1789), null, true, false, new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a2758512-8943-422c-a4e7-b330e063b83d"), null, new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, null, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(7441), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("de433980-6f0a-4016-a49c-c98c911233ac"), null, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(8938), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("a2758512-8943-422c-a4e7-b330e063b83d"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8"), new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(965), null, new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), new Guid("a2758512-8943-422c-a4e7-b330e063b83d"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("13eb6098-a63f-467c-9e6b-026f04580b73"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3672), null, true, false, new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("dc06614a-5299-4463-a049-dc02923d9a3c"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3654), null, true, false, new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("b426c52e-ffb1-4ecc-afad-f6b2bf596f6b"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3636), null, true, false, new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("eca942b4-f1d3-4bac-8321-e2e87fb00327"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3618), null, true, false, new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("8bae82f2-5f7a-48a1-84cf-a1f807f6bfa2"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3599), null, true, false, new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("91d5199a-ea15-44ae-882f-14047f06cee7"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3582), null, true, false, new Guid("55de40d5-958f-4e81-934a-8757a088343a"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("4c3f245c-e26a-435a-b096-8d4099de98a3"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3564), null, true, false, new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("c98fa626-2e3f-4c41-8155-40db09f10d3e"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3544), null, true, false, new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("c17ded48-12c0-486c-8e44-9ed85f250293"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3526), null, true, false, new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("113c8551-7fb3-454d-aadd-16719b82539d"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3508), null, true, false, new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("99be9aba-343b-450e-be7a-f6722cdcf32a"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3689), null, true, false, new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("a2dec382-34f2-457e-83d5-ab1c2a7eb872"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3472), null, true, false, new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("5d4e1d7c-0d0b-4983-95a3-1387c235000a"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3424), null, true, false, new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("3e4e869e-a195-46e5-85b0-fc313a474895"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3406), null, true, false, new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("9e378bac-05f9-45af-b306-997ad0793ec5"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3388), null, true, false, new Guid("3da018f3-d91f-49f1-af95-415be4305329"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("708b7b5a-7878-4a8d-be79-8258a1dbdc75"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3365), null, true, false, new Guid("e00e9432-231b-401f-a031-745ac31cb733"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("265d075e-8119-4686-b6d5-47d4dd6107ed"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3345), null, true, false, new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("db07b235-05a5-4866-8a0b-b3b01c7c87ca"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3326), null, true, false, new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("89936aa7-5b67-4226-a43f-add7b62312dd"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3308), null, true, false, new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("ff23db77-1308-478c-93b5-a5752c476f3e"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3285), null, true, false, new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("aceb1a9b-3040-4704-bf84-9855e42f4940"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3098), null, true, false, new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("ac408a23-6ff2-4994-a473-c3d45bd94fa3"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3491), null, true, false, new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("2a517ce9-439d-4c22-a716-c4961352169a"), "usuário administrativo", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(5975), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("79aa661f-8295-44ff-8907-5035e8a224eb"), new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(1543), null, true, false, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });

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
                name: "Breeds");

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
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Educations");

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
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MenusType");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Resposabilities");

            migrationBuilder.DropTable(
                name: "Shifts");

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
