using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("1107a351-d2f5-4aab-ada5-b34855618b3c"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("87814197-6f34-49b3-88b4-c4edfa87b77d"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("13855c76-e390-4d51-bfc9-ef87de5e02e3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1f65486b-3cc5-4025-aee1-8c86c1f0800d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("20edec13-710f-40c1-b2dc-026fea210996"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("434e07c0-a8fe-4564-bfbd-240f8f16eb88"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("47fda49b-a388-4160-a2a4-25cfd8ec1b71"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("59e3215f-c56e-4db4-baca-86fbd14e34c1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7a903f1b-d443-47dd-8634-965dabc2fc5f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7f8b7feb-a12a-489f-8947-a3da76001432"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("80bf10f4-8681-400f-90e8-753eec4ec9fa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("82b4723f-5bb3-420f-bbde-56ff83f255e4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8a7319bb-d4b7-447c-b438-6309b7184ef5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8e06fa14-35fc-4c38-937f-ec113368d87e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8eb7bb92-0445-4700-935c-ffe4fcad4543"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("928cce97-5402-4dcc-a29f-72465325c3e8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("96186092-a859-4d12-b3a9-9091639bd76c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ab38ef97-96b8-4b61-863a-edd0b54e25bc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("aca63e77-b79f-4d9a-acfd-13d0459a5bb6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("badaeab8-4f0f-4709-b1cf-a0ecfce6e401"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c952ad0d-8e55-41a4-9a2a-c9f885787dd9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("caf4b8b8-d386-49f5-9ab9-90d59e8389de"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e186a01d-d989-4c17-869d-2042ec1add70"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e6ca6c9e-2737-4b3b-8868-7de847ca2116"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4b5aade3-109c-42c0-ae91-b2f2c33d328c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c717ca1b-6813-4261-8321-4f271fe579cd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("fc5c81c2-55db-4a2b-ab18-c52f8aea8f09"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("037d0a5d-110f-4210-b1a0-3aa7f4819b9d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("12c7216d-fd53-48b4-86e9-a61e15a20068"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2250a853-26a6-4f06-aa28-f9d63bfc4ccd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("280ce9f8-c73d-47b9-96bc-e5592852dccf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("28c9909a-92c8-4fcf-82f7-8c00ddc54b3a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("35ae2102-a8da-4c64-9620-97fa00a2aa30"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("41e71583-3c51-4749-92c0-4048eb9fd065"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4f2cfff6-3e7d-4440-a2db-dac3f46806d3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("51dda023-7491-43ec-9676-14e0551b07c1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("60c19722-1f8f-42cd-9f53-16fcf88233e5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6ac5383c-ac80-405e-950f-42835f1127ec"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6cea4afd-478e-4519-8d5a-457d91204520"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6f35e1a5-719d-4e04-9e72-d43202520652"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("71fbcfbf-d30e-43ec-911f-17f7f1ee0754"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9fd67d94-656f-484d-be74-d0f0391b0ae0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a5dfb391-b061-4309-b55d-9e931c877bf0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bd4c3795-779e-4979-835c-5a3708e35b7e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ced51269-e1ad-4b62-a4d4-7e48e7e683b5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d9314324-5a4c-4d84-b0cd-a915ab6417cc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e2c8f188-22f9-4ea3-b721-a328db9f935f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e5d28bb3-3069-476a-813e-f34de1e0afc1"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("26e499b4-559f-4907-b9a4-7c51b1c09e26"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("693b1330-6714-4b8a-aa0d-e50571a38d3f"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("a89411c2-6e47-43a3-a455-ceadfe212cb9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0d78c02d-ebb0-4837-94b0-2d489cade6c7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("29b1d136-740a-47aa-ab25-6955cd5d7a86"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2e37c35c-e971-44dc-b9b5-2ef531fd008a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("31479f0d-f062-4121-82f9-8c0c385e1605"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("33ed49a3-5e07-4862-a51a-d07569483df5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("35565a9a-8ad6-42aa-8b93-7d7c63bad084"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("57d85fb9-cfe6-4b95-9ddd-4009b10d2215"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5b7d27de-0207-4d25-9366-bb007edf4f99"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5e816511-b61f-49a0-95ef-b492c64663bf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("73103a4d-47d9-4894-8ac9-a625473aba45"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8b2c77c2-ebff-4a7b-a077-f7490c2a5f39"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8bf8f1e8-ca8a-4ce2-8e73-ba7ff4311b8d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b949e98f-45c4-4df9-bb36-648b8310a47e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c66898d7-f43a-459b-932e-1ef2f3d72f7d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c6eeb7d0-171b-470a-9855-bab89e60a47a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c7405a2f-7b77-4f6f-a626-1fa6ff030b3d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cdd3f637-eb8e-4e7a-8a0a-ef753b8f4764"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dc10bc85-4755-4e73-a037-ad60a1a6e31c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ed18fb13-f161-41ac-b364-a877077ddd4c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f81742f5-0cab-4239-a1ea-f5dd50f2bda4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f932670d-eef5-4b63-86b2-dbbcba5f35a7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fa09557d-10e0-4a8c-a755-26232a5ea088"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e04e7568-ca1e-4c94-afa5-bd2e6d59a612"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("766a1a1e-ae81-4c8c-a4fc-0ce179ecc85d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("f9cee36a-7290-4798-8931-2e66369315e9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("03a6b329-be34-4513-9597-f26f0a961ba6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("142a52df-71b7-4155-a345-f691cbfb8b1f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("33799918-718f-4a18-9716-e9a9f43c6f61"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("388e00a9-4811-4647-80fb-913d71120cb1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4ced212f-be5c-477c-be03-7a1bc53f4166"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5235e499-c0aa-4856-87ca-a5ca2ae12059"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("64da69cc-d1aa-4dc3-9201-061643f11e52"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6605b06d-a062-44a6-af3b-6ecc40dd39d5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("679f6c48-2a7a-490a-a142-cbc2004a50ce"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("68b31cab-f207-4c28-baae-533524b33ead"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("78c3e6da-c315-4497-b269-acf7a49a4696"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9c85bb35-b2cb-4ce6-8847-304028cdbffa"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9d955e0d-d04c-400c-a0f7-391b6497273f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a35e7620-10fc-4859-b3c0-7aa371bd83b5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a54d1895-b372-4485-b2e8-c54144b13b51"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("acbef693-d732-4dda-aef4-055da7fc25c3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c3882c23-5b11-46d1-a3d2-040738df59b1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c47ac3c3-1f38-467d-bd5e-57a31374bbe3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c7605a6a-7415-4abf-ab60-2c54fedc6a2a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d77c9d69-da6c-4f3b-8af0-2edc424894be"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("de6174a5-c058-41bb-aa54-7043e18128a5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e983a141-6706-40bd-8c69-716004192bd1"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("37e413aa-e8f8-4a92-bb5b-7b1e9e53223a"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"));

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("74b1d30d-f3af-4c38-9fff-c7298ceeadcb"), null, null, null, null, null, new DateTime(2021, 2, 23, 16, 7, 16, 734, DateTimeKind.Local).AddTicks(3635), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), null, new DateTime(2021, 2, 23, 16, 7, 16, 741, DateTimeKind.Local).AddTicks(3361), true, false, "Administradores", new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("5c5053ec-4270-4c03-91c6-f46e58403e7f"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(9143), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("f746312b-dc8e-43b4-9efc-dee00d8d4131"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("708096d1-67e1-4687-a9aa-b40e68a8ffeb"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(9104), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("09e83632-8a16-48d2-b542-375586d07ff0"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("32eb5c13-1e19-4f8a-9563-52e99d0343e1"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(9061), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("9c8d30cc-e7de-4523-823f-83a85d4a7890"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("28710ffd-b141-4a03-a241-a3d8e89075fc"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(9015), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("34bc2664-d86e-47a6-8935-a8d947a2125f"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("5969b534-d156-452d-8757-21c56eac52e8"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8963), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("bc53fb5f-cd66-496a-9f06-ad01297f3396"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("926c30f2-f4a9-4227-b7a6-d144ab9016f9"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8923), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("f2ac4c31-9a04-45b1-8268-db69af5354dd"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("b82a7d80-00af-40a3-aebc-b0dee9687713"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8885), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("59f3d793-acd9-4da9-b057-baf48baf36c7"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("7ae674e7-822c-4a80-af99-ff8aabe253f0"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8846), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("524732c4-596e-4501-b4d8-44a24bbb8af0"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("fe87c2e8-fc0c-4c06-a30c-dab92ff0a399"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8803), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("06c1dd5e-9358-4216-abb3-211f51d51de5"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("84808837-e863-4c22-8e62-a5f31055e003"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8761), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("480a4641-1d95-48d8-8516-35c404a4f52e"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("d7ece60e-95d8-45f3-a002-25cfb4be41e7"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8718), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("c5bc7601-1219-4255-8e03-dc1ee87a7d43"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("ce61a802-1d91-4ccf-84fe-9502d72afdff"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8668), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("3733191b-75ca-4232-b070-9ada37f3701e"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("e2bd5686-e35e-441c-8b7e-f704b97b1da7"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8625), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("9b67a5c1-ea1d-4a0d-9454-85ecae2a280e"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("397ef0f5-a25a-46d6-a802-6f8da7451dd0"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8582), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("4c3593c6-a8d1-4517-9946-e80b480fc4e1"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("edd4de10-3811-4b7b-a93c-0efc760668b4"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8542), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("39c536a2-f600-4391-8603-502e1cf1db76"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("08a78220-bf90-4dbd-a38e-d1191d7defbb"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8502), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("c16cb4f2-7fb4-41c8-b4f2-ab97000331ec"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("2d3919a8-de4a-4ed2-a8d5-7b2f70c71c5e"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8453), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("1f08d74a-750a-4304-853e-82b101351da8"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("5d7cc47b-6025-4a27-976a-d583761e779a"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8412), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("3a710774-e170-4db5-bcc2-01d39761cfd9"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("0738b3a1-5650-4dea-80c4-992fb30685ef"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8362), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("433f31c4-a4d5-4eee-8b37-fece785e0d07"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("3a1b9cce-98ec-4e11-9fbc-011cda06f9bf"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(8269), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("bd563b04-6a90-45cb-9ecc-0d59554291d1"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("d6d4ed69-9066-4996-9fc5-8a20c5becd7e"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(7422), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null },
                    { new Guid("055fe50d-942e-4956-ba4c-c4d8f00696f7"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 743, DateTimeKind.Local).AddTicks(9183), new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("db4d0e8f-d73b-4c16-a3dc-5d8320a04a7e"), true, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("2493747f-9b0c-403c-9871-e10bcae4a39f"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 23, 16, 7, 16, 741, DateTimeKind.Local).AddTicks(408), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef53f48f-35a6-4912-af86-93140b98f45d"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 23, 16, 7, 16, 741, DateTimeKind.Local).AddTicks(114), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("17f38d84-3930-407f-a468-aea68d8755a8"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 23, 16, 7, 16, 740, DateTimeKind.Local).AddTicks(4039), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("db4d0e8f-d73b-4c16-a3dc-5d8320a04a7e"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9290), null, "", true, false, "groupusers/details", new Guid("09e83632-8a16-48d2-b542-375586d07ff0"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f746312b-dc8e-43b4-9efc-dee00d8d4131"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9204), null, "", true, false, "groupusers/list", new Guid("09e83632-8a16-48d2-b542-375586d07ff0"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("09e83632-8a16-48d2-b542-375586d07ff0"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9119), null, "", true, false, "", new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c8d30cc-e7de-4523-823f-83a85d4a7890"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9028), null, "", true, false, "systems/details", new Guid("bc53fb5f-cd66-496a-9f06-ad01297f3396"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("34bc2664-d86e-47a6-8935-a8d947a2125f"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8934), null, "", true, false, "systems/list", new Guid("bc53fb5f-cd66-496a-9f06-ad01297f3396"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bc53fb5f-cd66-496a-9f06-ad01297f3396"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8833), null, "", true, false, "", new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f2ac4c31-9a04-45b1-8268-db69af5354dd"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8730), null, "", true, false, "languages/details", new Guid("524732c4-596e-4501-b4d8-44a24bbb8af0"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("59f3d793-acd9-4da9-b057-baf48baf36c7"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8637), null, "", true, false, "languages/list", new Guid("524732c4-596e-4501-b4d8-44a24bbb8af0"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("524732c4-596e-4501-b4d8-44a24bbb8af0"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8549), null, "", true, false, "", new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("06c1dd5e-9358-4216-abb3-211f51d51de5"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8463), null, "", true, false, "clients/details", new Guid("c5bc7601-1219-4255-8e03-dc1ee87a7d43"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("480a4641-1d95-48d8-8516-35c404a4f52e"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8372), null, "", true, false, "clients/list", new Guid("c5bc7601-1219-4255-8e03-dc1ee87a7d43"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3733191b-75ca-4232-b070-9ada37f3701e"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8143), null, "", true, false, "menus/details", new Guid("4c3593c6-a8d1-4517-9946-e80b480fc4e1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9b67a5c1-ea1d-4a0d-9454-85ecae2a280e"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8042), null, "", true, false, "menus/list", new Guid("4c3593c6-a8d1-4517-9946-e80b480fc4e1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c3593c6-a8d1-4517-9946-e80b480fc4e1"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7949), null, "", true, false, "", new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("39c536a2-f600-4391-8603-502e1cf1db76"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7854), null, "", true, false, "users/details", new Guid("1f08d74a-750a-4304-853e-82b101351da8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c16cb4f2-7fb4-41c8-b4f2-ab97000331ec"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7763), null, "", true, false, "users/list", new Guid("1f08d74a-750a-4304-853e-82b101351da8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f08d74a-750a-4304-853e-82b101351da8"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7662), null, "", true, false, "", new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3a710774-e170-4db5-bcc2-01d39761cfd9"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7373), null, "", true, false, "companyoperators/details", new Guid("bd563b04-6a90-45cb-9ecc-0d59554291d1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("433f31c4-a4d5-4eee-8b37-fece785e0d07"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7263), null, "", true, false, "companyoperators/list", new Guid("bd563b04-6a90-45cb-9ecc-0d59554291d1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bd563b04-6a90-45cb-9ecc-0d59554291d1"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7014), null, "", true, false, "", new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(1204), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5bc7601-1219-4255-8e03-dc1ee87a7d43"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8265), null, "", true, false, "", new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 23, 16, 7, 16, 739, DateTimeKind.Local).AddTicks(251), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("da551669-3855-466a-93ab-57cda98d6e72"), null, new DateTime(2021, 2, 23, 16, 7, 16, 741, DateTimeKind.Local).AddTicks(502), true, true, false, new Guid("2493747f-9b0c-403c-9871-e10bcae4a39f"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, null },
                    { new Guid("064adca3-2408-46fb-a568-fcd98788e9f5"), null, new DateTime(2021, 2, 23, 16, 7, 16, 740, DateTimeKind.Local).AddTicks(9434), true, true, false, new Guid("17f38d84-3930-407f-a468-aea68d8755a8"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, null },
                    { new Guid("36a15a65-0ad9-43d1-b3bb-ac7caeea14d6"), null, new DateTime(2021, 2, 23, 16, 7, 16, 741, DateTimeKind.Local).AddTicks(324), true, true, false, new Guid("ef53f48f-35a6-4912-af86-93140b98f45d"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f30d5277-5039-4d86-a0fe-694e912007f1"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8877), null, true, false, new Guid("bc53fb5f-cd66-496a-9f06-ad01297f3396"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e398b93e-2217-45c6-98aa-bc533da9620c"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9246), null, true, false, new Guid("f746312b-dc8e-43b4-9efc-dee00d8d4131"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9927e0aa-3491-4026-a9b9-26e770bfff90"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9158), null, true, false, new Guid("09e83632-8a16-48d2-b542-375586d07ff0"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("12850735-f65b-4e6a-965d-c67ff5f05c83"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9068), null, true, false, new Guid("9c8d30cc-e7de-4523-823f-83a85d4a7890"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cf82903b-c320-4ced-99fa-5d4b56ad947d"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8978), null, true, false, new Guid("34bc2664-d86e-47a6-8935-a8d947a2125f"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e8b11920-02e2-4fe9-95ef-51339c62c4e2"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8775), null, true, false, new Guid("f2ac4c31-9a04-45b1-8268-db69af5354dd"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("746c2dd1-3fb2-4cab-8ede-383b4931570c"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8678), null, true, false, new Guid("59f3d793-acd9-4da9-b057-baf48baf36c7"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("407e9117-0a78-427d-850a-cea9049a43f1"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8591), null, true, false, new Guid("524732c4-596e-4501-b4d8-44a24bbb8af0"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("163bf2ca-0ff7-47ab-b97f-0914b2a5df11"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8502), null, true, false, new Guid("06c1dd5e-9358-4216-abb3-211f51d51de5"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cc7d3e82-4903-4374-8233-a270305f4bfb"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8417), null, true, false, new Guid("480a4641-1d95-48d8-8516-35c404a4f52e"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("467845d0-e00d-4f05-ae6a-0743947b7947"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8316), null, true, false, new Guid("c5bc7601-1219-4255-8e03-dc1ee87a7d43"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8484eb7b-f34a-4974-ab4f-5cd21fd6f072"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8189), null, true, false, new Guid("3733191b-75ca-4232-b070-9ada37f3701e"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("651bca39-1ad1-4496-8c21-f82716e9df68"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(8094), null, true, false, new Guid("9b67a5c1-ea1d-4a0d-9454-85ecae2a280e"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("aba785f0-cfe9-4850-a0d8-bde2de17a6ae"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7992), null, true, false, new Guid("4c3593c6-a8d1-4517-9946-e80b480fc4e1"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b28fb61f-8fb4-4b5d-8b69-f729345a2a21"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7896), null, true, false, new Guid("39c536a2-f600-4391-8603-502e1cf1db76"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("324f7ac5-9111-4ed0-8b02-8dcd526851ca"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7807), null, true, false, new Guid("c16cb4f2-7fb4-41c8-b4f2-ab97000331ec"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b8dc70ae-7934-49f7-a1ba-464f2a9507e4"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7712), null, true, false, new Guid("1f08d74a-750a-4304-853e-82b101351da8"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bbd70e86-8182-400f-96d3-16a8d3da3a19"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7417), null, true, false, new Guid("3a710774-e170-4db5-bcc2-01d39761cfd9"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8100ec56-cd7e-4abf-9746-3ef0372dd22c"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7310), null, true, false, new Guid("433f31c4-a4d5-4eee-8b37-fece785e0d07"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("05503c4c-2b33-47f3-926a-0ae694688c19"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(7186), null, true, false, new Guid("bd563b04-6a90-45cb-9ecc-0d59554291d1"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b9aa8ede-5090-4bc3-b1d7-b2fd5b8c2dba"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(5457), null, true, false, new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6f5a778c-1b04-480b-89c8-adb85eac98de"), null, new DateTime(2021, 2, 23, 16, 7, 16, 742, DateTimeKind.Local).AddTicks(9341), null, true, false, new Guid("db4d0e8f-d73b-4c16-a3dc-5d8320a04a7e"), new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("0c86baaf-b0e3-47d2-b89a-746601778343"), null, new Guid("74b1d30d-f3af-4c38-9fff-c7298ceeadcb"), null, null, null, new DateTime(2021, 2, 23, 16, 7, 16, 744, DateTimeKind.Local).AddTicks(6538), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("bd02b453-7334-4d92-aec6-21ce95874726"), null, null, new DateTime(2021, 2, 23, 16, 7, 16, 745, DateTimeKind.Local).AddTicks(2514), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("0c86baaf-b0e3-47d2-b89a-746601778343"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5"), new Guid("74b1d30d-f3af-4c38-9fff-c7298ceeadcb"), null, new DateTime(2021, 2, 23, 16, 7, 16, 745, DateTimeKind.Local).AddTicks(9354), null, new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"), true, false, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), new Guid("0c86baaf-b0e3-47d2-b89a-746601778343"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("6bbfe43c-e63e-4873-ad75-47405ac9c109"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8836), null, true, false, new Guid("f746312b-dc8e-43b4-9efc-dee00d8d4131"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("a2cbbc10-0bce-4263-ab7b-d6ee3feeb889"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8795), null, true, false, new Guid("09e83632-8a16-48d2-b542-375586d07ff0"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("73171bba-ee68-4fb9-9f70-f77d01cda9e4"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8750), null, true, false, new Guid("9c8d30cc-e7de-4523-823f-83a85d4a7890"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("4a7684e7-35bb-4510-bcc7-015da27e8592"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8709), null, true, false, new Guid("34bc2664-d86e-47a6-8935-a8d947a2125f"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("b655a155-2042-40de-9a19-704b7b07f8c2"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8665), null, true, false, new Guid("bc53fb5f-cd66-496a-9f06-ad01297f3396"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("094d36dd-3d02-456c-a300-0dec3add7a7c"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8623), null, true, false, new Guid("f2ac4c31-9a04-45b1-8268-db69af5354dd"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("688bfb0f-3dc9-4d22-b559-de452740572c"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8584), null, true, false, new Guid("59f3d793-acd9-4da9-b057-baf48baf36c7"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("d4182d5f-e99e-43a4-8767-f84359502eb7"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8545), null, true, false, new Guid("524732c4-596e-4501-b4d8-44a24bbb8af0"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("37f1073e-9de8-487e-8279-36262df7f0b1"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8505), null, true, false, new Guid("06c1dd5e-9358-4216-abb3-211f51d51de5"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("1dec81dc-316e-4e2f-ae22-bcdc3e733ffb"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8459), null, true, false, new Guid("480a4641-1d95-48d8-8516-35c404a4f52e"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("74a5b122-589b-4161-b8d6-107ff53066d6"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8881), null, true, false, new Guid("db4d0e8f-d73b-4c16-a3dc-5d8320a04a7e"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("4b567be9-eeee-43fd-b0e5-09eb56be7449"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8372), null, true, false, new Guid("3733191b-75ca-4232-b070-9ada37f3701e"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("beee799b-b004-4a47-9b79-a6666c11fa5f"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8329), null, true, false, new Guid("9b67a5c1-ea1d-4a0d-9454-85ecae2a280e"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("341c1af3-0ddb-4912-a6a7-9be0e200c30a"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8289), null, true, false, new Guid("4c3593c6-a8d1-4517-9946-e80b480fc4e1"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("05da1872-4e0a-4418-b01d-047c6e7185b8"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8248), null, true, false, new Guid("39c536a2-f600-4391-8603-502e1cf1db76"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("299e48e5-d207-4eb8-a18b-5a328c0ee1ac"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8177), null, true, false, new Guid("c16cb4f2-7fb4-41c8-b4f2-ab97000331ec"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("93bd7bd9-e552-4585-8a5c-d4c5bee780ba"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8129), null, true, false, new Guid("1f08d74a-750a-4304-853e-82b101351da8"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("a3060758-e256-44ac-8ce8-30ff3bbe3158"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8085), null, true, false, new Guid("3a710774-e170-4db5-bcc2-01d39761cfd9"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("536f4145-98bd-4c68-901f-8a1997de303f"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8029), null, true, false, new Guid("433f31c4-a4d5-4eee-8b37-fece785e0d07"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("2a7df1ff-3838-4f0c-8539-59ccbe596334"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(7962), null, true, false, new Guid("bd563b04-6a90-45cb-9ecc-0d59554291d1"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("80d97312-d651-4922-852d-d1a76b5f84fc"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(7187), null, true, false, new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") },
                    { new Guid("762c0895-c182-4192-91b9-85c005da092c"), true, true, null, new DateTime(2021, 2, 23, 16, 7, 16, 746, DateTimeKind.Local).AddTicks(8414), null, true, false, new Guid("c5bc7601-1219-4255-8e03-dc1ee87a7d43"), true, true, null, null, null, new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("612301a3-4eab-4841-965d-86bddd031584"), "usuário administrativo", null, new DateTime(2021, 2, 23, 16, 7, 16, 744, DateTimeKind.Local).AddTicks(2271), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b91f0f20-6b03-4295-b1a8-5e17bcb826fc"), new Guid("74b1d30d-f3af-4c38-9fff-c7298ceeadcb"), null, new DateTime(2021, 2, 23, 16, 7, 16, 739, DateTimeKind.Local).AddTicks(6186), null, true, false, new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("74b1d30d-f3af-4c38-9fff-c7298ceeadcb"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("b91f0f20-6b03-4295-b1a8-5e17bcb826fc"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("ab819c32-2ca5-482a-b350-1f8bc8be0889"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("055fe50d-942e-4956-ba4c-c4d8f00696f7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0738b3a1-5650-4dea-80c4-992fb30685ef"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("08a78220-bf90-4dbd-a38e-d1191d7defbb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("28710ffd-b141-4a03-a241-a3d8e89075fc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2d3919a8-de4a-4ed2-a8d5-7b2f70c71c5e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("32eb5c13-1e19-4f8a-9563-52e99d0343e1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("397ef0f5-a25a-46d6-a802-6f8da7451dd0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3a1b9cce-98ec-4e11-9fbc-011cda06f9bf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5969b534-d156-452d-8757-21c56eac52e8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5c5053ec-4270-4c03-91c6-f46e58403e7f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5d7cc47b-6025-4a27-976a-d583761e779a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("708096d1-67e1-4687-a9aa-b40e68a8ffeb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7ae674e7-822c-4a80-af99-ff8aabe253f0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("84808837-e863-4c22-8e62-a5f31055e003"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("926c30f2-f4a9-4227-b7a6-d144ab9016f9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b82a7d80-00af-40a3-aebc-b0dee9687713"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ce61a802-1d91-4ccf-84fe-9502d72afdff"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d6d4ed69-9066-4996-9fc5-8a20c5becd7e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d7ece60e-95d8-45f3-a002-25cfb4be41e7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e2bd5686-e35e-441c-8b7e-f704b97b1da7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("edd4de10-3811-4b7b-a93c-0efc760668b4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fe87c2e8-fc0c-4c06-a30c-dab92ff0a399"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("17f38d84-3930-407f-a468-aea68d8755a8"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2493747f-9b0c-403c-9871-e10bcae4a39f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ef53f48f-35a6-4912-af86-93140b98f45d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("06c1dd5e-9358-4216-abb3-211f51d51de5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("09e83632-8a16-48d2-b542-375586d07ff0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("109d7591-8c1c-48ef-bcb4-0de3df8eee1d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1f08d74a-750a-4304-853e-82b101351da8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("34bc2664-d86e-47a6-8935-a8d947a2125f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3733191b-75ca-4232-b070-9ada37f3701e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("39c536a2-f600-4391-8603-502e1cf1db76"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3a710774-e170-4db5-bcc2-01d39761cfd9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("433f31c4-a4d5-4eee-8b37-fece785e0d07"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("480a4641-1d95-48d8-8516-35c404a4f52e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4c3593c6-a8d1-4517-9946-e80b480fc4e1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("524732c4-596e-4501-b4d8-44a24bbb8af0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("59f3d793-acd9-4da9-b057-baf48baf36c7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9b67a5c1-ea1d-4a0d-9454-85ecae2a280e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9c8d30cc-e7de-4523-823f-83a85d4a7890"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bc53fb5f-cd66-496a-9f06-ad01297f3396"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bd563b04-6a90-45cb-9ecc-0d59554291d1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c16cb4f2-7fb4-41c8-b4f2-ab97000331ec"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c5bc7601-1219-4255-8e03-dc1ee87a7d43"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("db4d0e8f-d73b-4c16-a3dc-5d8320a04a7e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f2ac4c31-9a04-45b1-8268-db69af5354dd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f746312b-dc8e-43b4-9efc-dee00d8d4131"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("064adca3-2408-46fb-a568-fcd98788e9f5"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("36a15a65-0ad9-43d1-b3bb-ac7caeea14d6"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("da551669-3855-466a-93ab-57cda98d6e72"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("05503c4c-2b33-47f3-926a-0ae694688c19"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("12850735-f65b-4e6a-965d-c67ff5f05c83"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("163bf2ca-0ff7-47ab-b97f-0914b2a5df11"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("324f7ac5-9111-4ed0-8b02-8dcd526851ca"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("407e9117-0a78-427d-850a-cea9049a43f1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("467845d0-e00d-4f05-ae6a-0743947b7947"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("651bca39-1ad1-4496-8c21-f82716e9df68"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6f5a778c-1b04-480b-89c8-adb85eac98de"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("746c2dd1-3fb2-4cab-8ede-383b4931570c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8100ec56-cd7e-4abf-9746-3ef0372dd22c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8484eb7b-f34a-4974-ab4f-5cd21fd6f072"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9927e0aa-3491-4026-a9b9-26e770bfff90"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("aba785f0-cfe9-4850-a0d8-bde2de17a6ae"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b28fb61f-8fb4-4b5d-8b69-f729345a2a21"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b8dc70ae-7934-49f7-a1ba-464f2a9507e4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b9aa8ede-5090-4bc3-b1d7-b2fd5b8c2dba"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bbd70e86-8182-400f-96d3-16a8d3da3a19"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cc7d3e82-4903-4374-8233-a270305f4bfb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cf82903b-c320-4ced-99fa-5d4b56ad947d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e398b93e-2217-45c6-98aa-bc533da9620c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e8b11920-02e2-4fe9-95ef-51339c62c4e2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f30d5277-5039-4d86-a0fe-694e912007f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("0c86baaf-b0e3-47d2-b89a-746601778343"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("bd02b453-7334-4d92-aec6-21ce95874726"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("31b2c4b0-9ef1-48a3-a7a2-13720402efe5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("05da1872-4e0a-4418-b01d-047c6e7185b8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("094d36dd-3d02-456c-a300-0dec3add7a7c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1dec81dc-316e-4e2f-ae22-bcdc3e733ffb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("299e48e5-d207-4eb8-a18b-5a328c0ee1ac"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2a7df1ff-3838-4f0c-8539-59ccbe596334"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("341c1af3-0ddb-4912-a6a7-9be0e200c30a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("37f1073e-9de8-487e-8279-36262df7f0b1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4a7684e7-35bb-4510-bcc7-015da27e8592"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4b567be9-eeee-43fd-b0e5-09eb56be7449"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("536f4145-98bd-4c68-901f-8a1997de303f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("688bfb0f-3dc9-4d22-b559-de452740572c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6bbfe43c-e63e-4873-ad75-47405ac9c109"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("73171bba-ee68-4fb9-9f70-f77d01cda9e4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("74a5b122-589b-4161-b8d6-107ff53066d6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("762c0895-c182-4192-91b9-85c005da092c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("80d97312-d651-4922-852d-d1a76b5f84fc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("93bd7bd9-e552-4585-8a5c-d4c5bee780ba"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a2cbbc10-0bce-4263-ab7b-d6ee3feeb889"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3060758-e256-44ac-8ce8-30ff3bbe3158"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b655a155-2042-40de-9a19-704b7b07f8c2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("beee799b-b004-4a47-9b79-a6666c11fa5f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d4182d5f-e99e-43a4-8767-f84359502eb7"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("612301a3-4eab-4841-965d-86bddd031584"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("35852bfe-2424-4d91-8cb8-fccd23b109c9"));

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1107a351-d2f5-4aab-ada5-b34855618b3c"), null, null, null, null, null, new DateTime(2021, 2, 23, 15, 56, 56, 673, DateTimeKind.Local).AddTicks(3419), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), null, new DateTime(2021, 2, 23, 15, 56, 56, 681, DateTimeKind.Local).AddTicks(1996), true, false, "Administradores", new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("caf4b8b8-d386-49f5-9ab9-90d59e8389de"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9572), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("280ce9f8-c73d-47b9-96bc-e5592852dccf"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("badaeab8-4f0f-4709-b1cf-a0ecfce6e401"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9521), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("51dda023-7491-43ec-9676-14e0551b07c1"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("7a903f1b-d443-47dd-8634-965dabc2fc5f"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9477), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("41e71583-3c51-4749-92c0-4048eb9fd065"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("aca63e77-b79f-4d9a-acfd-13d0459a5bb6"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9435), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("a5dfb391-b061-4309-b55d-9e931c877bf0"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("8eb7bb92-0445-4700-935c-ffe4fcad4543"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9387), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("d9314324-5a4c-4d84-b0cd-a915ab6417cc"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("80bf10f4-8681-400f-90e8-753eec4ec9fa"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9343), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("ced51269-e1ad-4b62-a4d4-7e48e7e683b5"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("7f8b7feb-a12a-489f-8947-a3da76001432"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9301), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("60c19722-1f8f-42cd-9f53-16fcf88233e5"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("e6ca6c9e-2737-4b3b-8868-7de847ca2116"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9253), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("4f2cfff6-3e7d-4440-a2db-dac3f46806d3"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("434e07c0-a8fe-4564-bfbd-240f8f16eb88"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9085), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("35ae2102-a8da-4c64-9620-97fa00a2aa30"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("82b4723f-5bb3-420f-bbde-56ff83f255e4"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9036), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("bd4c3795-779e-4979-835c-5a3708e35b7e"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("ab38ef97-96b8-4b61-863a-edd0b54e25bc"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8994), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("12c7216d-fd53-48b4-86e9-a61e15a20068"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("20edec13-710f-40c1-b2dc-026fea210996"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8951), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("28c9909a-92c8-4fcf-82f7-8c00ddc54b3a"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("8e06fa14-35fc-4c38-937f-ec113368d87e"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8904), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("2250a853-26a6-4f06-aa28-f9d63bfc4ccd"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("59e3215f-c56e-4db4-baca-86fbd14e34c1"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8860), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("71fbcfbf-d30e-43ec-911f-17f7f1ee0754"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("96186092-a859-4d12-b3a9-9091639bd76c"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8817), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("6ac5383c-ac80-405e-950f-42835f1127ec"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("1f65486b-3cc5-4025-aee1-8c86c1f0800d"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8773), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("6f35e1a5-719d-4e04-9e72-d43202520652"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("13855c76-e390-4d51-bfc9-ef87de5e02e3"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8720), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("e2c8f188-22f9-4ea3-b721-a328db9f935f"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("928cce97-5402-4dcc-a29f-72465325c3e8"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8664), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("9fd67d94-656f-484d-be74-d0f0391b0ae0"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("c952ad0d-8e55-41a4-9a2a-c9f885787dd9"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8616), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("037d0a5d-110f-4210-b1a0-3aa7f4819b9d"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("47fda49b-a388-4160-a2a4-25cfd8ec1b71"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(8513), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("e5d28bb3-3069-476a-813e-f34de1e0afc1"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("8a7319bb-d4b7-447c-b438-6309b7184ef5"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(7435), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null },
                    { new Guid("e186a01d-d989-4c17-869d-2042ec1add70"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 684, DateTimeKind.Local).AddTicks(9615), new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("6cea4afd-478e-4519-8d5a-457d91204520"), true, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("fc5c81c2-55db-4a2b-ab18-c52f8aea8f09"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 23, 15, 56, 56, 680, DateTimeKind.Local).AddTicks(9083), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c717ca1b-6813-4261-8321-4f271fe579cd"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 23, 15, 56, 56, 680, DateTimeKind.Local).AddTicks(8832), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4b5aade3-109c-42c0-ae91-b2f2c33d328c"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 23, 15, 56, 56, 680, DateTimeKind.Local).AddTicks(2191), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("6cea4afd-478e-4519-8d5a-457d91204520"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8845), null, "", true, false, "groupusers/details", new Guid("51dda023-7491-43ec-9676-14e0551b07c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("280ce9f8-c73d-47b9-96bc-e5592852dccf"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8676), null, "", true, false, "groupusers/list", new Guid("51dda023-7491-43ec-9676-14e0551b07c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("51dda023-7491-43ec-9676-14e0551b07c1"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8578), null, "", true, false, "", new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("41e71583-3c51-4749-92c0-4048eb9fd065"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8481), null, "", true, false, "systems/details", new Guid("d9314324-5a4c-4d84-b0cd-a915ab6417cc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a5dfb391-b061-4309-b55d-9e931c877bf0"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8386), null, "", true, false, "systems/list", new Guid("d9314324-5a4c-4d84-b0cd-a915ab6417cc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d9314324-5a4c-4d84-b0cd-a915ab6417cc"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8284), null, "", true, false, "", new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ced51269-e1ad-4b62-a4d4-7e48e7e683b5"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8170), null, "", true, false, "languages/details", new Guid("4f2cfff6-3e7d-4440-a2db-dac3f46806d3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60c19722-1f8f-42cd-9f53-16fcf88233e5"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8061), null, "", true, false, "languages/list", new Guid("4f2cfff6-3e7d-4440-a2db-dac3f46806d3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f2cfff6-3e7d-4440-a2db-dac3f46806d3"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7890), null, "", true, false, "", new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("35ae2102-a8da-4c64-9620-97fa00a2aa30"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7792), null, "", true, false, "clients/details", new Guid("12c7216d-fd53-48b4-86e9-a61e15a20068"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bd4c3795-779e-4979-835c-5a3708e35b7e"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7692), null, "", true, false, "clients/list", new Guid("12c7216d-fd53-48b4-86e9-a61e15a20068"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28c9909a-92c8-4fcf-82f7-8c00ddc54b3a"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7493), null, "", true, false, "menus/details", new Guid("71fbcfbf-d30e-43ec-911f-17f7f1ee0754"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2250a853-26a6-4f06-aa28-f9d63bfc4ccd"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7383), null, "", true, false, "menus/list", new Guid("71fbcfbf-d30e-43ec-911f-17f7f1ee0754"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("71fbcfbf-d30e-43ec-911f-17f7f1ee0754"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7247), null, "", true, false, "", new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6ac5383c-ac80-405e-950f-42835f1127ec"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6981), null, "", true, false, "users/details", new Guid("e2c8f188-22f9-4ea3-b721-a328db9f935f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6f35e1a5-719d-4e04-9e72-d43202520652"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6883), null, "", true, false, "users/list", new Guid("e2c8f188-22f9-4ea3-b721-a328db9f935f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e2c8f188-22f9-4ea3-b721-a328db9f935f"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6764), null, "", true, false, "", new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9fd67d94-656f-484d-be74-d0f0391b0ae0"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6440), null, "", true, false, "companyoperators/details", new Guid("e5d28bb3-3069-476a-813e-f34de1e0afc1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("037d0a5d-110f-4210-b1a0-3aa7f4819b9d"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6337), null, "", true, false, "companyoperators/list", new Guid("e5d28bb3-3069-476a-813e-f34de1e0afc1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e5d28bb3-3069-476a-813e-f34de1e0afc1"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6105), null, "", true, false, "", new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(47), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("12c7216d-fd53-48b4-86e9-a61e15a20068"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7596), null, "", true, false, "", new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 23, 15, 56, 56, 678, DateTimeKind.Local).AddTicks(275), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("26e499b4-559f-4907-b9a4-7c51b1c09e26"), null, new DateTime(2021, 2, 23, 15, 56, 56, 680, DateTimeKind.Local).AddTicks(9130), true, true, false, new Guid("fc5c81c2-55db-4a2b-ab18-c52f8aea8f09"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, null },
                    { new Guid("a89411c2-6e47-43a3-a455-ceadfe212cb9"), null, new DateTime(2021, 2, 23, 15, 56, 56, 680, DateTimeKind.Local).AddTicks(8252), true, true, false, new Guid("4b5aade3-109c-42c0-ae91-b2f2c33d328c"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, null },
                    { new Guid("693b1330-6714-4b8a-aa0d-e50571a38d3f"), null, new DateTime(2021, 2, 23, 15, 56, 56, 680, DateTimeKind.Local).AddTicks(9009), true, true, false, new Guid("c717ca1b-6813-4261-8321-4f271fe579cd"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("57d85fb9-cfe6-4b95-9ddd-4009b10d2215"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8333), null, true, false, new Guid("d9314324-5a4c-4d84-b0cd-a915ab6417cc"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdd3f637-eb8e-4e7a-8a0a-ef753b8f4764"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8791), null, true, false, new Guid("280ce9f8-c73d-47b9-96bc-e5592852dccf"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ed18fb13-f161-41ac-b364-a877077ddd4c"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8623), null, true, false, new Guid("51dda023-7491-43ec-9676-14e0551b07c1"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("35565a9a-8ad6-42aa-8b93-7d7c63bad084"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8527), null, true, false, new Guid("41e71583-3c51-4749-92c0-4048eb9fd065"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8b2c77c2-ebff-4a7b-a077-f7490c2a5f39"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8430), null, true, false, new Guid("a5dfb391-b061-4309-b55d-9e931c877bf0"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c7405a2f-7b77-4f6f-a626-1fa6ff030b3d"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8232), null, true, false, new Guid("ced51269-e1ad-4b62-a4d4-7e48e7e683b5"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("31479f0d-f062-4121-82f9-8c0c385e1605"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8116), null, true, false, new Guid("60c19722-1f8f-42cd-9f53-16fcf88233e5"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c66898d7-f43a-459b-932e-1ef2f3d72f7d"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7936), null, true, false, new Guid("4f2cfff6-3e7d-4440-a2db-dac3f46806d3"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5b7d27de-0207-4d25-9366-bb007edf4f99"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7837), null, true, false, new Guid("35ae2102-a8da-4c64-9620-97fa00a2aa30"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f932670d-eef5-4b63-86b2-dbbcba5f35a7"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7738), null, true, false, new Guid("bd4c3795-779e-4979-835c-5a3708e35b7e"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc10bc85-4755-4e73-a037-ad60a1a6e31c"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7641), null, true, false, new Guid("12c7216d-fd53-48b4-86e9-a61e15a20068"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33ed49a3-5e07-4862-a51a-d07569483df5"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7542), null, true, false, new Guid("28c9909a-92c8-4fcf-82f7-8c00ddc54b3a"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("73103a4d-47d9-4894-8ac9-a625473aba45"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7437), null, true, false, new Guid("2250a853-26a6-4f06-aa28-f9d63bfc4ccd"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("29b1d136-740a-47aa-ab25-6955cd5d7a86"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7313), null, true, false, new Guid("71fbcfbf-d30e-43ec-911f-17f7f1ee0754"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0d78c02d-ebb0-4837-94b0-2d489cade6c7"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(7025), null, true, false, new Guid("6ac5383c-ac80-405e-950f-42835f1127ec"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b949e98f-45c4-4df9-bb36-648b8310a47e"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6926), null, true, false, new Guid("6f35e1a5-719d-4e04-9e72-d43202520652"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2e37c35c-e971-44dc-b9b5-2ef531fd008a"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6822), null, true, false, new Guid("e2c8f188-22f9-4ea3-b721-a328db9f935f"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8bf8f1e8-ca8a-4ce2-8e73-ba7ff4311b8d"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6484), null, true, false, new Guid("9fd67d94-656f-484d-be74-d0f0391b0ae0"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fa09557d-10e0-4a8c-a755-26232a5ea088"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6385), null, true, false, new Guid("037d0a5d-110f-4210-b1a0-3aa7f4819b9d"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5e816511-b61f-49a0-95ef-b492c64663bf"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(6254), null, true, false, new Guid("e5d28bb3-3069-476a-813e-f34de1e0afc1"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f81742f5-0cab-4239-a1ea-f5dd50f2bda4"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(4180), null, true, false, new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c6eeb7d0-171b-470a-9855-bab89e60a47a"), null, new DateTime(2021, 2, 23, 15, 56, 56, 682, DateTimeKind.Local).AddTicks(8887), null, true, false, new Guid("6cea4afd-478e-4519-8d5a-457d91204520"), new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e04e7568-ca1e-4c94-afa5-bd2e6d59a612"), null, new Guid("1107a351-d2f5-4aab-ada5-b34855618b3c"), null, null, null, new DateTime(2021, 2, 23, 15, 56, 56, 685, DateTimeKind.Local).AddTicks(6901), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("766a1a1e-ae81-4c8c-a4fc-0ce179ecc85d"), null, null, new DateTime(2021, 2, 23, 15, 56, 56, 686, DateTimeKind.Local).AddTicks(1396), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("e04e7568-ca1e-4c94-afa5-bd2e6d59a612"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("f9cee36a-7290-4798-8931-2e66369315e9"), new Guid("1107a351-d2f5-4aab-ada5-b34855618b3c"), null, new DateTime(2021, 2, 23, 15, 56, 56, 687, DateTimeKind.Local).AddTicks(2117), null, new Guid("cd0c7602-4572-47b5-97fd-568c5fda01f5"), true, false, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), new Guid("e04e7568-ca1e-4c94-afa5-bd2e6d59a612"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("388e00a9-4811-4647-80fb-913d71120cb1"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(3570), null, true, false, new Guid("280ce9f8-c73d-47b9-96bc-e5592852dccf"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("a35e7620-10fc-4859-b3c0-7aa371bd83b5"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(3472), null, true, false, new Guid("51dda023-7491-43ec-9676-14e0551b07c1"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("acbef693-d732-4dda-aef4-055da7fc25c3"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(3375), null, true, false, new Guid("41e71583-3c51-4749-92c0-4048eb9fd065"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("5235e499-c0aa-4856-87ca-a5ca2ae12059"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(3255), null, true, false, new Guid("a5dfb391-b061-4309-b55d-9e931c877bf0"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("78c3e6da-c315-4497-b269-acf7a49a4696"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2952), null, true, false, new Guid("d9314324-5a4c-4d84-b0cd-a915ab6417cc"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("9c85bb35-b2cb-4ce6-8847-304028cdbffa"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2849), null, true, false, new Guid("ced51269-e1ad-4b62-a4d4-7e48e7e683b5"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("03a6b329-be34-4513-9597-f26f0a961ba6"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2761), null, true, false, new Guid("60c19722-1f8f-42cd-9f53-16fcf88233e5"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("e983a141-6706-40bd-8c69-716004192bd1"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2661), null, true, false, new Guid("4f2cfff6-3e7d-4440-a2db-dac3f46806d3"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("9d955e0d-d04c-400c-a0f7-391b6497273f"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2561), null, true, false, new Guid("35ae2102-a8da-4c64-9620-97fa00a2aa30"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("d77c9d69-da6c-4f3b-8af0-2edc424894be"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2401), null, true, false, new Guid("bd4c3795-779e-4979-835c-5a3708e35b7e"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("679f6c48-2a7a-490a-a142-cbc2004a50ce"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(3661), null, true, false, new Guid("6cea4afd-478e-4519-8d5a-457d91204520"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("c47ac3c3-1f38-467d-bd5e-57a31374bbe3"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2208), null, true, false, new Guid("28c9909a-92c8-4fcf-82f7-8c00ddc54b3a"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("64da69cc-d1aa-4dc3-9201-061643f11e52"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2103), null, true, false, new Guid("2250a853-26a6-4f06-aa28-f9d63bfc4ccd"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("de6174a5-c058-41bb-aa54-7043e18128a5"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2004), null, true, false, new Guid("71fbcfbf-d30e-43ec-911f-17f7f1ee0754"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("6605b06d-a062-44a6-af3b-6ecc40dd39d5"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(1923), null, true, false, new Guid("6ac5383c-ac80-405e-950f-42835f1127ec"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("33799918-718f-4a18-9716-e9a9f43c6f61"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(1826), null, true, false, new Guid("6f35e1a5-719d-4e04-9e72-d43202520652"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("68b31cab-f207-4c28-baae-533524b33ead"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(1714), null, true, false, new Guid("e2c8f188-22f9-4ea3-b721-a328db9f935f"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("c3882c23-5b11-46d1-a3d2-040738df59b1"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(1614), null, true, false, new Guid("9fd67d94-656f-484d-be74-d0f0391b0ae0"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("4ced212f-be5c-477c-be03-7a1bc53f4166"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(1509), null, true, false, new Guid("037d0a5d-110f-4210-b1a0-3aa7f4819b9d"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("a54d1895-b372-4485-b2e8-c54144b13b51"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(1231), null, true, false, new Guid("e5d28bb3-3069-476a-813e-f34de1e0afc1"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("c7605a6a-7415-4abf-ab60-2c54fedc6a2a"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(435), null, true, false, new Guid("37624df4-e96d-4258-bf91-7b9acafdddd2"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") },
                    { new Guid("142a52df-71b7-4155-a345-f691cbfb8b1f"), true, true, null, new DateTime(2021, 2, 23, 15, 56, 56, 688, DateTimeKind.Local).AddTicks(2313), null, true, false, new Guid("12c7216d-fd53-48b4-86e9-a61e15a20068"), true, true, null, null, null, new Guid("f9cee36a-7290-4798-8931-2e66369315e9") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("37e413aa-e8f8-4a92-bb5b-7b1e9e53223a"), "usuário administrativo", null, new DateTime(2021, 2, 23, 15, 56, 56, 685, DateTimeKind.Local).AddTicks(3130), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("87814197-6f34-49b3-88b4-c4edfa87b77d"), new Guid("1107a351-d2f5-4aab-ada5-b34855618b3c"), null, new DateTime(2021, 2, 23, 15, 56, 56, 678, DateTimeKind.Local).AddTicks(9505), null, true, false, new Guid("22e0eee3-4c4b-417a-ba97-28da1e90f76d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
