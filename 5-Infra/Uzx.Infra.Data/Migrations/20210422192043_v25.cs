using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("e5a49ef7-a996-4b8a-8ad6-9e33e985e671"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("17d28e81-e2cf-4f15-b519-dce0e715fe4c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1df5485d-7f72-4456-bee3-a1d92041b972"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2d17a4ad-0e78-4c1e-9815-ee298346d4bd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2fc3e754-d16a-409b-80f6-bb39391090c2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("40d0b824-6e26-425c-911f-4e6b0db12982"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5257c655-40c9-468a-9ec7-a71a67f63940"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("53f57673-86f4-430d-a9b1-d9e81c8491d9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6cbd9818-9712-4301-b83c-7f7e3b39b06c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7c73896c-0412-4c28-b533-4465e089e9f4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7d37c2aa-e97e-4865-95d9-c97fa04a82d8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7f7fecd3-6af0-4b2f-8727-0bf0840574be"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("85f07777-7c35-4d17-af7b-5bcddaa81cfc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9da56925-2978-469f-89df-e5d86641faba"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bb8da7a5-7ba3-4bfb-b1f7-f51709c46af2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d1b642d6-f0c2-4204-a30d-cf1a837cc63a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("df449838-6055-4176-a534-f92003b17f6e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ea5c9ed4-8790-49b4-93ff-852d1ad9e9a5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec731bf2-ba71-458c-ae13-35048a993977"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f1ba1454-f336-4dbb-abf6-7f2aa487cfaf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f251bee9-73f0-4e28-aace-90e266d2fb8f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f83f33cd-c2ca-4b38-9bf6-40daa7a47b28"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fcb4b9d6-4567-4754-abc2-a8b5c4e4910b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("3aea18f3-bf2e-4470-b187-660aecae6cf6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9bc96bb1-f321-489f-a1bb-0bca7e1eca09"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f39f1187-d59d-47ca-9e6a-1a0001215e28"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("227a3363-6b60-49f9-854e-6f2722040498"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a72b8d04-cee2-4297-845c-2b098a862731"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("1dfedb88-1b3a-43c8-af47-3bde0e412fb0"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("2c30587b-7796-43f8-b2c6-810c9879d940"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("b61c73ec-28eb-434e-8320-88797806c45f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("07e473b0-85a0-46b3-9d24-7c12984d6125"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1765d3ec-5c18-40da-8c97-f14b752aa57d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1b620e04-f26d-45b2-98f7-5615423c3547"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1d449d0b-faf3-46db-88f7-861fdd67e1ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("20c7350a-fba9-4d3e-bbb1-74def8f49b1f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("21cd67c6-5257-4e1e-a30e-69023c0a2346"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("28b85dee-101b-4d85-9837-af35edafd15d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2ebdea6c-f535-4586-8669-624fd56c46d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("33feb980-c7da-464a-a4c1-4b9704e84fa7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3668027b-50e8-45e9-80cb-8c12ffe83f10"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("413ad711-23bb-4135-b697-fa30159c1291"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("688b2506-159b-4b47-8e47-bdfd6b27e8cb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("82a5b927-d141-4bab-b463-3ade73527d5d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8be78e10-d413-4103-91bf-2dd22af0e470"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8ed58637-4acb-42b3-93fd-7d769d5527d0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("931bc296-7810-4288-92a3-a91813c9c3d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("97575aac-4d4d-4ecb-b159-4c7de739dd4e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b1534a07-cf99-4ec7-9290-23eefbc41541"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bd1f7d7f-f6d7-46c4-b513-a86c2fc1b386"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cdb3e5bc-3bf7-40c0-8e14-7f61963c939e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d2e0cd5d-50b0-4fa7-bbd0-c123fa27fd81"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e6d980ef-2bd0-466b-abdd-cc70757e6a99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("42589e48-e92f-4aee-a869-9c69d42c925f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0fc5a5d1-b2d2-4c96-a649-8406b568c385"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("14e92758-1059-479e-86c7-fe5a9a655650"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("171c8f39-a34e-4aa9-8ae5-8d5981a2a389"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("22673f39-f746-49b5-969a-43afffa84597"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("34cdbd51-6cb4-4868-a56b-a414958d33d3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3625085b-854a-454c-9d23-7756f42c61f1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3da20dcb-9915-445f-9663-74a71059d73b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("407908ae-8265-4b8b-88fa-4bf3f473bacc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4b76566f-551d-41ba-ba2a-957635e0b389"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("688528bc-84fa-4549-86ad-388b88d58f6a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8580959e-4335-4fee-9701-7698b8b54429"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8c9f025d-fc55-4900-83a8-e67f756a1b14"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9280f1dd-8f1a-47ff-a870-c097824724db"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("93f3cbf1-3ab5-4906-8620-dfb7e91d852b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a11abfad-e57e-4fe4-b1b5-680d22641c23"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a59e177e-88ef-473f-9455-b5625742fd8f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bbc272b3-827a-4760-aeff-c08ed8aa61a8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c8c0508b-60a3-410c-a980-0525e1e3150a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c935f5b6-809d-4a66-9388-8e0e593882ed"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d1d65eb2-2eeb-48a2-bc09-acea6813d456"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e4c96689-61ec-4eb0-ba38-340ece849999"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e91f4210-e013-4e2d-8066-d0a5db21390f"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("eddfa31b-fc21-404d-b066-f8bb591dd6bf"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"));

            migrationBuilder.CreateTable(
                name: "CustomersGhost",
                columns: table => new
                {
                    CustomerGhostId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DeniedDescription = table.Column<string>(type: "varchar(200)", nullable: true),
                    Amenities = table.Column<string>(type: "text", nullable: true),
                    Specialties = table.Column<string>(type: "text", nullable: true),
                    VideoLink = table.Column<string>(type: "text", nullable: true),
                    PaymentMethods = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "varchar(200)", nullable: true),
                    LogoIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    PhoneNumberIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberIsVisible2 = table.Column<bool>(type: "boolean", nullable: false),
                    Whats = table.Column<string>(type: "text", nullable: true),
                    WhatsIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    Site = table.Column<string>(type: "varchar(200)", nullable: true),
                    SiteIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Latitude = table.Column<string>(type: "text", nullable: true),
                    Longitude = table.Column<string>(type: "text", nullable: true),
                    SalePlanId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DtEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EmailIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: true),
                    AddressIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    LkFacebook = table.Column<string>(type: "text", nullable: true),
                    LkTwitter = table.Column<string>(type: "text", nullable: true),
                    LkGooglePlus = table.Column<string>(type: "text", nullable: true),
                    LkLinkedin = table.Column<string>(type: "text", nullable: true),
                    LkYoutube = table.Column<string>(type: "text", nullable: true),
                    LkInstagram = table.Column<string>(type: "text", nullable: true),
                    NeighborhoodId = table.Column<Guid>(type: "uuid", nullable: true),
                    Timetable = table.Column<string>(type: "text", nullable: true),
                    Images = table.Column<string>(type: "text", nullable: true),
                    UserSiteId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsGhost = table.Column<bool>(type: "boolean", nullable: false),
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
                    table.PrimaryKey("PK_CustomersGhost", x => x.CustomerGhostId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, null, null, null, null, new DateTime(2021, 4, 22, 16, 20, 41, 235, DateTimeKind.Local).AddTicks(1070), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(115), true, false, "Administradores", new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("a6112c57-bc82-4f97-bc50-e3034f2d8ca7"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3874), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("05cd35ab-16b1-440a-82ec-e560d6174170"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3854), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("3e37266e-481c-4b06-a9ee-2abfab5f48ad"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3832), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("584304f9-1990-480f-a918-dfe0e718b5e4"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3808), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("76c08676-9717-4ea2-b7f2-00cdc9438879"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3786), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("1288efae-fb92-4370-bc91-db05d023b07f"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3765), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("334096b4-d30b-4564-b642-916e44c99f48"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3744), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("4d301736-a1d4-4134-9f88-57830514d627"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("f0e925a2-45d2-4ab2-95bf-3d0ceb935a80"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3724), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("05e6c34f-4596-4bd9-943e-3a546b47b535"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3703), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("38fdba99-4591-4abd-aec7-289c34d7fb06"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3682), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("8792684a-2405-4939-a67b-ce8e0be69994"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3661), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("9f215775-6144-4df2-9c7d-e01f381cb781"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3633), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("d8721517-b63f-4d22-a1a0-56941e333e11"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3562), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("92495ed9-f1eb-4813-bb18-f648be908390"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3542), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("59451cd9-c085-4ca3-bb25-78ce66e8eea4"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3520), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("698feb2a-0a6f-4593-b9f0-0210df5ee0ab"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3498), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("889c5e06-82b1-4507-a266-f2a91b50af46"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3473), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("cbf6e08c-0146-4c83-b79e-63aa06e5f739"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3451), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("5233fb2d-8e22-4eef-89e5-dc59882cf42d"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3426), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("52a5a627-40b1-47ee-8fdc-54c7389d10eb"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3382), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("0f4f6666-2fb1-4b0c-920b-0e47fb085f11"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3064), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("88795365-a81b-463b-b97a-13745df5f376"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3895), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("e6e69c03-8f1c-414f-bf6c-cfe4b979111e"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8471), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e6711223-7778-417e-a13a-a20e306600b4"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8246), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d8eeae24-bbec-4edf-8e11-13fc01548cc0"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(4842), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8538), null, "", true, false, "groupusers/details", new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8492), null, "", true, false, "groupusers/list", new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8447), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8350), null, "", true, false, "systems/details", new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8307), null, "", true, false, "systems/list", new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8257), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8210), null, "", true, false, "languages/details", new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4d301736-a1d4-4134-9f88-57830514d627"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8164), null, "", true, false, "languages/list", new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8118), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7784), null, "", true, false, "clients/details", new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7634), null, "", true, false, "clients/list", new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7545), null, "", true, false, "menus/details", new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7499), null, "", true, false, "menus/list", new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7455), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7405), null, "", true, false, "users/details", new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7302), null, "", true, false, "users/list", new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7248), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7121), null, "", true, false, "companyoperators/details", new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7069), null, "", true, false, "companyoperators/list", new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(6960), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(4171), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7587), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 22, 16, 20, 41, 237, DateTimeKind.Local).AddTicks(8214), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("afcd707d-019a-443a-8f1f-1ef9de3a265d"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8512), true, true, false, new Guid("e6e69c03-8f1c-414f-bf6c-cfe4b979111e"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null },
                    { new Guid("cdd75575-1b38-4897-9839-e6a68a3d21f2"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(7942), true, true, false, new Guid("d8eeae24-bbec-4edf-8e11-13fc01548cc0"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null },
                    { new Guid("40d3bafc-adfd-4189-8be9-415039538d46"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8349), true, true, false, new Guid("e6711223-7778-417e-a13a-a20e306600b4"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("04b795ce-e9a4-4b02-899a-31134ec496ce"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8280), null, true, false, new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("080aea41-8a23-4f14-8812-04ea86fa2b2f"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8512), null, true, false, new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e04ae67-0793-444c-a0f7-b82fd4ab0228"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8469), null, true, false, new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8a796db6-d14d-4171-9594-1275b02ec8c9"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8371), null, true, false, new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8c01cced-b345-40f1-9b77-65c06918763d"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8328), null, true, false, new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bad19f53-02fa-441d-be60-71cafd11866d"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8230), null, true, false, new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e98bbe18-91ea-47a0-b5a4-fb82a2ed1e5b"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8184), null, true, false, new Guid("4d301736-a1d4-4134-9f88-57830514d627"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d49018d9-da74-4d87-ad10-60b9a3c759e2"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8140), null, true, false, new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("293c53b8-30e7-4c9d-824a-f33c5d53bc94"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8088), null, true, false, new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("708b35a3-3c2a-4a90-9710-4f2d92b3085a"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7742), null, true, false, new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53756d44-a100-4280-a104-c443d26da9cb"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7608), null, true, false, new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e1fef9e-c5a3-4559-92cf-015dc9f8ec43"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7565), null, true, false, new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f8606d86-bf91-41ef-9d74-43672af7cc25"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7521), null, true, false, new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c43a9a3b-3bd5-48ab-9604-f16aca670ee9"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7475), null, true, false, new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f7ee741a-fe30-4154-b3b8-8be78b9878e3"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7426), null, true, false, new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8281576d-1c33-40a7-89cd-f2634e32000c"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7377), null, true, false, new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("668cf82f-fed9-4fe6-96d3-36780b4f5e82"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7276), null, true, false, new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ecacd594-63e8-4386-bdbe-847d4304e868"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7142), null, true, false, new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2bc103b7-c69e-41c1-94f4-9e50f3dadc19"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7091), null, true, false, new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8cf381d7-598b-4960-8152-7ffa219fe66e"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7029), null, true, false, new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c1ecca0c-cca6-44a3-9522-9b19f39be3f2"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(6239), null, true, false, new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a33c14c8-e454-4e47-8e03-a846575adc80"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8558), null, true, false, new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"), null, new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, null, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(7514), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("acfdcefb-9c22-4fdc-96ed-1c50f9f1dcb4"), null, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(86), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68"), new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(4526), null, new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("e3aa32b9-bd39-487f-8d69-b474ba07dd6c"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9335), null, true, false, new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("53d15809-75d2-4ec8-b9a7-91c3933f4732"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9315), null, true, false, new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("3b294238-523c-4af5-8db0-03e05530d23f"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9293), null, true, false, new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("3c9557b8-f7d8-4e8c-ad4e-4769feaf4eb1"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9271), null, true, false, new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("05785714-fe2d-4c68-995f-32e2cea31dd3"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9247), null, true, false, new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("78dba7d2-07e1-42dc-b11e-947721f2ce38"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9222), null, true, false, new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("61326e93-bf72-41d6-b6ed-fdeab5e4047e"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9196), null, true, false, new Guid("4d301736-a1d4-4134-9f88-57830514d627"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("a622c100-f46b-4e34-899a-2462b58c2e15"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9124), null, true, false, new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("ea506768-15ad-43d2-a476-a0ce48ff7d6b"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9103), null, true, false, new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("2a9a895e-0426-4ca9-a401-c04543aa1e02"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9081), null, true, false, new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("24a15367-79f2-4acc-ae77-85ea84af1c5e"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9356), null, true, false, new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("14853d7f-eb0c-4f96-a3f2-0ba7790f62df"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9038), null, true, false, new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("56b35b75-85e6-4815-8379-8e02c850bf71"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9013), null, true, false, new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("0b20640c-e98f-4ac9-a4d7-4cc8dc79e018"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8986), null, true, false, new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("d89a378b-d679-486e-b533-72475538a47c"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8965), null, true, false, new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("f1fc4d1a-a91c-4552-b706-e79651952ad7"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8943), null, true, false, new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("1cb940ca-6e08-4226-90c6-7c9c0eb338e6"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8918), null, true, false, new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("80bd0bec-262d-44d5-805e-77dbf39ab079"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8896), null, true, false, new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("768334b5-678b-4f51-b43d-11b3c77b85a6"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8871), null, true, false, new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("51beb53a-9425-4208-a746-5b84179df225"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8828), null, true, false, new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("46744193-3031-42fb-8eaf-e5fea1619501"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8552), null, true, false, new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("65163df7-dfe7-42e5-8692-6ae8c614220d"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9060), null, true, false, new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("2626cc90-5fbe-41ac-8284-f67946656662"), "usuário administrativo", null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(5460), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("83e7f151-664a-469e-b0d8-a5260e5d2e20"), new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(1100), null, true, false, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersGhost");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("14625b02-62cf-4810-8d45-8d03e869d100"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("83e7f151-664a-469e-b0d8-a5260e5d2e20"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05cd35ab-16b1-440a-82ec-e560d6174170"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05e6c34f-4596-4bd9-943e-3a546b47b535"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0f4f6666-2fb1-4b0c-920b-0e47fb085f11"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1288efae-fb92-4370-bc91-db05d023b07f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("334096b4-d30b-4564-b642-916e44c99f48"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("38fdba99-4591-4abd-aec7-289c34d7fb06"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3e37266e-481c-4b06-a9ee-2abfab5f48ad"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5233fb2d-8e22-4eef-89e5-dc59882cf42d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("52a5a627-40b1-47ee-8fdc-54c7389d10eb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("584304f9-1990-480f-a918-dfe0e718b5e4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("59451cd9-c085-4ca3-bb25-78ce66e8eea4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("698feb2a-0a6f-4593-b9f0-0210df5ee0ab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("76c08676-9717-4ea2-b7f2-00cdc9438879"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8792684a-2405-4939-a67b-ce8e0be69994"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("88795365-a81b-463b-b97a-13745df5f376"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("889c5e06-82b1-4507-a266-f2a91b50af46"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("92495ed9-f1eb-4813-bb18-f648be908390"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9f215775-6144-4df2-9c7d-e01f381cb781"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a6112c57-bc82-4f97-bc50-e3034f2d8ca7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cbf6e08c-0146-4c83-b79e-63aa06e5f739"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d8721517-b63f-4d22-a1a0-56941e333e11"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f0e925a2-45d2-4ab2-95bf-3d0ceb935a80"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d8eeae24-bbec-4edf-8e11-13fc01548cc0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e6711223-7778-417e-a13a-a20e306600b4"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e6e69c03-8f1c-414f-bf6c-cfe4b979111e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("339c3306-462f-4395-9711-06d0d8bf8713"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4d301736-a1d4-4134-9f88-57830514d627"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b3d94456-6c56-4343-b483-af199326b2a5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("40d3bafc-adfd-4189-8be9-415039538d46"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("afcd707d-019a-443a-8f1f-1ef9de3a265d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("cdd75575-1b38-4897-9839-e6a68a3d21f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("04b795ce-e9a4-4b02-899a-31134ec496ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("080aea41-8a23-4f14-8812-04ea86fa2b2f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("293c53b8-30e7-4c9d-824a-f33c5d53bc94"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2bc103b7-c69e-41c1-94f4-9e50f3dadc19"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4e04ae67-0793-444c-a0f7-b82fd4ab0228"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("53756d44-a100-4280-a104-c443d26da9cb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("668cf82f-fed9-4fe6-96d3-36780b4f5e82"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6e1fef9e-c5a3-4559-92cf-015dc9f8ec43"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("708b35a3-3c2a-4a90-9710-4f2d92b3085a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8281576d-1c33-40a7-89cd-f2634e32000c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8a796db6-d14d-4171-9594-1275b02ec8c9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8c01cced-b345-40f1-9b77-65c06918763d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8cf381d7-598b-4960-8152-7ffa219fe66e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a33c14c8-e454-4e47-8e03-a846575adc80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bad19f53-02fa-441d-be60-71cafd11866d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c1ecca0c-cca6-44a3-9522-9b19f39be3f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c43a9a3b-3bd5-48ab-9604-f16aca670ee9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d49018d9-da74-4d87-ad10-60b9a3c759e2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e98bbe18-91ea-47a0-b5a4-fb82a2ed1e5b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ecacd594-63e8-4386-bdbe-847d4304e868"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f7ee741a-fe30-4154-b3b8-8be78b9878e3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f8606d86-bf91-41ef-9d74-43672af7cc25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("acfdcefb-9c22-4fdc-96ed-1c50f9f1dcb4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("05785714-fe2d-4c68-995f-32e2cea31dd3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0b20640c-e98f-4ac9-a4d7-4cc8dc79e018"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("14853d7f-eb0c-4f96-a3f2-0ba7790f62df"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1cb940ca-6e08-4226-90c6-7c9c0eb338e6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("24a15367-79f2-4acc-ae77-85ea84af1c5e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2a9a895e-0426-4ca9-a401-c04543aa1e02"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3b294238-523c-4af5-8db0-03e05530d23f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3c9557b8-f7d8-4e8c-ad4e-4769feaf4eb1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("46744193-3031-42fb-8eaf-e5fea1619501"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("51beb53a-9425-4208-a746-5b84179df225"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("53d15809-75d2-4ec8-b9a7-91c3933f4732"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("56b35b75-85e6-4815-8379-8e02c850bf71"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("61326e93-bf72-41d6-b6ed-fdeab5e4047e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("65163df7-dfe7-42e5-8692-6ae8c614220d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("768334b5-678b-4f51-b43d-11b3c77b85a6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("78dba7d2-07e1-42dc-b11e-947721f2ce38"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("80bd0bec-262d-44d5-805e-77dbf39ab079"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a622c100-f46b-4e34-899a-2462b58c2e15"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d89a378b-d679-486e-b533-72475538a47c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e3aa32b9-bd39-487f-8d69-b474ba07dd6c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ea506768-15ad-43d2-a476-a0ce48ff7d6b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f1fc4d1a-a91c-4552-b706-e79651952ad7"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("2626cc90-5fbe-41ac-8284-f67946656662"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, null, null, null, null, new DateTime(2021, 4, 13, 15, 37, 15, 534, DateTimeKind.Local).AddTicks(6880), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(1900), true, false, "Administradores", new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("df449838-6055-4176-a534-f92003b17f6e"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5670), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("ea5c9ed4-8790-49b4-93ff-852d1ad9e9a5"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5646), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("7f7fecd3-6af0-4b2f-8727-0bf0840574be"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5573), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("7c73896c-0412-4c28-b533-4465e089e9f4"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5549), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("f1ba1454-f336-4dbb-abf6-7f2aa487cfaf"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5524), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("6cbd9818-9712-4301-b83c-7f7e3b39b06c"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5501), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("fcb4b9d6-4567-4754-abc2-a8b5c4e4910b"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5477), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("2fc3e754-d16a-409b-80f6-bb39391090c2"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5452), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("f83f33cd-c2ca-4b38-9bf6-40daa7a47b28"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5428), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("d1b642d6-f0c2-4204-a30d-cf1a837cc63a"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5405), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("ec731bf2-ba71-458c-ae13-35048a993977"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5382), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("9da56925-2978-469f-89df-e5d86641faba"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5358), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("227a3363-6b60-49f9-854e-6f2722040498"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("2d17a4ad-0e78-4c1e-9815-ee298346d4bd"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5333), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("17d28e81-e2cf-4f15-b519-dce0e715fe4c"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5310), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("7d37c2aa-e97e-4865-95d9-c97fa04a82d8"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5286), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("f251bee9-73f0-4e28-aace-90e266d2fb8f"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5255), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("bb8da7a5-7ba3-4bfb-b1f7-f51709c46af2"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5226), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("53f57673-86f4-430d-a9b1-d9e81c8491d9"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5200), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("1df5485d-7f72-4456-bee3-a1d92041b972"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5112), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("5257c655-40c9-468a-9ec7-a71a67f63940"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5071), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("40d0b824-6e26-425c-911f-4e6b0db12982"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(4457), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("85f07777-7c35-4d17-af7b-5bcddaa81cfc"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5693), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("3aea18f3-bf2e-4470-b187-660aecae6cf6"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(67), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9bc96bb1-f321-489f-a1bb-0bca7e1eca09"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(9873), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f39f1187-d59d-47ca-9e6a-1a0001215e28"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(5315), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(9047), null, "", true, false, "groupusers/details", new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8994), null, "", true, false, "groupusers/list", new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8944), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8895), null, "", true, false, "systems/details", new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8846), null, "", true, false, "systems/list", new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8784), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8687), null, "", true, false, "languages/details", new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8635), null, "", true, false, "languages/list", new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8585), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8531), null, "", true, false, "clients/details", new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8479), null, "", true, false, "clients/list", new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("227a3363-6b60-49f9-854e-6f2722040498"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8361), null, "", true, false, "menus/details", new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8222), null, "", true, false, "menus/list", new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8170), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8117), null, "", true, false, "users/details", new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8057), null, "", true, false, "users/list", new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7986), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7798), null, "", true, false, "companyoperators/details", new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7601), null, "", true, false, "companyoperators/list", new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7466), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(3173), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8425), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 13, 15, 37, 15, 537, DateTimeKind.Local).AddTicks(6922), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("2c30587b-7796-43f8-b2c6-810c9879d940"), null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(97), true, true, false, new Guid("3aea18f3-bf2e-4470-b187-660aecae6cf6"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null },
                    { new Guid("1dfedb88-1b3a-43c8-af47-3bde0e412fb0"), null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(9511), true, true, false, new Guid("f39f1187-d59d-47ca-9e6a-1a0001215e28"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null },
                    { new Guid("b61c73ec-28eb-434e-8320-88797806c45f"), null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(3), true, true, false, new Guid("9bc96bb1-f321-489f-a1bb-0bca7e1eca09"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("e6d980ef-2bd0-466b-abdd-cc70757e6a99"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8814), null, true, false, new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1765d3ec-5c18-40da-8c97-f14b752aa57d"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(9016), null, true, false, new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8be78e10-d413-4103-91bf-2dd22af0e470"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8968), null, true, false, new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bd1f7d7f-f6d7-46c4-b513-a86c2fc1b386"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8918), null, true, false, new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("20c7350a-fba9-4d3e-bbb1-74def8f49b1f"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8869), null, true, false, new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2ebdea6c-f535-4586-8669-624fd56c46d5"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8711), null, true, false, new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("82a5b927-d141-4bab-b463-3ade73527d5d"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8658), null, true, false, new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d449d0b-faf3-46db-88f7-861fdd67e1ce"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8608), null, true, false, new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("688b2506-159b-4b47-8e47-bdfd6b27e8cb"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8554), null, true, false, new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d2e0cd5d-50b0-4fa7-bbd0-c123fa27fd81"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8505), null, true, false, new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33feb980-c7da-464a-a4c1-4b9704e84fa7"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8449), null, true, false, new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("07e473b0-85a0-46b3-9d24-7c12984d6125"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8393), null, true, false, new Guid("227a3363-6b60-49f9-854e-6f2722040498"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1b620e04-f26d-45b2-98f7-5615423c3547"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8249), null, true, false, new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("21cd67c6-5257-4e1e-a30e-69023c0a2346"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8192), null, true, false, new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("413ad711-23bb-4135-b697-fa30159c1291"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8141), null, true, false, new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b1534a07-cf99-4ec7-9290-23eefbc41541"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8083), null, true, false, new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdb3e5bc-3bf7-40c0-8e14-7f61963c939e"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8019), null, true, false, new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3668027b-50e8-45e9-80cb-8c12ffe83f10"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7824), null, true, false, new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("97575aac-4d4d-4ecb-b159-4c7de739dd4e"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7757), null, true, false, new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8ed58637-4acb-42b3-93fd-7d769d5527d0"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7556), null, true, false, new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28b85dee-101b-4d85-9837-af35edafd15d"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(6377), null, true, false, new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("931bc296-7810-4288-92a3-a91813c9c3d5"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(9070), null, true, false, new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"), null, new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, null, null, new DateTime(2021, 4, 13, 15, 37, 15, 542, DateTimeKind.Local).AddTicks(391), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("42589e48-e92f-4aee-a869-9c69d42c925f"), null, null, new DateTime(2021, 4, 13, 15, 37, 15, 542, DateTimeKind.Local).AddTicks(3831), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00"), new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, new DateTime(2021, 4, 13, 15, 37, 15, 542, DateTimeKind.Local).AddTicks(8027), null, new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("bbc272b3-827a-4760-aeff-c08ed8aa61a8"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3421), null, true, false, new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("688528bc-84fa-4549-86ad-388b88d58f6a"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3396), null, true, false, new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("a59e177e-88ef-473f-9455-b5625742fd8f"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3374), null, true, false, new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("e4c96689-61ec-4eb0-ba38-340ece849999"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3350), null, true, false, new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("171c8f39-a34e-4aa9-8ae5-8d5981a2a389"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3325), null, true, false, new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("14e92758-1059-479e-86c7-fe5a9a655650"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3302), null, true, false, new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("407908ae-8265-4b8b-88fa-4bf3f473bacc"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3279), null, true, false, new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("d1d65eb2-2eeb-48a2-bc09-acea6813d456"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3255), null, true, false, new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("e91f4210-e013-4e2d-8066-d0a5db21390f"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3231), null, true, false, new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("8c9f025d-fc55-4900-83a8-e67f756a1b14"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3205), null, true, false, new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("22673f39-f746-49b5-969a-43afffa84597"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3444), null, true, false, new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("0fc5a5d1-b2d2-4c96-a649-8406b568c385"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3159), null, true, false, new Guid("227a3363-6b60-49f9-854e-6f2722040498"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("34cdbd51-6cb4-4868-a56b-a414958d33d3"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3132), null, true, false, new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("c935f5b6-809d-4a66-9388-8e0e593882ed"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3032), null, true, false, new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("c8c0508b-60a3-410c-a980-0525e1e3150a"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3008), null, true, false, new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("3da20dcb-9915-445f-9663-74a71059d73b"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2985), null, true, false, new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("9280f1dd-8f1a-47ff-a870-c097824724db"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2956), null, true, false, new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("a11abfad-e57e-4fe4-b1b5-680d22641c23"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2926), null, true, false, new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("8580959e-4335-4fee-9701-7698b8b54429"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2901), null, true, false, new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("4b76566f-551d-41ba-ba2a-957635e0b389"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2864), null, true, false, new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("93f3cbf1-3ab5-4906-8620-dfb7e91d852b"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2491), null, true, false, new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("3625085b-854a-454c-9d23-7756f42c61f1"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3182), null, true, false, new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("eddfa31b-fc21-404d-b066-f8bb591dd6bf"), "usuário administrativo", null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(7551), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e5a49ef7-a996-4b8a-8ad6-9e33e985e671"), new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(254), null, true, false, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
