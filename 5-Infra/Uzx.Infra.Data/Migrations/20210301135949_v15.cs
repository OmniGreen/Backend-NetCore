using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("57e67f20-879c-4830-83b6-de6063337e5c"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05239893-f52e-4bb3-936d-26d6c4c10241"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1ee4aa5d-4714-49c1-b34c-883e3c1664e0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("21b3a942-0cd8-4c6e-aff1-1234569ff976"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("245e454f-904e-40be-b1c0-c348db6edb5a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4096656b-df16-45c6-9a28-8fa86f5a5340"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4d7b9e5e-def1-45a5-b304-0be49056c2d8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4e1b2c6f-3a1e-4770-80ba-04b0fdb8c2e9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("69263d5a-f475-491e-a83a-4563d0e857ed"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7e4281c2-ab66-41a5-a1fe-1aa2bc1f19c4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8408e7cf-3444-4aa3-9d72-453ad8f0f4c6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("885c25b1-24b1-432c-a635-e085b8370259"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9ce35bc2-96d3-4144-9a4f-1dfc931bd5f3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9eec35ec-1f74-45cb-9c4d-45ec39e2f351"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a5526eda-1923-44cf-8768-967b439e81a1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("aee13dab-55bf-4b02-9782-d76c63de8dbc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c575494b-abbe-49d1-ba87-5231535865d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c9914482-5141-4d72-a71b-249079be6ec5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d1e3bee0-4040-4ee4-a6b5-a2e344648c20"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d4fd0c1b-a161-403f-8618-3404bb209341"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("df3c2ad6-597a-4cbc-9a61-af2b73f8205c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fef552e6-c514-4a78-bc87-c31ab6093026"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ffa152eb-1c47-479c-b3c0-8614357e699d"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("3a66f80a-c685-48f4-bed5-ba2c87dd7cd1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("65d3e4df-f4b0-4052-967b-84aeefcf3478"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("dd1bdef9-277e-4231-8bec-9521144ad818"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("61aaec20-111e-407d-b7c3-909adb57584d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b6352257-8e94-4907-b158-6872dbaedf58"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d2894634-91de-4fec-8058-e6395fee4d06"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("68ef487f-656d-47b7-8c28-dcc999f269d2"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("aa558ad5-dd29-4179-b420-4f34e21cfda2"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("ced8a8bc-3dd7-437a-9485-ba0a36191de0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("076002df-80c6-4efc-8888-89936006d946"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0be3fc51-5973-42f1-b27f-8168dfa3ba97"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("19797bae-0382-474b-a861-a33a5665017f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("24849eb1-97b7-4efc-ae7f-1856a5dc945e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2b9bd656-1e11-4924-8945-ae1c1a093b99"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("32787569-cef3-41c1-b4c3-48055babd87d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3ea091ae-1592-4834-a45d-253b1a8d5d55"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4a8766f3-387f-4e63-9d23-aee66c73e5d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5e69a354-d43b-43bb-a8cd-668932fcbde7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("60158115-b1c2-46ad-bb69-5ab373dc7edf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("907ac2cf-78e5-42bc-ad0b-68e5026572f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("92422c56-ee11-47fb-a27c-e888a9f7604b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9daa6ac0-93aa-4029-9756-755cc90f3b69"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a0d87b2c-b035-4f03-ac66-29ffcf301564"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a2f65e4d-d1fe-47ea-ae9d-e3e4b54f4615"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b7b032dc-15bc-4bf6-9083-bf5974731e45"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b82ceba9-f365-4949-83ce-b3e74a7c4cc6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bcf853d9-91d2-48f8-87e2-5c3b21e3c969"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("befffa5e-2002-41f3-b9b9-30becb405e88"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c8aa871e-c63e-4aa3-a233-1b2fca8d4cbf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e9f3bcf5-d30b-4d3c-9a56-5b4f3a3140ed"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f8b11550-deec-4e05-8621-fb83d3b53182"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("4e17dc11-2c34-454a-b95f-33e4e59907ca"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("5dd68006-3167-449c-85db-826ede251049"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("03955a04-b87f-4b31-a4a3-802d52da9a4f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("05aa5830-234c-4782-918c-31ff342c282d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0b5616b1-3829-4fc1-8ccb-83ba306f8390"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0eb2d8c6-1f0e-4a10-9a37-7ba399bf8cc4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0f6f0458-ee3f-450a-999b-f31988727754"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("53c15963-8fab-4d8e-8366-eae0075e24d5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("54fcac41-34c0-48ed-bf36-ac8ba27857b2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5ed26dff-18ba-4727-8cfa-c1e834eafff8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("619dff44-ecd3-4e01-aa03-8501a0d3b1e4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("74019d1a-9034-47b3-bbba-734dc7a0d6d1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7a07eead-8f23-4d5e-9d92-5c9138c141b6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7fb5d275-c301-48b9-80b5-14069e08faab"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("94e3d27d-123f-47ae-b7ec-b5b3acabe674"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("95bc1dd7-eaba-4fc6-b5b9-9ff1786dac16"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aa746fcf-41a3-4a63-b880-01474cdb7f41"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cec6005e-acd4-4306-be3a-2cacb196a846"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("dae6f319-a3cc-4f92-b817-9f6c0d9f0690"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e2705b11-725e-488c-af86-c5ee5f7f8110"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e3e8215b-f4fb-4b8b-8991-3462378d1288"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e61f97a8-3eb1-427a-9fb5-bc17594ad51c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e68600b4-521a-4639-b242-2c924a1f18f9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ee3328f0-59c3-41af-af0a-d1ceb52324bc"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("125e6d70-2a8a-45be-aebb-1707094dfa1d"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"));

            migrationBuilder.RenameColumn(
                name: "CustomersId",
                table: "Coupons",
                newName: "CustomerId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("7fa9fc57-11c3-4548-b05c-9a37796fe81a"), null, null, null, null, null, new DateTime(2021, 3, 1, 10, 59, 47, 43, DateTimeKind.Local).AddTicks(3633), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), null, new DateTime(2021, 3, 1, 10, 59, 47, 48, DateTimeKind.Local).AddTicks(2437), true, false, "Administradores", new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("cff123d4-d2ae-489a-beb8-d92566c1af8c"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2734), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("f921f220-0043-4bda-973e-ee87cddbe5ff"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("20ad4aca-1608-473e-bb12-e370c17e427c"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2694), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("6ebc8766-f183-47f5-bc6e-6d36a9c7d86b"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("3e3a12b7-740d-4596-b839-d4efe2443043"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2658), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("ded4b00e-b20b-4b04-be44-06ffd45b069b"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("20c0afa1-8844-4e80-bda0-00421fe59b46"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2622), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("129c05ff-094c-4253-9aa2-b9141ca7a0d2"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("302f868a-fdc8-4568-a7cc-da360005b503"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2580), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("1a6b8b74-b386-4361-aa03-b1238ff01d4c"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("20f773a7-988a-49e8-9dd2-2ddf6c024221"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2544), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("637fbab1-8a2f-4a6e-bc9c-7e5dfb5bd36b"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("bb502aaf-4b4e-4e38-9dab-beb042abcaa6"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2509), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("1b38f953-e6e9-4dba-8434-2c20af641a25"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("d3a1c969-f4c8-4f79-89d1-5497a07b6dcd"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2472), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("05291c60-1651-482a-805c-a16a4b7f67ba"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("ad531a14-dc13-4a61-8bc8-aaeb65c36a77"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2432), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("b721597a-3f6b-44ad-a92b-e8e2da6b6812"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("f6abd27a-ffed-464a-907b-7893499a6d7f"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2389), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("e2c5dda4-93f1-44b5-979f-3461689a1fe6"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("72be47ac-800a-4705-90d7-01f5097916d6"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2355), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("3f94a917-24d0-4fe9-a312-b9ac1d174ef8"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("ff589066-e62f-4e1c-a1c9-7b594bb86b6d"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2318), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("4a412c0e-c8b9-4221-af4b-b1f4e678367e"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("92317e09-6eec-4990-bb6a-193b8cdad1f3"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2275), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("cb12f404-1b9d-44b6-b42b-81b02cc6d705"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("1e3dbde6-9084-42a7-a975-622c2bbb5ee2"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2238), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("ec7b06d6-e0e5-468b-a231-d4638c7c9358"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("bc1d7534-8304-4cf4-851c-868349c556e5"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2197), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("939339d1-3993-46bd-a478-51b3fff48b9b"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("799a16c9-d317-43db-862a-1017c4267354"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2137), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("3b678c06-feca-4fc8-b0ab-92dbee1b33f9"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("4285aae9-c141-46f0-9cf7-799ac68debec"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(1880), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("ca759e5c-06bc-45d7-ad40-046332bce6be"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("2e911cea-5b30-403b-a9ca-042b50152c05"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(1835), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("badd0087-5116-44fc-93c1-b815d2f3bf5a"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("1f5eaaea-c318-4b28-a8b5-d8d3531f1484"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(1797), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("6d96b455-2889-40c5-8a73-e3a8e210d0de"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("89437e84-f780-46e4-b531-27626902a947"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(1730), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("f47801ab-a64c-466a-b5fb-458be103a310"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("93fdd6ee-7af9-4b43-97b3-58d4bcdc746d"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(1194), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null },
                    { new Guid("b52ffbd3-b761-4fbd-bd47-d566110b55b6"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(2853), new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("b7f47d1f-1d6f-4da1-84eb-a75321732d25"), true, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("55ea360d-de6d-4821-b405-5c78e7618af9"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 1, 10, 59, 47, 48, DateTimeKind.Local).AddTicks(521), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d919a624-3d5a-441b-bc3e-3c10534da403"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 1, 10, 59, 47, 48, DateTimeKind.Local).AddTicks(376), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("be76372a-c641-4e44-88d7-d4bec5f7d296"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 1, 10, 59, 47, 47, DateTimeKind.Local).AddTicks(6763), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("b7f47d1f-1d6f-4da1-84eb-a75321732d25"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4900), null, "", true, false, "groupusers/details", new Guid("6ebc8766-f183-47f5-bc6e-6d36a9c7d86b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f921f220-0043-4bda-973e-ee87cddbe5ff"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4820), null, "", true, false, "groupusers/list", new Guid("6ebc8766-f183-47f5-bc6e-6d36a9c7d86b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6ebc8766-f183-47f5-bc6e-6d36a9c7d86b"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4737), null, "", true, false, "", new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ded4b00e-b20b-4b04-be44-06ffd45b069b"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4654), null, "", true, false, "systems/details", new Guid("1a6b8b74-b386-4361-aa03-b1238ff01d4c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("129c05ff-094c-4253-9aa2-b9141ca7a0d2"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4567), null, "", true, false, "systems/list", new Guid("1a6b8b74-b386-4361-aa03-b1238ff01d4c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1a6b8b74-b386-4361-aa03-b1238ff01d4c"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4404), null, "", true, false, "", new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("637fbab1-8a2f-4a6e-bc9c-7e5dfb5bd36b"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4316), null, "", true, false, "languages/details", new Guid("05291c60-1651-482a-805c-a16a4b7f67ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1b38f953-e6e9-4dba-8434-2c20af641a25"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4236), null, "", true, false, "languages/list", new Guid("05291c60-1651-482a-805c-a16a4b7f67ba"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("05291c60-1651-482a-805c-a16a4b7f67ba"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4158), null, "", true, false, "", new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b721597a-3f6b-44ad-a92b-e8e2da6b6812"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4081), null, "", true, false, "clients/details", new Guid("3f94a917-24d0-4fe9-a312-b9ac1d174ef8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e2c5dda4-93f1-44b5-979f-3461689a1fe6"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4008), null, "", true, false, "clients/list", new Guid("3f94a917-24d0-4fe9-a312-b9ac1d174ef8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4a412c0e-c8b9-4221-af4b-b1f4e678367e"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3765), null, "", true, false, "menus/details", new Guid("ec7b06d6-e0e5-468b-a231-d4638c7c9358"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cb12f404-1b9d-44b6-b42b-81b02cc6d705"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3687), null, "", true, false, "menus/list", new Guid("ec7b06d6-e0e5-468b-a231-d4638c7c9358"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ec7b06d6-e0e5-468b-a231-d4638c7c9358"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3608), null, "", true, false, "", new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("939339d1-3993-46bd-a478-51b3fff48b9b"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3538), null, "", true, false, "users/details", new Guid("ca759e5c-06bc-45d7-ad40-046332bce6be"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b678c06-feca-4fc8-b0ab-92dbee1b33f9"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3467), null, "", true, false, "users/list", new Guid("ca759e5c-06bc-45d7-ad40-046332bce6be"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ca759e5c-06bc-45d7-ad40-046332bce6be"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3372), null, "", true, false, "", new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("badd0087-5116-44fc-93c1-b815d2f3bf5a"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(2973), null, "", true, false, "companyoperators/details", new Guid("f47801ab-a64c-466a-b5fb-458be103a310"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6d96b455-2889-40c5-8a73-e3a8e210d0de"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(2845), null, "", true, false, "companyoperators/list", new Guid("f47801ab-a64c-466a-b5fb-458be103a310"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f47801ab-a64c-466a-b5fb-458be103a310"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(2655), null, "", true, false, "", new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 1, 10, 59, 47, 48, DateTimeKind.Local).AddTicks(8252), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3f94a917-24d0-4fe9-a312-b9ac1d174ef8"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3841), null, "", true, false, "", new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 1, 10, 59, 47, 46, DateTimeKind.Local).AddTicks(8909), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("0d22e204-ea82-4fb7-b29c-7e2c05b29506"), null, new DateTime(2021, 3, 1, 10, 59, 47, 48, DateTimeKind.Local).AddTicks(555), true, true, false, new Guid("55ea360d-de6d-4821-b405-5c78e7618af9"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, null },
                    { new Guid("33441a4f-b9a6-4101-930a-de4f60e89b7c"), null, new DateTime(2021, 3, 1, 10, 59, 47, 48, DateTimeKind.Local).AddTicks(85), true, true, false, new Guid("be76372a-c641-4e44-88d7-d4bec5f7d296"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, null },
                    { new Guid("6bfd38a8-0898-4466-874f-a20cb464a6fb"), null, new DateTime(2021, 3, 1, 10, 59, 47, 48, DateTimeKind.Local).AddTicks(481), true, true, false, new Guid("d919a624-3d5a-441b-bc3e-3c10534da403"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("0e67c6a1-6d46-48e6-a616-4fad4ef793ad"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4446), null, true, false, new Guid("1a6b8b74-b386-4361-aa03-b1238ff01d4c"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3c9b6673-fe33-493b-ad81-0d8108bc0444"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4857), null, true, false, new Guid("f921f220-0043-4bda-973e-ee87cddbe5ff"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b4b181fe-0ff5-4cfa-a1fe-e83b23e81c90"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4775), null, true, false, new Guid("6ebc8766-f183-47f5-bc6e-6d36a9c7d86b"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a57ffe55-c7dc-4185-a91e-f04bbce3aa30"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4692), null, true, false, new Guid("ded4b00e-b20b-4b04-be44-06ffd45b069b"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f2e7b95f-ca21-4f2e-bb48-aa3c0f726e0c"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4609), null, true, false, new Guid("129c05ff-094c-4253-9aa2-b9141ca7a0d2"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a3d90d3b-35a0-4676-8777-f7afedacb708"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4355), null, true, false, new Guid("637fbab1-8a2f-4a6e-bc9c-7e5dfb5bd36b"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bb20927d-270f-43f8-b394-b16e10113248"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4274), null, true, false, new Guid("1b38f953-e6e9-4dba-8434-2c20af641a25"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ec6db21-5c64-458b-a902-10c617881f6f"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4194), null, true, false, new Guid("05291c60-1651-482a-805c-a16a4b7f67ba"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cf54316b-34a6-4dfc-9f41-718c5ec53417"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4118), null, true, false, new Guid("b721597a-3f6b-44ad-a92b-e8e2da6b6812"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("47009307-7984-4365-9d9a-2dfd0bf2541e"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4041), null, true, false, new Guid("e2c5dda4-93f1-44b5-979f-3461689a1fe6"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0e377bda-e33c-4edd-997b-384d6c441379"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3967), null, true, false, new Guid("3f94a917-24d0-4fe9-a312-b9ac1d174ef8"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46f87a46-c333-4fcd-bcc4-a3d8ad1605d5"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3799), null, true, false, new Guid("4a412c0e-c8b9-4221-af4b-b1f4e678367e"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0674cc5e-5ab4-46ed-83dc-9388b2a3da7c"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3724), null, true, false, new Guid("cb12f404-1b9d-44b6-b42b-81b02cc6d705"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3f88c84a-d574-4196-88cb-236bd13efe4c"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3641), null, true, false, new Guid("ec7b06d6-e0e5-468b-a231-d4638c7c9358"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5222c2c4-4db0-4ccd-80d2-a3f58577df01"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3571), null, true, false, new Guid("939339d1-3993-46bd-a478-51b3fff48b9b"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9f198991-8426-4df5-97a7-e9e99142a66b"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3501), null, true, false, new Guid("3b678c06-feca-4fc8-b0ab-92dbee1b33f9"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a9be92d3-4792-45f9-bd32-b5062d3a5c84"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3421), null, true, false, new Guid("ca759e5c-06bc-45d7-ad40-046332bce6be"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6677a40b-0fd2-4532-84d9-c6625d1f3885"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(3110), null, true, false, new Guid("badd0087-5116-44fc-93c1-b815d2f3bf5a"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ea42c941-3ebe-4ce2-aadb-2405efeecb23"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(2907), null, true, false, new Guid("6d96b455-2889-40c5-8a73-e3a8e210d0de"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6721cd26-123c-478e-9745-122eed87d79c"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(2771), null, true, false, new Guid("f47801ab-a64c-466a-b5fb-458be103a310"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c4dd6ac-4a43-486f-96b4-d30c8767de10"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(1497), null, true, false, new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e8a19643-b654-4715-b8c0-6de8d78ee936"), null, new DateTime(2021, 3, 1, 10, 59, 47, 49, DateTimeKind.Local).AddTicks(4937), null, true, false, new Guid("b7f47d1f-1d6f-4da1-84eb-a75321732d25"), new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9961c47e-c45e-48b3-8a94-5c6cce21b65d"), null, new Guid("7fa9fc57-11c3-4548-b05c-9a37796fe81a"), null, null, null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(8779), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("bff6c437-860e-4cb5-a855-b80ae8d56c06"), null, null, new DateTime(2021, 3, 1, 10, 59, 47, 51, DateTimeKind.Local).AddTicks(2561), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("9961c47e-c45e-48b3-8a94-5c6cce21b65d"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("921aab44-dede-4c93-89ba-c1866602e499"), new Guid("7fa9fc57-11c3-4548-b05c-9a37796fe81a"), null, new DateTime(2021, 3, 1, 10, 59, 47, 51, DateTimeKind.Local).AddTicks(6930), null, new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"), true, false, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), new Guid("9961c47e-c45e-48b3-8a94-5c6cce21b65d"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("094541e1-332b-442c-ac30-8f1af44fdc11"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(2043), null, true, false, new Guid("f921f220-0043-4bda-973e-ee87cddbe5ff"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("8b8cbbe7-e218-4a5c-801b-b47f1e77ceab"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(2013), null, true, false, new Guid("6ebc8766-f183-47f5-bc6e-6d36a9c7d86b"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("209bf91d-8637-4e8e-9002-e9287adc6541"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1982), null, true, false, new Guid("ded4b00e-b20b-4b04-be44-06ffd45b069b"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("3b7ef042-2313-425f-90a6-35d7bffc0089"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1949), null, true, false, new Guid("129c05ff-094c-4253-9aa2-b9141ca7a0d2"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("0addef06-d081-4b33-ac10-e0c74bca62c4"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1916), null, true, false, new Guid("1a6b8b74-b386-4361-aa03-b1238ff01d4c"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("83ef4d24-981e-467e-b92a-64dfe7fbdbe6"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1885), null, true, false, new Guid("637fbab1-8a2f-4a6e-bc9c-7e5dfb5bd36b"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("bc77edc9-5e12-4dca-abbe-a1bdd4d0c1b1"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1855), null, true, false, new Guid("1b38f953-e6e9-4dba-8434-2c20af641a25"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("8ddf2405-8150-49e7-91ee-d885e0773e32"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1825), null, true, false, new Guid("05291c60-1651-482a-805c-a16a4b7f67ba"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("714b5fb1-b5ae-43dd-a991-ae7e9073cc08"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1794), null, true, false, new Guid("b721597a-3f6b-44ad-a92b-e8e2da6b6812"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("713d3c30-1bbe-41c1-a7a0-18ee97e23dbc"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1762), null, true, false, new Guid("e2c5dda4-93f1-44b5-979f-3461689a1fe6"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("4fd15325-7610-4e72-9671-e2338db309c5"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(2073), null, true, false, new Guid("b7f47d1f-1d6f-4da1-84eb-a75321732d25"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("e1952838-643d-42e5-8f6a-0ceffd6bd4db"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1573), null, true, false, new Guid("4a412c0e-c8b9-4221-af4b-b1f4e678367e"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("ee786c74-7735-4f4f-bea7-ed5c16f73820"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1540), null, true, false, new Guid("cb12f404-1b9d-44b6-b42b-81b02cc6d705"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("d39da551-2425-4710-bfb4-8be4315933b7"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1509), null, true, false, new Guid("ec7b06d6-e0e5-468b-a231-d4638c7c9358"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("00edbc3f-59c8-4b8c-9563-2485674b5862"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1478), null, true, false, new Guid("939339d1-3993-46bd-a478-51b3fff48b9b"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("d210abc5-c251-457f-bb28-a932c60a5d31"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1448), null, true, false, new Guid("3b678c06-feca-4fc8-b0ab-92dbee1b33f9"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("ba2cbd33-ffd4-406b-9ffa-0ec1e671945c"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1413), null, true, false, new Guid("ca759e5c-06bc-45d7-ad40-046332bce6be"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("25bc5726-eb9d-4c4b-b865-2b92c133da6a"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1380), null, true, false, new Guid("badd0087-5116-44fc-93c1-b815d2f3bf5a"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("5a95d42b-9c35-47c6-9f12-c21d6b0886f6"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1346), null, true, false, new Guid("6d96b455-2889-40c5-8a73-e3a8e210d0de"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("9409868b-aef6-42be-9792-f209e111d41f"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1291), null, true, false, new Guid("f47801ab-a64c-466a-b5fb-458be103a310"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("684c9e5b-7ef6-47dc-98b8-f0e7c9bd2996"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(996), null, true, false, new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") },
                    { new Guid("fdaebaa8-70b0-4524-9ef1-911c1c675ed6"), true, true, null, new DateTime(2021, 3, 1, 10, 59, 47, 52, DateTimeKind.Local).AddTicks(1730), null, true, false, new Guid("3f94a917-24d0-4fe9-a312-b9ac1d174ef8"), true, true, null, null, null, new Guid("921aab44-dede-4c93-89ba-c1866602e499") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e26e4280-b23a-424a-b58b-3b856b6f0e57"), "usuário administrativo", null, new DateTime(2021, 3, 1, 10, 59, 47, 50, DateTimeKind.Local).AddTicks(5597), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("789714ab-df9c-43d6-8d44-9833936f00d7"), new Guid("7fa9fc57-11c3-4548-b05c-9a37796fe81a"), null, new DateTime(2021, 3, 1, 10, 59, 47, 47, DateTimeKind.Local).AddTicks(2356), null, true, false, new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("7fa9fc57-11c3-4548-b05c-9a37796fe81a"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("789714ab-df9c-43d6-8d44-9833936f00d7"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("955a38d5-a588-45bc-870c-d642d6d7b003"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1e3dbde6-9084-42a7-a975-622c2bbb5ee2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1f5eaaea-c318-4b28-a8b5-d8d3531f1484"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("20ad4aca-1608-473e-bb12-e370c17e427c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("20c0afa1-8844-4e80-bda0-00421fe59b46"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("20f773a7-988a-49e8-9dd2-2ddf6c024221"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2e911cea-5b30-403b-a9ca-042b50152c05"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("302f868a-fdc8-4568-a7cc-da360005b503"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3e3a12b7-740d-4596-b839-d4efe2443043"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4285aae9-c141-46f0-9cf7-799ac68debec"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("72be47ac-800a-4705-90d7-01f5097916d6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("799a16c9-d317-43db-862a-1017c4267354"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("89437e84-f780-46e4-b531-27626902a947"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("92317e09-6eec-4990-bb6a-193b8cdad1f3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("93fdd6ee-7af9-4b43-97b3-58d4bcdc746d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ad531a14-dc13-4a61-8bc8-aaeb65c36a77"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b52ffbd3-b761-4fbd-bd47-d566110b55b6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bb502aaf-4b4e-4e38-9dab-beb042abcaa6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bc1d7534-8304-4cf4-851c-868349c556e5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cff123d4-d2ae-489a-beb8-d92566c1af8c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d3a1c969-f4c8-4f79-89d1-5497a07b6dcd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f6abd27a-ffed-464a-907b-7893499a6d7f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ff589066-e62f-4e1c-a1c9-7b594bb86b6d"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("55ea360d-de6d-4821-b405-5c78e7618af9"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("be76372a-c641-4e44-88d7-d4bec5f7d296"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d919a624-3d5a-441b-bc3e-3c10534da403"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("05291c60-1651-482a-805c-a16a4b7f67ba"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("129c05ff-094c-4253-9aa2-b9141ca7a0d2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1a6b8b74-b386-4361-aa03-b1238ff01d4c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1b38f953-e6e9-4dba-8434-2c20af641a25"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("293c52fa-afcf-4e76-8efc-77c510c5be9d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3b678c06-feca-4fc8-b0ab-92dbee1b33f9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3f94a917-24d0-4fe9-a312-b9ac1d174ef8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4a412c0e-c8b9-4221-af4b-b1f4e678367e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("637fbab1-8a2f-4a6e-bc9c-7e5dfb5bd36b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6d96b455-2889-40c5-8a73-e3a8e210d0de"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6ebc8766-f183-47f5-bc6e-6d36a9c7d86b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("939339d1-3993-46bd-a478-51b3fff48b9b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b721597a-3f6b-44ad-a92b-e8e2da6b6812"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b7f47d1f-1d6f-4da1-84eb-a75321732d25"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("badd0087-5116-44fc-93c1-b815d2f3bf5a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ca759e5c-06bc-45d7-ad40-046332bce6be"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cb12f404-1b9d-44b6-b42b-81b02cc6d705"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ded4b00e-b20b-4b04-be44-06ffd45b069b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e2c5dda4-93f1-44b5-979f-3461689a1fe6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ec7b06d6-e0e5-468b-a231-d4638c7c9358"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f47801ab-a64c-466a-b5fb-458be103a310"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f921f220-0043-4bda-973e-ee87cddbe5ff"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("0d22e204-ea82-4fb7-b29c-7e2c05b29506"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("33441a4f-b9a6-4101-930a-de4f60e89b7c"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("6bfd38a8-0898-4466-874f-a20cb464a6fb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0674cc5e-5ab4-46ed-83dc-9388b2a3da7c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0e377bda-e33c-4edd-997b-384d6c441379"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0e67c6a1-6d46-48e6-a616-4fad4ef793ad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0ec6db21-5c64-458b-a902-10c617881f6f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3c9b6673-fe33-493b-ad81-0d8108bc0444"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3f88c84a-d574-4196-88cb-236bd13efe4c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("46f87a46-c333-4fcd-bcc4-a3d8ad1605d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("47009307-7984-4365-9d9a-2dfd0bf2541e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4c4dd6ac-4a43-486f-96b4-d30c8767de10"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5222c2c4-4db0-4ccd-80d2-a3f58577df01"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6677a40b-0fd2-4532-84d9-c6625d1f3885"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6721cd26-123c-478e-9745-122eed87d79c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9f198991-8426-4df5-97a7-e9e99142a66b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a3d90d3b-35a0-4676-8777-f7afedacb708"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a57ffe55-c7dc-4185-a91e-f04bbce3aa30"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a9be92d3-4792-45f9-bd32-b5062d3a5c84"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b4b181fe-0ff5-4cfa-a1fe-e83b23e81c90"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bb20927d-270f-43f8-b394-b16e10113248"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cf54316b-34a6-4dfc-9f41-718c5ec53417"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e8a19643-b654-4715-b8c0-6de8d78ee936"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ea42c941-3ebe-4ce2-aadb-2405efeecb23"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f2e7b95f-ca21-4f2e-bb48-aa3c0f726e0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9961c47e-c45e-48b3-8a94-5c6cce21b65d"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("bff6c437-860e-4cb5-a855-b80ae8d56c06"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("921aab44-dede-4c93-89ba-c1866602e499"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("00edbc3f-59c8-4b8c-9563-2485674b5862"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("094541e1-332b-442c-ac30-8f1af44fdc11"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0addef06-d081-4b33-ac10-e0c74bca62c4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("209bf91d-8637-4e8e-9002-e9287adc6541"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("25bc5726-eb9d-4c4b-b865-2b92c133da6a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3b7ef042-2313-425f-90a6-35d7bffc0089"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4fd15325-7610-4e72-9671-e2338db309c5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5a95d42b-9c35-47c6-9f12-c21d6b0886f6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("684c9e5b-7ef6-47dc-98b8-f0e7c9bd2996"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("713d3c30-1bbe-41c1-a7a0-18ee97e23dbc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("714b5fb1-b5ae-43dd-a991-ae7e9073cc08"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("83ef4d24-981e-467e-b92a-64dfe7fbdbe6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8b8cbbe7-e218-4a5c-801b-b47f1e77ceab"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8ddf2405-8150-49e7-91ee-d885e0773e32"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9409868b-aef6-42be-9792-f209e111d41f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ba2cbd33-ffd4-406b-9ffa-0ec1e671945c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bc77edc9-5e12-4dca-abbe-a1bdd4d0c1b1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d210abc5-c251-457f-bb28-a932c60a5d31"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d39da551-2425-4710-bfb4-8be4315933b7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e1952838-643d-42e5-8f6a-0ceffd6bd4db"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ee786c74-7735-4f4f-bea7-ed5c16f73820"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fdaebaa8-70b0-4524-9ef1-911c1c675ed6"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("e26e4280-b23a-424a-b58b-3b856b6f0e57"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("b56510ab-88c4-4c3a-932b-9dc365ac453d"));

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Coupons",
                newName: "CustomersId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, null, null, null, null, new DateTime(2021, 2, 27, 19, 41, 10, 559, DateTimeKind.Local).AddTicks(8353), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(5914), true, false, "Administradores", new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("a5526eda-1923-44cf-8768-967b439e81a1"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7234), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("69263d5a-f475-491e-a83a-4563d0e857ed"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7139), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("9eec35ec-1f74-45cb-9c4d-45ec39e2f351"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7097), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("df3c2ad6-597a-4cbc-9a61-af2b73f8205c"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7059), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("aee13dab-55bf-4b02-9782-d76c63de8dbc"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7017), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("ffa152eb-1c47-479c-b3c0-8614357e699d"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6980), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("d1e3bee0-4040-4ee4-a6b5-a2e344648c20"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6943), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("c9914482-5141-4d72-a71b-249079be6ec5"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6906), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("d4fd0c1b-a161-403f-8618-3404bb209341"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6870), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("8408e7cf-3444-4aa3-9d72-453ad8f0f4c6"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6835), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("9ce35bc2-96d3-4144-9a4f-1dfc931bd5f3"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6796), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("4096656b-df16-45c6-9a28-8fa86f5a5340"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6760), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("4e1b2c6f-3a1e-4770-80ba-04b0fdb8c2e9"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6721), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("fef552e6-c514-4a78-bc87-c31ab6093026"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6684), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("885c25b1-24b1-432c-a635-e085b8370259"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6646), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("245e454f-904e-40be-b1c0-c348db6edb5a"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6607), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("4d7b9e5e-def1-45a5-b304-0be49056c2d8"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6560), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("c575494b-abbe-49d1-ba87-5231535865d5"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6430), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("1ee4aa5d-4714-49c1-b34c-883e3c1664e0"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6378), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("7e4281c2-ab66-41a5-a1fe-1aa2bc1f19c4"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6308), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("05239893-f52e-4bb3-936d-26d6c4c10241"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(5770), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("21b3a942-0cd8-4c6e-aff1-1234569ff976"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7273), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("65d3e4df-f4b0-4052-967b-84aeefcf3478"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3564), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3a66f80a-c685-48f4-bed5-ba2c87dd7cd1"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3290), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dd1bdef9-277e-4231-8bec-9521144ad818"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 27, 19, 41, 10, 563, DateTimeKind.Local).AddTicks(7721), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9120), null, "", true, false, "groupusers/details", new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9051), null, "", true, false, "groupusers/list", new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8981), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8906), null, "", true, false, "systems/details", new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8832), null, "", true, false, "systems/list", new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8691), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8605), null, "", true, false, "languages/details", new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8530), null, "", true, false, "languages/list", new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8455), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8382), null, "", true, false, "clients/details", new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8304), null, "", true, false, "clients/list", new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7981), null, "", true, false, "menus/details", new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7897), null, "", true, false, "menus/list", new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7817), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7743), null, "", true, false, "users/details", new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7664), null, "", true, false, "users/list", new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7559), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7298), null, "", true, false, "companyoperators/details", new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7107), null, "", true, false, "companyoperators/list", new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(6931), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(2540), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8191), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 27, 19, 41, 10, 562, DateTimeKind.Local).AddTicks(7189), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("68ef487f-656d-47b7-8c28-dcc999f269d2"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3634), true, true, false, new Guid("65d3e4df-f4b0-4052-967b-84aeefcf3478"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null },
                    { new Guid("aa558ad5-dd29-4179-b420-4f34e21cfda2"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(2588), true, true, false, new Guid("dd1bdef9-277e-4231-8bec-9521144ad818"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null },
                    { new Guid("ced8a8bc-3dd7-437a-9485-ba0a36191de0"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3487), true, true, false, new Guid("3a66f80a-c685-48f4-bed5-ba2c87dd7cd1"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("2b9bd656-1e11-4924-8945-ae1c1a093b99"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8788), null, true, false, new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a2f65e4d-d1fe-47ea-ae9d-e3e4b54f4615"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9083), null, true, false, new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5e69a354-d43b-43bb-a8cd-668932fcbde7"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9012), null, true, false, new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("19797bae-0382-474b-a861-a33a5665017f"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8941), null, true, false, new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("907ac2cf-78e5-42bc-ad0b-68e5026572f2"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8865), null, true, false, new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c8aa871e-c63e-4aa3-a233-1b2fca8d4cbf"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8643), null, true, false, new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24849eb1-97b7-4efc-ae7f-1856a5dc945e"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8566), null, true, false, new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0d87b2c-b035-4f03-ac66-29ffcf301564"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8491), null, true, false, new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("befffa5e-2002-41f3-b9b9-30becb405e88"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8415), null, true, false, new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b82ceba9-f365-4949-83ce-b3e74a7c4cc6"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8339), null, true, false, new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b7b032dc-15bc-4bf6-9083-bf5974731e45"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8230), null, true, false, new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f8b11550-deec-4e05-8621-fb83d3b53182"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8138), null, true, false, new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9daa6ac0-93aa-4029-9756-755cc90f3b69"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7938), null, true, false, new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bcf853d9-91d2-48f8-87e2-5c3b21e3c969"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7851), null, true, false, new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("076002df-80c6-4efc-8888-89936006d946"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7778), null, true, false, new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("32787569-cef3-41c1-b4c3-48055babd87d"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7701), null, true, false, new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4a8766f3-387f-4e63-9d23-aee66c73e5d5"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7604), null, true, false, new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92422c56-ee11-47fb-a27c-e888a9f7604b"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7348), null, true, false, new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e9f3bcf5-d30b-4d3c-9a56-5b4f3a3140ed"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7144), null, true, false, new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60158115-b1c2-46ad-bb69-5ab373dc7edf"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7046), null, true, false, new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ea091ae-1592-4834-a45d-253b1a8d5d55"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(5864), null, true, false, new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0be3fc51-5973-42f1-b27f-8168dfa3ba97"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9153), null, true, false, new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"), null, new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, null, null, new DateTime(2021, 2, 27, 19, 41, 10, 567, DateTimeKind.Local).AddTicks(2530), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("4e17dc11-2c34-454a-b95f-33e4e59907ca"), null, null, new DateTime(2021, 2, 27, 19, 41, 10, 567, DateTimeKind.Local).AddTicks(5957), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5dd68006-3167-449c-85db-826ede251049"), new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, new DateTime(2021, 2, 27, 19, 41, 10, 567, DateTimeKind.Local).AddTicks(9477), null, new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("74019d1a-9034-47b3-bbba-734dc7a0d6d1"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4212), null, true, false, new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("7a07eead-8f23-4d5e-9d92-5c9138c141b6"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4190), null, true, false, new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e2705b11-725e-488c-af86-c5ee5f7f8110"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4167), null, true, false, new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("dae6f319-a3cc-4f92-b817-9f6c0d9f0690"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4144), null, true, false, new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("03955a04-b87f-4b31-a4a3-802d52da9a4f"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4117), null, true, false, new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("7fb5d275-c301-48b9-80b5-14069e08faab"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4094), null, true, false, new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("0eb2d8c6-1f0e-4a10-9a37-7ba399bf8cc4"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4072), null, true, false, new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("95bc1dd7-eaba-4fc6-b5b9-9ff1786dac16"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4050), null, true, false, new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("ee3328f0-59c3-41af-af0a-d1ceb52324bc"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4028), null, true, false, new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("94e3d27d-123f-47ae-b7ec-b5b3acabe674"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4006), null, true, false, new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("53c15963-8fab-4d8e-8366-eae0075e24d5"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4235), null, true, false, new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("05aa5830-234c-4782-918c-31ff342c282d"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3959), null, true, false, new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("0f6f0458-ee3f-450a-999b-f31988727754"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3833), null, true, false, new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("54fcac41-34c0-48ed-bf36-ac8ba27857b2"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3811), null, true, false, new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e68600b4-521a-4639-b242-2c924a1f18f9"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3788), null, true, false, new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("619dff44-ecd3-4e01-aa03-8501a0d3b1e4"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3765), null, true, false, new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e3e8215b-f4fb-4b8b-8991-3462378d1288"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3738), null, true, false, new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("cec6005e-acd4-4306-be3a-2cacb196a846"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3714), null, true, false, new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("aa746fcf-41a3-4a63-b880-01474cdb7f41"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3688), null, true, false, new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("5ed26dff-18ba-4727-8cfa-c1e834eafff8"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3649), null, true, false, new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e61f97a8-3eb1-427a-9fb5-bc17594ad51c"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3367), null, true, false, new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("0b5616b1-3829-4fc1-8ccb-83ba306f8390"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3983), null, true, false, new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("125e6d70-2a8a-45be-aebb-1707094dfa1d"), "usuário administrativo", null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(9544), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("57e67f20-879c-4830-83b6-de6063337e5c"), new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, new DateTime(2021, 2, 27, 19, 41, 10, 563, DateTimeKind.Local).AddTicks(1880), null, true, false, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
