using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("baa37821-3bb9-4852-9f32-de4ea70af927"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("9b4313b7-ab44-4dcc-b402-d921df62b95a"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("214cb56e-a070-4ade-86bb-44839d78836f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("081b70c6-84c8-4e63-89e1-c01bdc9aee45"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("12c6092f-040b-4fc4-9d79-def89fe58b7f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1b857d7f-4c45-4f96-9d76-e4abad64df31"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("206380bf-cc8d-4bf8-b9e8-25f7d2b902cd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("25461b9f-faab-4e1e-bece-dd2a220fa70e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29e4ca37-c678-48c5-9a64-6e50deabb0be"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("338ee6e6-8330-42d0-960e-7cd6a2ee5150"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("35f5a353-b281-4dc4-816e-bd3b6d84ed54"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6181819d-b35e-429e-83a5-f42ac8b64bec"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("62d66292-f1f9-46ab-ad79-f2d387fd537f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6caecdd3-f1da-495c-a3a2-78fe43457d56"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("823cfba2-fc1a-4dc6-9b6f-34049efb57e7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("90bb58d5-d7e3-4bb4-b33b-08a4c343c32b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("94fe1c7d-5143-4338-b13c-c8ddffafacca"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a375e7e3-0d27-433a-98a3-c81ac70cdf07"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("add9c054-6ddd-4043-97ae-176c19089ca3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cd6ea415-a935-4eb1-9951-f157e817f9a8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d8dc7640-b192-4ab6-8ce8-1573591cf7b6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("dd7a0e06-7057-465a-b7f7-4ca0d54bfeb8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ea739d2e-fc58-4b95-88d0-efe673becbfb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f66096d0-121f-4e7b-9fcf-d0d2ea467466"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f800d729-f72e-4f9f-be61-6e6d38eed220"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("1a16b575-0e8a-45b1-a18c-5b775500c147"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2198d503-9c30-4446-a9fc-e40456f30d02"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ab2efc3a-03f7-4a7a-b904-206039db406f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("002be42d-5cf9-4afe-b0d8-6b4ec3c82729"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("051e2a1a-b3ac-4b20-9570-873717d6ba48"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0ce936c1-a9c9-4f71-8be3-6ff4952b48d8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("53ecb007-9686-4651-b5c4-740db3b69e38"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("58f801c3-874f-48f2-aa84-a3ffa207180c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("590fbf44-9212-4d91-af40-3fa6d1b28974"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5ba00b62-0e4e-4bbd-a4e7-d8ae2ef7a68f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6843a676-95da-4692-86b1-15f4d7f07069"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6a5be953-e0ac-41bc-970d-669e62e83d6e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("705b13a8-0fdf-4705-adb0-27ba696d97d8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7a7d7c86-7199-452b-afe9-542f09f2ef1f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8b4e60a7-2d9e-40ab-a306-e1474a232bb1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bdc7e05a-0ac8-47ed-a5a4-7919c7f3bf70"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c6ac8ed4-4448-4f18-8d1a-690694e59e38"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e5343522-2177-4076-a437-d7f306d78812"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e615fc44-a0da-4b7c-b7a5-00db745e1694"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f082e31a-4414-442a-b0e8-b727a44886a6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f402b4dd-b861-4231-9b13-2261c8561017"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f589fa84-3230-47c2-b091-069b3cf59a77"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f8e75541-5799-4fb0-9e99-b3c26749cc25"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fe08a155-585c-46aa-af8d-cf0bfb47e888"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("236e44fb-0375-4aaa-b18b-b34daae6f405"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("3ea6269a-42bd-4bbd-9374-bcb9f618260a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("d6773292-527f-4d3d-b3b0-f2440976f3f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("007e67d2-bf63-4c55-9e51-970d634b763a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("00e3f8a1-ad1c-4808-84e2-d0b4a1073885"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0c8e5a73-9528-4280-b10f-7760d579c0ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1f9aaa69-3baa-4427-ba0d-ac1f92f30a56"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3038c6d3-830e-412a-a87b-cbaec1ca1f53"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("41c27d34-f9dc-4ed8-a7b3-7ac82b73339f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4460c2b3-97f2-4a58-9d86-fe1e8b678b2e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4e4bf619-8d70-4d85-b3bc-01c91d928447"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4f1433de-7215-4541-82a2-26667d04eff9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6d72cbe9-f079-436d-beaa-8d9f7139da73"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6e118987-1dbb-45a7-b1af-6d7e1c32d9e1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6f14e2cc-d295-4a68-a04c-d371721c9418"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("77697ec2-a69b-4010-9e69-3b1c3a285d60"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("80b49f94-b58b-4ebe-893b-2b381a2af753"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("86e72467-9f0e-4800-95bb-17d3196acd52"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("956d55b0-43d5-43ee-a777-bb048aa09081"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("985edc29-dc65-4654-998b-151ad146b1b2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ae5272f6-e406-48c2-8198-1310bcabb8d2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cb7c7018-25b9-4310-909e-6cbf8fa922e3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dee54757-4302-42db-a06c-2b34456189cf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e85c7c16-a089-4d45-8faf-e11c963e30ad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ebf27874-7bbf-46ac-b52a-f10dd846c178"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6a34e532-4633-497c-a1e4-60dac60f9a33"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("063d9ea6-8e17-4827-be65-0d87cbad62b9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("053768b5-c619-4263-a481-49e9e0d72584"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("23f17532-a856-492e-9ec9-748328769f9a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("35c6803b-a152-4eeb-8e32-1ccff7f3743a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4d51d9bf-a62b-4257-be69-313c5fbbc456"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("517d0007-6cb4-469c-958b-68b628ba3771"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("535b684e-00af-49b9-8756-ed4f82233328"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("574311ab-e1d9-4517-bd6e-4c802db08b32"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("580fcf8f-9a73-4336-9dd3-9e9d0806ac51"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("67e5a3d1-83b9-499f-bafc-e7171185b1b3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("725f4d78-2c00-422c-b318-526e648223e2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7484db8c-4485-4a8a-b74a-dcf36bdcdd4f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("87e8c733-3b9c-41c0-a431-7f6959defbe6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8db50e2b-ed8f-45a2-89e7-c22319d749ef"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("90938758-8135-4393-bbce-f9182f10126d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("90f13cbf-2896-4d63-ae98-ae3f94f4cd8a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9677c172-e111-432b-8b2b-4a4f0c16cd4b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("982d331d-fd96-4eb3-ad72-d5eee79c95c2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3df3e4a-9c0c-4eeb-b114-ce8c9e5d219f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bea56bc4-0f72-4839-ba77-dd444307d97e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c4d249c4-8a43-4d00-9e11-c1177369e7a2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d9d0a3c6-e48b-482f-a821-5a7a61a2c58a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e70c8a32-03a9-4a5a-8b86-0fa96d082880"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("bdff09cf-a6b7-42a6-848b-d937cdd15bf5"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("12d089c4-19ba-429a-960f-e4967af2e82f"), null, null, null, null, null, new DateTime(2021, 4, 30, 15, 53, 7, 358, DateTimeKind.Local).AddTicks(5323), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(9904), true, false, "Administradores", new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("a6b1191a-3f57-49a6-b53c-11bc5799f9e3"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7348), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("fa148197-b2b8-424b-a90e-7d07ad989441"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("1e98403c-8888-411c-befa-eec54e0782c4"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7329), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("16a0399b-2ccc-456b-885c-179e6db82212"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("ac83f22a-d074-490f-850a-b71302425c89"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7310), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("3b274dc0-1b9b-41f1-b8ed-cd5ac3f1e881"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("c423a293-d0bb-4c67-aaa8-f54e0affc20d"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7290), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("63167dd3-473b-4f2e-a9c4-e8e4eab48301"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("290bb132-00ae-4f5d-bc3e-c7653da8b9bf"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7267), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("28d935fc-ffec-4b6f-89b8-caf64351a797"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("04503d86-3ce3-465b-9e51-f3ae02838ee7"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7248), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("d0af893b-6f2c-46df-802f-6353f5689d5a"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("6f7aff58-4884-4b71-a8f6-86739adad48b"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7228), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("1ff186f5-ef25-422c-8804-f79a52c8f94d"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("e30a92d4-7492-437c-9da5-b089267ec35e"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7206), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("0816b772-3b97-454e-b2a7-8c9e58356bb1"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("c8f0efdb-be14-4302-94e8-a96644b2bd62"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7151), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("aed7f1a7-8204-4c62-8da2-baad826d458a"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("750b67f8-58de-4398-9db3-6687dc78ee9f"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7131), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("d153e061-c91e-49de-836d-68edee9f6c25"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("7fdb850d-8a2a-40d7-8b27-3efe3ba71202"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7112), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("e28669d9-9e54-49a5-b4b4-f684df2cb1c1"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("8553cc0b-8944-4fc4-965f-612d13f14066"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7092), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("5788b708-8255-4895-81cb-d8eef22cc41a"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("a889f7b5-6113-42c4-a510-e75bc41cfeeb"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7068), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("d9ce237b-060e-44ec-a5d8-ec6719defbca"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("605ef1e2-e965-4bb3-bab1-40c6acd6b42c"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7049), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("a2e05ec7-eba8-49ce-8ae1-c4a06a5bcbbc"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("f9a64dea-2f7e-40ee-9448-6b992cce7245"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7029), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("247fbdab-abd6-4479-a282-2399d1b58b02"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("a90d6349-307f-4980-924f-2bec39338e98"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7009), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("f0c8bb69-4a1b-4cd8-85bb-98729e43c350"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("fc3871a6-248e-4e97-9081-bf8a3037ef36"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(6987), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("aaf498e6-d19d-4130-925d-d9060dfcc7a3"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("512fc119-1490-43d8-942b-5e8ddb3a64de"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(6966), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("0d08006a-fd06-492a-81c3-183698f9ed6a"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("73b59169-1d5c-4916-a111-eecb58822252"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(6944), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("bcc934af-523f-4467-904b-f733fbfc594f"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("fbf6650e-c1ad-41fc-ae29-ecd1283458b4"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(6911), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("b15807af-ce46-4f3a-8d1d-40247d9472d6"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("e611047b-8927-422e-92e7-1a7a3a778c15"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(6683), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null },
                    { new Guid("6a646d79-714e-4ca9-b13a-e5b741bd7ac3"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(7368), new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("a72d7413-1de7-4dd0-b378-0da8a259684f"), true, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("a9388aca-2f7c-45f1-82e7-93428d709040"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(9157), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e3a0e0d1-44f6-4d4b-baea-5e7714a2ddd9"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(9034), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("14aa6e5c-2e5b-453a-952a-1bf1a47a2c98"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(7156), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("a72d7413-1de7-4dd0-b378-0da8a259684f"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4606), null, "", true, false, "groupusers/details", new Guid("16a0399b-2ccc-456b-885c-179e6db82212"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fa148197-b2b8-424b-a90e-7d07ad989441"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4529), null, "", true, false, "groupusers/list", new Guid("16a0399b-2ccc-456b-885c-179e6db82212"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("16a0399b-2ccc-456b-885c-179e6db82212"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4489), null, "", true, false, "", new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b274dc0-1b9b-41f1-b8ed-cd5ac3f1e881"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4446), null, "", true, false, "systems/details", new Guid("28d935fc-ffec-4b6f-89b8-caf64351a797"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("63167dd3-473b-4f2e-a9c4-e8e4eab48301"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4405), null, "", true, false, "systems/list", new Guid("28d935fc-ffec-4b6f-89b8-caf64351a797"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28d935fc-ffec-4b6f-89b8-caf64351a797"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4362), null, "", true, false, "", new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0af893b-6f2c-46df-802f-6353f5689d5a"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4320), null, "", true, false, "languages/details", new Guid("0816b772-3b97-454e-b2a7-8c9e58356bb1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1ff186f5-ef25-422c-8804-f79a52c8f94d"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4272), null, "", true, false, "languages/list", new Guid("0816b772-3b97-454e-b2a7-8c9e58356bb1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0816b772-3b97-454e-b2a7-8c9e58356bb1"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4199), null, "", true, false, "", new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("aed7f1a7-8204-4c62-8da2-baad826d458a"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4159), null, "", true, false, "clients/details", new Guid("e28669d9-9e54-49a5-b4b4-f684df2cb1c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d153e061-c91e-49de-836d-68edee9f6c25"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4119), null, "", true, false, "clients/list", new Guid("e28669d9-9e54-49a5-b4b4-f684df2cb1c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5788b708-8255-4895-81cb-d8eef22cc41a"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4032), null, "", true, false, "menus/details", new Guid("a2e05ec7-eba8-49ce-8ae1-c4a06a5bcbbc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d9ce237b-060e-44ec-a5d8-ec6719defbca"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3988), null, "", true, false, "menus/list", new Guid("a2e05ec7-eba8-49ce-8ae1-c4a06a5bcbbc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a2e05ec7-eba8-49ce-8ae1-c4a06a5bcbbc"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3938), null, "", true, false, "", new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("247fbdab-abd6-4479-a282-2399d1b58b02"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3832), null, "", true, false, "users/details", new Guid("aaf498e6-d19d-4130-925d-d9060dfcc7a3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f0c8bb69-4a1b-4cd8-85bb-98729e43c350"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3791), null, "", true, false, "users/list", new Guid("aaf498e6-d19d-4130-925d-d9060dfcc7a3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("aaf498e6-d19d-4130-925d-d9060dfcc7a3"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3741), null, "", true, false, "", new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0d08006a-fd06-492a-81c3-183698f9ed6a"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3598), null, "", true, false, "companyoperators/details", new Guid("b15807af-ce46-4f3a-8d1d-40247d9472d6"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bcc934af-523f-4467-904b-f733fbfc594f"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3547), null, "", true, false, "companyoperators/list", new Guid("b15807af-ce46-4f3a-8d1d-40247d9472d6"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b15807af-ce46-4f3a-8d1d-40247d9472d6"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3454), null, "", true, false, "", new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(1961), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e28669d9-9e54-49a5-b4b4-f684df2cb1c1"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4075), null, "", true, false, "", new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(3727), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("f32e103e-69a2-4803-9239-d0d2eee4fae2"), null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(9181), true, true, false, new Guid("a9388aca-2f7c-45f1-82e7-93428d709040"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, null },
                    { new Guid("36884355-e3de-433e-be29-76c69238e943"), null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(8807), true, true, false, new Guid("14aa6e5c-2e5b-453a-952a-1bf1a47a2c98"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, null },
                    { new Guid("c16ce1aa-361c-4ca7-abd7-5cf7b91e8bd4"), null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(9118), true, true, false, new Guid("e3a0e0d1-44f6-4d4b-baea-5e7714a2ddd9"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("eee10ca0-6c8c-4c3f-88b9-d32ecad03d6a"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4383), null, true, false, new Guid("28d935fc-ffec-4b6f-89b8-caf64351a797"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ccba5e1-5fdd-4a97-838c-6261765d5ad7"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4583), null, true, false, new Guid("fa148197-b2b8-424b-a90e-7d07ad989441"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ccff2bd-228f-4a45-a9b7-0ea61298ba0a"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4508), null, true, false, new Guid("16a0399b-2ccc-456b-885c-179e6db82212"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92d32851-4530-4f0e-bb84-b3319ae7195c"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4464), null, true, false, new Guid("3b274dc0-1b9b-41f1-b8ed-cd5ac3f1e881"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b0f87bc6-9360-4513-8905-1cdb13d1e806"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4424), null, true, false, new Guid("63167dd3-473b-4f2e-a9c4-e8e4eab48301"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e725186-14b6-436a-8bd7-34198991c2d8"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4340), null, true, false, new Guid("d0af893b-6f2c-46df-802f-6353f5689d5a"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("45cafba7-6a52-4114-a112-2d11f638584e"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4294), null, true, false, new Guid("1ff186f5-ef25-422c-8804-f79a52c8f94d"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b72115a-fe1a-498d-90df-0fde79e8cd45"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4218), null, true, false, new Guid("0816b772-3b97-454e-b2a7-8c9e58356bb1"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("846d168e-9c83-4547-a15c-ff348f6a1e17"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4178), null, true, false, new Guid("aed7f1a7-8204-4c62-8da2-baad826d458a"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a86a54eb-5c7d-4bbe-a419-06fac041ad27"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4138), null, true, false, new Guid("d153e061-c91e-49de-836d-68edee9f6c25"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("35a5ddfa-e835-4e90-b4a4-281778c1f3ad"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4094), null, true, false, new Guid("e28669d9-9e54-49a5-b4b4-f684df2cb1c1"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4d077b15-978b-457c-8127-a624df80d769"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4052), null, true, false, new Guid("5788b708-8255-4895-81cb-d8eef22cc41a"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("38861f88-7442-43b2-bb45-b15e3782fe7a"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4009), null, true, false, new Guid("d9ce237b-060e-44ec-a5d8-ec6719defbca"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("feb8a092-14c9-4910-85ab-3186bef05dea"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3962), null, true, false, new Guid("a2e05ec7-eba8-49ce-8ae1-c4a06a5bcbbc"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fab4607b-3f16-4474-b90b-e0268670eed3"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3853), null, true, false, new Guid("247fbdab-abd6-4479-a282-2399d1b58b02"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f452d36d-65c6-4061-9286-d90568676709"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3810), null, true, false, new Guid("f0c8bb69-4a1b-4cd8-85bb-98729e43c350"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2f965ece-040d-4cd6-8ff3-d150bcb4634f"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3767), null, true, false, new Guid("aaf498e6-d19d-4130-925d-d9060dfcc7a3"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("43d8a072-dba1-463d-995d-09518272f8ce"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3617), null, true, false, new Guid("0d08006a-fd06-492a-81c3-183698f9ed6a"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d1866315-5763-488f-9a8f-dae51afaf7df"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3569), null, true, false, new Guid("bcc934af-523f-4467-904b-f733fbfc594f"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d8dbabc7-b526-46d4-86da-d38e8bcf9c93"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3514), null, true, false, new Guid("b15807af-ce46-4f3a-8d1d-40247d9472d6"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7dfc50a2-d671-462f-8d51-3028ca5c9087"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(3024), null, true, false, new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("09f9cc7c-6a43-4722-9e51-696700e3a501"), null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(4626), null, true, false, new Guid("a72d7413-1de7-4dd0-b378-0da8a259684f"), new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b4c74bd4-7441-41bd-bce7-ce43d224fc2f"), null, new Guid("12d089c4-19ba-429a-960f-e4967af2e82f"), null, null, null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(9395), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("70822afd-b0c7-4d70-951b-0abba3cf2c41"), null, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(795), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("b4c74bd4-7441-41bd-bce7-ce43d224fc2f"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc"), new Guid("12d089c4-19ba-429a-960f-e4967af2e82f"), null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(2517), null, new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"), true, false, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), new Guid("b4c74bd4-7441-41bd-bce7-ce43d224fc2f"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("f2096d69-a53c-413f-934f-a3196363ebc3"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4999), null, true, false, new Guid("fa148197-b2b8-424b-a90e-7d07ad989441"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("1adf4952-e0ea-4388-8090-5eb9f80695df"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4978), null, true, false, new Guid("16a0399b-2ccc-456b-885c-179e6db82212"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("31303210-bacc-43e6-ac8a-dd178950c0e8"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4957), null, true, false, new Guid("3b274dc0-1b9b-41f1-b8ed-cd5ac3f1e881"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("d05cadbb-b8c8-4e56-8546-22501a0584b4"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4934), null, true, false, new Guid("63167dd3-473b-4f2e-a9c4-e8e4eab48301"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("1a33e800-a826-4328-9745-4da2d6b69b0b"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4874), null, true, false, new Guid("28d935fc-ffec-4b6f-89b8-caf64351a797"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("4066daf6-cff2-4fe0-a9b5-ca08b8ca5b61"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4853), null, true, false, new Guid("d0af893b-6f2c-46df-802f-6353f5689d5a"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("91dfba0d-8d3f-4ad1-9008-27fcf1f3e9bb"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4829), null, true, false, new Guid("1ff186f5-ef25-422c-8804-f79a52c8f94d"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("17fa8ba8-4ef4-402e-b2c4-424dbffc9cd2"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4808), null, true, false, new Guid("0816b772-3b97-454e-b2a7-8c9e58356bb1"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("951f1da2-42d5-4772-936d-e5cca9a51e6a"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4787), null, true, false, new Guid("aed7f1a7-8204-4c62-8da2-baad826d458a"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("d8f90a56-440f-4827-bfd4-0cab968a85ee"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4766), null, true, false, new Guid("d153e061-c91e-49de-836d-68edee9f6c25"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("a013f576-4bc7-4008-af80-a647005e6254"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(5019), null, true, false, new Guid("a72d7413-1de7-4dd0-b378-0da8a259684f"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("a3a9abb3-116d-44ab-b428-410c156ab2a8"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4723), null, true, false, new Guid("5788b708-8255-4895-81cb-d8eef22cc41a"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("2709ca46-18ce-4d91-95d0-da6771e0ea1a"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4700), null, true, false, new Guid("d9ce237b-060e-44ec-a5d8-ec6719defbca"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("674ff2cd-dfc5-409c-b133-6816d6c3c06a"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4678), null, true, false, new Guid("a2e05ec7-eba8-49ce-8ae1-c4a06a5bcbbc"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("8b7e8e69-21f5-47af-8009-f7a2c2e2121a"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4653), null, true, false, new Guid("247fbdab-abd6-4479-a282-2399d1b58b02"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("031ecd56-5eb4-4f0b-b743-179af385313e"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4631), null, true, false, new Guid("f0c8bb69-4a1b-4cd8-85bb-98729e43c350"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("ef56f7a9-e494-47c1-9155-b24001b6504a"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4607), null, true, false, new Guid("aaf498e6-d19d-4130-925d-d9060dfcc7a3"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("891a44c6-be2c-4463-8207-846d4c4a1884"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4586), null, true, false, new Guid("0d08006a-fd06-492a-81c3-183698f9ed6a"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("889b943c-3b7c-4fa1-99b3-a025e73cbcab"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4562), null, true, false, new Guid("bcc934af-523f-4467-904b-f733fbfc594f"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("6f322027-0725-42e9-9202-1982c1613a4c"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4497), null, true, false, new Guid("b15807af-ce46-4f3a-8d1d-40247d9472d6"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("db4b2f14-845c-45a3-b227-6af1193f9854"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4293), null, true, false, new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") },
                    { new Guid("1860c35b-bdb8-48ab-9bb5-263c6c9622e3"), true, true, null, new DateTime(2021, 4, 30, 15, 53, 7, 362, DateTimeKind.Local).AddTicks(4745), null, true, false, new Guid("e28669d9-9e54-49a5-b4b4-f684df2cb1c1"), true, true, null, null, null, new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("fe35622f-2f6b-42d5-9d6f-37904d7205c8"), "usuário administrativo", null, new DateTime(2021, 4, 30, 15, 53, 7, 361, DateTimeKind.Local).AddTicks(8185), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("f5f9ee61-d2e9-44d6-b929-60293c54f67e"), new Guid("12d089c4-19ba-429a-960f-e4967af2e82f"), null, new DateTime(2021, 4, 30, 15, 53, 7, 360, DateTimeKind.Local).AddTicks(5238), null, true, false, new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("12d089c4-19ba-429a-960f-e4967af2e82f"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("f5f9ee61-d2e9-44d6-b929-60293c54f67e"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("92f8e4db-e6dc-4543-aa29-c567c214d60b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("04503d86-3ce3-465b-9e51-f3ae02838ee7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1e98403c-8888-411c-befa-eec54e0782c4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("290bb132-00ae-4f5d-bc3e-c7653da8b9bf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("512fc119-1490-43d8-942b-5e8ddb3a64de"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("605ef1e2-e965-4bb3-bab1-40c6acd6b42c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6a646d79-714e-4ca9-b13a-e5b741bd7ac3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6f7aff58-4884-4b71-a8f6-86739adad48b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("73b59169-1d5c-4916-a111-eecb58822252"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("750b67f8-58de-4398-9db3-6687dc78ee9f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7fdb850d-8a2a-40d7-8b27-3efe3ba71202"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8553cc0b-8944-4fc4-965f-612d13f14066"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a6b1191a-3f57-49a6-b53c-11bc5799f9e3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a889f7b5-6113-42c4-a510-e75bc41cfeeb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a90d6349-307f-4980-924f-2bec39338e98"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ac83f22a-d074-490f-850a-b71302425c89"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c423a293-d0bb-4c67-aaa8-f54e0affc20d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c8f0efdb-be14-4302-94e8-a96644b2bd62"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e30a92d4-7492-437c-9da5-b089267ec35e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e611047b-8927-422e-92e7-1a7a3a778c15"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f9a64dea-2f7e-40ee-9448-6b992cce7245"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fbf6650e-c1ad-41fc-ae29-ecd1283458b4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fc3871a6-248e-4e97-9081-bf8a3037ef36"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("14aa6e5c-2e5b-453a-952a-1bf1a47a2c98"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("a9388aca-2f7c-45f1-82e7-93428d709040"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e3a0e0d1-44f6-4d4b-baea-5e7714a2ddd9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0816b772-3b97-454e-b2a7-8c9e58356bb1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0d08006a-fd06-492a-81c3-183698f9ed6a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("16a0399b-2ccc-456b-885c-179e6db82212"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1ff186f5-ef25-422c-8804-f79a52c8f94d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("247fbdab-abd6-4479-a282-2399d1b58b02"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("28d935fc-ffec-4b6f-89b8-caf64351a797"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3a8ea606-857d-41a8-bbfc-68e24c5793b1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3b274dc0-1b9b-41f1-b8ed-cd5ac3f1e881"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5788b708-8255-4895-81cb-d8eef22cc41a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("63167dd3-473b-4f2e-a9c4-e8e4eab48301"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a2e05ec7-eba8-49ce-8ae1-c4a06a5bcbbc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a72d7413-1de7-4dd0-b378-0da8a259684f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("aaf498e6-d19d-4130-925d-d9060dfcc7a3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("aed7f1a7-8204-4c62-8da2-baad826d458a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b15807af-ce46-4f3a-8d1d-40247d9472d6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bcc934af-523f-4467-904b-f733fbfc594f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d0af893b-6f2c-46df-802f-6353f5689d5a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d153e061-c91e-49de-836d-68edee9f6c25"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d9ce237b-060e-44ec-a5d8-ec6719defbca"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e28669d9-9e54-49a5-b4b4-f684df2cb1c1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f0c8bb69-4a1b-4cd8-85bb-98729e43c350"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fa148197-b2b8-424b-a90e-7d07ad989441"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("36884355-e3de-433e-be29-76c69238e943"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("c16ce1aa-361c-4ca7-abd7-5cf7b91e8bd4"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("f32e103e-69a2-4803-9239-d0d2eee4fae2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("09f9cc7c-6a43-4722-9e51-696700e3a501"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2f965ece-040d-4cd6-8ff3-d150bcb4634f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("35a5ddfa-e835-4e90-b4a4-281778c1f3ad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("38861f88-7442-43b2-bb45-b15e3782fe7a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3b72115a-fe1a-498d-90df-0fde79e8cd45"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3ccff2bd-228f-4a45-a9b7-0ea61298ba0a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("43d8a072-dba1-463d-995d-09518272f8ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("45cafba7-6a52-4114-a112-2d11f638584e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4d077b15-978b-457c-8127-a624df80d769"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4e725186-14b6-436a-8bd7-34198991c2d8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ccba5e1-5fdd-4a97-838c-6261765d5ad7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7dfc50a2-d671-462f-8d51-3028ca5c9087"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("846d168e-9c83-4547-a15c-ff348f6a1e17"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("92d32851-4530-4f0e-bb84-b3319ae7195c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a86a54eb-5c7d-4bbe-a419-06fac041ad27"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b0f87bc6-9360-4513-8905-1cdb13d1e806"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d1866315-5763-488f-9a8f-dae51afaf7df"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d8dbabc7-b526-46d4-86da-d38e8bcf9c93"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("eee10ca0-6c8c-4c3f-88b9-d32ecad03d6a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f452d36d-65c6-4061-9286-d90568676709"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fab4607b-3f16-4474-b90b-e0268670eed3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("feb8a092-14c9-4910-85ab-3186bef05dea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b4c74bd4-7441-41bd-bce7-ce43d224fc2f"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("70822afd-b0c7-4d70-951b-0abba3cf2c41"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("13aeee2f-d1d5-4aec-9d39-13d2af1aacfc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("031ecd56-5eb4-4f0b-b743-179af385313e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("17fa8ba8-4ef4-402e-b2c4-424dbffc9cd2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1860c35b-bdb8-48ab-9bb5-263c6c9622e3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1a33e800-a826-4328-9745-4da2d6b69b0b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1adf4952-e0ea-4388-8090-5eb9f80695df"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2709ca46-18ce-4d91-95d0-da6771e0ea1a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("31303210-bacc-43e6-ac8a-dd178950c0e8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4066daf6-cff2-4fe0-a9b5-ca08b8ca5b61"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("674ff2cd-dfc5-409c-b133-6816d6c3c06a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6f322027-0725-42e9-9202-1982c1613a4c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("889b943c-3b7c-4fa1-99b3-a025e73cbcab"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("891a44c6-be2c-4463-8207-846d4c4a1884"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8b7e8e69-21f5-47af-8009-f7a2c2e2121a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("91dfba0d-8d3f-4ad1-9008-27fcf1f3e9bb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("951f1da2-42d5-4772-936d-e5cca9a51e6a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a013f576-4bc7-4008-af80-a647005e6254"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3a9abb3-116d-44ab-b428-410c156ab2a8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d05cadbb-b8c8-4e56-8546-22501a0584b4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d8f90a56-440f-4827-bfd4-0cab968a85ee"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("db4b2f14-845c-45a3-b227-6af1193f9854"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ef56f7a9-e494-47c1-9155-b24001b6504a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f2096d69-a53c-413f-934f-a3196363ebc3"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("fe35622f-2f6b-42d5-9d6f-37904d7205c8"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("84270cd8-d591-4f62-be1f-9b13bb38a85d"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("baa37821-3bb9-4852-9f32-de4ea70af927"), null, null, null, null, null, new DateTime(2021, 4, 30, 15, 37, 5, 768, DateTimeKind.Local).AddTicks(2553), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(8990), true, false, "Administradores", new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("d8dc7640-b192-4ab6-8ce8-1573591cf7b6"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6976), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("f402b4dd-b861-4231-9b13-2261c8561017"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("cd6ea415-a935-4eb1-9951-f157e817f9a8"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6930), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("7a7d7c86-7199-452b-afe9-542f09f2ef1f"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("29e4ca37-c678-48c5-9a64-6e50deabb0be"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6911), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("f082e31a-4414-442a-b0e8-b727a44886a6"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("a375e7e3-0d27-433a-98a3-c81ac70cdf07"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6891), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("6a5be953-e0ac-41bc-970d-669e62e83d6e"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("25461b9f-faab-4e1e-bece-dd2a220fa70e"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6871), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("6843a676-95da-4692-86b1-15f4d7f07069"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("94fe1c7d-5143-4338-b13c-c8ddffafacca"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6851), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("002be42d-5cf9-4afe-b0d8-6b4ec3c82729"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("6181819d-b35e-429e-83a5-f42ac8b64bec"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6833), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("590fbf44-9212-4d91-af40-3fa6d1b28974"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("338ee6e6-8330-42d0-960e-7cd6a2ee5150"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6814), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("f589fa84-3230-47c2-b091-069b3cf59a77"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("12c6092f-040b-4fc4-9d79-def89fe58b7f"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6796), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("8b4e60a7-2d9e-40ab-a306-e1474a232bb1"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("f800d729-f72e-4f9f-be61-6e6d38eed220"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6777), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("0ce936c1-a9c9-4f71-8be3-6ff4952b48d8"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("081b70c6-84c8-4e63-89e1-c01bdc9aee45"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6757), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("f8e75541-5799-4fb0-9e99-b3c26749cc25"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("add9c054-6ddd-4043-97ae-176c19089ca3"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6736), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("5ba00b62-0e4e-4bbd-a4e7-d8ae2ef7a68f"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("206380bf-cc8d-4bf8-b9e8-25f7d2b902cd"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6716), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("051e2a1a-b3ac-4b20-9570-873717d6ba48"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("823cfba2-fc1a-4dc6-9b6f-34049efb57e7"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6697), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("705b13a8-0fdf-4705-adb0-27ba696d97d8"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("ea739d2e-fc58-4b95-88d0-efe673becbfb"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6678), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("e5343522-2177-4076-a437-d7f306d78812"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("62d66292-f1f9-46ab-ad79-f2d387fd537f"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6659), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("c6ac8ed4-4448-4f18-8d1a-690694e59e38"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("6caecdd3-f1da-495c-a3a2-78fe43457d56"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6636), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("58f801c3-874f-48f2-aa84-a3ffa207180c"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("f66096d0-121f-4e7b-9fcf-d0d2ea467466"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6583), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("e615fc44-a0da-4b7c-b7a5-00db745e1694"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("dd7a0e06-7057-465a-b7f7-4ca0d54bfeb8"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6562), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("53ecb007-9686-4651-b5c4-740db3b69e38"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("35f5a353-b281-4dc4-816e-bd3b6d84ed54"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6528), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("bdc7e05a-0ac8-47ed-a5a4-7919c7f3bf70"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("90bb58d5-d7e3-4bb4-b33b-08a4c343c32b"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6291), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null },
                    { new Guid("1b857d7f-4c45-4f96-9d76-e4abad64df31"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(6996), new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("fe08a155-585c-46aa-af8d-cf0bfb47e888"), true, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("ab2efc3a-03f7-4a7a-b904-206039db406f"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(8049), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1a16b575-0e8a-45b1-a18c-5b775500c147"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(7939), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2198d503-9c30-4446-a9fc-e40456f30d02"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(6117), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("fe08a155-585c-46aa-af8d-cf0bfb47e888"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4171), null, "", true, false, "groupusers/details", new Guid("7a7d7c86-7199-452b-afe9-542f09f2ef1f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f402b4dd-b861-4231-9b13-2261c8561017"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4131), null, "", true, false, "groupusers/list", new Guid("7a7d7c86-7199-452b-afe9-542f09f2ef1f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7a7d7c86-7199-452b-afe9-542f09f2ef1f"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4091), null, "", true, false, "", new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f082e31a-4414-442a-b0e8-b727a44886a6"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4048), null, "", true, false, "systems/details", new Guid("6843a676-95da-4692-86b1-15f4d7f07069"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6a5be953-e0ac-41bc-970d-669e62e83d6e"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4003), null, "", true, false, "systems/list", new Guid("6843a676-95da-4692-86b1-15f4d7f07069"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6843a676-95da-4692-86b1-15f4d7f07069"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3930), null, "", true, false, "", new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("002be42d-5cf9-4afe-b0d8-6b4ec3c82729"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3887), null, "", true, false, "languages/details", new Guid("f589fa84-3230-47c2-b091-069b3cf59a77"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("590fbf44-9212-4d91-af40-3fa6d1b28974"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3843), null, "", true, false, "languages/list", new Guid("f589fa84-3230-47c2-b091-069b3cf59a77"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f589fa84-3230-47c2-b091-069b3cf59a77"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3801), null, "", true, false, "", new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8b4e60a7-2d9e-40ab-a306-e1474a232bb1"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3760), null, "", true, false, "clients/details", new Guid("f8e75541-5799-4fb0-9e99-b3c26749cc25"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ce936c1-a9c9-4f71-8be3-6ff4952b48d8"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3718), null, "", true, false, "clients/list", new Guid("f8e75541-5799-4fb0-9e99-b3c26749cc25"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ba00b62-0e4e-4bbd-a4e7-d8ae2ef7a68f"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3599), null, "", true, false, "menus/details", new Guid("705b13a8-0fdf-4705-adb0-27ba696d97d8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("051e2a1a-b3ac-4b20-9570-873717d6ba48"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3555), null, "", true, false, "menus/list", new Guid("705b13a8-0fdf-4705-adb0-27ba696d97d8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("705b13a8-0fdf-4705-adb0-27ba696d97d8"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3510), null, "", true, false, "", new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e5343522-2177-4076-a437-d7f306d78812"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3464), null, "", true, false, "users/details", new Guid("58f801c3-874f-48f2-aa84-a3ffa207180c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c6ac8ed4-4448-4f18-8d1a-690694e59e38"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3422), null, "", true, false, "users/list", new Guid("58f801c3-874f-48f2-aa84-a3ffa207180c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("58f801c3-874f-48f2-aa84-a3ffa207180c"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3369), null, "", true, false, "", new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e615fc44-a0da-4b7c-b7a5-00db745e1694"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3215), null, "", true, false, "companyoperators/details", new Guid("bdc7e05a-0ac8-47ed-a5a4-7919c7f3bf70"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53ecb007-9686-4651-b5c4-740db3b69e38"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3125), null, "", true, false, "companyoperators/list", new Guid("bdc7e05a-0ac8-47ed-a5a4-7919c7f3bf70"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bdc7e05a-0ac8-47ed-a5a4-7919c7f3bf70"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3032), null, "", true, false, "", new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(1467), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f8e75541-5799-4fb0-9e99-b3c26749cc25"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3669), null, "", true, false, "", new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(2640), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("3ea6269a-42bd-4bbd-9374-bcb9f618260a"), null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(8084), true, true, false, new Guid("ab2efc3a-03f7-4a7a-b904-206039db406f"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, null },
                    { new Guid("236e44fb-0375-4aaa-b18b-b34daae6f405"), null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(7682), true, true, false, new Guid("2198d503-9c30-4446-a9fc-e40456f30d02"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, null },
                    { new Guid("d6773292-527f-4d3d-b3b0-f2440976f3f2"), null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(8022), true, true, false, new Guid("1a16b575-0e8a-45b1-a18c-5b775500c147"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("dee54757-4302-42db-a06c-2b34456189cf"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3977), null, true, false, new Guid("6843a676-95da-4692-86b1-15f4d7f07069"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00e3f8a1-ad1c-4808-84e2-d0b4a1073885"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4150), null, true, false, new Guid("f402b4dd-b861-4231-9b13-2261c8561017"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("985edc29-dc65-4654-998b-151ad146b1b2"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4110), null, true, false, new Guid("7a7d7c86-7199-452b-afe9-542f09f2ef1f"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("86e72467-9f0e-4800-95bb-17d3196acd52"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4067), null, true, false, new Guid("f082e31a-4414-442a-b0e8-b727a44886a6"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("77697ec2-a69b-4010-9e69-3b1c3a285d60"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4025), null, true, false, new Guid("6a5be953-e0ac-41bc-970d-669e62e83d6e"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cb7c7018-25b9-4310-909e-6cbf8fa922e3"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3906), null, true, false, new Guid("002be42d-5cf9-4afe-b0d8-6b4ec3c82729"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e118987-1dbb-45a7-b1af-6d7e1c32d9e1"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3862), null, true, false, new Guid("590fbf44-9212-4d91-af40-3fa6d1b28974"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("80b49f94-b58b-4ebe-893b-2b381a2af753"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3822), null, true, false, new Guid("f589fa84-3230-47c2-b091-069b3cf59a77"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("956d55b0-43d5-43ee-a777-bb048aa09081"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3779), null, true, false, new Guid("8b4e60a7-2d9e-40ab-a306-e1474a232bb1"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ebf27874-7bbf-46ac-b52a-f10dd846c178"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3738), null, true, false, new Guid("0ce936c1-a9c9-4f71-8be3-6ff4952b48d8"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e85c7c16-a089-4d45-8faf-e11c963e30ad"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3689), null, true, false, new Guid("f8e75541-5799-4fb0-9e99-b3c26749cc25"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4460c2b3-97f2-4a58-9d86-fe1e8b678b2e"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3645), null, true, false, new Guid("5ba00b62-0e4e-4bbd-a4e7-d8ae2ef7a68f"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("41c27d34-f9dc-4ed8-a7b3-7ac82b73339f"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3577), null, true, false, new Guid("051e2a1a-b3ac-4b20-9570-873717d6ba48"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("007e67d2-bf63-4c55-9e51-970d634b763a"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3530), null, true, false, new Guid("705b13a8-0fdf-4705-adb0-27ba696d97d8"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f1433de-7215-4541-82a2-26667d04eff9"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3483), null, true, false, new Guid("e5343522-2177-4076-a437-d7f306d78812"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6d72cbe9-f079-436d-beaa-8d9f7139da73"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3442), null, true, false, new Guid("c6ac8ed4-4448-4f18-8d1a-690694e59e38"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ae5272f6-e406-48c2-8198-1310bcabb8d2"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3397), null, true, false, new Guid("58f801c3-874f-48f2-aa84-a3ffa207180c"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0c8e5a73-9528-4280-b10f-7760d579c0ce"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3238), null, true, false, new Guid("e615fc44-a0da-4b7c-b7a5-00db745e1694"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6f14e2cc-d295-4a68-a04c-d371721c9418"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3147), null, true, false, new Guid("53ecb007-9686-4651-b5c4-740db3b69e38"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e4bf619-8d70-4d85-b3bc-01c91d928447"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(3091), null, true, false, new Guid("bdc7e05a-0ac8-47ed-a5a4-7919c7f3bf70"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3038c6d3-830e-412a-a87b-cbaec1ca1f53"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(2576), null, true, false, new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f9aaa69-3baa-4427-ba0d-ac1f92f30a56"), null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(4190), null, true, false, new Guid("fe08a155-585c-46aa-af8d-cf0bfb47e888"), new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6a34e532-4633-497c-a1e4-60dac60f9a33"), null, new Guid("baa37821-3bb9-4852-9f32-de4ea70af927"), null, null, null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(9054), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("063d9ea6-8e17-4827-be65-0d87cbad62b9"), null, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(332), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("6a34e532-4633-497c-a1e4-60dac60f9a33"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11"), new Guid("baa37821-3bb9-4852-9f32-de4ea70af927"), null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(2088), null, new Guid("214cb56e-a070-4ade-86bb-44839d78836f"), true, false, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), new Guid("6a34e532-4633-497c-a1e4-60dac60f9a33"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("87e8c733-3b9c-41c0-a431-7f6959defbe6"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4621), null, true, false, new Guid("f402b4dd-b861-4231-9b13-2261c8561017"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("e70c8a32-03a9-4a5a-8b86-0fa96d082880"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4602), null, true, false, new Guid("7a7d7c86-7199-452b-afe9-542f09f2ef1f"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("535b684e-00af-49b9-8756-ed4f82233328"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4582), null, true, false, new Guid("f082e31a-4414-442a-b0e8-b727a44886a6"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("982d331d-fd96-4eb3-ad72-d5eee79c95c2"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4562), null, true, false, new Guid("6a5be953-e0ac-41bc-970d-669e62e83d6e"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("574311ab-e1d9-4517-bd6e-4c802db08b32"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4539), null, true, false, new Guid("6843a676-95da-4692-86b1-15f4d7f07069"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("a3df3e4a-9c0c-4eeb-b114-ce8c9e5d219f"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4517), null, true, false, new Guid("002be42d-5cf9-4afe-b0d8-6b4ec3c82729"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("d9d0a3c6-e48b-482f-a821-5a7a61a2c58a"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4498), null, true, false, new Guid("590fbf44-9212-4d91-af40-3fa6d1b28974"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("bea56bc4-0f72-4839-ba77-dd444307d97e"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4478), null, true, false, new Guid("f589fa84-3230-47c2-b091-069b3cf59a77"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("23f17532-a856-492e-9ec9-748328769f9a"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4458), null, true, false, new Guid("8b4e60a7-2d9e-40ab-a306-e1474a232bb1"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("4d51d9bf-a62b-4257-be69-313c5fbbc456"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4439), null, true, false, new Guid("0ce936c1-a9c9-4f71-8be3-6ff4952b48d8"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("8db50e2b-ed8f-45a2-89e7-c22319d749ef"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4641), null, true, false, new Guid("fe08a155-585c-46aa-af8d-cf0bfb47e888"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("35c6803b-a152-4eeb-8e32-1ccff7f3743a"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4398), null, true, false, new Guid("5ba00b62-0e4e-4bbd-a4e7-d8ae2ef7a68f"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("90f13cbf-2896-4d63-ae98-ae3f94f4cd8a"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4344), null, true, false, new Guid("051e2a1a-b3ac-4b20-9570-873717d6ba48"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("517d0007-6cb4-469c-958b-68b628ba3771"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4319), null, true, false, new Guid("705b13a8-0fdf-4705-adb0-27ba696d97d8"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("67e5a3d1-83b9-499f-bafc-e7171185b1b3"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4299), null, true, false, new Guid("e5343522-2177-4076-a437-d7f306d78812"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("90938758-8135-4393-bbce-f9182f10126d"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4278), null, true, false, new Guid("c6ac8ed4-4448-4f18-8d1a-690694e59e38"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("580fcf8f-9a73-4336-9dd3-9e9d0806ac51"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4255), null, true, false, new Guid("58f801c3-874f-48f2-aa84-a3ffa207180c"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("7484db8c-4485-4a8a-b74a-dcf36bdcdd4f"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4234), null, true, false, new Guid("e615fc44-a0da-4b7c-b7a5-00db745e1694"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("725f4d78-2c00-422c-b318-526e648223e2"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4211), null, true, false, new Guid("53ecb007-9686-4651-b5c4-740db3b69e38"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("053768b5-c619-4263-a481-49e9e0d72584"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4180), null, true, false, new Guid("bdc7e05a-0ac8-47ed-a5a4-7919c7f3bf70"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("c4d249c4-8a43-4d00-9e11-c1177369e7a2"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(3952), null, true, false, new Guid("4cbfc002-efac-4b76-afb9-0d4dfce512c9"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") },
                    { new Guid("9677c172-e111-432b-8b2b-4a4f0c16cd4b"), true, true, null, new DateTime(2021, 4, 30, 15, 37, 5, 772, DateTimeKind.Local).AddTicks(4419), null, true, false, new Guid("f8e75541-5799-4fb0-9e99-b3c26749cc25"), true, true, null, null, null, new Guid("190e13aa-2a6f-4f60-97e3-5195014b4f11") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("bdff09cf-a6b7-42a6-848b-d937cdd15bf5"), "usuário administrativo", null, new DateTime(2021, 4, 30, 15, 37, 5, 771, DateTimeKind.Local).AddTicks(7831), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9b4313b7-ab44-4dcc-b402-d921df62b95a"), new Guid("baa37821-3bb9-4852-9f32-de4ea70af927"), null, new DateTime(2021, 4, 30, 15, 37, 5, 770, DateTimeKind.Local).AddTicks(4295), null, true, false, new Guid("c4a65a8c-2fa5-469b-a6f2-fab725d2ec72"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
