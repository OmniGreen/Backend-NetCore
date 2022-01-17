using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("f37533a5-2e0c-402e-b478-216b53ccea7a"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("c18f691d-7cc9-445c-90ad-b81f512480e9"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("13049e36-b7ec-49f7-8182-b293560469cd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1dd5d411-8853-4d50-bd0d-3090535c79e1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1e73244a-7ab6-48e7-83c4-e94ce729c8cb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1fd2a675-eede-4347-84d4-c9d5407a2ce6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("20e335ec-ebe9-476f-b69b-5f05b1c2efde"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("257ffd01-d9f4-4dc4-be86-ce95891bc522"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("33e5e52e-00c8-413c-9176-6283b8282c32"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4d9442d2-ee4c-4a42-8027-77daa0808cdf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ae07446-67aa-44a5-90c5-32a605330307"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8003c3df-30fe-4eb7-972a-99c3ec8ab79b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8f439caf-b8ba-4637-8cf4-4c29e2a35956"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ac7d46fd-5708-4c49-9720-06296167841a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("afd4862e-d8e5-4a29-a6eb-28c9f3b43d33"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b19db45e-4f16-46a6-9f6a-d015db7ae3f2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c7e5412f-fb9d-47e4-a50b-4e64dec1f35e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c9022642-c0e9-43f0-bd38-1ed336d3d2dc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d2b8257e-5021-413c-81bf-bc78776ed5b2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("db56f204-fcdb-40c3-9302-8c3e4ae68c1d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("dc509cb5-57be-4659-be4c-abcdf1e5c566"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e4cca44e-c131-48bc-a2de-1664e59b335a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e8243b94-a7ad-4f4c-81ca-1c92fbb8cf25"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ece8fe00-dfb1-416f-a36c-7f476a225ac2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("39f5ee27-43f9-4e26-82af-50318adb3f43"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d0fce199-72fe-4cb8-8299-1a654420be05"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("eb2d205c-63f6-469b-ad4e-f152c365f4ad"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("01cc07af-2601-4ade-8bab-951eb13fcc37"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("05f06f15-7d62-4907-8492-c8f37d939b29"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0f4a4932-d4b5-4560-b45e-192c4368a7d1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2b4cecf6-300d-4aab-aff1-8d88b26e80d9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("33e46a43-ea1a-4657-acd3-02200426c678"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("36e71dea-c5aa-434f-887c-db472b908a94"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3f9599fe-a5a6-4c96-a3f6-f7f991ef0281"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("43e4cba6-03a7-46a8-9d45-9a66ef876aa9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4b440787-b3d6-4607-8fee-84afcf6f5b7a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4bf8b2f4-40ff-4bf6-ab56-1be6053df087"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("56df2997-566d-42fa-8cba-a3f969202a9e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("804b3338-98ea-4677-ac17-c5c4e5763268"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("87c9a85e-4281-442d-ba25-f4602704b8f2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8d8ea52c-dc79-43c7-85ca-9f5fa1a42225"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9a0d407d-117b-41c3-902a-29d7b4143bbc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a3d46ed0-1013-4b36-8c4f-6bd73074a017"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c36f4677-609f-4b8d-b770-546398f7cea5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c6f6b13e-7eb9-4b5e-b695-0d7d9c363272"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dbe948c9-be73-45ac-9c60-b423591501d1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ee6a06d6-b8f9-4639-94ba-2b185798f4ab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f46f46f5-1eb2-43c2-944c-5a384d09a915"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("5d0b0eb6-e825-4d3b-b544-afad48e37046"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("88c0338f-c44f-400a-87a8-0226c5579c66"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("dd95ef70-c273-456b-9317-a67aa5449d92"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("01031641-e7ac-42b3-ad46-379ad8577678"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0424938c-2922-49e2-9676-e86868f05ba7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0d9d320f-d043-46b6-8408-c9b88d8cfaa5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1931db53-e49e-4ffe-a764-70e5413a3996"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("49946854-b759-44db-80a4-4c109fd5510d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("555fdbbc-149c-4e83-bf84-8c75643711b7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ae2f74f-77ba-4101-a98c-9c9fae69d68b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5c05c3bb-c255-478a-b3bd-5c041bf43ef4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5d303254-36fe-4ae7-a612-0ef7c8d117c3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("75725a1c-b6d1-4fe0-88af-469d94dc881d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7a666d65-da70-48ef-8e15-65a8b5f80fd4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7af7cc3c-4fbd-420a-8542-76926a72b998"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7c355017-3278-41d5-aa4d-4bb7b011fcdc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9812fb4c-9ccd-40c6-87fb-d37b962b45a9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a47a97d0-24c8-4464-9044-ab703313c6c2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ac317cc6-93ea-4e97-8f02-8da6d91539ea"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b3396fea-105f-4c5f-8b07-a54927774921"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba227c0c-c59d-472c-abf9-fa4500e6c678"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("df011d01-13e3-4340-a893-766fa9b99089"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e4bf6812-8bdb-4528-b219-52ff0135beb2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f573c446-420d-472c-a84e-26a7613e08ec"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f7bab911-e8ac-4b56-b0af-768164a90250"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("55074fdf-2cfa-43d1-897f-5b7251078f3b"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("b6f16664-9bec-4c31-a7c6-c074a9e322a9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("071401e7-ea41-442f-8c27-ad9e7c5853e1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0a3d403d-0f7f-40a4-98d7-ecbe4b70c091"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("170d8923-a402-4c54-a1d1-b3d6128da03b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("177a82f6-b261-4d98-aa0e-7dd6e2adaa08"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("29c99e54-60bc-4adb-9b27-ff67a779ff50"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("31a9c7e6-2c1f-4d0e-b896-20a8c96f4980"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4178e199-1ee4-40c5-b134-7b6c6007a732"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("446fa887-84d0-41ca-8919-a06557ede635"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("46a73a8b-be48-4147-9acc-6e0a9cdea29a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("49852188-e99e-46bd-b3bb-dc9a98f08544"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4ee10932-50b7-454b-905a-b5717bb08405"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6c83f454-5ebe-4441-ac0a-809bbc251a86"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("736bf435-27a1-4773-884f-de2f050995b4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7d50265d-f747-4687-8ee0-298ea7644e5a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8d97986e-4bbe-461d-8fdb-3f2578d6ce85"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a0c1875e-6c08-4a5e-a17c-5e27192f8b15"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a4842845-e08a-4de4-976f-bb8b54f68010"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c7989d52-90ff-436a-babe-aff387ef276d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d5e6c82d-7cfa-4257-9f6c-daaae0d19c4b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e5a1eeca-3827-401d-af50-ac8669b30a5f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e7c1fe7e-6482-460c-b55d-0fa2d2ec9962"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f3b3838a-c175-4714-8f4f-f418a5785a7e"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("b1543f3f-c569-4625-98de-17d48c20afeb"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("ff65068a-d0a9-4445-af16-1ec152e5b37a"), null, null, null, null, null, new DateTime(2021, 10, 2, 1, 1, 38, 942, DateTimeKind.Local).AddTicks(5328), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(1973), true, false, "Administradores", new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("79c17a3f-fff8-4bb3-8938-ea92223b98da"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1663), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("c273949a-ba96-4390-9399-6eca45dc898b"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("05777874-c2e3-45dc-84cd-c761a546fb36"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1644), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("39fdc467-e662-47ff-8551-476cfd11b761"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("f2bbb67b-3311-497f-bf23-be1cd017a300"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1625), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("49dfda06-f13a-4b6e-9471-1ea88522bc10"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("d5694073-e0d7-4f0e-91ce-42a95e6630fb"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1607), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("a5a1b383-8613-4712-8581-2ae6b9cb5ce5"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("a2721ea3-cdf7-4c58-af40-eb54a075c217"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1586), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("3b6fdc4a-6ff5-4813-b5fd-4472e518573d"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("e938a94d-75e0-41de-b7c5-058ddc6d229d"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1568), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("00cbbba1-d85b-4aae-9924-cfe7d721f63a"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("5ae25220-224c-4238-87ff-efe177c90a4e"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1549), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("3ebd60a4-cfc8-4411-adf1-9dd3763a2623"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("2b807475-f2b2-4011-9292-f75d9934aa76"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1530), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("ca491f37-ffae-434c-b8ce-96a4e8ae347d"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("bbf4ade3-1ad9-4b1a-97c5-0187351d5a64"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1509), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("7b9b488e-f765-4e44-b751-5cea3879731d"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("0fcd4a38-cef7-4662-9b9e-b0ccc66d9dd3"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1490), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("69f4ce23-b5b3-4b46-9c12-adb1e193e266"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("f2e4aa66-aa94-4ecc-9505-a10ed60a5727"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1471), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("cf0e023a-8eb6-4526-92b2-0b510c89ee8b"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("a0f7550e-b4a5-420f-bcf0-8c3b059c8138"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1452), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("6bf447b3-7036-437c-b87b-ddca13b6b59d"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("419ceddc-bf71-40e7-b5a7-4936e33afec0"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1426), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("a763a32e-7401-46fe-98a1-dd4f91be3264"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("3259579d-c21b-4cc7-8db7-7985b180e586"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1361), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("82e964a7-93eb-40bc-a9c3-bf00337c0ed5"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("872ce512-bc2c-49bd-91f8-0714ff7a724d"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1342), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("f13924bb-19cd-4681-9d06-e36b01da0b84"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("33726431-3d7f-4160-a861-078763016a96"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1323), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("ec77004f-b488-45e4-98d8-ea9f552fd28d"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("9fbb59f4-82fb-4348-af0e-d8fbd3aa052d"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1294), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("611f01f6-fe4b-4f3c-bd1d-eb2be3947b47"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("77b2b968-d4f8-4d4a-b9f1-f45005a78e99"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1275), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("00a8e207-65f3-486f-8708-90f5d3956953"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("87c6369e-290c-4e0c-ae8e-e2d728027a61"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1254), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("c4c53975-3c5e-4c5e-bfd2-3e8a6d990e03"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("3f81fdd5-d08e-4026-a2c1-92f1477d0280"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1214), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("20a10e30-08a2-4c71-b1eb-b281a3b99bac"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("d52b158c-d06b-4cab-abde-1a5e7c4c57fe"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(900), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null },
                    { new Guid("e5fd6f5e-7c46-4bd1-bfdf-5d84d3dbe3a9"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(1684), new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("0b31c975-32dd-4c83-a6e1-ddd704464e3f"), true, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("bfe1cde1-e511-4eb5-8036-c077a3477825"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(1206), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("880f18ef-8b0b-4387-99b3-939c42cef9a1"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(1075), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4975da6c-015b-474c-bf19-d53223445bf1"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 10, 2, 1, 1, 38, 944, DateTimeKind.Local).AddTicks(9190), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("0b31c975-32dd-4c83-a6e1-ddd704464e3f"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8494), null, "", true, false, "groupusers/details", new Guid("39fdc467-e662-47ff-8551-476cfd11b761"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c273949a-ba96-4390-9399-6eca45dc898b"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8454), null, "", true, false, "groupusers/list", new Guid("39fdc467-e662-47ff-8551-476cfd11b761"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("39fdc467-e662-47ff-8551-476cfd11b761"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8415), null, "", true, false, "", new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("49dfda06-f13a-4b6e-9471-1ea88522bc10"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8373), null, "", true, false, "systems/details", new Guid("3b6fdc4a-6ff5-4813-b5fd-4472e518573d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a5a1b383-8613-4712-8581-2ae6b9cb5ce5"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8299), null, "", true, false, "systems/list", new Guid("3b6fdc4a-6ff5-4813-b5fd-4472e518573d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b6fdc4a-6ff5-4813-b5fd-4472e518573d"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8256), null, "", true, false, "", new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00cbbba1-d85b-4aae-9924-cfe7d721f63a"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8215), null, "", true, false, "languages/details", new Guid("ca491f37-ffae-434c-b8ce-96a4e8ae347d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ebd60a4-cfc8-4411-adf1-9dd3763a2623"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8176), null, "", true, false, "languages/list", new Guid("ca491f37-ffae-434c-b8ce-96a4e8ae347d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ca491f37-ffae-434c-b8ce-96a4e8ae347d"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8137), null, "", true, false, "", new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7b9b488e-f765-4e44-b751-5cea3879731d"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8095), null, "", true, false, "clients/details", new Guid("cf0e023a-8eb6-4526-92b2-0b510c89ee8b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("69f4ce23-b5b3-4b46-9c12-adb1e193e266"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8014), null, "", true, false, "clients/list", new Guid("cf0e023a-8eb6-4526-92b2-0b510c89ee8b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bf447b3-7036-437c-b87b-ddca13b6b59d"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7932), null, "", true, false, "menus/details", new Guid("82e964a7-93eb-40bc-a9c3-bf00337c0ed5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a763a32e-7401-46fe-98a1-dd4f91be3264"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7885), null, "", true, false, "menus/list", new Guid("82e964a7-93eb-40bc-a9c3-bf00337c0ed5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("82e964a7-93eb-40bc-a9c3-bf00337c0ed5"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7842), null, "", true, false, "", new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f13924bb-19cd-4681-9d06-e36b01da0b84"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7795), null, "", true, false, "users/details", new Guid("611f01f6-fe4b-4f3c-bd1d-eb2be3947b47"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ec77004f-b488-45e4-98d8-ea9f552fd28d"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7605), null, "", true, false, "users/list", new Guid("611f01f6-fe4b-4f3c-bd1d-eb2be3947b47"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("611f01f6-fe4b-4f3c-bd1d-eb2be3947b47"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7482), null, "", true, false, "", new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00a8e207-65f3-486f-8708-90f5d3956953"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7274), null, "", true, false, "companyoperators/details", new Guid("20a10e30-08a2-4c71-b1eb-b281a3b99bac"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c4c53975-3c5e-4c5e-bfd2-3e8a6d990e03"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7231), null, "", true, false, "companyoperators/list", new Guid("20a10e30-08a2-4c71-b1eb-b281a3b99bac"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("20a10e30-08a2-4c71-b1eb-b281a3b99bac"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7124), null, "", true, false, "", new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(4254), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cf0e023a-8eb6-4526-92b2-0b510c89ee8b"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7971), null, "", true, false, "", new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 10, 2, 1, 1, 38, 944, DateTimeKind.Local).AddTicks(4839), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("afb949b8-88f3-46c8-979f-058eb14d711e"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(1231), true, true, false, new Guid("bfe1cde1-e511-4eb5-8036-c077a3477825"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, null },
                    { new Guid("64441273-3da4-4350-82c9-e5e499cef21b"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(780), true, true, false, new Guid("4975da6c-015b-474c-bf19-d53223445bf1"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, null },
                    { new Guid("e3a487dc-f222-40ff-aed2-b53845ab51d8"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(1175), true, true, false, new Guid("880f18ef-8b0b-4387-99b3-939c42cef9a1"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("67697efa-e28b-480c-b296-72a0eb3a9d8e"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8275), null, true, false, new Guid("3b6fdc4a-6ff5-4813-b5fd-4472e518573d"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b98456ee-99b9-42c3-9c79-815a5c3e3f85"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8472), null, true, false, new Guid("c273949a-ba96-4390-9399-6eca45dc898b"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2ad75e60-4447-4a9b-8e68-7b2d5b010397"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8432), null, true, false, new Guid("39fdc467-e662-47ff-8551-476cfd11b761"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ba0e949f-5db1-4427-a152-194f1ff0b405"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8394), null, true, false, new Guid("49dfda06-f13a-4b6e-9471-1ea88522bc10"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60c01ef2-f549-486a-a056-eb060578738f"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8316), null, true, false, new Guid("a5a1b383-8613-4712-8581-2ae6b9cb5ce5"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5e2ff568-0ddb-4782-9caf-f11b0116997d"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8233), null, true, false, new Guid("00cbbba1-d85b-4aae-9924-cfe7d721f63a"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6c8641b8-e021-4bad-a441-542950e42885"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8194), null, true, false, new Guid("3ebd60a4-cfc8-4411-adf1-9dd3763a2623"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3840ec48-d2a3-4c41-bcc6-00a665d34b29"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8155), null, true, false, new Guid("ca491f37-ffae-434c-b8ce-96a4e8ae347d"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c2055c52-427a-4f1f-aa19-28e55d70fa0c"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8114), null, true, false, new Guid("7b9b488e-f765-4e44-b751-5cea3879731d"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("676e00ae-c6fc-471d-a7cb-abe037023e68"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8032), null, true, false, new Guid("69f4ce23-b5b3-4b46-9c12-adb1e193e266"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ca9d13a3-2d23-4daa-ac65-de9eff32508c"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7994), null, true, false, new Guid("cf0e023a-8eb6-4526-92b2-0b510c89ee8b"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c2ecdfb-4879-47d9-9439-eb1f3362dbff"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7950), null, true, false, new Guid("6bf447b3-7036-437c-b87b-ddca13b6b59d"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b59c0462-be0c-408e-94e9-0f8cd0e0aec7"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7906), null, true, false, new Guid("a763a32e-7401-46fe-98a1-dd4f91be3264"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bddc05c0-dee5-4950-bfb4-c11b9c6dfe3f"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7861), null, true, false, new Guid("82e964a7-93eb-40bc-a9c3-bf00337c0ed5"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4445ec10-994b-4c8c-b333-e91cb84dbe6d"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7820), null, true, false, new Guid("f13924bb-19cd-4681-9d06-e36b01da0b84"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fcd1fb08-1bf3-4295-9ebb-6362bf6af81d"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7624), null, true, false, new Guid("ec77004f-b488-45e4-98d8-ea9f552fd28d"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("167d5ffd-e670-468e-b0a2-9a5cbec0aa88"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7508), null, true, false, new Guid("611f01f6-fe4b-4f3c-bd1d-eb2be3947b47"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8e9b28fe-ac8d-49e6-96b3-afb07ff2250b"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7292), null, true, false, new Guid("00a8e207-65f3-486f-8708-90f5d3956953"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("efb38cc9-fa3e-4862-a4fe-a844b19d55c8"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7252), null, true, false, new Guid("c4c53975-3c5e-4c5e-bfd2-3e8a6d990e03"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("34c6b78f-6cf8-4b23-9cbb-bb68927e0df3"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(7195), null, true, false, new Guid("20a10e30-08a2-4c71-b1eb-b281a3b99bac"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1ec55c6c-8d26-4dd6-b0cc-627b1b6c029b"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(6287), null, true, false, new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("87adc830-bc1f-40eb-90fd-abab684fecaa"), null, new DateTime(2021, 10, 2, 1, 1, 38, 945, DateTimeKind.Local).AddTicks(8511), null, true, false, new Guid("0b31c975-32dd-4c83-a6e1-ddd704464e3f"), new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1bac0401-e200-451b-a51f-b5bfbf824f37"), null, new Guid("ff65068a-d0a9-4445-af16-1ec152e5b37a"), null, null, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(3869), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("cca99886-5516-4992-bede-fd3373686694"), null, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(5321), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("1bac0401-e200-451b-a51f-b5bfbf824f37"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1"), new Guid("ff65068a-d0a9-4445-af16-1ec152e5b37a"), null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(7085), null, new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"), true, false, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), new Guid("1bac0401-e200-451b-a51f-b5bfbf824f37"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("3bc6867b-7071-4e28-a225-cb8ac13427c8"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9575), null, true, false, new Guid("c273949a-ba96-4390-9399-6eca45dc898b"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("31727568-0e5c-4d10-aa00-cb4b0fc7cd32"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9555), null, true, false, new Guid("39fdc467-e662-47ff-8551-476cfd11b761"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("7bbecc0a-99c1-4463-9bdb-607601b38c99"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9533), null, true, false, new Guid("49dfda06-f13a-4b6e-9471-1ea88522bc10"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("4e1b9928-aa4c-47e3-a772-4a545880b8a3"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9513), null, true, false, new Guid("a5a1b383-8613-4712-8581-2ae6b9cb5ce5"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("1b6f89e7-6347-44fc-adff-bb28c83b081a"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9492), null, true, false, new Guid("3b6fdc4a-6ff5-4813-b5fd-4472e518573d"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("fa68d621-dd27-414c-9a07-228ffe87773a"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9472), null, true, false, new Guid("00cbbba1-d85b-4aae-9924-cfe7d721f63a"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("3b3a1daf-fbdf-467b-80c7-44eb12e66b1b"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9453), null, true, false, new Guid("3ebd60a4-cfc8-4411-adf1-9dd3763a2623"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("c7670340-fa93-4adc-b405-7aab462fc4c9"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9429), null, true, false, new Guid("ca491f37-ffae-434c-b8ce-96a4e8ae347d"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("9e65d7d4-9fb4-4f38-8158-cc8d9b47ffe3"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9365), null, true, false, new Guid("7b9b488e-f765-4e44-b751-5cea3879731d"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("17c15e70-3661-41bf-b17c-0cc384a885fe"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9346), null, true, false, new Guid("69f4ce23-b5b3-4b46-9c12-adb1e193e266"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("5736600e-cfa4-42e2-aab7-300edf9147ef"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9595), null, true, false, new Guid("0b31c975-32dd-4c83-a6e1-ddd704464e3f"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("d9dc4c33-09f8-4a55-8c58-057c96d7e93f"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9304), null, true, false, new Guid("6bf447b3-7036-437c-b87b-ddca13b6b59d"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("a6fa6f5d-62d2-44a6-8c7c-a0014661a0be"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9283), null, true, false, new Guid("a763a32e-7401-46fe-98a1-dd4f91be3264"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("1a66038a-032f-4eec-8a69-a6b8a731c5f4"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9263), null, true, false, new Guid("82e964a7-93eb-40bc-a9c3-bf00337c0ed5"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("923e6f42-9442-4665-a2a6-2b829eb39d26"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9243), null, true, false, new Guid("f13924bb-19cd-4681-9d06-e36b01da0b84"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("42068787-d7f6-4cc0-9885-8b5f66835153"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9221), null, true, false, new Guid("ec77004f-b488-45e4-98d8-ea9f552fd28d"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("6a8c35d2-3fd6-4b49-9b8a-7669f95b96ce"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9198), null, true, false, new Guid("611f01f6-fe4b-4f3c-bd1d-eb2be3947b47"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("00a5ee85-8783-4cb5-929d-0b1b6a55dde2"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9177), null, true, false, new Guid("00a8e207-65f3-486f-8708-90f5d3956953"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("2eb75331-79e7-4ba0-b8b9-06d9d39e8754"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9148), null, true, false, new Guid("c4c53975-3c5e-4c5e-bfd2-3e8a6d990e03"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("2ab904cc-29a9-4c48-b47d-f8ceb2d0c8c3"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9115), null, true, false, new Guid("20a10e30-08a2-4c71-b1eb-b281a3b99bac"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("84936947-7be6-4ac9-8750-53ab21825ea6"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(8908), null, true, false, new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") },
                    { new Guid("65003975-7ef0-464a-a697-f6c0d95fa511"), true, true, null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(9323), null, true, false, new Guid("cf0e023a-8eb6-4526-92b2-0b510c89ee8b"), true, true, null, null, null, new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e0fa79fb-aac5-477b-9f49-602562b9856c"), "usuário administrativo", null, new DateTime(2021, 10, 2, 1, 1, 38, 946, DateTimeKind.Local).AddTicks(2623), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a9ef9881-ea0e-4ca2-924b-fdeefedacea0"), new Guid("ff65068a-d0a9-4445-af16-1ec152e5b37a"), null, new DateTime(2021, 10, 2, 1, 1, 38, 944, DateTimeKind.Local).AddTicks(7255), null, true, false, new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("ff65068a-d0a9-4445-af16-1ec152e5b37a"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("a9ef9881-ea0e-4ca2-924b-fdeefedacea0"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("9c49cf36-cc3f-4a14-bc46-38f884348efc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05777874-c2e3-45dc-84cd-c761a546fb36"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0fcd4a38-cef7-4662-9b9e-b0ccc66d9dd3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2b807475-f2b2-4011-9292-f75d9934aa76"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3259579d-c21b-4cc7-8db7-7985b180e586"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("33726431-3d7f-4160-a861-078763016a96"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3f81fdd5-d08e-4026-a2c1-92f1477d0280"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("419ceddc-bf71-40e7-b5a7-4936e33afec0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ae25220-224c-4238-87ff-efe177c90a4e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("77b2b968-d4f8-4d4a-b9f1-f45005a78e99"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("79c17a3f-fff8-4bb3-8938-ea92223b98da"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("872ce512-bc2c-49bd-91f8-0714ff7a724d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("87c6369e-290c-4e0c-ae8e-e2d728027a61"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9fbb59f4-82fb-4348-af0e-d8fbd3aa052d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a0f7550e-b4a5-420f-bcf0-8c3b059c8138"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a2721ea3-cdf7-4c58-af40-eb54a075c217"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bbf4ade3-1ad9-4b1a-97c5-0187351d5a64"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d52b158c-d06b-4cab-abde-1a5e7c4c57fe"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d5694073-e0d7-4f0e-91ce-42a95e6630fb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e5fd6f5e-7c46-4bd1-bfdf-5d84d3dbe3a9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e938a94d-75e0-41de-b7c5-058ddc6d229d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f2bbb67b-3311-497f-bf23-be1cd017a300"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f2e4aa66-aa94-4ecc-9505-a10ed60a5727"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4975da6c-015b-474c-bf19-d53223445bf1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("880f18ef-8b0b-4387-99b3-939c42cef9a1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("bfe1cde1-e511-4eb5-8036-c077a3477825"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("00a8e207-65f3-486f-8708-90f5d3956953"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("00cbbba1-d85b-4aae-9924-cfe7d721f63a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0b31c975-32dd-4c83-a6e1-ddd704464e3f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("20a10e30-08a2-4c71-b1eb-b281a3b99bac"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("39fdc467-e662-47ff-8551-476cfd11b761"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3b6fdc4a-6ff5-4813-b5fd-4472e518573d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3ebd60a4-cfc8-4411-adf1-9dd3763a2623"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("49dfda06-f13a-4b6e-9471-1ea88522bc10"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("611f01f6-fe4b-4f3c-bd1d-eb2be3947b47"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("69f4ce23-b5b3-4b46-9c12-adb1e193e266"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6bf447b3-7036-437c-b87b-ddca13b6b59d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7b9b488e-f765-4e44-b751-5cea3879731d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("82e964a7-93eb-40bc-a9c3-bf00337c0ed5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("948b8ce1-be96-4729-b1c1-a7d8f74e0236"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a5a1b383-8613-4712-8581-2ae6b9cb5ce5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a763a32e-7401-46fe-98a1-dd4f91be3264"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c273949a-ba96-4390-9399-6eca45dc898b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c4c53975-3c5e-4c5e-bfd2-3e8a6d990e03"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ca491f37-ffae-434c-b8ce-96a4e8ae347d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cf0e023a-8eb6-4526-92b2-0b510c89ee8b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ec77004f-b488-45e4-98d8-ea9f552fd28d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f13924bb-19cd-4681-9d06-e36b01da0b84"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("64441273-3da4-4350-82c9-e5e499cef21b"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("afb949b8-88f3-46c8-979f-058eb14d711e"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("e3a487dc-f222-40ff-aed2-b53845ab51d8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("167d5ffd-e670-468e-b0a2-9a5cbec0aa88"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1ec55c6c-8d26-4dd6-b0cc-627b1b6c029b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2ad75e60-4447-4a9b-8e68-7b2d5b010397"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("34c6b78f-6cf8-4b23-9cbb-bb68927e0df3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3840ec48-d2a3-4c41-bcc6-00a665d34b29"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4445ec10-994b-4c8c-b333-e91cb84dbe6d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5e2ff568-0ddb-4782-9caf-f11b0116997d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("60c01ef2-f549-486a-a056-eb060578738f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("67697efa-e28b-480c-b296-72a0eb3a9d8e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("676e00ae-c6fc-471d-a7cb-abe037023e68"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6c8641b8-e021-4bad-a441-542950e42885"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("87adc830-bc1f-40eb-90fd-abab684fecaa"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8e9b28fe-ac8d-49e6-96b3-afb07ff2250b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9c2ecdfb-4879-47d9-9439-eb1f3362dbff"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b59c0462-be0c-408e-94e9-0f8cd0e0aec7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b98456ee-99b9-42c3-9c79-815a5c3e3f85"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba0e949f-5db1-4427-a152-194f1ff0b405"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bddc05c0-dee5-4950-bfb4-c11b9c6dfe3f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c2055c52-427a-4f1f-aa19-28e55d70fa0c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ca9d13a3-2d23-4daa-ac65-de9eff32508c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("efb38cc9-fa3e-4862-a4fe-a844b19d55c8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fcd1fb08-1bf3-4295-9ebb-6362bf6af81d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1bac0401-e200-451b-a51f-b5bfbf824f37"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("cca99886-5516-4992-bede-fd3373686694"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("1b9da5b9-633e-47ca-8a20-262fdbb5b1e1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("00a5ee85-8783-4cb5-929d-0b1b6a55dde2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("17c15e70-3661-41bf-b17c-0cc384a885fe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1a66038a-032f-4eec-8a69-a6b8a731c5f4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1b6f89e7-6347-44fc-adff-bb28c83b081a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2ab904cc-29a9-4c48-b47d-f8ceb2d0c8c3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2eb75331-79e7-4ba0-b8b9-06d9d39e8754"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("31727568-0e5c-4d10-aa00-cb4b0fc7cd32"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3b3a1daf-fbdf-467b-80c7-44eb12e66b1b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3bc6867b-7071-4e28-a225-cb8ac13427c8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("42068787-d7f6-4cc0-9885-8b5f66835153"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4e1b9928-aa4c-47e3-a772-4a545880b8a3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5736600e-cfa4-42e2-aab7-300edf9147ef"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("65003975-7ef0-464a-a697-f6c0d95fa511"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6a8c35d2-3fd6-4b49-9b8a-7669f95b96ce"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7bbecc0a-99c1-4463-9bdb-607601b38c99"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("84936947-7be6-4ac9-8750-53ab21825ea6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("923e6f42-9442-4665-a2a6-2b829eb39d26"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9e65d7d4-9fb4-4f38-8158-cc8d9b47ffe3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a6fa6f5d-62d2-44a6-8c7c-a0014661a0be"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c7670340-fa93-4adc-b405-7aab462fc4c9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d9dc4c33-09f8-4a55-8c58-057c96d7e93f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fa68d621-dd27-414c-9a07-228ffe87773a"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("e0fa79fb-aac5-477b-9f49-602562b9856c"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("9fdd6efa-2650-474d-9b52-dffd48ac7797"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("f37533a5-2e0c-402e-b478-216b53ccea7a"), null, null, null, null, null, new DateTime(2021, 7, 15, 15, 27, 57, 209, DateTimeKind.Local).AddTicks(5917), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(4079), true, false, "Administradores", new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("c9022642-c0e9-43f0-bd38-1ed336d3d2dc"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4962), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("05f06f15-7d62-4907-8492-c8f37d939b29"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("dc509cb5-57be-4659-be4c-abcdf1e5c566"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4944), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("36e71dea-c5aa-434f-887c-db472b908a94"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("8f439caf-b8ba-4637-8cf4-4c29e2a35956"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4925), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("c6f6b13e-7eb9-4b5e-b695-0d7d9c363272"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("d2b8257e-5021-413c-81bf-bc78776ed5b2"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4906), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("9a0d407d-117b-41c3-902a-29d7b4143bbc"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("8003c3df-30fe-4eb7-972a-99c3ec8ab79b"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4886), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("87c9a85e-4281-442d-ba25-f4602704b8f2"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("1dd5d411-8853-4d50-bd0d-3090535c79e1"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4868), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("33e46a43-ea1a-4657-acd3-02200426c678"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("ece8fe00-dfb1-416f-a36c-7f476a225ac2"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4850), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("0f4a4932-d4b5-4560-b45e-192c4368a7d1"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("ac7d46fd-5708-4c49-9720-06296167841a"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4832), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("f46f46f5-1eb2-43c2-944c-5a384d09a915"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("db56f204-fcdb-40c3-9302-8c3e4ae68c1d"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4811), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("4b440787-b3d6-4607-8fee-84afcf6f5b7a"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("e4cca44e-c131-48bc-a2de-1664e59b335a"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4788), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("8d8ea52c-dc79-43c7-85ca-9f5fa1a42225"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("33e5e52e-00c8-413c-9176-6283b8282c32"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4721), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("56df2997-566d-42fa-8cba-a3f969202a9e"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("b19db45e-4f16-46a6-9f6a-d015db7ae3f2"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4703), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("c36f4677-609f-4b8d-b770-546398f7cea5"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("5ae07446-67aa-44a5-90c5-32a605330307"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4683), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("4bf8b2f4-40ff-4bf6-ab56-1be6053df087"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("afd4862e-d8e5-4a29-a6eb-28c9f3b43d33"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4664), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("dbe948c9-be73-45ac-9c60-b423591501d1"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("257ffd01-d9f4-4dc4-be86-ce95891bc522"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4645), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("01cc07af-2601-4ade-8bab-951eb13fcc37"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("e8243b94-a7ad-4f4c-81ca-1c92fbb8cf25"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4626), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("43e4cba6-03a7-46a8-9d45-9a66ef876aa9"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("c7e5412f-fb9d-47e4-a50b-4e64dec1f35e"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4597), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("a3d46ed0-1013-4b36-8c4f-6bd73074a017"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("1e73244a-7ab6-48e7-83c4-e94ce729c8cb"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4575), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("ee6a06d6-b8f9-4639-94ba-2b185798f4ab"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("13049e36-b7ec-49f7-8182-b293560469cd"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4531), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("804b3338-98ea-4677-ac17-c5c4e5763268"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("1fd2a675-eede-4347-84d4-c9d5407a2ce6"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4491), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("3f9599fe-a5a6-4c96-a3f6-f7f991ef0281"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("20e335ec-ebe9-476f-b69b-5f05b1c2efde"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4151), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null },
                    { new Guid("4d9442d2-ee4c-4a42-8027-77daa0808cdf"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(4983), new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("2b4cecf6-300d-4aab-aff1-8d88b26e80d9"), true, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("eb2d205c-63f6-469b-ad4e-f152c365f4ad"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(3052), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0fce199-72fe-4cb8-8299-1a654420be05"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(2942), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("39f5ee27-43f9-4e26-82af-50318adb3f43"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(1035), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("2b4cecf6-300d-4aab-aff1-8d88b26e80d9"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1797), null, "", true, false, "groupusers/details", new Guid("36e71dea-c5aa-434f-887c-db472b908a94"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("05f06f15-7d62-4907-8492-c8f37d939b29"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1756), null, "", true, false, "groupusers/list", new Guid("36e71dea-c5aa-434f-887c-db472b908a94"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("36e71dea-c5aa-434f-887c-db472b908a94"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1685), null, "", true, false, "", new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c6f6b13e-7eb9-4b5e-b695-0d7d9c363272"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1647), null, "", true, false, "systems/details", new Guid("87c9a85e-4281-442d-ba25-f4602704b8f2"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9a0d407d-117b-41c3-902a-29d7b4143bbc"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1608), null, "", true, false, "systems/list", new Guid("87c9a85e-4281-442d-ba25-f4602704b8f2"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("87c9a85e-4281-442d-ba25-f4602704b8f2"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1561), null, "", true, false, "", new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33e46a43-ea1a-4657-acd3-02200426c678"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1521), null, "", true, false, "languages/details", new Guid("f46f46f5-1eb2-43c2-944c-5a384d09a915"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0f4a4932-d4b5-4560-b45e-192c4368a7d1"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1481), null, "", true, false, "languages/list", new Guid("f46f46f5-1eb2-43c2-944c-5a384d09a915"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f46f46f5-1eb2-43c2-944c-5a384d09a915"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1391), null, "", true, false, "", new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4b440787-b3d6-4607-8fee-84afcf6f5b7a"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1350), null, "", true, false, "clients/details", new Guid("56df2997-566d-42fa-8cba-a3f969202a9e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d8ea52c-dc79-43c7-85ca-9f5fa1a42225"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1311), null, "", true, false, "clients/list", new Guid("56df2997-566d-42fa-8cba-a3f969202a9e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c36f4677-609f-4b8d-b770-546398f7cea5"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1234), null, "", true, false, "menus/details", new Guid("dbe948c9-be73-45ac-9c60-b423591501d1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4bf8b2f4-40ff-4bf6-ab56-1be6053df087"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1189), null, "", true, false, "menus/list", new Guid("dbe948c9-be73-45ac-9c60-b423591501d1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dbe948c9-be73-45ac-9c60-b423591501d1"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1144), null, "", true, false, "", new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("01cc07af-2601-4ade-8bab-951eb13fcc37"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1057), null, "", true, false, "users/details", new Guid("a3d46ed0-1013-4b36-8c4f-6bd73074a017"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("43e4cba6-03a7-46a8-9d45-9a66ef876aa9"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1015), null, "", true, false, "users/list", new Guid("a3d46ed0-1013-4b36-8c4f-6bd73074a017"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a3d46ed0-1013-4b36-8c4f-6bd73074a017"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(956), null, "", true, false, "", new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee6a06d6-b8f9-4639-94ba-2b185798f4ab"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(737), null, "", true, false, "companyoperators/details", new Guid("3f9599fe-a5a6-4c96-a3f6-f7f991ef0281"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("804b3338-98ea-4677-ac17-c5c4e5763268"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(687), null, "", true, false, "companyoperators/list", new Guid("3f9599fe-a5a6-4c96-a3f6-f7f991ef0281"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3f9599fe-a5a6-4c96-a3f6-f7f991ef0281"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(587), null, "", true, false, "", new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(8432), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("56df2997-566d-42fa-8cba-a3f969202a9e"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1272), null, "", true, false, "", new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 7, 15, 15, 27, 57, 211, DateTimeKind.Local).AddTicks(7262), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("88c0338f-c44f-400a-87a8-0226c5579c66"), null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(3097), true, true, false, new Guid("eb2d205c-63f6-469b-ad4e-f152c365f4ad"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, null },
                    { new Guid("5d0b0eb6-e825-4d3b-b544-afad48e37046"), null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(2668), true, true, false, new Guid("39f5ee27-43f9-4e26-82af-50318adb3f43"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, null },
                    { new Guid("dd95ef70-c273-456b-9317-a67aa5449d92"), null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(3025), true, true, false, new Guid("d0fce199-72fe-4cb8-8299-1a654420be05"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("ba227c0c-c59d-472c-abf9-fa4500e6c678"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1581), null, true, false, new Guid("87c9a85e-4281-442d-ba25-f4602704b8f2"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e4bf6812-8bdb-4528-b219-52ff0135beb2"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1775), null, true, false, new Guid("05f06f15-7d62-4907-8492-c8f37d939b29"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("555fdbbc-149c-4e83-bf84-8c75643711b7"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1702), null, true, false, new Guid("36e71dea-c5aa-434f-887c-db472b908a94"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1931db53-e49e-4ffe-a764-70e5413a3996"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1665), null, true, false, new Guid("c6f6b13e-7eb9-4b5e-b695-0d7d9c363272"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f573c446-420d-472c-a84e-26a7613e08ec"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1626), null, true, false, new Guid("9a0d407d-117b-41c3-902a-29d7b4143bbc"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b3396fea-105f-4c5f-8b07-a54927774921"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1539), null, true, false, new Guid("33e46a43-ea1a-4657-acd3-02200426c678"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("75725a1c-b6d1-4fe0-88af-469d94dc881d"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1499), null, true, false, new Guid("0f4a4932-d4b5-4560-b45e-192c4368a7d1"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f7bab911-e8ac-4b56-b0af-768164a90250"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1458), null, true, false, new Guid("f46f46f5-1eb2-43c2-944c-5a384d09a915"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0424938c-2922-49e2-9676-e86868f05ba7"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1368), null, true, false, new Guid("4b440787-b3d6-4607-8fee-84afcf6f5b7a"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7c355017-3278-41d5-aa4d-4bb7b011fcdc"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1330), null, true, false, new Guid("8d8ea52c-dc79-43c7-85ca-9f5fa1a42225"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a47a97d0-24c8-4464-9044-ab703313c6c2"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1290), null, true, false, new Guid("56df2997-566d-42fa-8cba-a3f969202a9e"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("01031641-e7ac-42b3-ad46-379ad8577678"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1252), null, true, false, new Guid("c36f4677-609f-4b8d-b770-546398f7cea5"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5d303254-36fe-4ae7-a612-0ef7c8d117c3"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1209), null, true, false, new Guid("4bf8b2f4-40ff-4bf6-ab56-1be6053df087"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5c05c3bb-c255-478a-b3bd-5c041bf43ef4"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1166), null, true, false, new Guid("dbe948c9-be73-45ac-9c60-b423591501d1"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9812fb4c-9ccd-40c6-87fb-d37b962b45a9"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1121), null, true, false, new Guid("01cc07af-2601-4ade-8bab-951eb13fcc37"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ae2f74f-77ba-4101-a98c-9c9fae69d68b"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1034), null, true, false, new Guid("43e4cba6-03a7-46a8-9d45-9a66ef876aa9"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df011d01-13e3-4340-a893-766fa9b99089"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(984), null, true, false, new Guid("a3d46ed0-1013-4b36-8c4f-6bd73074a017"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7a666d65-da70-48ef-8e15-65a8b5f80fd4"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(756), null, true, false, new Guid("ee6a06d6-b8f9-4639-94ba-2b185798f4ab"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7af7cc3c-4fbd-420a-8542-76926a72b998"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(709), null, true, false, new Guid("804b3338-98ea-4677-ac17-c5c4e5763268"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0d9d320f-d043-46b6-8408-c9b88d8cfaa5"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(653), null, true, false, new Guid("3f9599fe-a5a6-4c96-a3f6-f7f991ef0281"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ac317cc6-93ea-4e97-8f02-8da6d91539ea"), null, new DateTime(2021, 7, 15, 15, 27, 57, 212, DateTimeKind.Local).AddTicks(9972), null, true, false, new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("49946854-b759-44db-80a4-4c109fd5510d"), null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(1814), null, true, false, new Guid("2b4cecf6-300d-4aab-aff1-8d88b26e80d9"), new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("55074fdf-2cfa-43d1-897f-5b7251078f3b"), null, new Guid("f37533a5-2e0c-402e-b478-216b53ccea7a"), null, null, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(7017), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b6f16664-9bec-4c31-a7c6-c074a9e322a9"), null, null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(8418), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("55074fdf-2cfa-43d1-897f-5b7251078f3b"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd"), new Guid("f37533a5-2e0c-402e-b478-216b53ccea7a"), null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(185), null, new Guid("b9cb722d-d009-4f04-b64c-db680dd7d773"), true, false, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), new Guid("55074fdf-2cfa-43d1-897f-5b7251078f3b"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("446fa887-84d0-41ca-8919-a06557ede635"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2991), null, true, false, new Guid("05f06f15-7d62-4907-8492-c8f37d939b29"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("177a82f6-b261-4d98-aa0e-7dd6e2adaa08"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2970), null, true, false, new Guid("36e71dea-c5aa-434f-887c-db472b908a94"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("e7c1fe7e-6482-460c-b55d-0fa2d2ec9962"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2945), null, true, false, new Guid("c6f6b13e-7eb9-4b5e-b695-0d7d9c363272"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("8d97986e-4bbe-461d-8fdb-3f2578d6ce85"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2925), null, true, false, new Guid("9a0d407d-117b-41c3-902a-29d7b4143bbc"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("736bf435-27a1-4773-884f-de2f050995b4"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2899), null, true, false, new Guid("87c9a85e-4281-442d-ba25-f4602704b8f2"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("4178e199-1ee4-40c5-b134-7b6c6007a732"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2847), null, true, false, new Guid("33e46a43-ea1a-4657-acd3-02200426c678"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("071401e7-ea41-442f-8c27-ad9e7c5853e1"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2826), null, true, false, new Guid("0f4a4932-d4b5-4560-b45e-192c4368a7d1"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("7d50265d-f747-4687-8ee0-298ea7644e5a"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2804), null, true, false, new Guid("f46f46f5-1eb2-43c2-944c-5a384d09a915"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("a0c1875e-6c08-4a5e-a17c-5e27192f8b15"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2783), null, true, false, new Guid("4b440787-b3d6-4607-8fee-84afcf6f5b7a"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("e5a1eeca-3827-401d-af50-ac8669b30a5f"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2762), null, true, false, new Guid("8d8ea52c-dc79-43c7-85ca-9f5fa1a42225"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("f3b3838a-c175-4714-8f4f-f418a5785a7e"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(3012), null, true, false, new Guid("2b4cecf6-300d-4aab-aff1-8d88b26e80d9"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("0a3d403d-0f7f-40a4-98d7-ecbe4b70c091"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2717), null, true, false, new Guid("c36f4677-609f-4b8d-b770-546398f7cea5"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("d5e6c82d-7cfa-4257-9f6c-daaae0d19c4b"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2695), null, true, false, new Guid("4bf8b2f4-40ff-4bf6-ab56-1be6053df087"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("46a73a8b-be48-4147-9acc-6e0a9cdea29a"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2673), null, true, false, new Guid("dbe948c9-be73-45ac-9c60-b423591501d1"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("c7989d52-90ff-436a-babe-aff387ef276d"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2652), null, true, false, new Guid("01cc07af-2601-4ade-8bab-951eb13fcc37"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("170d8923-a402-4c54-a1d1-b3d6128da03b"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2631), null, true, false, new Guid("43e4cba6-03a7-46a8-9d45-9a66ef876aa9"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("4ee10932-50b7-454b-905a-b5717bb08405"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2606), null, true, false, new Guid("a3d46ed0-1013-4b36-8c4f-6bd73074a017"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("31a9c7e6-2c1f-4d0e-b896-20a8c96f4980"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2583), null, true, false, new Guid("ee6a06d6-b8f9-4639-94ba-2b185798f4ab"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("a4842845-e08a-4de4-976f-bb8b54f68010"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2549), null, true, false, new Guid("804b3338-98ea-4677-ac17-c5c4e5763268"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("29c99e54-60bc-4adb-9b27-ff67a779ff50"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2488), null, true, false, new Guid("3f9599fe-a5a6-4c96-a3f6-f7f991ef0281"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("49852188-e99e-46bd-b3bb-dc9a98f08544"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2180), null, true, false, new Guid("1e5d786a-5612-4518-b512-d122d4cf07ec"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") },
                    { new Guid("6c83f454-5ebe-4441-ac0a-809bbc251a86"), true, true, null, new DateTime(2021, 7, 15, 15, 27, 57, 214, DateTimeKind.Local).AddTicks(2738), null, true, false, new Guid("56df2997-566d-42fa-8cba-a3f969202a9e"), true, true, null, null, null, new Guid("4839a90b-7370-4f52-82ce-a4fc6d6ba5fd") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b1543f3f-c569-4625-98de-17d48c20afeb"), "usuário administrativo", null, new DateTime(2021, 7, 15, 15, 27, 57, 213, DateTimeKind.Local).AddTicks(5891), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c18f691d-7cc9-445c-90ad-b81f512480e9"), new Guid("f37533a5-2e0c-402e-b478-216b53ccea7a"), null, new DateTime(2021, 7, 15, 15, 27, 57, 211, DateTimeKind.Local).AddTicks(9099), null, true, false, new Guid("a799b4a0-2134-4c8e-af27-52b07f0d38f8"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
