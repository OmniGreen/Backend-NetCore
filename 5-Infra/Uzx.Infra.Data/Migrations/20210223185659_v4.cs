using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("aab934ae-f162-4345-8a9b-c4eab78b6916"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("27aa0e7a-4393-4237-aabf-f8462784953b"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1221eca4-bcfd-4eab-98f0-2d65f78c7c10"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2876bcd4-8c6b-400a-a503-f2bba1ad4e87"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("295eb7b0-8c44-467f-9339-d43b005ff7b1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3f4060ea-04b8-443f-b5a5-618143f9a397"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("436835ce-b2bb-4039-a936-b431dcda917a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4c2783a9-e8f1-4ec8-904e-ea677df6ef8a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6960e35b-c20a-4cdf-9eaf-a28bad56013a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("78b6f547-2300-47ac-9acd-d53d07fa358e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8610e1ea-2689-43e3-b33d-0c21f6667ec6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9c928ee2-a9db-4608-92db-30d94bc498de"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a0fdb86d-607e-46fb-bfb7-f4311a8360f5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b1521849-165f-4eb7-a3fa-cdaaa25c2ccd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b484e279-2904-4fcb-91b6-58a0badae033"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b61d2618-5148-4982-b3cb-7ce0e000c5fa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b975c0d1-e528-4b2c-9b24-1c2866ede10d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c26f39e9-7650-4351-928f-25fcd9e0f8b7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("dddc5ba2-a203-48c4-a2a9-4f7f4d47249e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("df4e8a84-3195-4b4f-a960-0af3b3bef455"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("edd535ca-c6fd-4690-bc2a-f68a1bd484a2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f69f714e-570f-4ede-bee3-a830ef8e31ea"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fbdec2cb-18d0-4d9a-b887-e2e8425a038b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fc382050-e786-43e9-a970-c49473dc95b1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("79259fe6-38bc-4637-9444-30325ce77ff3"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9b5ff118-68e1-4e0e-9ab9-1f554266aabf"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("dad8fccc-793f-4557-86e6-96805a3becbc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("02c4dfb1-14df-4ccf-90fd-518f27e04c78"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1d6a11ee-03a7-4316-8bec-134acd2a1dcb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1f3ada45-2313-4115-b8ab-0c400f9a9373"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("233b4ec5-4e8a-49d6-ab58-872ae015ab16"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2f4f0fc1-15f2-4b58-94f7-0aad3be3b8ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2f733166-22ac-4c85-9122-89cbcb612b01"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("47a37c0c-bf55-435b-b715-86405bdc122d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("847a915a-6971-4a38-8c27-bbdc797244c8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8a5c237b-0bf9-4147-8a81-6bc9b87791ce"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8b73b8b2-ef59-478a-8dc2-cc5bb2c6420d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8cafd5a2-c81e-4709-9f77-ddf58cf60ff2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("95d6a20e-b6c1-435c-b6d6-3df3e48a7210"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("adef594e-7031-480f-aca0-42c5fdb37ed8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c2635ce1-67ee-4945-892d-294f17567f29"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cc37734f-8893-4dd9-88a8-36f9a6697011"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ce474796-8302-42c6-a734-a1e88601baa2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d1f3acd2-56fe-48a3-b04c-71f767834225"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d8e9a2ac-8475-4fdd-9dc2-0b6dcb3a07e9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e97da2d6-05c2-4302-8de9-555aa0e251e0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f63b84ef-80d8-4ec2-ab2a-bee261631e03"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f974001c-f5ec-4931-9320-807f3f318925"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("4a354337-0ea9-4228-8241-001434a195ce"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("fc51afe4-ab02-44ec-a62e-907c667305cc"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("fe036ebd-dcba-4254-b68d-5c0a81a298f6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("04ee205d-2fd0-4d3c-bcf3-73aa7ed2d3d0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("07f3ffc1-ff0f-4b43-b6b4-dd04d01fa448"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("197502ed-542f-49a0-894b-904b6f59452b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("25ce067b-c9e4-45f7-8cfb-e5157140e061"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("263149e0-ccf5-484a-bb57-4f6e589dc25c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2dce065d-a51a-4bfb-85c7-864ce8653cbd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4374fcfc-2578-401e-93a2-e13bdc5314bb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4aa2ac9c-bf39-4540-98d2-db31926e7df2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("54f5f956-5d12-4dd9-a74e-94149b915376"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("76119242-7381-4cfe-91b2-c0a2b3805f69"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8055aad4-0581-4945-a255-bd687e7caefc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("86c5bb3e-4599-4a1e-bdf7-87e478a0b281"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("892da13f-72fb-4885-87b7-355cabeda8e6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a9a49c7a-2ce3-4a6a-9932-f42c2953d188"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("aa89d2ca-1519-423a-8833-151744a13c08"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("af4ef71f-8823-45ea-b6d5-7826cdfe762e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c189616d-c48c-4249-a272-e3e19c1c143c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c83df1ab-a442-404b-bdcb-a8db7e636fba"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cb872207-d2cb-40d3-b623-1fec9c91e289"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d2d8fef6-5453-4791-9b10-ba32110713f5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("de4bf978-5fed-448e-9d1f-59da6a6ae476"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e23a060c-ec16-4f99-ba9d-cd3623d7fb24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7c9e8aa6-f6be-4e80-b4cc-7a59154b802c"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("cb245ff6-d653-4265-99bd-91c05762f1a7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("020a1277-11c4-4ee7-a361-0b6eea35d7bf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("029d5622-4508-4d6b-a785-3092dfc1e1c3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1a3a10ed-5ed6-4f5e-ab54-5aa4b333a572"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2243302a-33a8-41be-8eb2-a9beb15eefdf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("23b01e32-e153-4739-8ab9-d73b0e17b667"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2a19bf92-5615-405c-9c2d-12f58d96c111"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("33b35288-bc25-4718-a030-2307eb5f33da"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("34525adb-879b-4561-a421-194035931794"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("554851ba-6679-424d-813a-dde426410534"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5f86336f-739a-47b5-a7f1-49f384026b98"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("71dc8fbd-0bd8-4250-b08c-b307a4ab089a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a929f509-2d68-48cf-9382-08842dda6a7a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a976e5cc-b8e1-475d-b5c3-c4f5e8d6eb13"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("af6a6b33-bd0a-448f-8f40-13231b253ef9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bf91e099-cff5-4ed9-aae6-b9674e58c706"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c556dbcd-c7da-4a39-8e0b-ddc39e20c04f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cb4eb41e-0ed9-4559-979a-11c526433ce1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e0b75c8e-1274-4c29-8471-e0b67f0d613a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e433423c-e200-40e4-9067-35c08cc042f3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ea8d1e3d-ebce-4886-aeb2-882f376f3455"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ee9450e0-6eec-42a5-80ba-cbf4ef025b8f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f5ee0a7f-3ab1-4e2c-981c-34a5cfcdc419"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("e4f0503f-4535-4dc5-bc6c-0a63147c9c60"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"));

            migrationBuilder.AddColumn<bool>(
                name: "IsBanner",
                table: "SalePlans",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCoupons",
                table: "SalePlans",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEvents",
                table: "SalePlans",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSearch",
                table: "SalePlans",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LkFacebook",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkGooglePlus",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkInstagram",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkLinkedin",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkTwitter",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkYoutube",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkFacebook",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkGooglePlus",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkInstagram",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkLinkedin",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkTwitter",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LkYoutube",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameBanner",
                table: "Banners",
                type: "varchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsBanner",
                table: "SalePlans");

            migrationBuilder.DropColumn(
                name: "IsCoupons",
                table: "SalePlans");

            migrationBuilder.DropColumn(
                name: "IsEvents",
                table: "SalePlans");

            migrationBuilder.DropColumn(
                name: "IsSearch",
                table: "SalePlans");

            migrationBuilder.DropColumn(
                name: "LkFacebook",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LkGooglePlus",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LkInstagram",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LkLinkedin",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LkTwitter",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LkYoutube",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LkFacebook",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LkGooglePlus",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LkInstagram",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LkLinkedin",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LkTwitter",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LkYoutube",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "NameBanner",
                table: "Banners",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("aab934ae-f162-4345-8a9b-c4eab78b6916"), null, null, null, null, null, new DateTime(2021, 2, 12, 11, 36, 48, 745, DateTimeKind.Local).AddTicks(8188), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3285), true, false, "Administradores", new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("df4e8a84-3195-4b4f-a960-0af3b3bef455"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1267), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("2f733166-22ac-4c85-9122-89cbcb612b01"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("fc382050-e786-43e9-a970-c49473dc95b1"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1248), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("2f4f0fc1-15f2-4b58-94f7-0aad3be3b8ef"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("b1521849-165f-4eb7-a3fa-cdaaa25c2ccd"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1228), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("1f3ada45-2313-4115-b8ab-0c400f9a9373"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("b975c0d1-e528-4b2c-9b24-1c2866ede10d"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1207), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("1d6a11ee-03a7-4316-8bec-134acd2a1dcb"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("2876bcd4-8c6b-400a-a503-f2bba1ad4e87"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1186), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("d8e9a2ac-8475-4fdd-9dc2-0b6dcb3a07e9"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("a0fdb86d-607e-46fb-bfb7-f4311a8360f5"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1167), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("233b4ec5-4e8a-49d6-ab58-872ae015ab16"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("3f4060ea-04b8-443f-b5a5-618143f9a397"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1147), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("d1f3acd2-56fe-48a3-b04c-71f767834225"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("edd535ca-c6fd-4690-bc2a-f68a1bd484a2"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1088), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("95d6a20e-b6c1-435c-b6d6-3df3e48a7210"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("78b6f547-2300-47ac-9acd-d53d07fa358e"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1068), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("8a5c237b-0bf9-4147-8a81-6bc9b87791ce"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("f69f714e-570f-4ede-bee3-a830ef8e31ea"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1049), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("847a915a-6971-4a38-8c27-bbdc797244c8"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("295eb7b0-8c44-467f-9339-d43b005ff7b1"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1030), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("02c4dfb1-14df-4ccf-90fd-518f27e04c78"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("4c2783a9-e8f1-4ec8-904e-ea677df6ef8a"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1008), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("cc37734f-8893-4dd9-88a8-36f9a6697011"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("b484e279-2904-4fcb-91b6-58a0badae033"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(987), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("8b73b8b2-ef59-478a-8dc2-cc5bb2c6420d"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("b61d2618-5148-4982-b3cb-7ce0e000c5fa"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(968), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("adef594e-7031-480f-aca0-42c5fdb37ed8"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("8610e1ea-2689-43e3-b33d-0c21f6667ec6"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(948), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("c2635ce1-67ee-4945-892d-294f17567f29"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("436835ce-b2bb-4039-a936-b431dcda917a"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(928), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("e97da2d6-05c2-4302-8de9-555aa0e251e0"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("6960e35b-c20a-4cdf-9eaf-a28bad56013a"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(907), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("47a37c0c-bf55-435b-b715-86405bdc122d"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("9c928ee2-a9db-4608-92db-30d94bc498de"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(887), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("8cafd5a2-c81e-4709-9f77-ddf58cf60ff2"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("fbdec2cb-18d0-4d9a-b887-e2e8425a038b"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(865), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("ce474796-8302-42c6-a734-a1e88601baa2"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("1221eca4-bcfd-4eab-98f0-2d65f78c7c10"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(839), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("f63b84ef-80d8-4ec2-ab2a-bee261631e03"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("dddc5ba2-a203-48c4-a2a9-4f7f4d47249e"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(694), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null },
                    { new Guid("c26f39e9-7650-4351-928f-25fcd9e0f8b7"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(1286), new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("f974001c-f5ec-4931-9320-807f3f318925"), true, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("9b5ff118-68e1-4e0e-9ab9-1f554266aabf"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3237), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("79259fe6-38bc-4637-9444-30325ce77ff3"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3196), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dad8fccc-793f-4557-86e6-96805a3becbc"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3089), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f974001c-f5ec-4931-9320-807f3f318925"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8771), null, "", true, false, "groupusers/details", new Guid("2f4f0fc1-15f2-4b58-94f7-0aad3be3b8ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2f733166-22ac-4c85-9122-89cbcb612b01"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8701), null, "", true, false, "groupusers/list", new Guid("2f4f0fc1-15f2-4b58-94f7-0aad3be3b8ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2f4f0fc1-15f2-4b58-94f7-0aad3be3b8ef"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8661), null, "", true, false, "", new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f3ada45-2313-4115-b8ab-0c400f9a9373"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8619), null, "", true, false, "systems/details", new Guid("d8e9a2ac-8475-4fdd-9dc2-0b6dcb3a07e9"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d6a11ee-03a7-4316-8bec-134acd2a1dcb"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8580), null, "", true, false, "systems/list", new Guid("d8e9a2ac-8475-4fdd-9dc2-0b6dcb3a07e9"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d8e9a2ac-8475-4fdd-9dc2-0b6dcb3a07e9"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8538), null, "", true, false, "", new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("233b4ec5-4e8a-49d6-ab58-872ae015ab16"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8497), null, "", true, false, "languages/details", new Guid("95d6a20e-b6c1-435c-b6d6-3df3e48a7210"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d1f3acd2-56fe-48a3-b04c-71f767834225"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8453), null, "", true, false, "languages/list", new Guid("95d6a20e-b6c1-435c-b6d6-3df3e48a7210"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("95d6a20e-b6c1-435c-b6d6-3df3e48a7210"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8381), null, "", true, false, "", new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8a5c237b-0bf9-4147-8a81-6bc9b87791ce"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8341), null, "", true, false, "clients/details", new Guid("02c4dfb1-14df-4ccf-90fd-518f27e04c78"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("847a915a-6971-4a38-8c27-bbdc797244c8"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8301), null, "", true, false, "clients/list", new Guid("02c4dfb1-14df-4ccf-90fd-518f27e04c78"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cc37734f-8893-4dd9-88a8-36f9a6697011"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8218), null, "", true, false, "menus/details", new Guid("adef594e-7031-480f-aca0-42c5fdb37ed8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8b73b8b2-ef59-478a-8dc2-cc5bb2c6420d"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8171), null, "", true, false, "menus/list", new Guid("adef594e-7031-480f-aca0-42c5fdb37ed8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("adef594e-7031-480f-aca0-42c5fdb37ed8"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(7920), null, "", true, false, "", new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c2635ce1-67ee-4945-892d-294f17567f29"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(7870), null, "", true, false, "users/details", new Guid("47a37c0c-bf55-435b-b715-86405bdc122d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e97da2d6-05c2-4302-8de9-555aa0e251e0"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(6565), null, "", true, false, "users/list", new Guid("47a37c0c-bf55-435b-b715-86405bdc122d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("47a37c0c-bf55-435b-b715-86405bdc122d"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3797), null, "", true, false, "", new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8cafd5a2-c81e-4709-9f77-ddf58cf60ff2"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3729), null, "", true, false, "companyoperators/details", new Guid("f63b84ef-80d8-4ec2-ab2a-bee261631e03"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ce474796-8302-42c6-a734-a1e88601baa2"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3687), null, "", true, false, "companyoperators/list", new Guid("f63b84ef-80d8-4ec2-ab2a-bee261631e03"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f63b84ef-80d8-4ec2-ab2a-bee261631e03"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3648), null, "", true, false, "", new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3542), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("02c4dfb1-14df-4ccf-90fd-518f27e04c78"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8258), null, "", true, false, "", new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(2874), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("4a354337-0ea9-4228-8241-001434a195ce"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3263), true, true, false, new Guid("9b5ff118-68e1-4e0e-9ab9-1f554266aabf"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, null },
                    { new Guid("fc51afe4-ab02-44ec-a62e-907c667305cc"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3148), true, true, false, new Guid("dad8fccc-793f-4557-86e6-96805a3becbc"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, null },
                    { new Guid("fe036ebd-dcba-4254-b68d-5c0a81a298f6"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3217), true, true, false, new Guid("79259fe6-38bc-4637-9444-30325ce77ff3"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("a9a49c7a-2ce3-4a6a-9932-f42c2953d188"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8558), null, true, false, new Guid("d8e9a2ac-8475-4fdd-9dc2-0b6dcb3a07e9"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("04ee205d-2fd0-4d3c-bcf3-73aa7ed2d3d0"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8719), null, true, false, new Guid("2f733166-22ac-4c85-9122-89cbcb612b01"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2dce065d-a51a-4bfb-85c7-864ce8653cbd"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8680), null, true, false, new Guid("2f4f0fc1-15f2-4b58-94f7-0aad3be3b8ef"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("25ce067b-c9e4-45f7-8cfb-e5157140e061"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8638), null, true, false, new Guid("1f3ada45-2313-4115-b8ab-0c400f9a9373"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("54f5f956-5d12-4dd9-a74e-94149b915376"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8599), null, true, false, new Guid("1d6a11ee-03a7-4316-8bec-134acd2a1dcb"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e23a060c-ec16-4f99-ba9d-cd3623d7fb24"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8515), null, true, false, new Guid("233b4ec5-4e8a-49d6-ab58-872ae015ab16"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("af4ef71f-8823-45ea-b6d5-7826cdfe762e"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8474), null, true, false, new Guid("d1f3acd2-56fe-48a3-b04c-71f767834225"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d2d8fef6-5453-4791-9b10-ba32110713f5"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8399), null, true, false, new Guid("95d6a20e-b6c1-435c-b6d6-3df3e48a7210"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cb872207-d2cb-40d3-b623-1fec9c91e289"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8360), null, true, false, new Guid("8a5c237b-0bf9-4147-8a81-6bc9b87791ce"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("263149e0-ccf5-484a-bb57-4f6e589dc25c"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8320), null, true, false, new Guid("847a915a-6971-4a38-8c27-bbdc797244c8"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("de4bf978-5fed-448e-9d1f-59da6a6ae476"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8277), null, true, false, new Guid("02c4dfb1-14df-4ccf-90fd-518f27e04c78"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("aa89d2ca-1519-423a-8833-151744a13c08"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8237), null, true, false, new Guid("cc37734f-8893-4dd9-88a8-36f9a6697011"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("86c5bb3e-4599-4a1e-bdf7-87e478a0b281"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8195), null, true, false, new Guid("8b73b8b2-ef59-478a-8dc2-cc5bb2c6420d"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4aa2ac9c-bf39-4540-98d2-db31926e7df2"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8111), null, true, false, new Guid("adef594e-7031-480f-aca0-42c5fdb37ed8"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c83df1ab-a442-404b-bdcb-a8db7e636fba"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(7892), null, true, false, new Guid("c2635ce1-67ee-4945-892d-294f17567f29"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("197502ed-542f-49a0-894b-904b6f59452b"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(7806), null, true, false, new Guid("e97da2d6-05c2-4302-8de9-555aa0e251e0"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("76119242-7381-4cfe-91b2-c0a2b3805f69"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3817), null, true, false, new Guid("47a37c0c-bf55-435b-b715-86405bdc122d"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4374fcfc-2578-401e-93a2-e13bdc5314bb"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3746), null, true, false, new Guid("8cafd5a2-c81e-4709-9f77-ddf58cf60ff2"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c189616d-c48c-4249-a272-e3e19c1c143c"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3705), null, true, false, new Guid("ce474796-8302-42c6-a734-a1e88601baa2"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("07f3ffc1-ff0f-4b43-b6b4-dd04d01fa448"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3667), null, true, false, new Guid("f63b84ef-80d8-4ec2-ab2a-bee261631e03"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("892da13f-72fb-4885-87b7-355cabeda8e6"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3600), null, true, false, new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8055aad4-0581-4945-a255-bd687e7caefc"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(8789), null, true, false, new Guid("f974001c-f5ec-4931-9320-807f3f318925"), new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("7c9e8aa6-f6be-4e80-b4cc-7a59154b802c"), null, new Guid("aab934ae-f162-4345-8a9b-c4eab78b6916"), null, null, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(3224), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("cb245ff6-d653-4265-99bd-91c05762f1a7"), null, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(4352), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("7c9e8aa6-f6be-4e80-b4cc-7a59154b802c"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9"), new Guid("aab934ae-f162-4345-8a9b-c4eab78b6916"), null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(5891), null, new Guid("e53a8ce4-051a-44d8-8267-13f71710209a"), true, false, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), new Guid("7c9e8aa6-f6be-4e80-b4cc-7a59154b802c"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("2a19bf92-5615-405c-9c2d-12f58d96c111"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(8123), null, true, false, new Guid("2f733166-22ac-4c85-9122-89cbcb612b01"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("71dc8fbd-0bd8-4250-b08c-b307a4ab089a"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(8102), null, true, false, new Guid("2f4f0fc1-15f2-4b58-94f7-0aad3be3b8ef"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("a929f509-2d68-48cf-9382-08842dda6a7a"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(8072), null, true, false, new Guid("1f3ada45-2313-4115-b8ab-0c400f9a9373"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("020a1277-11c4-4ee7-a361-0b6eea35d7bf"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7973), null, true, false, new Guid("1d6a11ee-03a7-4316-8bec-134acd2a1dcb"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("f5ee0a7f-3ab1-4e2c-981c-34a5cfcdc419"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7952), null, true, false, new Guid("d8e9a2ac-8475-4fdd-9dc2-0b6dcb3a07e9"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("34525adb-879b-4561-a421-194035931794"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7930), null, true, false, new Guid("233b4ec5-4e8a-49d6-ab58-872ae015ab16"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("cb4eb41e-0ed9-4559-979a-11c526433ce1"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7910), null, true, false, new Guid("d1f3acd2-56fe-48a3-b04c-71f767834225"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("554851ba-6679-424d-813a-dde426410534"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7891), null, true, false, new Guid("95d6a20e-b6c1-435c-b6d6-3df3e48a7210"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("bf91e099-cff5-4ed9-aae6-b9674e58c706"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7871), null, true, false, new Guid("8a5c237b-0bf9-4147-8a81-6bc9b87791ce"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("c556dbcd-c7da-4a39-8e0b-ddc39e20c04f"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7852), null, true, false, new Guid("847a915a-6971-4a38-8c27-bbdc797244c8"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("a976e5cc-b8e1-475d-b5c3-c4f5e8d6eb13"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(8142), null, true, false, new Guid("f974001c-f5ec-4931-9320-807f3f318925"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("2243302a-33a8-41be-8eb2-a9beb15eefdf"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7812), null, true, false, new Guid("cc37734f-8893-4dd9-88a8-36f9a6697011"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("029d5622-4508-4d6b-a785-3092dfc1e1c3"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7791), null, true, false, new Guid("8b73b8b2-ef59-478a-8dc2-cc5bb2c6420d"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("af6a6b33-bd0a-448f-8f40-13231b253ef9"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7766), null, true, false, new Guid("adef594e-7031-480f-aca0-42c5fdb37ed8"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("33b35288-bc25-4718-a030-2307eb5f33da"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7746), null, true, false, new Guid("c2635ce1-67ee-4945-892d-294f17567f29"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("ea8d1e3d-ebce-4886-aeb2-882f376f3455"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7726), null, true, false, new Guid("e97da2d6-05c2-4302-8de9-555aa0e251e0"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("e433423c-e200-40e4-9067-35c08cc042f3"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7704), null, true, false, new Guid("47a37c0c-bf55-435b-b715-86405bdc122d"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("23b01e32-e153-4739-8ab9-d73b0e17b667"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7684), null, true, false, new Guid("8cafd5a2-c81e-4709-9f77-ddf58cf60ff2"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("1a3a10ed-5ed6-4f5e-ab54-5aa4b333a572"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7626), null, true, false, new Guid("ce474796-8302-42c6-a734-a1e88601baa2"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("e0b75c8e-1274-4c29-8471-e0b67f0d613a"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7603), null, true, false, new Guid("f63b84ef-80d8-4ec2-ab2a-bee261631e03"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("5f86336f-739a-47b5-a7f1-49f384026b98"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7478), null, true, false, new Guid("fbbabcfa-a33d-47ae-a450-ffc191a29b30"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") },
                    { new Guid("ee9450e0-6eec-42a5-80ba-cbf4ef025b8f"), true, true, null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(7832), null, true, false, new Guid("02c4dfb1-14df-4ccf-90fd-518f27e04c78"), true, true, null, null, null, new Guid("05e9c698-1b91-4d01-b1e6-8e915af7e7f9") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e4f0503f-4535-4dc5-bc6c-0a63147c9c60"), "usuário administrativo", null, new DateTime(2021, 2, 12, 11, 36, 48, 748, DateTimeKind.Local).AddTicks(2051), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("27aa0e7a-4393-4237-aabf-f8462784953b"), new Guid("aab934ae-f162-4345-8a9b-c4eab78b6916"), null, new DateTime(2021, 2, 12, 11, 36, 48, 747, DateTimeKind.Local).AddTicks(3010), null, true, false, new Guid("e50060b5-a03f-4228-b158-e6ca5ee7d0ce"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
