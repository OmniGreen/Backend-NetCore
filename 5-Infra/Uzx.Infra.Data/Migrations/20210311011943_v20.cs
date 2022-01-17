using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("46635be6-40ae-4045-9d15-351c8a0732bb"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("186f8263-f821-4110-83d1-05e2bded6880"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1e12e0b4-dadd-4811-9674-d828ac88f059"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("23b907d9-55e7-47f0-b577-bad40ed67a5b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("39f0a325-1133-43b5-a9c9-adf8eda32d60"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4c2e8417-feec-456f-aa64-033a8b6ddd6e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7529b803-5b42-4122-a01c-f1ecbd6031d4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7f3b2ec6-f008-43c9-8d63-0dadb0ff5280"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("880490c5-c149-4a64-b803-3c14ba317a00"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8ce9f76d-c295-459c-9bac-9704cd35af1b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9c07d216-48c1-4234-934c-5e5b610ecc4e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a1f90a20-de24-4e63-af30-ea29a0e14eba"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b0a1be5b-4310-4e2b-9c3b-40344a8bb5ee"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b1a9b4d1-bb4e-40ff-91bb-75c9ed439ea6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b8cb71bf-1246-4fe4-9374-af7db5aed1ab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c9231007-fd12-42ae-a2d6-bd9294e3e766"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ca6a0802-86c2-4857-a2da-be1cbcd88f03"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d2287672-40ca-4f09-9de3-a121ccb51bc2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d76f2088-58a2-4151-a31f-251029d9ee30"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("dabcf7dd-9a54-48fa-aa31-6b68f8dac382"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e84d79d8-cc7e-4b98-9cba-7d7fe96ffce4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f7781238-569c-44d2-a64a-5c6b9736ecfe"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f83defd1-3b80-4114-8dde-ac31e99ba9be"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("3c3f4080-695b-4cf7-96b2-c8b23b0ba152"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7776f4dc-859c-48ee-bd8a-439f3dbc34b6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f2e83ebe-aa89-47b7-ad77-63f51f617c6a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3486f369-d661-4fac-972d-8f01b51adc22"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("88523520-8020-407d-8080-b3920c2da18e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a67fb92f-806c-43ea-9339-eb301638d750"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("be03e597-f466-4a8c-8c58-b4003890d686"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("2f1f190e-fcca-4b2f-b37e-c5c7f6524882"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("7992b767-e38e-4c88-b9c0-bbc08274a58e"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("f0a121f2-e103-47a9-ac56-5c6aab1744db"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("16c8706f-5a69-4391-816d-3c4e67496926"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("19018968-b46d-442e-9ced-25219f7c4c96"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("32969a75-0b30-4492-9511-6b64a040536a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("53b3cc02-38ff-4c2f-8775-72c94fc17714"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("64ed43ac-e680-4053-ab39-83920cbad76d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6bbb36dc-7da9-47a4-a337-728089689a8f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9685bcee-86a4-466e-974d-1dbe004ed16c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9698c8a6-38c8-44a2-896b-10453d8b8ffb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("99cc25c5-564c-49cf-bbbf-c1225915782b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("99d37e20-0121-4328-8499-6180dc951168"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9cc5a663-236c-48de-8303-2e8bbac2eb4c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a56c90cb-cc75-46e4-88ea-75bc8e9c8181"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("acd25e60-ab87-45f0-86b0-0fc9998e6ca8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b1f07851-4414-4a17-80f0-a2422f9f6fcd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b61d8c6a-3576-4236-9089-deecd8e3daad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b8e28b64-95bf-4c2e-a423-ab8867b74755"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c4301d59-0ffa-4e4e-9bf9-9ad3a62fa514"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("caefb70a-4876-4761-ba50-8480811fed84"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d0c07e7e-a9da-4cf2-928c-6041195fe43e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d72616f6-72dd-404d-83f8-935563f952b8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dc39de64-bace-4414-b45e-c66badf89626"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ded99cf2-b06c-4c3d-b25e-9077699e7abf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("476104fe-3136-4df5-8420-9698b62169bb"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("27a4d08c-7857-4189-856e-0d5a222c7f06"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("011796e3-ba18-4069-b060-746183615d98"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0926895a-0438-45f3-b538-a2c56a746b45"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("12696dc5-1aeb-460d-b972-fdac9fbdc58c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("152d5134-a3ef-40f4-9bf2-c250cdafbe89"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1e708230-51a6-44ec-bdae-9f808d95977f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("26f9bfbb-e8f6-4e78-85f4-01fa90e7d8a7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3dea9c07-3ab8-4e94-b5d5-39caf86b1831"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3e0dc115-78bb-4815-9b65-a3607fa25aa0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5462b482-7106-41e0-8c48-5e3dd480d44c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6c036cf9-f490-4ff7-b095-a0693076e941"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6ca9bb92-c0c0-49fe-a663-4172de75044e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("72b1e21a-3dc6-480a-b80a-30b77965fef1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("83093f4b-bf92-4ec4-b67f-7a0a50e7c299"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8df6ad74-e4b0-4102-b549-1f1f4ff254e7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b6f10169-2eec-41a9-bc97-89501db73b8c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b7e19874-b6f4-4fe1-8750-3ae9fcd15935"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ba8ced89-bd7f-4007-8684-9d6694a5fd1e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c6c71232-ccac-4cea-83dd-e39f36744c76"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("de25be93-7838-4fb2-97f9-ff081b7510e1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e1b39dfe-91bc-4c5f-b26b-9d1aae8b4e7b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ea2c3953-36a0-479f-b552-b367aa1e157e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ec9e1129-2b4c-4b1b-9a23-3bbdc12ba302"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("40a48f66-7faf-47c7-9ab6-14bc2c7ae7e6"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("d687793c-7785-4978-91bc-af41c966bb4e"));

            migrationBuilder.AddColumn<Guid>(
                name: "NeighborhoodId",
                table: "Customers",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Timetable",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, null, null, null, null, new DateTime(2021, 3, 10, 22, 19, 42, 131, DateTimeKind.Local).AddTicks(553), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(7954), true, false, "Administradores", new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("7bec2834-4e0b-4896-b655-0cce6a15a3ff"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1371), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("0846e863-8584-43e5-bc02-c31fbd182c11"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1311), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("1f88c03e-ca68-4347-a8b9-6d3aefae5f30"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1289), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("05745628-45bd-4df5-ba79-e01a2546f0ca"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1267), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("87918ea1-5b72-4f18-8341-73a68b807391"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1243), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("ac189a4d-6e52-4d16-a37f-cc2990404b17"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1221), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("a0b4dcbd-1720-48fc-ba4f-b04aabcb1b7e"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1199), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("c210b22a-59eb-4711-8f79-177d9c292e88"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1173), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("2e0b0fd7-5810-4726-9b82-8dc5b06045a4"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1151), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("f1d882ae-ed3c-42f7-8eef-488201b642ad"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1129), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("903185c4-0153-4656-be6b-4bf56f13b73e"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1107), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("2376255d-201c-48a3-b897-5d9b281ecd2f"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1084), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("3859f496-ee61-437b-9faf-253d37559890"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("debd44d5-3f7b-48f3-ab2f-e89a9d0f95d3"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1060), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("ce6a9ea7-c741-484c-9124-77852318abe4"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1037), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("4134c574-7440-4b06-832e-9dd8d7071092"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1015), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("ec710fad-dbfb-43ae-b433-878fb0b46820"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(986), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("e1324608-1eb2-4481-9897-a271069d3865"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("5ad39e04-d8d8-4302-8f26-30e9a58fe1f3"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(958), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("0d7e18c4-b16b-45ca-86c2-a99b3913916a"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(893), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("d7ccc363-aff5-482a-a21a-486832fbc81d"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(869), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("7d479fcb-66a5-46fc-80f4-d7052d623fca"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(830), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("64d5775b-5b79-4175-8af1-33ce5f1722c7"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(520), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("905c2810-f46a-4fa3-896a-39c1cf5124b8"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1395), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("44f655c9-7f09-4927-8c98-c84bd4bf565f"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6452), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("26b615d8-bdf5-421e-93cc-cf7c3a31678a"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6330), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eba4653a-4637-4e0b-b723-364042b908da"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(2650), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6263), null, "", true, false, "groupusers/details", new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6133), null, "", true, false, "groupusers/list", new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6087), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6040), null, "", true, false, "systems/details", new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5991), null, "", true, false, "systems/list", new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5899), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5850), null, "", true, false, "languages/details", new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5802), null, "", true, false, "languages/list", new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5755), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5705), null, "", true, false, "clients/details", new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5655), null, "", true, false, "clients/list", new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3859f496-ee61-437b-9faf-253d37559890"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5464), null, "", true, false, "menus/details", new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5410), null, "", true, false, "menus/list", new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5361), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5313), null, "", true, false, "users/details", new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e1324608-1eb2-4481-9897-a271069d3865"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5262), null, "", true, false, "users/list", new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5200), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5058), null, "", true, false, "companyoperators/details", new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4915), null, "", true, false, "companyoperators/list", new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4803), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(1980), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5606), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("93fceab7-9c84-4520-b930-370035caf145"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 10, 22, 19, 42, 133, DateTimeKind.Local).AddTicks(5834), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("1649523f-75a5-4704-b6ac-f818e8e97677"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6478), true, true, false, new Guid("44f655c9-7f09-4927-8c98-c84bd4bf565f"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null },
                    { new Guid("6091e668-c2e8-4ef3-a436-4557db04a3c3"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6061), true, true, false, new Guid("eba4653a-4637-4e0b-b723-364042b908da"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null },
                    { new Guid("5b367650-3a53-4165-845a-956ca4a52f5d"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6421), true, true, false, new Guid("26b615d8-bdf5-421e-93cc-cf7c3a31678a"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f46c627c-ad07-460d-a04a-a44fe42f095a"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5959), null, true, false, new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5f58f7c3-5d4a-4a18-b48b-b1705bc510b2"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6209), null, true, false, new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e6d14052-d1c2-4bc9-8461-11e391d9f629"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6109), null, true, false, new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("78fe3934-cb5c-4365-bcb5-d05a993ea176"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6062), null, true, false, new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2cf3fef3-bb82-4950-8e93-c505c94f00bb"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6014), null, true, false, new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("80f3c3e8-ab11-409c-9148-72f0d5571b02"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5873), null, true, false, new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e62103a-19f4-47bf-9bc7-6c5538aa92f5"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5825), null, true, false, new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f1560717-e1a7-45d0-8c35-6617313e56b6"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5777), null, true, false, new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b5bcf80-22e9-4d66-ac41-44f3d7f45d9f"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5727), null, true, false, new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f40a4bf5-f970-47c1-a404-7dff16a08889"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5681), null, true, false, new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("832f3b0f-e29f-40c1-a724-3e4f67bc7e1b"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5630), null, true, false, new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4597226d-6611-4fff-9c57-88c36521071b"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5487), null, true, false, new Guid("3859f496-ee61-437b-9faf-253d37559890"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("45b64c5d-5b56-4bd1-86c9-c7261828ac7a"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5435), null, true, false, new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b91a3b59-f4af-48ec-82e6-4792991c9cc3"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5383), null, true, false, new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("21a43c60-f0b2-4380-8d4a-69729e8b60de"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5335), null, true, false, new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cc068159-a9a7-4baa-83eb-97e4c2b0ee51"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5288), null, true, false, new Guid("e1324608-1eb2-4481-9897-a271069d3865"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4fee2935-b013-47d6-abb2-da265f35b0aa"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5228), null, true, false, new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("89d76425-e052-40e9-89eb-efbac1b5ff1e"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5085), null, true, false, new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df4dcb39-c96c-432c-a0ca-e1d79cb7a094"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4941), null, true, false, new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3dd7da17-563a-497e-928f-be875fdbe504"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4872), null, true, false, new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6a2124c6-5663-4ffa-90dc-60ba31bbbf55"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4034), null, true, false, new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c59793b1-c08a-4d0d-ac56-eaedf5c61f99"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6287), null, true, false, new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"), null, new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, null, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(5049), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e8324380-d77c-4adf-b2d0-2d455ec6d34d"), null, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(7606), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e72542da-9df9-4289-a651-871306885488"), new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(1017), null, new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("93fceab7-9c84-4520-b930-370035caf145"), new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("a692cf27-353b-49cf-bace-09bd81479412"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5561), null, true, false, new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("fbf23c11-1849-453b-b06c-97459e7cae10"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5537), null, true, false, new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("bd6e85c2-422a-43c9-9e01-f850c460bb05"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5515), null, true, false, new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("047e6fac-df48-4bb4-b853-4a9bf491d09d"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5492), null, true, false, new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("9fa8b80f-11ed-4e4a-9cc1-074ad2a865c0"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5468), null, true, false, new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("1250c0b1-33d0-4c7c-ab60-9112f444f82d"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5446), null, true, false, new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("3a8f3d95-9dbf-483b-855e-e0f4129511cf"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5423), null, true, false, new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("ca497547-a372-4bb3-ad44-d254d7d6a36c"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5400), null, true, false, new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("0c439b93-2008-4433-b3fb-47cee3ed6453"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5377), null, true, false, new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("43d42f06-4291-4169-897e-5292d8673363"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5352), null, true, false, new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("d562794b-0b7a-4659-828b-49d7334c4aae"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5584), null, true, false, new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("f3002d79-2e18-430a-950f-e7675a6ad2f1"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5305), null, true, false, new Guid("3859f496-ee61-437b-9faf-253d37559890"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("2deb651a-41bb-4769-891d-5ff55cdb659f"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5230), null, true, false, new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("fb198050-afe6-4f9c-af3c-4bf2386ce346"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5207), null, true, false, new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("b1a574a8-724e-406d-aace-d141d463677e"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5185), null, true, false, new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("de2930ac-e1c7-45a6-b576-49154377ecb5"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5162), null, true, false, new Guid("e1324608-1eb2-4481-9897-a271069d3865"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("a0c28a15-e7ec-4796-8dc4-b34695f7b7cf"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5135), null, true, false, new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("45fcff05-c80e-4f5b-a946-1261c7b98c70"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5105), null, true, false, new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("9ebaeaa5-00e1-4fda-9639-e0ec628f4007"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5081), null, true, false, new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("9860c8ba-134f-4d9a-a53e-6a16ba167914"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5043), null, true, false, new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("30f6ff85-fa6b-4ee3-abbc-6cacda6bf5d6"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(4806), null, true, false, new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("adf85610-d920-4e15-aee7-d944bcb7d130"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5329), null, true, false, new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("98d2d482-7492-4e62-9b9a-54421d8bff30"), "usuário administrativo", null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(2923), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5b6b9a75-3a0a-4c5a-9ceb-a6ce74dd3314"), new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, new DateTime(2021, 3, 10, 22, 19, 42, 133, DateTimeKind.Local).AddTicks(8847), null, true, false, new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("5b6b9a75-3a0a-4c5a-9ceb-a6ce74dd3314"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05745628-45bd-4df5-ba79-e01a2546f0ca"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0846e863-8584-43e5-bc02-c31fbd182c11"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0d7e18c4-b16b-45ca-86c2-a99b3913916a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1f88c03e-ca68-4347-a8b9-6d3aefae5f30"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2376255d-201c-48a3-b897-5d9b281ecd2f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2e0b0fd7-5810-4726-9b82-8dc5b06045a4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4134c574-7440-4b06-832e-9dd8d7071092"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ad39e04-d8d8-4302-8f26-30e9a58fe1f3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("64d5775b-5b79-4175-8af1-33ce5f1722c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7bec2834-4e0b-4896-b655-0cce6a15a3ff"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7d479fcb-66a5-46fc-80f4-d7052d623fca"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("87918ea1-5b72-4f18-8341-73a68b807391"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("903185c4-0153-4656-be6b-4bf56f13b73e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("905c2810-f46a-4fa3-896a-39c1cf5124b8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a0b4dcbd-1720-48fc-ba4f-b04aabcb1b7e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ac189a4d-6e52-4d16-a37f-cc2990404b17"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c210b22a-59eb-4711-8f79-177d9c292e88"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ce6a9ea7-c741-484c-9124-77852318abe4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d7ccc363-aff5-482a-a21a-486832fbc81d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("debd44d5-3f7b-48f3-ab2f-e89a9d0f95d3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec710fad-dbfb-43ae-b433-878fb0b46820"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f1d882ae-ed3c-42f7-8eef-488201b642ad"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("26b615d8-bdf5-421e-93cc-cf7c3a31678a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("44f655c9-7f09-4927-8c98-c84bd4bf565f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("eba4653a-4637-4e0b-b723-364042b908da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3859f496-ee61-437b-9faf-253d37559890"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e1324608-1eb2-4481-9897-a271069d3865"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("1649523f-75a5-4704-b6ac-f818e8e97677"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("5b367650-3a53-4165-845a-956ca4a52f5d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("6091e668-c2e8-4ef3-a436-4557db04a3c3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("21a43c60-f0b2-4380-8d4a-69729e8b60de"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2cf3fef3-bb82-4950-8e93-c505c94f00bb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3b5bcf80-22e9-4d66-ac41-44f3d7f45d9f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3dd7da17-563a-497e-928f-be875fdbe504"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4597226d-6611-4fff-9c57-88c36521071b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("45b64c5d-5b56-4bd1-86c9-c7261828ac7a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4e62103a-19f4-47bf-9bc7-6c5538aa92f5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4fee2935-b013-47d6-abb2-da265f35b0aa"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5f58f7c3-5d4a-4a18-b48b-b1705bc510b2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6a2124c6-5663-4ffa-90dc-60ba31bbbf55"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("78fe3934-cb5c-4365-bcb5-d05a993ea176"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("80f3c3e8-ab11-409c-9148-72f0d5571b02"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("832f3b0f-e29f-40c1-a724-3e4f67bc7e1b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("89d76425-e052-40e9-89eb-efbac1b5ff1e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b91a3b59-f4af-48ec-82e6-4792991c9cc3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c59793b1-c08a-4d0d-ac56-eaedf5c61f99"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cc068159-a9a7-4baa-83eb-97e4c2b0ee51"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("df4dcb39-c96c-432c-a0ca-e1d79cb7a094"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e6d14052-d1c2-4bc9-8461-11e391d9f629"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f1560717-e1a7-45d0-8c35-6617313e56b6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f40a4bf5-f970-47c1-a404-7dff16a08889"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f46c627c-ad07-460d-a04a-a44fe42f095a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("e8324380-d77c-4adf-b2d0-2d455ec6d34d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("e72542da-9df9-4289-a651-871306885488"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("047e6fac-df48-4bb4-b853-4a9bf491d09d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0c439b93-2008-4433-b3fb-47cee3ed6453"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1250c0b1-33d0-4c7c-ab60-9112f444f82d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2deb651a-41bb-4769-891d-5ff55cdb659f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("30f6ff85-fa6b-4ee3-abbc-6cacda6bf5d6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3a8f3d95-9dbf-483b-855e-e0f4129511cf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("43d42f06-4291-4169-897e-5292d8673363"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("45fcff05-c80e-4f5b-a946-1261c7b98c70"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9860c8ba-134f-4d9a-a53e-6a16ba167914"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9ebaeaa5-00e1-4fda-9639-e0ec628f4007"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9fa8b80f-11ed-4e4a-9cc1-074ad2a865c0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a0c28a15-e7ec-4796-8dc4-b34695f7b7cf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a692cf27-353b-49cf-bace-09bd81479412"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("adf85610-d920-4e15-aee7-d944bcb7d130"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b1a574a8-724e-406d-aace-d141d463677e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bd6e85c2-422a-43c9-9e01-f850c460bb05"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ca497547-a372-4bb3-ad44-d254d7d6a36c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d562794b-0b7a-4659-828b-49d7334c4aae"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("de2930ac-e1c7-45a6-b576-49154377ecb5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f3002d79-2e18-430a-950f-e7675a6ad2f1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fb198050-afe6-4f9c-af3c-4bf2386ce346"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fbf23c11-1849-453b-b06c-97459e7cae10"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("98d2d482-7492-4e62-9b9a-54421d8bff30"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("93fceab7-9c84-4520-b930-370035caf145"));

            migrationBuilder.DropColumn(
                name: "NeighborhoodId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Timetable",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, null, null, null, null, new DateTime(2021, 3, 6, 18, 12, 32, 64, DateTimeKind.Local).AddTicks(1216), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(4440), true, false, "Administradores", new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("b0a1be5b-4310-4e2b-9c3b-40344a8bb5ee"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4541), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("f7781238-569c-44d2-a64a-5c6b9736ecfe"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4506), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("7529b803-5b42-4122-a01c-f1ecbd6031d4"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4472), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("d2287672-40ca-4f09-9de3-a121ccb51bc2"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4436), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("ca6a0802-86c2-4857-a2da-be1cbcd88f03"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4394), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("9c07d216-48c1-4234-934c-5e5b610ecc4e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4359), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("88523520-8020-407d-8080-b3920c2da18e"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("f83defd1-3b80-4114-8dde-ac31e99ba9be"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4323), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("7f3b2ec6-f008-43c9-8d63-0dadb0ff5280"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4284), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("39f0a325-1133-43b5-a9c9-adf8eda32d60"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4181), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("c9231007-fd12-42ae-a2d6-bd9294e3e766"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4147), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("8ce9f76d-c295-459c-9bac-9704cd35af1b"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4114), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("b8cb71bf-1246-4fe4-9374-af7db5aed1ab"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4079), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("a1f90a20-de24-4e63-af30-ea29a0e14eba"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4037), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("1e12e0b4-dadd-4811-9674-d828ac88f059"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4003), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("d76f2088-58a2-4151-a31f-251029d9ee30"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3969), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("e84d79d8-cc7e-4b98-9cba-7d7fe96ffce4"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3935), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("b1a9b4d1-bb4e-40ff-91bb-75c9ed439ea6"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3894), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("4c2e8417-feec-456f-aa64-033a8b6ddd6e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3860), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("dabcf7dd-9a54-48fa-aa31-6b68f8dac382"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3823), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("186f8263-f821-4110-83d1-05e2bded6880"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3766), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("23b907d9-55e7-47f0-b577-bad40ed67a5b"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3315), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("880490c5-c149-4a64-b803-3c14ba317a00"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4575), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f2e83ebe-aa89-47b7-ad77-63f51f617c6a"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2817), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3c3f4080-695b-4cf7-96b2-c8b23b0ba152"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2662), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7776f4dc-859c-48ee-bd8a-439f3dbc34b6"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 6, 18, 12, 32, 67, DateTimeKind.Local).AddTicks(9033), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7317), null, "", true, false, "groupusers/details", new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7189), null, "", true, false, "groupusers/list", new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7119), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7044), null, "", true, false, "systems/details", new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6973), null, "", true, false, "systems/list", new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6896), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("88523520-8020-407d-8080-b3920c2da18e"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6821), null, "", true, false, "languages/details", new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6740), null, "", true, false, "languages/list", new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6612), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6541), null, "", true, false, "clients/details", new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6465), null, "", true, false, "clients/list", new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6318), null, "", true, false, "menus/details", new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6241), null, "", true, false, "menus/list", new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6161), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6014), null, "", true, false, "users/details", new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5943), null, "", true, false, "users/list", new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5859), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5613), null, "", true, false, "companyoperators/details", new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5518), null, "", true, false, "companyoperators/list", new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5259), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(698), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6387), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 6, 18, 12, 32, 67, DateTimeKind.Local).AddTicks(1529), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("7992b767-e38e-4c88-b9c0-bbc08274a58e"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2847), true, true, false, new Guid("f2e83ebe-aa89-47b7-ad77-63f51f617c6a"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null },
                    { new Guid("f0a121f2-e103-47a9-ac56-5c6aab1744db"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2372), true, true, false, new Guid("7776f4dc-859c-48ee-bd8a-439f3dbc34b6"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null },
                    { new Guid("2f1f190e-fcca-4b2f-b37e-c5c7f6524882"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2771), true, true, false, new Guid("3c3f4080-695b-4cf7-96b2-c8b23b0ba152"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("b61d8c6a-3576-4236-9089-deecd8e3daad"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6932), null, true, false, new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9cc5a663-236c-48de-8303-2e8bbac2eb4c"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7276), null, true, false, new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc39de64-bace-4414-b45e-c66badf89626"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7150), null, true, false, new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("64ed43ac-e680-4053-ab39-83920cbad76d"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7077), null, true, false, new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9685bcee-86a4-466e-974d-1dbe004ed16c"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7006), null, true, false, new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ded99cf2-b06c-4c3d-b25e-9077699e7abf"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6855), null, true, false, new Guid("88523520-8020-407d-8080-b3920c2da18e"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("99cc25c5-564c-49cf-bbbf-c1225915782b"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6776), null, true, false, new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("19018968-b46d-442e-9ced-25219f7c4c96"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6645), null, true, false, new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a56c90cb-cc75-46e4-88ea-75bc8e9c8181"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6573), null, true, false, new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53b3cc02-38ff-4c2f-8775-72c94fc17714"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6500), null, true, false, new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0c07e7e-a9da-4cf2-928c-6041195fe43e"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6420), null, true, false, new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("caefb70a-4876-4761-ba50-8480811fed84"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6350), null, true, false, new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b1f07851-4414-4a17-80f0-a2422f9f6fcd"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6278), null, true, false, new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("32969a75-0b30-4492-9511-6b64a040536a"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6199), null, true, false, new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d72616f6-72dd-404d-83f8-935563f952b8"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6047), null, true, false, new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("16c8706f-5a69-4391-816d-3c4e67496926"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5977), null, true, false, new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9698c8a6-38c8-44a2-896b-10453d8b8ffb"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5900), null, true, false, new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c4301d59-0ffa-4e4e-9bf9-9ad3a62fa514"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5648), null, true, false, new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b8e28b64-95bf-4c2e-a423-ab8867b74755"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5557), null, true, false, new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("99d37e20-0121-4328-8499-6180dc951168"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5448), null, true, false, new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("acd25e60-ab87-45f0-86b0-0fc9998e6ca8"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(4061), null, true, false, new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bbb36dc-7da9-47a4-a337-728089689a8f"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7349), null, true, false, new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("476104fe-3136-4df5-8420-9698b62169bb"), null, new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, null, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(9714), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("27a4d08c-7857-4189-856e-0d5a222c7f06"), null, null, new DateTime(2021, 3, 6, 18, 12, 32, 71, DateTimeKind.Local).AddTicks(3313), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("476104fe-3136-4df5-8420-9698b62169bb"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8"), new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, new DateTime(2021, 3, 6, 18, 12, 32, 71, DateTimeKind.Local).AddTicks(8129), null, new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), new Guid("476104fe-3136-4df5-8420-9698b62169bb"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("3e0dc115-78bb-4815-9b65-a3607fa25aa0"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4470), null, true, false, new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("152d5134-a3ef-40f4-9bf2-c250cdafbe89"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4435), null, true, false, new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("b7e19874-b6f4-4fe1-8750-3ae9fcd15935"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4401), null, true, false, new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("83093f4b-bf92-4ec4-b67f-7a0a50e7c299"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4356), null, true, false, new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("0926895a-0438-45f3-b538-a2c56a746b45"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4163), null, true, false, new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("ba8ced89-bd7f-4007-8684-9d6694a5fd1e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4129), null, true, false, new Guid("88523520-8020-407d-8080-b3920c2da18e"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("5462b482-7106-41e0-8c48-5e3dd480d44c"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4094), null, true, false, new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("3dea9c07-3ab8-4e94-b5d5-39caf86b1831"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4061), null, true, false, new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("26f9bfbb-e8f6-4e78-85f4-01fa90e7d8a7"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4028), null, true, false, new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("de25be93-7838-4fb2-97f9-ff081b7510e1"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3995), null, true, false, new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("72b1e21a-3dc6-480a-b80a-30b77965fef1"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4504), null, true, false, new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("8df6ad74-e4b0-4102-b549-1f1f4ff254e7"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3927), null, true, false, new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("011796e3-ba18-4069-b060-746183615d98"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3891), null, true, false, new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("ea2c3953-36a0-479f-b552-b367aa1e157e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3856), null, true, false, new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("12696dc5-1aeb-460d-b972-fdac9fbdc58c"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3814), null, true, false, new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("e1b39dfe-91bc-4c5f-b26b-9d1aae8b4e7b"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3780), null, true, false, new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("ec9e1129-2b4c-4b1b-9a23-3bbdc12ba302"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3741), null, true, false, new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("6ca9bb92-c0c0-49fe-a663-4172de75044e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3706), null, true, false, new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("1e708230-51a6-44ec-bdae-9f808d95977f"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3666), null, true, false, new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("c6c71232-ccac-4cea-83dd-e39f36744c76"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3539), null, true, false, new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("6c036cf9-f490-4ff7-b095-a0693076e941"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3165), null, true, false, new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("b6f10169-2eec-41a9-bc97-89501db73b8c"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3962), null, true, false, new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("40a48f66-7faf-47c7-9ab6-14bc2c7ae7e6"), "usuário administrativo", null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(6781), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("46635be6-40ae-4045-9d15-351c8a0732bb"), new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, new DateTime(2021, 3, 6, 18, 12, 32, 67, DateTimeKind.Local).AddTicks(4691), null, true, false, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
