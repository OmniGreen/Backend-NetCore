using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("d835f17d-d80c-45c2-aded-4832e198293d"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("84a6fc83-fd98-4147-9326-c7c5421c8f10"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("56e1a650-37c3-4645-a433-9900a6356b13"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("00bf7ba9-7b66-4cd7-8c70-6ac1c80cf087"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0f0d5ee7-f1f2-4e57-970a-42dfc6e6c4ac"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1ab3bd80-8684-43b9-9453-e4f77288eb44"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1ab4a38e-a7a2-42a6-b0f3-6b8e7999f52d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1ed11866-ce7c-41f1-9f0b-b5245ef254b0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1f9de083-1db1-406f-9431-92a1e8b95b6f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29f7702d-4a8e-418c-9555-ea40c3b011fe"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2e0f2eb6-4818-45f9-96a2-c06af5e5ac61"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("33f4046b-c961-416b-aad2-fcf00767c6b2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("38acfc83-f199-4394-aeef-c7ec9a2c8e2d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("499d2cd7-b07a-4275-8e1e-c9a12c4c7d59"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6bbc8afa-c4e6-460e-a91f-2757d9493ddd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("72890ee9-c6d2-4bb1-b1a6-b64deefa7367"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8f7fe56d-c9cd-46a3-8af8-0223f948e28b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("91a5bca9-eec4-442f-bc37-2a13dd0e209c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a2ac64a4-be53-46a5-9324-2725dd6ec101"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ab1171a1-d6da-442b-bf07-e0c63c27b381"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("baf55d1c-eb08-4165-82ce-d354e2750ed9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bc3e09eb-1938-4fd4-a347-100c54efb31c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cea1120c-98e8-47aa-9afc-e13156dc0552"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cf68089e-3bb5-4d70-994f-685ebe919222"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f88d2b1d-1816-4344-8b2d-0cf4cd8a3b5c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4eb947a4-261f-41eb-9d0e-5d6f34a78710"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5a76d96d-981a-4e4e-875f-a02ac69a3312"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e2a7df0b-1793-4a6f-8019-b91849acfedb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0eebd11a-7ebd-4004-b151-55ad02626550"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1ec5b8a1-147d-4b10-bdf0-073ff10d2a30"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2054a610-11ba-4e21-8ae1-ede36deab5f1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2291e84d-2727-4c8e-88cf-e95969e20179"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("269b550c-8479-4ab8-b2ae-5f7288191046"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("33fc4c3b-7bac-493e-b6e2-e39c66731767"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("365c734c-56de-48dc-b683-cc6dcab9556b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("479fd935-8fc1-4e8c-b2af-52bef8636f2a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("79d0001e-82fb-4633-8c55-0c32bc5d85e1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8577c0ec-2d30-46c2-b5e5-df04f9e5f914"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8ac0eed0-74d5-483c-8120-4d4737a216da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("981d1af1-4833-4149-824d-1b36bdfb1a2f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a14a965a-a1ca-496e-9e69-74d855a8ac94"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a54787b7-b79c-4172-884a-a6626fbc5199"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ac2eba16-9589-4053-80b8-38ca93bfa1ce"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c6ce4ce9-5237-4a55-8d14-18a0e2537fac"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e8fb068a-1b5b-4637-b6b0-6a9f40b15cbc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ebd62a53-5a18-4360-8e13-c9289f5f4319"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f2ae923c-077c-44ad-be5a-b8b4fea2e32c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f39f685c-f9de-4995-859d-5d65cd8b9754"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fd6c0ed4-b973-467f-96a2-e78cdcd00531"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("4250c9f5-52f0-4ad0-b132-e222cf41d764"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("cd18d2ea-d556-4d89-a3d1-5f636bdcda2f"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("fcdf86f0-b533-49be-b556-f224ca3eb752"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("059a3512-dbde-4983-b461-6920e81eba2d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0ff0d38f-5e55-469c-a61d-7228bcee2ee1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("13d92f88-548e-4cf5-8283-c9576eb0af52"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2401ab37-f669-480f-a5c5-70ab96b52cd8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2bd77840-b71f-4768-8c14-d3d9d58aa84b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("40f791fe-9f5c-483b-ab45-f7fd6055d60b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5a73523f-1d43-488e-8be3-8ce74cdaf7d2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ecf457f-6b95-49d8-9777-cce8f48632ac"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6765212f-3f4b-4fd6-bd9c-d446a4ef54a5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7d8d52d6-e874-41d1-b608-0b6a42aed0be"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9d2145ad-7fa8-4451-8d33-516397e0b531"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a0ab5bf7-a8a7-41bb-9724-8211113548ea"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a4173a14-dfe3-49f7-9027-6ad97e3f5dd5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("af4c90e0-0acc-4c49-8216-23077f7142bf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b4260d06-5b11-45f8-89e5-acd19a3bfdbb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cdb26ccd-748e-4421-a935-107df7c3d213"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cf36d3ec-fe3d-4f06-be80-11e4f70bc316"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d5d682d5-424e-41a6-a3d7-e67e27c808af"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d9748405-4a28-40f2-9240-cbb18818d8bb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("effd9142-ba99-4ac2-abf4-92b89b044dd7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f5c591bc-9ba9-4782-a553-440d52174332"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fd9a59b3-b6ca-4eeb-91f9-67166e129772"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b2d06566-8fff-4a11-89af-c972773b8643"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("18a6c9b4-9220-4a21-b8d9-d955047915fc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("082b6888-4ed8-42fe-89c0-d76e37e22fc9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("16c4d4f7-6161-47c9-9b01-b7630ffa6861"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3c8641a0-2ba5-4533-856a-e56836b6aa67"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4b257ca6-76af-4559-9f7b-6500c84b4698"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6325bdd5-ee7a-4061-8110-07f1e9480057"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6b722c74-d342-47b5-b645-326d089669b0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6c490a12-8e32-491b-8383-b5c3a4d36f51"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("72203b18-3f0b-4917-9d9f-13bca0f7e34e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("72e1bf5f-12a4-4583-80c0-609087a2937c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("82804293-c41d-4d07-94e5-8b959f6031bd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("85322a22-d3fc-4585-acc4-3a4426e3e9f8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9a8686ff-b206-49de-9883-e94875d37c24"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a68ee387-f1b5-45e8-9cf5-8e5a128eb689"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a6ac6cf1-042a-420b-b327-60efc9b921fb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ab30a452-dd19-4241-a46b-e15626448110"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b4f854a5-a57e-4cf5-b797-a6a874159f70"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b91d8ab4-9fca-4d6e-9276-92972480349f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c28cc78b-054d-4775-a40a-80f19e0761e7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d0bc07c9-0fa2-4725-ab2a-0e498d3faf66"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("db0a433f-a6dd-4c10-b0d2-97fe7f3befbe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e1e28def-b040-4531-9714-d0499ed10a8a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f63abb02-129b-437e-a947-31cec22becca"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("d560c7c6-ba67-4500-af69-d33d7f6e4d28"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("34747f20-a488-426e-96ee-4e16b58f3364"));

            migrationBuilder.RenameColumn(
                name: "IsSearch",
                table: "SalePlans",
                newName: "IsGuia");

            migrationBuilder.RenameColumn(
                name: "CustomersId",
                table: "Banners",
                newName: "CustomerId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, null, null, null, null, new DateTime(2021, 2, 25, 12, 50, 6, 486, DateTimeKind.Local).AddTicks(9855), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(5762), true, false, "Administradores", new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("83da8e00-d424-47ca-ad83-d6421c87d4e7"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9240), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("e98e4602-809d-46f6-9081-8b44c440cd0b"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9219), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("942f7d6b-4db4-4053-8054-fd8c95be1095"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9197), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("60be98b2-3aa6-4c83-acb0-0106ba917b2c"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9176), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("4369843f-bc8f-4e3d-9c1b-65e5d3487c07"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9152), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("2d018120-12d0-4070-9a1d-2d9c4d0fd8a9"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9131), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("2cc94739-345c-4c42-af27-cc8d0fd20551"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9106), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("8c9dafe0-b14f-405c-a378-bb085ecf201e"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9038), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("3007be7c-9a22-4357-a152-0b0fccc6ae13"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9016), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("baf20a3f-81ae-4153-9889-cd3304ad2fe8"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8995), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("744aeb02-0288-4ba4-817c-103185a96718"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("7383e1ab-9b2e-46d1-9977-62b84c8518a7"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8973), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("75a90bb5-abaa-4dbb-afae-1171baf22a0a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8952), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("ece3fb7d-8c6a-402b-aa8b-90ecf6b794ac"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8929), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("09b099e8-d3aa-4ac7-95e5-4bb0eb457b2a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8908), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("b47bed69-ffb1-4034-940c-0db0d96088aa"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8886), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("4624d78e-5360-4eb3-8ff8-abbdb58bf1ee"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8859), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("1080123c-8650-4eff-a0d7-b9de4a35c4d6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8833), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("0bb6192a-ada3-449b-ad36-b783c70a98e6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8812), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("29e784b2-388e-4e4d-b218-953251e442cc"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8788), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("8b203b25-6b5e-4ffa-bdde-9a59a8a28135"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8752), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("ec69f0c3-127c-4d2c-aeb4-21fa667ccb60"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8431), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("7429ac95-fb49-43f3-8ca1-93c3420e07c7"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9262), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("03090d0b-6338-4a36-9241-fbb3104140c0"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4326), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef81d6f6-8f59-42f8-b327-47c0ddcee435"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4203), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cb2650bb-d3f8-4b45-88fe-6610919576bd"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(964), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(4096), null, "", true, false, "groupusers/details", new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3997), null, "", true, false, "groupusers/list", new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3951), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3904), null, "", true, false, "systems/details", new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3852), null, "", true, false, "systems/list", new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3798), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3748), null, "", true, false, "languages/details", new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3661), null, "", true, false, "languages/list", new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3610), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3557), null, "", true, false, "clients/details", new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("744aeb02-0288-4ba4-817c-103185a96718"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3510), null, "", true, false, "clients/list", new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3411), null, "", true, false, "menus/details", new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3354), null, "", true, false, "menus/list", new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3229), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3177), null, "", true, false, "users/details", new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3128), null, "", true, false, "users/list", new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3068), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2930), null, "", true, false, "companyoperators/details", new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2877), null, "", true, false, "companyoperators/list", new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2757), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(9651), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3461), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 25, 12, 50, 6, 489, DateTimeKind.Local).AddTicks(4431), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("c40e757b-2da9-43e4-9787-3e2b3a470e67"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4357), true, true, false, new Guid("03090d0b-6338-4a36-9241-fbb3104140c0"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null },
                    { new Guid("65951ba1-de61-46f7-8936-c2a0bf993d3a"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(3933), true, true, false, new Guid("cb2650bb-d3f8-4b45-88fe-6610919576bd"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null },
                    { new Guid("6257ccdc-6717-456a-b59b-658bfcb8400a"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4294), true, true, false, new Guid("ef81d6f6-8f59-42f8-b327-47c0ddcee435"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("2abb33f9-7294-4bd3-87cd-9b8861d1befb"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3821), null, true, false, new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f940f1ba-e519-4d17-9111-8c86d9135c12"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(4018), null, true, false, new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fd9a1cd9-8506-46b0-b40b-e1e8ec0ba85c"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3973), null, true, false, new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("03aeec1f-0a1d-4ed8-9753-f036c40dadbd"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3926), null, true, false, new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("356d5ca8-eb85-43fc-8f3f-2cf5caffc35c"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3877), null, true, false, new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d78ff3d8-9d6c-4802-8cda-efae34b07a80"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3772), null, true, false, new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("946869a2-f0d5-464e-87a4-8de3c106f316"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3720), null, true, false, new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a65135d4-096d-45b2-992c-20a30c5d8824"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3635), null, true, false, new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1daa91ed-dc2a-434b-a270-fbe428bf8a0e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3579), null, true, false, new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1dbe0c06-ccdb-4226-b274-fd4ba50a2da9"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3532), null, true, false, new Guid("744aeb02-0288-4ba4-817c-103185a96718"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0e35bd7-42d6-410d-8dd1-c34132e00ab5"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3485), null, true, false, new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5f1a3f2d-8886-4f8b-9e75-a5138202399e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3434), null, true, false, new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7151affe-385f-41e6-819d-ba42ab4ee13c"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3380), null, true, false, new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7028abc3-4af3-4fe6-97c9-80438b1f8932"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3319), null, true, false, new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e63f52ac-0eca-45ff-b778-dbf343510a6b"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3202), null, true, false, new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3326e25c-7479-4361-b493-135fe84e1748"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3151), null, true, false, new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("583e4a0d-4a79-4942-a04f-b0b9b89a3266"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3096), null, true, false, new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a7a5b125-35a3-4274-ad26-83cba4015558"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2953), null, true, false, new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("193ba98b-a12e-46b8-9167-15ee80fd0fea"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2903), null, true, false, new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8ec3d665-9440-4181-9d2c-79b323f7435e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2833), null, true, false, new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ba6b1f12-c70a-4dca-973c-7700893c871e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2014), null, true, false, new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("10be4f5d-1835-4696-ad9e-e34dac345524"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(4122), null, true, false, new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"), null, new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, null, null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(2953), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("787fe36a-82f6-4027-bae4-b24e14889153"), null, null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(5429), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b"), new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(8712), null, new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("0a8174e9-81de-4d92-bb3d-3dbb29ce6f18"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3198), null, true, false, new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("5d96bac9-1291-4835-af06-06955320e4c6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3174), null, true, false, new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("ad2502c8-dfd0-4159-b7f9-ac14e4b705c2"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3146), null, true, false, new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("7fa19468-5bfb-4528-9ef7-fc29d3bfa72d"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3028), null, true, false, new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("30ef7bbc-8fa9-4bdf-979c-2b301d661e4a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3004), null, true, false, new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("f0641e2c-246a-4dce-be3e-34546cca4a91"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2982), null, true, false, new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("2122167a-8a28-4278-99ad-7dc863609fb5"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2959), null, true, false, new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("50e817e7-9bc7-4eae-a23f-d155f73301c8"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2937), null, true, false, new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("ec106864-8f27-4ca8-a9dc-de595b233ea9"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2914), null, true, false, new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("7c5c57ff-c6b6-44e0-8807-947d5a76fd36"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2890), null, true, false, new Guid("744aeb02-0288-4ba4-817c-103185a96718"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("6f4c39e0-e97b-46fd-b7c0-f7b9580969ff"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3221), null, true, false, new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("eb8a1453-5caf-4864-a997-335ba7c26bc0"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2845), null, true, false, new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("e93ab32f-2d13-49aa-a8a2-c0860a171f6a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2821), null, true, false, new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("85f3231a-9cd9-4ec5-a2aa-8082162e8573"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2798), null, true, false, new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("c9866a25-ae45-4407-9a27-42fbb76a4235"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2775), null, true, false, new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("b11c2b30-a499-4793-b0dc-8bf59342212e"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2753), null, true, false, new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("0843a74d-1d66-424f-9c98-e185c81c8b9b"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2724), null, true, false, new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("c6b90981-da26-4a61-89b6-6a0abc3bda3d"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2693), null, true, false, new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("6fb542aa-4941-4206-94ae-1b9c38025000"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2601), null, true, false, new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("2dc5ae93-e47a-42b9-a251-b20a8ee24aa6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2565), null, true, false, new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("9202e232-02bd-4380-b0a9-8e293c78065d"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2321), null, true, false, new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("8ebcee38-759c-4bd8-9259-f595a1591c29"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2867), null, true, false, new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6a78ba23-f085-4485-a2b1-a26cf849f42e"), "usuário administrativo", null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(899), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("389f28b1-44d1-4b2f-8a2c-55c777414c89"), new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, new DateTime(2021, 2, 25, 12, 50, 6, 489, DateTimeKind.Local).AddTicks(7190), null, true, false, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("389f28b1-44d1-4b2f-8a2c-55c777414c89"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("09b099e8-d3aa-4ac7-95e5-4bb0eb457b2a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0bb6192a-ada3-449b-ad36-b783c70a98e6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1080123c-8650-4eff-a0d7-b9de4a35c4d6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29e784b2-388e-4e4d-b218-953251e442cc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2cc94739-345c-4c42-af27-cc8d0fd20551"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2d018120-12d0-4070-9a1d-2d9c4d0fd8a9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3007be7c-9a22-4357-a152-0b0fccc6ae13"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4369843f-bc8f-4e3d-9c1b-65e5d3487c07"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4624d78e-5360-4eb3-8ff8-abbdb58bf1ee"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("60be98b2-3aa6-4c83-acb0-0106ba917b2c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7383e1ab-9b2e-46d1-9977-62b84c8518a7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7429ac95-fb49-43f3-8ca1-93c3420e07c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("75a90bb5-abaa-4dbb-afae-1171baf22a0a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("83da8e00-d424-47ca-ad83-d6421c87d4e7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8b203b25-6b5e-4ffa-bdde-9a59a8a28135"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8c9dafe0-b14f-405c-a378-bb085ecf201e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("942f7d6b-4db4-4053-8054-fd8c95be1095"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b47bed69-ffb1-4034-940c-0db0d96088aa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("baf20a3f-81ae-4153-9889-cd3304ad2fe8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e98e4602-809d-46f6-9081-8b44c440cd0b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec69f0c3-127c-4d2c-aeb4-21fa667ccb60"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ece3fb7d-8c6a-402b-aa8b-90ecf6b794ac"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("03090d0b-6338-4a36-9241-fbb3104140c0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("cb2650bb-d3f8-4b45-88fe-6610919576bd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ef81d6f6-8f59-42f8-b327-47c0ddcee435"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("744aeb02-0288-4ba4-817c-103185a96718"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("6257ccdc-6717-456a-b59b-658bfcb8400a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("65951ba1-de61-46f7-8936-c2a0bf993d3a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("c40e757b-2da9-43e4-9787-3e2b3a470e67"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("03aeec1f-0a1d-4ed8-9753-f036c40dadbd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("10be4f5d-1835-4696-ad9e-e34dac345524"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("193ba98b-a12e-46b8-9167-15ee80fd0fea"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1daa91ed-dc2a-434b-a270-fbe428bf8a0e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1dbe0c06-ccdb-4226-b274-fd4ba50a2da9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2abb33f9-7294-4bd3-87cd-9b8861d1befb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3326e25c-7479-4361-b493-135fe84e1748"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("356d5ca8-eb85-43fc-8f3f-2cf5caffc35c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("583e4a0d-4a79-4942-a04f-b0b9b89a3266"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5f1a3f2d-8886-4f8b-9e75-a5138202399e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7028abc3-4af3-4fe6-97c9-80438b1f8932"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7151affe-385f-41e6-819d-ba42ab4ee13c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8ec3d665-9440-4181-9d2c-79b323f7435e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("946869a2-f0d5-464e-87a4-8de3c106f316"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a0e35bd7-42d6-410d-8dd1-c34132e00ab5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a65135d4-096d-45b2-992c-20a30c5d8824"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a7a5b125-35a3-4274-ad26-83cba4015558"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba6b1f12-c70a-4dca-973c-7700893c871e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d78ff3d8-9d6c-4802-8cda-efae34b07a80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e63f52ac-0eca-45ff-b778-dbf343510a6b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f940f1ba-e519-4d17-9111-8c86d9135c12"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fd9a1cd9-8506-46b0-b40b-e1e8ec0ba85c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("787fe36a-82f6-4027-bae4-b24e14889153"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0843a74d-1d66-424f-9c98-e185c81c8b9b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0a8174e9-81de-4d92-bb3d-3dbb29ce6f18"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2122167a-8a28-4278-99ad-7dc863609fb5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2dc5ae93-e47a-42b9-a251-b20a8ee24aa6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("30ef7bbc-8fa9-4bdf-979c-2b301d661e4a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("50e817e7-9bc7-4eae-a23f-d155f73301c8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5d96bac9-1291-4835-af06-06955320e4c6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6f4c39e0-e97b-46fd-b7c0-f7b9580969ff"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6fb542aa-4941-4206-94ae-1b9c38025000"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7c5c57ff-c6b6-44e0-8807-947d5a76fd36"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7fa19468-5bfb-4528-9ef7-fc29d3bfa72d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("85f3231a-9cd9-4ec5-a2aa-8082162e8573"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8ebcee38-759c-4bd8-9259-f595a1591c29"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9202e232-02bd-4380-b0a9-8e293c78065d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ad2502c8-dfd0-4159-b7f9-ac14e4b705c2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b11c2b30-a499-4793-b0dc-8bf59342212e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c6b90981-da26-4a61-89b6-6a0abc3bda3d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c9866a25-ae45-4407-9a27-42fbb76a4235"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e93ab32f-2d13-49aa-a8a2-c0860a171f6a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("eb8a1453-5caf-4864-a997-335ba7c26bc0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ec106864-8f27-4ca8-a9dc-de595b233ea9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f0641e2c-246a-4dce-be3e-34546cca4a91"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("6a78ba23-f085-4485-a2b1-a26cf849f42e"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"));

            migrationBuilder.RenameColumn(
                name: "IsGuia",
                table: "SalePlans",
                newName: "IsSearch");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Banners",
                newName: "CustomersId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("d835f17d-d80c-45c2-aded-4832e198293d"), null, null, null, null, null, new DateTime(2021, 2, 24, 21, 42, 41, 465, DateTimeKind.Local).AddTicks(6144), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), null, new DateTime(2021, 2, 24, 21, 42, 41, 470, DateTimeKind.Local).AddTicks(6164), true, false, "Administradores", new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("29f7702d-4a8e-418c-9555-ea40c3b011fe"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5735), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("8577c0ec-2d30-46c2-b5e5-df04f9e5f914"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("00bf7ba9-7b66-4cd7-8c70-6ac1c80cf087"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5649), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("ebd62a53-5a18-4360-8e13-c9289f5f4319"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("91a5bca9-eec4-442f-bc37-2a13dd0e209c"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5615), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("1ec5b8a1-147d-4b10-bdf0-073ff10d2a30"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("ab1171a1-d6da-442b-bf07-e0c63c27b381"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5581), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("2054a610-11ba-4e21-8ae1-ede36deab5f1"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("499d2cd7-b07a-4275-8e1e-c9a12c4c7d59"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5543), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("33fc4c3b-7bac-493e-b6e2-e39c66731767"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("8f7fe56d-c9cd-46a3-8af8-0223f948e28b"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5508), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("8ac0eed0-74d5-483c-8120-4d4737a216da"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("a2ac64a4-be53-46a5-9324-2725dd6ec101"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5473), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("479fd935-8fc1-4e8c-b2af-52bef8636f2a"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("2e0f2eb6-4818-45f9-96a2-c06af5e5ac61"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5434), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("f39f685c-f9de-4995-859d-5d65cd8b9754"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("1ab4a38e-a7a2-42a6-b0f3-6b8e7999f52d"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5401), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("a14a965a-a1ca-496e-9e69-74d855a8ac94"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("1f9de083-1db1-406f-9431-92a1e8b95b6f"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5368), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("c6ce4ce9-5237-4a55-8d14-18a0e2537fac"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("1ab3bd80-8684-43b9-9453-e4f77288eb44"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5333), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("fd6c0ed4-b973-467f-96a2-e78cdcd00531"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("0f0d5ee7-f1f2-4e57-970a-42dfc6e6c4ac"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5299), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("2291e84d-2727-4c8e-88cf-e95969e20179"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("f88d2b1d-1816-4344-8b2d-0cf4cd8a3b5c"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5261), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("a54787b7-b79c-4172-884a-a6626fbc5199"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("baf55d1c-eb08-4165-82ce-d354e2750ed9"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5225), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("0eebd11a-7ebd-4004-b151-55ad02626550"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("33f4046b-c961-416b-aad2-fcf00767c6b2"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5189), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("981d1af1-4833-4149-824d-1b36bdfb1a2f"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("cea1120c-98e8-47aa-9afc-e13156dc0552"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5147), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("e8fb068a-1b5b-4637-b6b0-6a9f40b15cbc"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("1ed11866-ce7c-41f1-9f0b-b5245ef254b0"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5104), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("ac2eba16-9589-4053-80b8-38ca93bfa1ce"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("38acfc83-f199-4394-aeef-c7ec9a2c8e2d"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5006), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("f2ae923c-077c-44ad-be5a-b8b4fea2e32c"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("72890ee9-c6d2-4bb1-b1a6-b64deefa7367"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(4969), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("269b550c-8479-4ab8-b2ae-5f7288191046"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("bc3e09eb-1938-4fd4-a347-100c54efb31c"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(4909), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("365c734c-56de-48dc-b683-cc6dcab9556b"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("6bbc8afa-c4e6-460e-a91f-2757d9493ddd"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(4511), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null },
                    { new Guid("cf68089e-3bb5-4d70-994f-685ebe919222"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(5769), new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("79d0001e-82fb-4633-8c55-0c32bc5d85e1"), true, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("5a76d96d-981a-4e4e-875f-a02ac69a3312"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 24, 21, 42, 41, 470, DateTimeKind.Local).AddTicks(4001), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e2a7df0b-1793-4a6f-8019-b91849acfedb"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 24, 21, 42, 41, 470, DateTimeKind.Local).AddTicks(3799), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4eb947a4-261f-41eb-9d0e-5d6f34a78710"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 24, 21, 42, 41, 469, DateTimeKind.Local).AddTicks(8943), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("79d0001e-82fb-4633-8c55-0c32bc5d85e1"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(9053), null, "", true, false, "groupusers/details", new Guid("ebd62a53-5a18-4360-8e13-c9289f5f4319"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8577c0ec-2d30-46c2-b5e5-df04f9e5f914"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8978), null, "", true, false, "groupusers/list", new Guid("ebd62a53-5a18-4360-8e13-c9289f5f4319"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ebd62a53-5a18-4360-8e13-c9289f5f4319"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8909), null, "", true, false, "", new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1ec5b8a1-147d-4b10-bdf0-073ff10d2a30"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8834), null, "", true, false, "systems/details", new Guid("33fc4c3b-7bac-493e-b6e2-e39c66731767"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2054a610-11ba-4e21-8ae1-ede36deab5f1"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8761), null, "", true, false, "systems/list", new Guid("33fc4c3b-7bac-493e-b6e2-e39c66731767"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33fc4c3b-7bac-493e-b6e2-e39c66731767"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8626), null, "", true, false, "", new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8ac0eed0-74d5-483c-8120-4d4737a216da"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8552), null, "", true, false, "languages/details", new Guid("f39f685c-f9de-4995-859d-5d65cd8b9754"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("479fd935-8fc1-4e8c-b2af-52bef8636f2a"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8477), null, "", true, false, "languages/list", new Guid("f39f685c-f9de-4995-859d-5d65cd8b9754"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f39f685c-f9de-4995-859d-5d65cd8b9754"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8404), null, "", true, false, "", new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a14a965a-a1ca-496e-9e69-74d855a8ac94"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8329), null, "", true, false, "clients/details", new Guid("fd6c0ed4-b973-467f-96a2-e78cdcd00531"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c6ce4ce9-5237-4a55-8d14-18a0e2537fac"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8258), null, "", true, false, "clients/list", new Guid("fd6c0ed4-b973-467f-96a2-e78cdcd00531"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2291e84d-2727-4c8e-88cf-e95969e20179"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8046), null, "", true, false, "menus/details", new Guid("0eebd11a-7ebd-4004-b151-55ad02626550"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a54787b7-b79c-4172-884a-a6626fbc5199"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7967), null, "", true, false, "menus/list", new Guid("0eebd11a-7ebd-4004-b151-55ad02626550"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0eebd11a-7ebd-4004-b151-55ad02626550"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7886), null, "", true, false, "", new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("981d1af1-4833-4149-824d-1b36bdfb1a2f"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7813), null, "", true, false, "users/details", new Guid("ac2eba16-9589-4053-80b8-38ca93bfa1ce"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e8fb068a-1b5b-4637-b6b0-6a9f40b15cbc"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7735), null, "", true, false, "users/list", new Guid("ac2eba16-9589-4053-80b8-38ca93bfa1ce"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ac2eba16-9589-4053-80b8-38ca93bfa1ce"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7512), null, "", true, false, "", new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f2ae923c-077c-44ad-be5a-b8b4fea2e32c"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7273), null, "", true, false, "companyoperators/details", new Guid("365c734c-56de-48dc-b683-cc6dcab9556b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("269b550c-8479-4ab8-b2ae-5f7288191046"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7070), null, "", true, false, "companyoperators/list", new Guid("365c734c-56de-48dc-b683-cc6dcab9556b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("365c734c-56de-48dc-b683-cc6dcab9556b"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(6894), null, "", true, false, "", new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(2874), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fd6c0ed4-b973-467f-96a2-e78cdcd00531"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8181), null, "", true, false, "", new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 24, 21, 42, 41, 468, DateTimeKind.Local).AddTicks(9363), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("fcdf86f0-b533-49be-b556-f224ca3eb752"), null, new DateTime(2021, 2, 24, 21, 42, 41, 470, DateTimeKind.Local).AddTicks(4085), true, true, false, new Guid("5a76d96d-981a-4e4e-875f-a02ac69a3312"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, null },
                    { new Guid("4250c9f5-52f0-4ad0-b132-e222cf41d764"), null, new DateTime(2021, 2, 24, 21, 42, 41, 470, DateTimeKind.Local).AddTicks(3366), true, true, false, new Guid("4eb947a4-261f-41eb-9d0e-5d6f34a78710"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, null },
                    { new Guid("cd18d2ea-d556-4d89-a3d1-5f636bdcda2f"), null, new DateTime(2021, 2, 24, 21, 42, 41, 470, DateTimeKind.Local).AddTicks(3946), true, true, false, new Guid("e2a7df0b-1793-4a6f-8019-b91849acfedb"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("fd9a59b3-b6ca-4eeb-91f9-67166e129772"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8713), null, true, false, new Guid("33fc4c3b-7bac-493e-b6e2-e39c66731767"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdb26ccd-748e-4421-a935-107df7c3d213"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(9011), null, true, false, new Guid("8577c0ec-2d30-46c2-b5e5-df04f9e5f914"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("effd9142-ba99-4ac2-abf4-92b89b044dd7"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8942), null, true, false, new Guid("ebd62a53-5a18-4360-8e13-c9289f5f4319"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2bd77840-b71f-4768-8c14-d3d9d58aa84b"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8869), null, true, false, new Guid("1ec5b8a1-147d-4b10-bdf0-073ff10d2a30"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2401ab37-f669-480f-a5c5-70ab96b52cd8"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8796), null, true, false, new Guid("2054a610-11ba-4e21-8ae1-ede36deab5f1"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f5c591bc-9ba9-4782-a553-440d52174332"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8586), null, true, false, new Guid("8ac0eed0-74d5-483c-8120-4d4737a216da"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ff0d38f-5e55-469c-a61d-7228bcee2ee1"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8511), null, true, false, new Guid("479fd935-8fc1-4e8c-b2af-52bef8636f2a"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6765212f-3f4b-4fd6-bd9c-d446a4ef54a5"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8438), null, true, false, new Guid("f39f685c-f9de-4995-859d-5d65cd8b9754"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b4260d06-5b11-45f8-89e5-acd19a3bfdbb"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8361), null, true, false, new Guid("a14a965a-a1ca-496e-9e69-74d855a8ac94"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a73523f-1d43-488e-8be3-8ce74cdaf7d2"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8292), null, true, false, new Guid("c6ce4ce9-5237-4a55-8d14-18a0e2537fac"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cf36d3ec-fe3d-4f06-be80-11e4f70bc316"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8216), null, true, false, new Guid("fd6c0ed4-b973-467f-96a2-e78cdcd00531"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ecf457f-6b95-49d8-9777-cce8f48632ac"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8133), null, true, false, new Guid("2291e84d-2727-4c8e-88cf-e95969e20179"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7d8d52d6-e874-41d1-b608-0b6a42aed0be"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(8002), null, true, false, new Guid("a54787b7-b79c-4172-884a-a6626fbc5199"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0ab5bf7-a8a7-41bb-9724-8211113548ea"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7923), null, true, false, new Guid("0eebd11a-7ebd-4004-b151-55ad02626550"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("059a3512-dbde-4983-b461-6920e81eba2d"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7847), null, true, false, new Guid("981d1af1-4833-4149-824d-1b36bdfb1a2f"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("af4c90e0-0acc-4c49-8216-23077f7142bf"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7773), null, true, false, new Guid("e8fb068a-1b5b-4637-b6b0-6a9f40b15cbc"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("40f791fe-9f5c-483b-ab45-f7fd6055d60b"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7558), null, true, false, new Guid("ac2eba16-9589-4053-80b8-38ca93bfa1ce"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9d2145ad-7fa8-4451-8d33-516397e0b531"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7316), null, true, false, new Guid("f2ae923c-077c-44ad-be5a-b8b4fea2e32c"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a4173a14-dfe3-49f7-9027-6ad97e3f5dd5"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7107), null, true, false, new Guid("269b550c-8479-4ab8-b2ae-5f7288191046"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d9748405-4a28-40f2-9240-cbb18818d8bb"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(7002), null, true, false, new Guid("365c734c-56de-48dc-b683-cc6dcab9556b"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d5d682d5-424e-41a6-a3d7-e67e27c808af"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(5860), null, true, false, new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("13d92f88-548e-4cf5-8283-c9576eb0af52"), null, new DateTime(2021, 2, 24, 21, 42, 41, 471, DateTimeKind.Local).AddTicks(9087), null, true, false, new Guid("79d0001e-82fb-4633-8c55-0c32bc5d85e1"), new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b2d06566-8fff-4a11-89af-c972773b8643"), null, new Guid("d835f17d-d80c-45c2-aded-4832e198293d"), null, null, null, new DateTime(2021, 2, 24, 21, 42, 41, 473, DateTimeKind.Local).AddTicks(537), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("18a6c9b4-9220-4a21-b8d9-d955047915fc"), null, null, new DateTime(2021, 2, 24, 21, 42, 41, 473, DateTimeKind.Local).AddTicks(3793), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("b2d06566-8fff-4a11-89af-c972773b8643"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531"), new Guid("d835f17d-d80c-45c2-aded-4832e198293d"), null, new DateTime(2021, 2, 24, 21, 42, 41, 473, DateTimeKind.Local).AddTicks(8221), null, new Guid("56e1a650-37c3-4645-a433-9900a6356b13"), true, false, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), new Guid("b2d06566-8fff-4a11-89af-c972773b8643"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("6c490a12-8e32-491b-8383-b5c3a4d36f51"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(4329), null, true, false, new Guid("8577c0ec-2d30-46c2-b5e5-df04f9e5f914"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("a6ac6cf1-042a-420b-b327-60efc9b921fb"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(4264), null, true, false, new Guid("ebd62a53-5a18-4360-8e13-c9289f5f4319"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("72e1bf5f-12a4-4583-80c0-609087a2937c"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(4204), null, true, false, new Guid("1ec5b8a1-147d-4b10-bdf0-073ff10d2a30"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("16c4d4f7-6161-47c9-9b01-b7630ffa6861"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(4147), null, true, false, new Guid("2054a610-11ba-4e21-8ae1-ede36deab5f1"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("c28cc78b-054d-4775-a40a-80f19e0761e7"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(4082), null, true, false, new Guid("33fc4c3b-7bac-493e-b6e2-e39c66731767"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("b91d8ab4-9fca-4d6e-9276-92972480349f"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(4023), null, true, false, new Guid("8ac0eed0-74d5-483c-8120-4d4737a216da"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("ab30a452-dd19-4241-a46b-e15626448110"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3967), null, true, false, new Guid("479fd935-8fc1-4e8c-b2af-52bef8636f2a"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("6325bdd5-ee7a-4061-8110-07f1e9480057"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3929), null, true, false, new Guid("f39f685c-f9de-4995-859d-5d65cd8b9754"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("a68ee387-f1b5-45e8-9cf5-8e5a128eb689"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3891), null, true, false, new Guid("a14a965a-a1ca-496e-9e69-74d855a8ac94"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("85322a22-d3fc-4585-acc4-3a4426e3e9f8"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3853), null, true, false, new Guid("c6ce4ce9-5237-4a55-8d14-18a0e2537fac"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("6b722c74-d342-47b5-b645-326d089669b0"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(4384), null, true, false, new Guid("79d0001e-82fb-4633-8c55-0c32bc5d85e1"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("9a8686ff-b206-49de-9883-e94875d37c24"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3775), null, true, false, new Guid("2291e84d-2727-4c8e-88cf-e95969e20179"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("db0a433f-a6dd-4c10-b0d2-97fe7f3befbe"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3652), null, true, false, new Guid("a54787b7-b79c-4172-884a-a6626fbc5199"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("82804293-c41d-4d07-94e5-8b959f6031bd"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3618), null, true, false, new Guid("0eebd11a-7ebd-4004-b151-55ad02626550"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("d0bc07c9-0fa2-4725-ab2a-0e498d3faf66"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3566), null, true, false, new Guid("981d1af1-4833-4149-824d-1b36bdfb1a2f"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("e1e28def-b040-4531-9714-d0499ed10a8a"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3531), null, true, false, new Guid("e8fb068a-1b5b-4637-b6b0-6a9f40b15cbc"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("72203b18-3f0b-4917-9d9f-13bca0f7e34e"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3490), null, true, false, new Guid("ac2eba16-9589-4053-80b8-38ca93bfa1ce"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("3c8641a0-2ba5-4533-856a-e56836b6aa67"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3445), null, true, false, new Guid("f2ae923c-077c-44ad-be5a-b8b4fea2e32c"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("082b6888-4ed8-42fe-89c0-d76e37e22fc9"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3407), null, true, false, new Guid("269b550c-8479-4ab8-b2ae-5f7288191046"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("4b257ca6-76af-4559-9f7b-6500c84b4698"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3352), null, true, false, new Guid("365c734c-56de-48dc-b683-cc6dcab9556b"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("f63abb02-129b-437e-a947-31cec22becca"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(2929), null, true, false, new Guid("014724bf-a94f-4915-89ed-b5a5cc450e0f"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") },
                    { new Guid("b4f854a5-a57e-4cf5-b797-a6a874159f70"), true, true, null, new DateTime(2021, 2, 24, 21, 42, 41, 474, DateTimeKind.Local).AddTicks(3816), null, true, false, new Guid("fd6c0ed4-b973-467f-96a2-e78cdcd00531"), true, true, null, null, null, new Guid("c06fb6c8-9b81-4af4-a31d-10dfa4012531") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("d560c7c6-ba67-4500-af69-d33d7f6e4d28"), "usuário administrativo", null, new DateTime(2021, 2, 24, 21, 42, 41, 472, DateTimeKind.Local).AddTicks(7835), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("84a6fc83-fd98-4147-9326-c7c5421c8f10"), new Guid("d835f17d-d80c-45c2-aded-4832e198293d"), null, new DateTime(2021, 2, 24, 21, 42, 41, 469, DateTimeKind.Local).AddTicks(3274), null, true, false, new Guid("34747f20-a488-426e-96ee-4e16b58f3364"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
