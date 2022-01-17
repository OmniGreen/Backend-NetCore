using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("51933536-5a13-41a9-aed5-d36c80c15224"), null, null, null, null, null, new DateTime(2021, 3, 6, 15, 53, 39, 468, DateTimeKind.Local).AddTicks(9076), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), null, new DateTime(2021, 3, 6, 15, 53, 39, 484, DateTimeKind.Local).AddTicks(4467), true, false, "Administradores", new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("1da0fb37-096f-460e-9957-9c0a5300024e"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(643), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("33d844b6-83c0-45a2-95cf-54bef1bf766f"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("d129ce45-4c80-4ad1-be29-2822a57e6ac3"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(604), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("79a88f0b-a700-49a1-9b5c-ffa5ad7750c1"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("d0946aba-9e13-41f9-82fa-9dba07157937"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(571), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("dca97207-e2e2-4cf4-a0ab-17355ae66565"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("4846fe76-8ba3-4e01-b804-2fa2de2e7e75"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(539), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("c151fce7-869e-4010-b5eb-4a97ae3df157"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("86c6e276-1415-4da6-93f3-da6bbf657941"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(504), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("769845e2-e256-494f-bcf3-fe3e2a0646f5"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("5ca24d8f-d6fe-4044-a751-b3be434de509"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(472), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("3cd8cb0b-fb1a-43e0-96f9-71c49365cb07"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("93d3c130-6137-413a-906e-04f59f335532"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(437), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("05ae7149-b661-4920-a5e9-720ef7b6c8e5"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("daf97caf-d495-431f-b059-b6b7e046273c"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(404), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("29884b50-0ad7-4ebe-b339-83bf7375adaf"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("8ca34726-2444-44a1-bba8-f1e16d86e9ce"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(369), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("ef318bcb-6691-4bbf-8e5c-a697718e8c3b"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("5422d45b-98ff-4db9-ac90-11f9ad540b96"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(330), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("e4f29bb9-bae0-4400-9be4-f6b20fa77b28"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("48fabebb-6743-4b1f-8fbb-c3ce6a26d831"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(294), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("e9029fca-f37e-4a12-8ee8-47d76c4e391f"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("a83dbcc9-c04f-483b-8463-ee07db451edb"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(253), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("e2df37dc-d501-4b77-a987-54a889fe7b54"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("5da0a728-bafa-44ab-a488-44db4868d50a"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(117), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("4d631a29-a196-4ddc-be9e-4d641acaf5ce"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("927897e0-8c7c-487b-ba7d-dbda54022880"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(81), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("f525b0ec-30ab-4f60-bb71-f8da6bfc22bc"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("ff6eb3a8-e568-4f58-8645-5d4b49acab6f"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(47), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("9ed468cf-89b2-481a-a818-fad9938ff3f7"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("4678707c-2aa1-4c51-83cd-981e785ab377"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(10), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("2c71c0d9-53c3-41ec-86ea-caea7e8b70d4"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("18e346f8-870d-418c-9748-2d4496873b07"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(9969), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("49846e1a-ed47-4315-a76b-51c0516a1e47"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("270a9646-0adc-497e-8136-37d6701a02cc"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(9922), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("dd36a69e-72c3-47e8-aa14-39fec9d4bce5"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("20068891-f7a5-4d2a-bcf0-97bfe640b2d6"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(9887), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("3ec05ca5-0a90-46d5-8b6b-f3113c8d66c0"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("014f2bce-ae5b-45cd-b019-fd2b05513f47"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(9814), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("bcf9f210-0fdf-486f-8e60-1b7f1ed9f93e"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("626f2ac0-8ebd-41de-9843-6d3a3bce9d4f"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(9084), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null },
                    { new Guid("17f28209-2fe2-47d5-98b0-673af937634f"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(677), new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("bd05bb83-6334-4606-8d76-61149258434f"), true, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("ad34fcc5-b981-4ac8-9fc8-b59021b7d156"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 6, 15, 53, 39, 484, DateTimeKind.Local).AddTicks(1803), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00dbf5a9-775d-4649-bb37-468489201ce6"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 6, 15, 53, 39, 484, DateTimeKind.Local).AddTicks(1363), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b08463a8-dff8-46d4-9d81-e9a8873dda23"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 6, 15, 53, 39, 483, DateTimeKind.Local).AddTicks(3990), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("bd05bb83-6334-4606-8d76-61149258434f"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1729), null, "", true, false, "groupusers/details", new Guid("79a88f0b-a700-49a1-9b5c-ffa5ad7750c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33d844b6-83c0-45a2-95cf-54bef1bf766f"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1649), null, "", true, false, "groupusers/list", new Guid("79a88f0b-a700-49a1-9b5c-ffa5ad7750c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("79a88f0b-a700-49a1-9b5c-ffa5ad7750c1"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1565), null, "", true, false, "", new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dca97207-e2e2-4cf4-a0ab-17355ae66565"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1432), null, "", true, false, "systems/details", new Guid("769845e2-e256-494f-bcf3-fe3e2a0646f5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c151fce7-869e-4010-b5eb-4a97ae3df157"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1351), null, "", true, false, "systems/list", new Guid("769845e2-e256-494f-bcf3-fe3e2a0646f5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("769845e2-e256-494f-bcf3-fe3e2a0646f5"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1266), null, "", true, false, "", new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3cd8cb0b-fb1a-43e0-96f9-71c49365cb07"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1178), null, "", true, false, "languages/details", new Guid("29884b50-0ad7-4ebe-b339-83bf7375adaf"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("05ae7149-b661-4920-a5e9-720ef7b6c8e5"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1103), null, "", true, false, "languages/list", new Guid("29884b50-0ad7-4ebe-b339-83bf7375adaf"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("29884b50-0ad7-4ebe-b339-83bf7375adaf"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1028), null, "", true, false, "", new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef318bcb-6691-4bbf-8e5c-a697718e8c3b"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(829), null, "", true, false, "clients/details", new Guid("e9029fca-f37e-4a12-8ee8-47d76c4e391f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e4f29bb9-bae0-4400-9be4-f6b20fa77b28"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(673), null, "", true, false, "clients/list", new Guid("e9029fca-f37e-4a12-8ee8-47d76c4e391f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e2df37dc-d501-4b77-a987-54a889fe7b54"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(418), null, "", true, false, "menus/details", new Guid("f525b0ec-30ab-4f60-bb71-f8da6bfc22bc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4d631a29-a196-4ddc-be9e-4d641acaf5ce"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(275), null, "", true, false, "menus/list", new Guid("f525b0ec-30ab-4f60-bb71-f8da6bfc22bc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f525b0ec-30ab-4f60-bb71-f8da6bfc22bc"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(137), null, "", true, false, "", new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9ed468cf-89b2-481a-a818-fad9938ff3f7"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(12), null, "", true, false, "users/details", new Guid("49846e1a-ed47-4315-a76b-51c0516a1e47"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2c71c0d9-53c3-41ec-86ea-caea7e8b70d4"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9759), null, "", true, false, "users/list", new Guid("49846e1a-ed47-4315-a76b-51c0516a1e47"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("49846e1a-ed47-4315-a76b-51c0516a1e47"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9600), null, "", true, false, "", new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dd36a69e-72c3-47e8-aa14-39fec9d4bce5"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9254), null, "", true, false, "companyoperators/details", new Guid("bcf9f210-0fdf-486f-8e60-1b7f1ed9f93e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ec05ca5-0a90-46d5-8b6b-f3113c8d66c0"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9118), null, "", true, false, "companyoperators/list", new Guid("bcf9f210-0fdf-486f-8e60-1b7f1ed9f93e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bcf9f210-0fdf-486f-8e60-1b7f1ed9f93e"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(8850), null, "", true, false, "", new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(2023), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e9029fca-f37e-4a12-8ee8-47d76c4e391f"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(546), null, "", true, false, "", new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 6, 15, 53, 39, 477, DateTimeKind.Local).AddTicks(5195), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("35c7b85a-6015-40ca-b865-cfe2aa5e1d8d"), null, new DateTime(2021, 3, 6, 15, 53, 39, 484, DateTimeKind.Local).AddTicks(1891), true, true, false, new Guid("ad34fcc5-b981-4ac8-9fc8-b59021b7d156"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, null },
                    { new Guid("cffad32d-0bb8-4c43-af81-ba42e44badd0"), null, new DateTime(2021, 3, 6, 15, 53, 39, 484, DateTimeKind.Local).AddTicks(715), true, true, false, new Guid("b08463a8-dff8-46d4-9d81-e9a8873dda23"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, null },
                    { new Guid("72d4fa3f-5990-48f2-b103-25079cf84a63"), null, new DateTime(2021, 3, 6, 15, 53, 39, 484, DateTimeKind.Local).AddTicks(1590), true, true, false, new Guid("00dbf5a9-775d-4649-bb37-468489201ce6"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("a6a9371c-a9dd-4154-921c-b582703f467a"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1305), null, true, false, new Guid("769845e2-e256-494f-bcf3-fe3e2a0646f5"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee9a03b6-b73b-49d3-9f09-20e94874691f"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1685), null, true, false, new Guid("33d844b6-83c0-45a2-95cf-54bef1bf766f"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d475d99-f166-4a8b-9b18-68c7e6a575b5"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1606), null, true, false, new Guid("79a88f0b-a700-49a1-9b5c-ffa5ad7750c1"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("479e2d64-bf5d-4fca-8050-3597b0d62c11"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1469), null, true, false, new Guid("dca97207-e2e2-4cf4-a0ab-17355ae66565"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1b1f63a4-44af-4880-8f69-d3b22b53b81e"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1387), null, true, false, new Guid("c151fce7-869e-4010-b5eb-4a97ae3df157"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f06dd2de-43bf-493e-a959-28e5c17c4c10"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1214), null, true, false, new Guid("3cd8cb0b-fb1a-43e0-96f9-71c49365cb07"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5ba9b11-d165-4ce0-b5f4-9db4f0e885b5"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1138), null, true, false, new Guid("05ae7149-b661-4920-a5e9-720ef7b6c8e5"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("91d8aefb-e601-4f16-87c0-b99e3a7ca7b9"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1065), null, true, false, new Guid("29884b50-0ad7-4ebe-b339-83bf7375adaf"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5abc66a3-8e66-462e-a34f-4aea53cbc244"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(965), null, true, false, new Guid("ef318bcb-6691-4bbf-8e5c-a697718e8c3b"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("aebea7ed-26f6-4bed-8429-d51e25de0f84"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(733), null, true, false, new Guid("e4f29bb9-bae0-4400-9be4-f6b20fa77b28"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d4420f6-1429-4b7a-b3b2-bc80032b0030"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(607), null, true, false, new Guid("e9029fca-f37e-4a12-8ee8-47d76c4e391f"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("970e9330-8bc7-463a-ad15-0f74718f8ab3"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(477), null, true, false, new Guid("e2df37dc-d501-4b77-a987-54a889fe7b54"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("68c23c1c-f9ed-4772-8608-19f2e8113644"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(342), null, true, false, new Guid("4d631a29-a196-4ddc-be9e-4d641acaf5ce"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0d7494b-22d4-4ec0-8e57-c78b5255fb39"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(199), null, true, false, new Guid("f525b0ec-30ab-4f60-bb71-f8da6bfc22bc"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("58137d72-3ad1-40a2-942a-1aa7cdbff1b9"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(71), null, true, false, new Guid("9ed468cf-89b2-481a-a818-fad9938ff3f7"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("22f88ac5-7573-4900-883d-9e47cacfdeca"), null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9936), null, true, false, new Guid("2c71c0d9-53c3-41ec-86ea-caea7e8b70d4"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0fcaeb24-6648-44ae-beef-892c3d310f5f"), null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9670), null, true, false, new Guid("49846e1a-ed47-4315-a76b-51c0516a1e47"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cb52f4c9-1bac-451d-afb0-3a21e1a819ce"), null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9318), null, true, false, new Guid("dd36a69e-72c3-47e8-aa14-39fec9d4bce5"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7e13832c-7cd6-44e8-8731-f18aae30abb3"), null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9184), null, true, false, new Guid("3ec05ca5-0a90-46d5-8b6b-f3113c8d66c0"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1fa6f782-9596-4c5e-81ba-647c6863d039"), null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(9018), null, true, false, new Guid("bcf9f210-0fdf-486f-8e60-1b7f1ed9f93e"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0bd243bc-06e5-4675-a6df-7b978bbf751f"), null, new DateTime(2021, 3, 6, 15, 53, 39, 486, DateTimeKind.Local).AddTicks(7339), null, true, false, new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53f51b7c-bdde-4d44-a43c-4b114fb4802a"), null, new DateTime(2021, 3, 6, 15, 53, 39, 487, DateTimeKind.Local).AddTicks(1764), null, true, false, new Guid("bd05bb83-6334-4606-8d76-61149258434f"), new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5c67508c-4254-410c-97c0-aa7535cc23f0"), null, new Guid("51933536-5a13-41a9-aed5-d36c80c15224"), null, null, null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(6661), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("bc7bdbf2-1c41-4be3-b4e7-fb5f089cd861"), null, null, new DateTime(2021, 3, 6, 15, 53, 39, 489, DateTimeKind.Local).AddTicks(957), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("5c67508c-4254-410c-97c0-aa7535cc23f0"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6"), new Guid("51933536-5a13-41a9-aed5-d36c80c15224"), null, new DateTime(2021, 3, 6, 15, 53, 39, 489, DateTimeKind.Local).AddTicks(6398), null, new Guid("0588a106-4088-4e47-91de-4fab97c19d51"), true, false, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), new Guid("5c67508c-4254-410c-97c0-aa7535cc23f0"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("a4917981-db92-4161-b186-137214839590"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(5149), null, true, false, new Guid("33d844b6-83c0-45a2-95cf-54bef1bf766f"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("439813cb-150e-4583-8fda-e33f4188f5ef"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(5112), null, true, false, new Guid("79a88f0b-a700-49a1-9b5c-ffa5ad7750c1"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("37f5d52c-f694-4963-a93f-1e6709960498"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(5071), null, true, false, new Guid("dca97207-e2e2-4cf4-a0ab-17355ae66565"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("e849d754-f083-4dc5-b423-07acf26682ce"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(5036), null, true, false, new Guid("c151fce7-869e-4010-b5eb-4a97ae3df157"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("12a8e2b5-13da-4971-9eee-934a48a98cb4"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4994), null, true, false, new Guid("769845e2-e256-494f-bcf3-fe3e2a0646f5"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("82fbd125-3e60-47c3-9d89-5b295f79db30"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4957), null, true, false, new Guid("3cd8cb0b-fb1a-43e0-96f9-71c49365cb07"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("25fb7e3c-4f38-4d47-9260-cb282064f15e"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4910), null, true, false, new Guid("05ae7149-b661-4920-a5e9-720ef7b6c8e5"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("0201cf0d-e852-4303-88ad-989d12774f2d"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4801), null, true, false, new Guid("29884b50-0ad7-4ebe-b339-83bf7375adaf"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("c6158ca3-8436-4ad6-884b-abee752065eb"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4764), null, true, false, new Guid("ef318bcb-6691-4bbf-8e5c-a697718e8c3b"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("ffa40104-00fe-455c-b24a-ac1bed87c8cd"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4713), null, true, false, new Guid("e4f29bb9-bae0-4400-9be4-f6b20fa77b28"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("86fbb486-fe6a-4bd3-8005-a395d983ee45"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(5189), null, true, false, new Guid("bd05bb83-6334-4606-8d76-61149258434f"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("ad90d973-7394-4397-a838-c6f96eed55e5"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4550), null, true, false, new Guid("e2df37dc-d501-4b77-a987-54a889fe7b54"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("4f3a2663-6d9a-4db1-997e-06d2ceea2bf0"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4495), null, true, false, new Guid("4d631a29-a196-4ddc-be9e-4d641acaf5ce"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("853aca7e-9dce-4702-9a20-d9677dd0020b"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4456), null, true, false, new Guid("f525b0ec-30ab-4f60-bb71-f8da6bfc22bc"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("c8d2949d-d64c-4b4b-8615-4dbdd6a9b23f"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4383), null, true, false, new Guid("9ed468cf-89b2-481a-a818-fad9938ff3f7"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("0cccc0a7-84c4-4cf1-8314-91ad6ce8ed3c"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4301), null, true, false, new Guid("2c71c0d9-53c3-41ec-86ea-caea7e8b70d4"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("6f978671-80c0-461c-92c0-559e71cafe0f"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4209), null, true, false, new Guid("49846e1a-ed47-4315-a76b-51c0516a1e47"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("da6a853e-e629-48a5-9cc7-5094b235e2ae"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4123), null, true, false, new Guid("dd36a69e-72c3-47e8-aa14-39fec9d4bce5"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("bbce8d5d-4882-4757-aec6-d3955864a60e"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4021), null, true, false, new Guid("3ec05ca5-0a90-46d5-8b6b-f3113c8d66c0"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("939344bc-e64f-4e0e-b6d8-4f62268af317"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(3903), null, true, false, new Guid("bcf9f210-0fdf-486f-8e60-1b7f1ed9f93e"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("12ec2172-35c1-4f4f-84ba-c02cd80acfcd"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(3072), null, true, false, new Guid("dd53c747-73f0-481e-8649-10df9de84a44"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") },
                    { new Guid("9288ae0d-8a76-4ee7-b1b6-a2254b1cba93"), true, true, null, new DateTime(2021, 3, 6, 15, 53, 39, 490, DateTimeKind.Local).AddTicks(4627), null, true, false, new Guid("e9029fca-f37e-4a12-8ee8-47d76c4e391f"), true, true, null, null, null, new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6953dc17-fb52-40e3-96bd-6c274cfc257c"), "usuário administrativo", null, new DateTime(2021, 3, 6, 15, 53, 39, 488, DateTimeKind.Local).AddTicks(2928), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("bd9856cd-826f-45d5-81f8-bae9cdf94d80"), new Guid("51933536-5a13-41a9-aed5-d36c80c15224"), null, new DateTime(2021, 3, 6, 15, 53, 39, 482, DateTimeKind.Local).AddTicks(2678), null, true, false, new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("51933536-5a13-41a9-aed5-d36c80c15224"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("bd9856cd-826f-45d5-81f8-bae9cdf94d80"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("0588a106-4088-4e47-91de-4fab97c19d51"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("014f2bce-ae5b-45cd-b019-fd2b05513f47"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("17f28209-2fe2-47d5-98b0-673af937634f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("18e346f8-870d-418c-9748-2d4496873b07"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1da0fb37-096f-460e-9957-9c0a5300024e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("20068891-f7a5-4d2a-bcf0-97bfe640b2d6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("270a9646-0adc-497e-8136-37d6701a02cc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4678707c-2aa1-4c51-83cd-981e785ab377"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4846fe76-8ba3-4e01-b804-2fa2de2e7e75"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("48fabebb-6743-4b1f-8fbb-c3ce6a26d831"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5422d45b-98ff-4db9-ac90-11f9ad540b96"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ca24d8f-d6fe-4044-a751-b3be434de509"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5da0a728-bafa-44ab-a488-44db4868d50a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("626f2ac0-8ebd-41de-9843-6d3a3bce9d4f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("86c6e276-1415-4da6-93f3-da6bbf657941"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8ca34726-2444-44a1-bba8-f1e16d86e9ce"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("927897e0-8c7c-487b-ba7d-dbda54022880"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("93d3c130-6137-413a-906e-04f59f335532"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a83dbcc9-c04f-483b-8463-ee07db451edb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d0946aba-9e13-41f9-82fa-9dba07157937"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d129ce45-4c80-4ad1-be29-2822a57e6ac3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("daf97caf-d495-431f-b059-b6b7e046273c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ff6eb3a8-e568-4f58-8645-5d4b49acab6f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("00dbf5a9-775d-4649-bb37-468489201ce6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ad34fcc5-b981-4ac8-9fc8-b59021b7d156"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b08463a8-dff8-46d4-9d81-e9a8873dda23"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("05ae7149-b661-4920-a5e9-720ef7b6c8e5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("29884b50-0ad7-4ebe-b339-83bf7375adaf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2c71c0d9-53c3-41ec-86ea-caea7e8b70d4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("33d844b6-83c0-45a2-95cf-54bef1bf766f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3cd8cb0b-fb1a-43e0-96f9-71c49365cb07"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3ec05ca5-0a90-46d5-8b6b-f3113c8d66c0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("49846e1a-ed47-4315-a76b-51c0516a1e47"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4d631a29-a196-4ddc-be9e-4d641acaf5ce"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("769845e2-e256-494f-bcf3-fe3e2a0646f5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("79a88f0b-a700-49a1-9b5c-ffa5ad7750c1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9ed468cf-89b2-481a-a818-fad9938ff3f7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bcf9f210-0fdf-486f-8e60-1b7f1ed9f93e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bd05bb83-6334-4606-8d76-61149258434f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c151fce7-869e-4010-b5eb-4a97ae3df157"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dca97207-e2e2-4cf4-a0ab-17355ae66565"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dd36a69e-72c3-47e8-aa14-39fec9d4bce5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dd53c747-73f0-481e-8649-10df9de84a44"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e2df37dc-d501-4b77-a987-54a889fe7b54"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e4f29bb9-bae0-4400-9be4-f6b20fa77b28"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e9029fca-f37e-4a12-8ee8-47d76c4e391f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ef318bcb-6691-4bbf-8e5c-a697718e8c3b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f525b0ec-30ab-4f60-bb71-f8da6bfc22bc"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("35c7b85a-6015-40ca-b865-cfe2aa5e1d8d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("72d4fa3f-5990-48f2-b103-25079cf84a63"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("cffad32d-0bb8-4c43-af81-ba42e44badd0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0bd243bc-06e5-4675-a6df-7b978bbf751f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0fcaeb24-6648-44ae-beef-892c3d310f5f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1b1f63a4-44af-4880-8f69-d3b22b53b81e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1fa6f782-9596-4c5e-81ba-647c6863d039"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("22f88ac5-7573-4900-883d-9e47cacfdeca"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("479e2d64-bf5d-4fca-8050-3597b0d62c11"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("53f51b7c-bdde-4d44-a43c-4b114fb4802a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("58137d72-3ad1-40a2-942a-1aa7cdbff1b9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5abc66a3-8e66-462e-a34f-4aea53cbc244"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("68c23c1c-f9ed-4772-8608-19f2e8113644"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7e13832c-7cd6-44e8-8731-f18aae30abb3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8d4420f6-1429-4b7a-b3b2-bc80032b0030"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8d475d99-f166-4a8b-9b18-68c7e6a575b5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("91d8aefb-e601-4f16-87c0-b99e3a7ca7b9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("970e9330-8bc7-463a-ad15-0f74718f8ab3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a6a9371c-a9dd-4154-921c-b582703f467a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("aebea7ed-26f6-4bed-8429-d51e25de0f84"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c5ba9b11-d165-4ce0-b5f4-9db4f0e885b5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cb52f4c9-1bac-451d-afb0-3a21e1a819ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d0d7494b-22d4-4ec0-8e57-c78b5255fb39"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ee9a03b6-b73b-49d3-9f09-20e94874691f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f06dd2de-43bf-493e-a959-28e5c17c4c10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5c67508c-4254-410c-97c0-aa7535cc23f0"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("bc7bdbf2-1c41-4be3-b4e7-fb5f089cd861"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("9e74d162-586a-4ab2-a166-6cb7452e5ae6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0201cf0d-e852-4303-88ad-989d12774f2d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0cccc0a7-84c4-4cf1-8314-91ad6ce8ed3c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("12a8e2b5-13da-4971-9eee-934a48a98cb4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("12ec2172-35c1-4f4f-84ba-c02cd80acfcd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("25fb7e3c-4f38-4d47-9260-cb282064f15e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("37f5d52c-f694-4963-a93f-1e6709960498"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("439813cb-150e-4583-8fda-e33f4188f5ef"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4f3a2663-6d9a-4db1-997e-06d2ceea2bf0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6f978671-80c0-461c-92c0-559e71cafe0f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("82fbd125-3e60-47c3-9d89-5b295f79db30"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("853aca7e-9dce-4702-9a20-d9677dd0020b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("86fbb486-fe6a-4bd3-8005-a395d983ee45"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9288ae0d-8a76-4ee7-b1b6-a2254b1cba93"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("939344bc-e64f-4e0e-b6d8-4f62268af317"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a4917981-db92-4161-b186-137214839590"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ad90d973-7394-4397-a838-c6f96eed55e5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bbce8d5d-4882-4757-aec6-d3955864a60e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c6158ca3-8436-4ad6-884b-abee752065eb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c8d2949d-d64c-4b4b-8615-4dbdd6a9b23f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("da6a853e-e629-48a5-9cc7-5094b235e2ae"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e849d754-f083-4dc5-b423-07acf26682ce"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ffa40104-00fe-455c-b24a-ac1bed87c8cd"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("6953dc17-fb52-40e3-96bd-6c274cfc257c"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("89a59dc3-d1b0-48ac-a4ce-4aa7f7876730"));

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
    }
}
