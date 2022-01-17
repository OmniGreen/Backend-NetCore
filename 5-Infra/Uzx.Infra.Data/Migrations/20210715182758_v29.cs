using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("a95df3d0-f094-4bb5-bd25-1c95f5f622bf"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("414de629-e7e7-4814-a263-972bd89b1af2"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("35a7ffd4-1817-447b-bbe3-ba82cfe6f702"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("38a5cd75-9fca-4a71-80f1-3a18eaead747"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3f6dbc19-38f5-4ab3-b470-281c2eb5807d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4937f0d4-ca32-4b67-b25a-15efbbc385bd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4ced0608-ab81-47dd-b80f-9533bbbf6f7a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4d4c360e-a04c-4bb6-8608-7f21d8eabe72"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5d0b21ea-2d00-42d0-aff1-38437f52d480"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7df37f53-3d4f-49aa-8454-e12a22101995"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("854e28b8-d567-4f9c-8c73-b22c01087cb1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8dc01677-0095-48a6-9a0c-1fd9b7d6d63f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("93733c0f-4265-46d7-9b7f-d435b1889883"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9da4753e-d5d0-4aab-bba9-5f03428243d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9e4c7341-3214-40f0-98b7-143ce2ba0654"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a159507e-2319-43e0-80a5-81f17c4fd3ee"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a504d9a7-8c19-44c3-b717-19c1bd830863"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a61790e7-5e74-4aaf-bae0-54d2ba661aef"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a94c7021-b9f5-4c4f-b409-5b58bb559c67"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("abeb7618-c123-42d9-8578-50ce252e62e8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c8bb40fe-99ec-410d-922a-4b6d285e2b69"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e5c23811-f90e-42a9-9182-cd1e8295c2d1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e9967dcf-0574-44cc-b452-4285e7e2aefb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ed4b5200-c57c-40af-9d8b-71e825ad094a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2e6b75db-2e06-4e6f-825f-c2e36086f77f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("911401d7-3616-4f89-9908-c91f74d8c91f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d76e6718-3d09-4025-85b7-f5a092531109"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("147a45e4-35a0-4c61-8b6b-e261a778d915"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("152a9833-9e2a-4f71-95c8-5d21389a7937"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("157b90f0-36d9-4410-8c13-d65ec322ff99"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1bf594e3-9920-4089-accc-59b41dd116b5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1c191b1f-68e9-413e-b34e-27a1efb23196"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3da0ad52-1b7e-4b34-ae65-c51abcdae589"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("41d499b4-d572-47a2-95b0-fa4b55e9aefc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4ef2fbb8-ecdd-40c1-8444-26675fe3a971"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("53628253-a48c-4257-9a92-737944f2ec11"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6150881c-94fc-4de4-b8c9-f7f4c4558593"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("65287a02-5894-4dd9-8bf8-2dc600323c1d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6b7f2757-9518-446f-8e3a-f73204373176"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("75ffa318-29ef-48de-be7e-5980ac11f6ab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7c2c24ca-196a-4222-ad67-a83f4810d2ce"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8075ac81-5f04-4165-910d-e4dbfb2b65f7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8c2898e1-1630-4127-a253-ec542ecd44c3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("916fdce1-d636-4b7a-a944-9dad75c1bcfa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9266c25b-b3d4-455e-b184-10c8a3c686b9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a0ab3934-2f8b-4a4c-b2ce-05db2f286f11"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b9f591f8-87b0-4e62-88a9-cd67537e381b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d9869002-ea5e-4ce3-b8be-76ae5dd8c384"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("2d710fa7-e95f-412a-97da-15409cca4d30"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("7c6459ed-af4b-4094-9d32-125e23094bf6"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("91f55b55-26d5-4b5f-895b-1e97cf6f303a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0468512c-e471-4590-998a-b2b47a965fe5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("05349159-b973-4e71-9d76-0c8caa87ad5f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("111f6a1b-7576-443a-a41a-1b71721ce304"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("26484334-a55c-4e88-b292-df2a59ff7000"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3721b8dd-532c-41e0-99ce-7735c3c09f59"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("498afb92-5736-4696-9ddc-fc25734f2710"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("52866e52-725e-491c-8dcd-03be981c4390"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("53420349-38f3-4823-8ae5-e39a2586f83f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("53617e17-dfbf-4591-9af2-b877f6dc7779"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("62b66ab6-1dd1-4a3e-bb5b-1567fd888334"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7262ca08-fee6-4ef0-90d1-b6cdaf6cdf69"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("730dd1c5-f717-4461-82fb-8d9db7dd8c0e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("92199d1d-5e09-4c68-942d-57621a3ee40a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a04bbebf-4ce1-4aec-a62a-fb99600be366"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ab54a7c8-bf64-4b1f-9ae5-aceebc255f11"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bb9d0ba2-4d5a-42d1-9364-6a75bd10ad12"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bdf9e68e-6068-4590-91b4-21db5ba6bd87"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c24cb65f-c662-4a56-9bed-b1837a22e766"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c8e1a98b-a872-4c55-a38e-7deb5b023cb0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f2166874-ac6f-479f-b75f-d5f6f0f186b1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f607f75a-0ae1-412b-b667-ea0ea34e5c49"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fd0b13bf-2132-4ea3-b9ec-b8eeb12dfde9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("85f26e91-c32b-4217-b163-8da8fa90dbd7"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("656d83e6-c82e-4045-992b-ded9c58e4a50"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("020c64dc-4206-4a03-989f-7b05cefa37cd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("04265db5-df3c-43a3-9e2a-7c47094471e4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1026c4b7-3d2b-4481-8c36-290bf972c83c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("16d073d1-857b-4942-a443-cc54fa76eadf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1a8ab087-fd67-4801-a777-b4c59c90a651"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1bc270f7-69f1-450b-bf13-b81d0b604ca8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("22f0d22c-f9b5-4671-9466-09a4673e3db2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3b1be4d4-c04a-4353-b196-fd393efdb996"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("50f63400-809c-45cc-a4f5-5751f3b817e3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("52e3a7b8-7478-427b-a7c3-bbfe72417e60"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("580192bb-d940-4598-a03a-5693f05ae7eb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5bbfa1ef-372c-4882-91fa-48cb1b2d66fe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6fe0ebc0-7f0d-40eb-a4e9-1357c1e8ceea"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9b91e59f-6c86-4473-ac51-9823a6cf7a6e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9e8605ae-22bf-4995-8c11-964841911787"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9e9865e6-77f7-4ecd-b067-9a8ce7166880"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a7c3eafd-de9b-4fff-96a0-e307fd276e50"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b3267d98-b16f-4a79-864d-e24f9016f206"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d5b1e568-74f3-4b9b-b1ca-94d7323b9866"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e64b6770-278e-4791-9922-59bfa03d72f5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f1d2c674-6817-47f1-acb3-da9fafc30da4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fd475075-35f2-4ec0-a792-e4dc5e2ae5e7"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("759484be-2599-498c-a4a0-cf2a9ddec2f3"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"));

            migrationBuilder.AlterColumn<string>(
                name: "Whatsapp",
                table: "UsersSite",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Whatsapp",
                table: "UsersSite",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a95df3d0-f094-4bb5-bd25-1c95f5f622bf"), null, null, null, null, null, new DateTime(2021, 7, 15, 14, 19, 5, 395, DateTimeKind.Local).AddTicks(1448), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(5621), true, false, "Administradores", new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("a61790e7-5e74-4aaf-bae0-54d2ba661aef"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3201), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("157b90f0-36d9-4410-8c13-d65ec322ff99"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("a159507e-2319-43e0-80a5-81f17c4fd3ee"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3180), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("6150881c-94fc-4de4-b8c9-f7f4c4558593"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("35a7ffd4-1817-447b-bbe3-ba82cfe6f702"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3160), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("7c2c24ca-196a-4222-ad67-a83f4810d2ce"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("a94c7021-b9f5-4c4f-b409-5b58bb559c67"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3137), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("8075ac81-5f04-4165-910d-e4dbfb2b65f7"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("c8bb40fe-99ec-410d-922a-4b6d285e2b69"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3114), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("9266c25b-b3d4-455e-b184-10c8a3c686b9"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("4d4c360e-a04c-4bb6-8608-7f21d8eabe72"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3059), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("4ef2fbb8-ecdd-40c1-8444-26675fe3a971"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("9e4c7341-3214-40f0-98b7-143ce2ba0654"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3039), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("6b7f2757-9518-446f-8e3a-f73204373176"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("5d0b21ea-2d00-42d0-aff1-38437f52d480"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3019), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("41d499b4-d572-47a2-95b0-fa4b55e9aefc"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("7df37f53-3d4f-49aa-8454-e12a22101995"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2999), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("a0ab3934-2f8b-4a4c-b2ce-05db2f286f11"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("abeb7618-c123-42d9-8578-50ce252e62e8"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2979), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("53628253-a48c-4257-9a92-737944f2ec11"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("854e28b8-d567-4f9c-8c73-b22c01087cb1"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2959), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("3da0ad52-1b7e-4b34-ae65-c51abcdae589"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("4ced0608-ab81-47dd-b80f-9533bbbf6f7a"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2936), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("1c191b1f-68e9-413e-b34e-27a1efb23196"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("ed4b5200-c57c-40af-9d8b-71e825ad094a"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2915), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("d9869002-ea5e-4ce3-b8be-76ae5dd8c384"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("e9967dcf-0574-44cc-b452-4285e7e2aefb"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2894), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("b9f591f8-87b0-4e62-88a9-cd67537e381b"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("a504d9a7-8c19-44c3-b717-19c1bd830863"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2875), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("1bf594e3-9920-4089-accc-59b41dd116b5"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("8dc01677-0095-48a6-9a0c-1fd9b7d6d63f"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2855), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("152a9833-9e2a-4f71-95c8-5d21389a7937"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("9da4753e-d5d0-4aab-bba9-5f03428243d5"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2831), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("65287a02-5894-4dd9-8bf8-2dc600323c1d"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("93733c0f-4265-46d7-9b7f-d435b1889883"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2811), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("147a45e4-35a0-4c61-8b6b-e261a778d915"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("3f6dbc19-38f5-4ab3-b470-281c2eb5807d"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2788), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("916fdce1-d636-4b7a-a944-9dad75c1bcfa"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("e5c23811-f90e-42a9-9182-cd1e8295c2d1"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2752), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("75ffa318-29ef-48de-be7e-5980ac11f6ab"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("38a5cd75-9fca-4a71-80f1-3a18eaead747"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(2509), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null },
                    { new Guid("4937f0d4-ca32-4b67-b25a-15efbbc385bd"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(3221), new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("8c2898e1-1630-4127-a253-ec542ecd44c3"), true, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("d76e6718-3d09-4025-85b7-f5a092531109"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(4859), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2e6b75db-2e06-4e6f-825f-c2e36086f77f"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(4755), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("911401d7-3616-4f89-9908-c91f74d8c91f"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(2977), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("8c2898e1-1630-4127-a253-ec542ecd44c3"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(344), null, "", true, false, "groupusers/details", new Guid("6150881c-94fc-4de4-b8c9-f7f4c4558593"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("157b90f0-36d9-4410-8c13-d65ec322ff99"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(305), null, "", true, false, "groupusers/list", new Guid("6150881c-94fc-4de4-b8c9-f7f4c4558593"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6150881c-94fc-4de4-b8c9-f7f4c4558593"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(263), null, "", true, false, "", new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7c2c24ca-196a-4222-ad67-a83f4810d2ce"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(219), null, "", true, false, "systems/details", new Guid("9266c25b-b3d4-455e-b184-10c8a3c686b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8075ac81-5f04-4165-910d-e4dbfb2b65f7"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(177), null, "", true, false, "systems/list", new Guid("9266c25b-b3d4-455e-b184-10c8a3c686b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9266c25b-b3d4-455e-b184-10c8a3c686b9"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(132), null, "", true, false, "", new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4ef2fbb8-ecdd-40c1-8444-26675fe3a971"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(87), null, "", true, false, "languages/details", new Guid("41d499b4-d572-47a2-95b0-fa4b55e9aefc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6b7f2757-9518-446f-8e3a-f73204373176"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(17), null, "", true, false, "languages/list", new Guid("41d499b4-d572-47a2-95b0-fa4b55e9aefc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("41d499b4-d572-47a2-95b0-fa4b55e9aefc"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9976), null, "", true, false, "", new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0ab3934-2f8b-4a4c-b2ce-05db2f286f11"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9935), null, "", true, false, "clients/details", new Guid("3da0ad52-1b7e-4b34-ae65-c51abcdae589"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53628253-a48c-4257-9a92-737944f2ec11"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9894), null, "", true, false, "clients/list", new Guid("3da0ad52-1b7e-4b34-ae65-c51abcdae589"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1c191b1f-68e9-413e-b34e-27a1efb23196"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9810), null, "", true, false, "menus/details", new Guid("b9f591f8-87b0-4e62-88a9-cd67537e381b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d9869002-ea5e-4ce3-b8be-76ae5dd8c384"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9760), null, "", true, false, "menus/list", new Guid("b9f591f8-87b0-4e62-88a9-cd67537e381b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b9f591f8-87b0-4e62-88a9-cd67537e381b"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9688), null, "", true, false, "", new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1bf594e3-9920-4089-accc-59b41dd116b5"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9642), null, "", true, false, "users/details", new Guid("65287a02-5894-4dd9-8bf8-2dc600323c1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("152a9833-9e2a-4f71-95c8-5d21389a7937"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9599), null, "", true, false, "users/list", new Guid("65287a02-5894-4dd9-8bf8-2dc600323c1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("65287a02-5894-4dd9-8bf8-2dc600323c1d"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9546), null, "", true, false, "", new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("147a45e4-35a0-4c61-8b6b-e261a778d915"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9390), null, "", true, false, "companyoperators/details", new Guid("75ffa318-29ef-48de-be7e-5980ac11f6ab"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("916fdce1-d636-4b7a-a944-9dad75c1bcfa"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9337), null, "", true, false, "companyoperators/list", new Guid("75ffa318-29ef-48de-be7e-5980ac11f6ab"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("75ffa318-29ef-48de-be7e-5980ac11f6ab"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9235), null, "", true, false, "", new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(7674), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3da0ad52-1b7e-4b34-ae65-c51abcdae589"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9851), null, "", true, false, "", new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 7, 15, 14, 19, 5, 396, DateTimeKind.Local).AddTicks(9545), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("91f55b55-26d5-4b5f-895b-1e97cf6f303a"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(4892), true, true, false, new Guid("d76e6718-3d09-4025-85b7-f5a092531109"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, null },
                    { new Guid("2d710fa7-e95f-412a-97da-15409cca4d30"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(4536), true, true, false, new Guid("911401d7-3616-4f89-9908-c91f74d8c91f"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, null },
                    { new Guid("7c6459ed-af4b-4094-9d32-125e23094bf6"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(4831), true, true, false, new Guid("2e6b75db-2e06-4e6f-825f-c2e36086f77f"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("bdf9e68e-6068-4590-91b4-21db5ba6bd87"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(154), null, true, false, new Guid("9266c25b-b3d4-455e-b184-10c8a3c686b9"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53617e17-dfbf-4591-9af2-b877f6dc7779"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(324), null, true, false, new Guid("157b90f0-36d9-4410-8c13-d65ec322ff99"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53420349-38f3-4823-8ae5-e39a2586f83f"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(283), null, true, false, new Guid("6150881c-94fc-4de4-b8c9-f7f4c4558593"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a04bbebf-4ce1-4aec-a62a-fb99600be366"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(239), null, true, false, new Guid("7c2c24ca-196a-4222-ad67-a83f4810d2ce"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c24cb65f-c662-4a56-9bed-b1837a22e766"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(198), null, true, false, new Guid("8075ac81-5f04-4165-910d-e4dbfb2b65f7"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3721b8dd-532c-41e0-99ce-7735c3c09f59"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(109), null, true, false, new Guid("4ef2fbb8-ecdd-40c1-8444-26675fe3a971"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92199d1d-5e09-4c68-942d-57621a3ee40a"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(37), null, true, false, new Guid("6b7f2757-9518-446f-8e3a-f73204373176"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fd0b13bf-2132-4ea3-b9ec-b8eeb12dfde9"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9996), null, true, false, new Guid("41d499b4-d572-47a2-95b0-fa4b55e9aefc"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c8e1a98b-a872-4c55-a38e-7deb5b023cb0"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9955), null, true, false, new Guid("a0ab3934-2f8b-4a4c-b2ce-05db2f286f11"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bb9d0ba2-4d5a-42d1-9364-6a75bd10ad12"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9914), null, true, false, new Guid("53628253-a48c-4257-9a92-737944f2ec11"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0468512c-e471-4590-998a-b2b47a965fe5"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9870), null, true, false, new Guid("3da0ad52-1b7e-4b34-ae65-c51abcdae589"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ab54a7c8-bf64-4b1f-9ae5-aceebc255f11"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9829), null, true, false, new Guid("1c191b1f-68e9-413e-b34e-27a1efb23196"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("52866e52-725e-491c-8dcd-03be981c4390"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9787), null, true, false, new Guid("d9869002-ea5e-4ce3-b8be-76ae5dd8c384"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f2166874-ac6f-479f-b75f-d5f6f0f186b1"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9708), null, true, false, new Guid("b9f591f8-87b0-4e62-88a9-cd67537e381b"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("26484334-a55c-4e88-b292-df2a59ff7000"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9662), null, true, false, new Guid("1bf594e3-9920-4089-accc-59b41dd116b5"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("498afb92-5736-4696-9ddc-fc25734f2710"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9619), null, true, false, new Guid("152a9833-9e2a-4f71-95c8-5d21389a7937"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("111f6a1b-7576-443a-a41a-1b71721ce304"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9573), null, true, false, new Guid("65287a02-5894-4dd9-8bf8-2dc600323c1d"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("62b66ab6-1dd1-4a3e-bb5b-1567fd888334"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9411), null, true, false, new Guid("147a45e4-35a0-4c61-8b6b-e261a778d915"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("730dd1c5-f717-4461-82fb-8d9db7dd8c0e"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9359), null, true, false, new Guid("916fdce1-d636-4b7a-a944-9dad75c1bcfa"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f607f75a-0ae1-412b-b667-ea0ea34e5c49"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(9301), null, true, false, new Guid("75ffa318-29ef-48de-be7e-5980ac11f6ab"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("05349159-b973-4e71-9d76-0c8caa87ad5f"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(8739), null, true, false, new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7262ca08-fee6-4ef0-90d1-b6cdaf6cdf69"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(425), null, true, false, new Guid("8c2898e1-1630-4127-a253-ec542ecd44c3"), new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("85f26e91-c32b-4217-b163-8da8fa90dbd7"), null, new Guid("a95df3d0-f094-4bb5-bd25-1c95f5f622bf"), null, null, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(5057), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("656d83e6-c82e-4045-992b-ded9c58e4a50"), null, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(6361), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("85f26e91-c32b-4217-b163-8da8fa90dbd7"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55"), new Guid("a95df3d0-f094-4bb5-bd25-1c95f5f622bf"), null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(8188), null, new Guid("3d56694f-25f2-4551-912e-50a5cb5fb232"), true, false, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), new Guid("85f26e91-c32b-4217-b163-8da8fa90dbd7"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("f1d2c674-6817-47f1-acb3-da9fafc30da4"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(699), null, true, false, new Guid("157b90f0-36d9-4410-8c13-d65ec322ff99"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("22f0d22c-f9b5-4671-9466-09a4673e3db2"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(644), null, true, false, new Guid("6150881c-94fc-4de4-b8c9-f7f4c4558593"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("fd475075-35f2-4ec0-a792-e4dc5e2ae5e7"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(623), null, true, false, new Guid("7c2c24ca-196a-4222-ad67-a83f4810d2ce"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("3b1be4d4-c04a-4353-b196-fd393efdb996"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(601), null, true, false, new Guid("8075ac81-5f04-4165-910d-e4dbfb2b65f7"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("e64b6770-278e-4791-9922-59bfa03d72f5"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(577), null, true, false, new Guid("9266c25b-b3d4-455e-b184-10c8a3c686b9"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("020c64dc-4206-4a03-989f-7b05cefa37cd"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(553), null, true, false, new Guid("4ef2fbb8-ecdd-40c1-8444-26675fe3a971"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("a7c3eafd-de9b-4fff-96a0-e307fd276e50"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(531), null, true, false, new Guid("6b7f2757-9518-446f-8e3a-f73204373176"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("04265db5-df3c-43a3-9e2a-7c47094471e4"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(509), null, true, false, new Guid("41d499b4-d572-47a2-95b0-fa4b55e9aefc"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("1bc270f7-69f1-450b-bf13-b81d0b604ca8"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(487), null, true, false, new Guid("a0ab3934-2f8b-4a4c-b2ce-05db2f286f11"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("9e9865e6-77f7-4ecd-b067-9a8ce7166880"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(465), null, true, false, new Guid("53628253-a48c-4257-9a92-737944f2ec11"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("1026c4b7-3d2b-4481-8c36-290bf972c83c"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(722), null, true, false, new Guid("8c2898e1-1630-4127-a253-ec542ecd44c3"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("9e8605ae-22bf-4995-8c11-964841911787"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(421), null, true, false, new Guid("1c191b1f-68e9-413e-b34e-27a1efb23196"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("6fe0ebc0-7f0d-40eb-a4e9-1357c1e8ceea"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(397), null, true, false, new Guid("d9869002-ea5e-4ce3-b8be-76ae5dd8c384"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("52e3a7b8-7478-427b-a7c3-bbfe72417e60"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(369), null, true, false, new Guid("b9f591f8-87b0-4e62-88a9-cd67537e381b"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("b3267d98-b16f-4a79-864d-e24f9016f206"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(346), null, true, false, new Guid("1bf594e3-9920-4089-accc-59b41dd116b5"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("580192bb-d940-4598-a03a-5693f05ae7eb"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(322), null, true, false, new Guid("152a9833-9e2a-4f71-95c8-5d21389a7937"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("50f63400-809c-45cc-a4f5-5751f3b817e3"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(262), null, true, false, new Guid("65287a02-5894-4dd9-8bf8-2dc600323c1d"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("16d073d1-857b-4942-a443-cc54fa76eadf"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(238), null, true, false, new Guid("147a45e4-35a0-4c61-8b6b-e261a778d915"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("d5b1e568-74f3-4b9b-b1ca-94d7323b9866"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(214), null, true, false, new Guid("916fdce1-d636-4b7a-a944-9dad75c1bcfa"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("9b91e59f-6c86-4473-ac51-9823a6cf7a6e"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(181), null, true, false, new Guid("75ffa318-29ef-48de-be7e-5980ac11f6ab"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("1a8ab087-fd67-4801-a777-b4c59c90a651"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(9977), null, true, false, new Guid("f72f51d2-64ec-49d3-a162-b0357e9b78ba"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") },
                    { new Guid("5bbfa1ef-372c-4882-91fa-48cb1b2d66fe"), true, true, null, new DateTime(2021, 7, 15, 14, 19, 5, 399, DateTimeKind.Local).AddTicks(443), null, true, false, new Guid("3da0ad52-1b7e-4b34-ae65-c51abcdae589"), true, true, null, null, null, new Guid("92153b43-a951-4a41-8b59-5a4ae37fdf55") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("759484be-2599-498c-a4a0-cf2a9ddec2f3"), "usuário administrativo", null, new DateTime(2021, 7, 15, 14, 19, 5, 398, DateTimeKind.Local).AddTicks(4028), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("414de629-e7e7-4814-a263-972bd89b1af2"), new Guid("a95df3d0-f094-4bb5-bd25-1c95f5f622bf"), null, new DateTime(2021, 7, 15, 14, 19, 5, 397, DateTimeKind.Local).AddTicks(1041), null, true, false, new Guid("66d584a9-f8b1-4e42-96d2-741873dd64ad"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
