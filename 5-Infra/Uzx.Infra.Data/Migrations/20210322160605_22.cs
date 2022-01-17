using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("74b1428c-6fbd-4c60-9945-dcccffa73845"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0382da53-f1a5-4669-82bd-76e1aa8ec212"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0d3ad4aa-62b1-4968-89ca-244e1886b531"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0ef528ac-73b6-4ec0-a7c2-3db00ced7d0b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("11977c94-d4ba-4e09-849b-5719bbc865ff"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1cbcfc76-e9aa-4ac3-ae12-85f237cb2eb8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("208dd1c6-8003-4c0d-9a38-444cf3c0a7fb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("36c69e23-6ddf-44a0-b8c6-04bfab9bc1fd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4d6d00da-1f7e-4031-93b3-502c24af1192"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("523139fd-f247-4d11-b8a4-164b4cae4045"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("685f58bf-bfb3-4d1d-b3c3-6684c69dea98"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("72af9939-9946-43b8-a795-f818ef4ae88f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7850b303-83df-4abb-ad35-7d10fbe6f5c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("79b2675c-0d7c-4051-a1a3-35724aeaa942"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7ea0a8fb-aa9e-40b7-8377-2dd219203e37"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("82b35d2c-54c5-4059-84c2-c547190378a5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("958e9b50-42fd-49dc-8dd4-6b2096812f51"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("96ccace8-77df-4bdd-a6ee-e3b34023bffb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b3826ca6-4c2a-4603-832f-0ffb2fb89c09"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bdc5b11b-586c-488c-ac5e-799d10a62699"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d4b7bc36-999a-4029-8bd9-43b0e1cc068c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d65d532b-93e2-4de5-bfd2-9a85e32e3d22"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d6bbd68d-6ada-49c1-bada-3f71e499372b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0688878b-5e72-403f-b6c1-c999258c3ce0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("6f9d3d14-a7ae-4ae9-8ed0-336660852b0b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e4e53154-3aec-4caa-b79f-4662c7ef53cd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9282db58-14cf-4568-abc6-6d566362c831"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a277562c-9415-4978-a057-8ae66afef387"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b1011fd3-4170-4397-b006-049b951998de"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("348e1552-e2aa-4b18-9b53-01942c227004"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("cf7eec30-8bc8-46bc-8207-a45fc9db1ead"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("f9a37221-d983-42bf-bcc7-adc69e2d8c1a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("31cb0bee-5629-4639-b984-e2c7e7d0490b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("46411d8b-70f9-4567-aadd-20188d983fd9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("51705aa0-3d7f-4993-aba0-ee09273f7575"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("59086292-7900-4d44-be1c-6014628b7716"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5a024adb-dffd-442d-aa0e-7c6abfaaed6e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5d56619f-d63c-486b-86e9-e1b3ed038019"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("60e5deb9-28dc-4f7d-83f5-ca8cb662e132"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("65de6488-07f4-45fb-9013-d87fa30e0d9e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("678e5a97-4b91-4cc0-badd-5154722d923a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6bf889e9-7717-4830-b62e-6c3995491c6a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6e0ef932-ec4b-43e7-8840-240247ae91a5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("73c01573-fafb-4389-908d-901df5721da5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7cf52ab0-85e3-4210-9c30-8f512b4f76d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8080186c-1b6e-42df-9c8d-66f8ee9245e6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8497ee0d-79bf-44de-bd97-584253ed8d1f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("92a2cb47-1041-47af-835e-d02d763bb795"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ab66fa74-8c7e-48de-b19e-d493f436ea5c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ade5a3ba-6e53-4a53-b7fb-8f8299d0d2d9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c01884b0-d898-4e75-b037-0d2ce1471143"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cdd553ef-b6ce-46ab-8baa-b8b93585d10c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ee84f3cf-a2ce-45c6-ba99-173d71a12e80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f627d29a-da26-48c3-9f07-727f0256bff5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("b600b3aa-c05b-42cd-bf33-618925e2f8a6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1b52684d-455a-4a24-a1f6-021e57083701"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2d4344a9-0ddb-41d0-b649-2958d2775652"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2ec28884-97d6-4652-998a-9dd6f8fc720d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("32cf5aa8-ad9f-44ef-8c0c-1a86c0ba28bc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3da6cb32-5f8e-43a3-a405-aa29f6a2124d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("457f099b-056f-4efa-ae28-fec65fef210c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4d9e4b6a-8f0f-412e-bbb0-d6c5093901e2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("732fb23d-859b-4210-88b4-aea3dd17980c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7a8546eb-164a-4f76-94b7-e911e53c3227"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("85d5353a-d17d-4953-ac81-d204e3d9f432"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8ebd5652-009a-4522-8903-1c3d60959be0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("97c751b1-89d4-42f2-8b16-4f27cd15db0c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3046e42-20bd-4b91-9cc4-4b3b5f27d3e8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3ef2638-4542-4b33-8760-c8ceb2c4b5e3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a515dc99-ea6c-429b-acd1-b72918c03bdc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a6ed022c-b843-4fec-b360-7adae4dc55e8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aa16e52a-fb02-42d0-ad83-a15ef1607024"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aac3fddf-c561-46fa-b6fd-dd9cf746b2a6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("addca7d3-afbc-4ba8-87bd-743741a80d8a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c325911a-dadf-4385-910f-87ea4590ff62"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d432731b-eda7-4c81-9943-e04cb3616899"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d8b0f2b5-d3f3-47b6-8df8-057c050472bd"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("aad70c67-4be1-4a11-bf83-d2001770f325"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"));

            migrationBuilder.AddColumn<string>(
                name: "CompraOnline",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Whats",
                table: "Events",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, null, null, null, null, new DateTime(2021, 3, 22, 13, 6, 3, 215, DateTimeKind.Local).AddTicks(285), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(1891), true, false, "Administradores", new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("4b8b1ac3-499a-4d20-bc90-23a34a21ea1d"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8674), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("c633af71-f3be-4d9a-91f9-8bd7d2c79952"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8650), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("90db599d-6391-4cc2-b1d8-44346e0d3cc4"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8628), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("752e8583-b8ab-4827-a000-ef6db96823bc"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8606), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("b245027d-43a4-4677-882a-c3f787521487"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8582), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("29492ce3-d629-4316-9f32-afb024f320d5"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8559), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("8671f903-86ad-4876-a9db-42c51d05f4d5"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8532), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("c65d933c-d2d8-4edf-85a6-3261189b9161"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8455), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("8402416e-e7c2-4eaa-a155-61e95d9fe95b"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8433), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("0f969598-11ae-4c5a-8a1c-8113a833a30b"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8409), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("5ccb9077-944d-4341-96e6-df441b3bc66f"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8387), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("687ce6e1-71c5-421d-940b-2aa1bb9046d0"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8365), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("b9a845b3-0c72-44b4-8f2c-cf50146824fa"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8342), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("c931b032-7b8d-4284-8888-402f5ba020c7"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8321), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("a5dd00fd-a18d-4b96-b030-12304873a534"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8299), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("a4daf52b-1a94-42da-84f9-754be533640c"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8276), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("dc076851-5994-484a-9283-80429002a85d"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("a17e607e-3e46-4a51-a4e3-3370ae6d3ff6"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8250), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("ca67aa44-7a0b-4cd8-a9a0-1b60f465ded2"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8222), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("37214869-9fee-41f6-9cb5-13b122a2cdc4"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8198), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("107c7cf8-bfae-4864-b3d2-7c40d5787bfb"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8162), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("2403d1ca-7d87-4a8a-b691-c4ca95f7ba5f"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(7811), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("df720e53-aa99-4d85-ad99-03b0452b719b"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8696), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("269b7fcf-0ef6-49d8-a937-dbc7a78848d2"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(340), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("88f210d7-73a5-4e30-80a4-5a3ab5c0be7b"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(201), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e867c9c5-4138-45fc-b4ef-b6e9e5cbe003"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 22, 13, 6, 3, 218, DateTimeKind.Local).AddTicks(6544), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(3015), null, "", true, false, "groupusers/details", new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2912), null, "", true, false, "groupusers/list", new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2866), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2820), null, "", true, false, "systems/details", new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2775), null, "", true, false, "systems/list", new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2727), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2675), null, "", true, false, "languages/details", new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2580), null, "", true, false, "languages/list", new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2535), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2487), null, "", true, false, "clients/details", new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2436), null, "", true, false, "clients/list", new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2340), null, "", true, false, "menus/details", new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2288), null, "", true, false, "menus/list", new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2161), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2106), null, "", true, false, "users/details", new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc076851-5994-484a-9283-80429002a85d"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2022), null, "", true, false, "users/list", new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1928), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1636), null, "", true, false, "companyoperators/details", new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1540), null, "", true, false, "companyoperators/list", new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1340), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 22, 13, 6, 3, 220, DateTimeKind.Local).AddTicks(5970), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2389), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 22, 13, 6, 3, 217, DateTimeKind.Local).AddTicks(8151), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("324e883a-7016-4637-a5d8-853e6910684a"), null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(367), true, true, false, new Guid("269b7fcf-0ef6-49d8-a937-dbc7a78848d2"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null },
                    { new Guid("08eb732c-34d9-49aa-a6f6-181ef09a3bd7"), null, new DateTime(2021, 3, 22, 13, 6, 3, 218, DateTimeKind.Local).AddTicks(9858), true, true, false, new Guid("e867c9c5-4138-45fc-b4ef-b6e9e5cbe003"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null },
                    { new Guid("9d2a6009-075b-48ab-a5f8-ead6295e3c33"), null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(309), true, true, false, new Guid("88f210d7-73a5-4e30-80a4-5a3ab5c0be7b"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("51efc264-3765-483c-b54d-1aefd4d59758"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2750), null, true, false, new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9a74cd1c-4fd0-4c4b-90a8-a0c47e8e263f"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2933), null, true, false, new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ba4fe512-8499-456a-8548-3b94e261ba6b"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2886), null, true, false, new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28195b16-b5d7-4c3b-a1a9-4d9bc71b1f35"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2841), null, true, false, new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5fd4321e-9b2d-4721-9b04-1e40731a1626"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2797), null, true, false, new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1ed20729-e6f7-4065-8a98-c4d10d60c726"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2699), null, true, false, new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("229df281-75e2-4d02-907a-4b2dc69c297c"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2647), null, true, false, new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ade80d2b-9cda-4fe3-8e24-fa173d1a5352"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2556), null, true, false, new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ef001ed-3ff6-4ce5-9500-6a16087b15d0"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2510), null, true, false, new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a1400012-7aa6-4666-8bdd-d1dfd831603d"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2459), null, true, false, new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("84dca31a-32da-4f4d-89ed-c73ce3c1d9cf"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2411), null, true, false, new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ce12dad6-aae8-4810-b330-7f856a3b9b1b"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2365), null, true, false, new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7e5378e5-d077-4a33-9466-65cc0a574a4c"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2312), null, true, false, new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("502d7ac3-7f7c-4111-8f9f-573f402d918c"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2250), null, true, false, new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("02fe5ac5-5929-4140-a9a0-de8b2b166a1f"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2135), null, true, false, new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8082a6fe-4dcf-4929-902a-79630cb68ca6"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2061), null, true, false, new Guid("dc076851-5994-484a-9283-80429002a85d"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a75cbd49-3eea-4e2b-8ea3-84839c9861e3"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1977), null, true, false, new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6c5c97e1-794a-4f44-8c8a-2de7a1667e5d"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1679), null, true, false, new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f5c8215-05e6-4dc2-8698-5f6af505283b"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1588), null, true, false, new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f30583e-b55e-4464-b020-236f1543f5ec"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1467), null, true, false, new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4ba0e271-1819-490a-8871-800da462c329"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(39), null, true, false, new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2eab63eb-876f-46d5-876e-8e7c444b4938"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(3040), null, true, false, new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"), null, new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, null, null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(2355), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("125621c4-2582-472b-8605-e3c9312ff10a"), null, null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(4899), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7"), new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(8292), null, new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("fe38001b-9b70-45ec-b6b7-d3919c708bf8"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2864), null, true, false, new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("cda225c3-58a0-419e-b8c2-2baae4145805"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2843), null, true, false, new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f5fd0d86-3f15-492a-8499-adea6ab09f51"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2818), null, true, false, new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("5b10d85d-cae7-4986-b27f-33827b10774c"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2749), null, true, false, new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c5eaa390-f0b8-4b92-8cc8-b9581c6a1d5a"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2727), null, true, false, new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c2e21782-2b5c-4a56-8b57-e29bfc66c1f9"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2706), null, true, false, new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("5dfba400-bd80-4ad2-82d7-28dd8d1d08e8"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2686), null, true, false, new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f5b02938-a252-49af-a4eb-cf9cdc0f7e23"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2665), null, true, false, new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c5a2659a-4096-48a4-9f94-728d4dc32d30"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2643), null, true, false, new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("91f5db60-9213-4435-8c50-f7964c9305a5"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2623), null, true, false, new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("2ab991f2-be6b-476f-b0b2-855862e51d82"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2885), null, true, false, new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f77eaaea-9250-426d-b124-3d1097549c0e"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2578), null, true, false, new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c6cfe0eb-a740-406e-af43-e7232372e159"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2555), null, true, false, new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("117467e3-2eb8-4a0d-945d-12e015ec0753"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2535), null, true, false, new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("48753d45-c486-4994-a3b7-9b63a655c98d"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2513), null, true, false, new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("8851b25c-02f6-4871-b1e7-beee95ab68d6"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2492), null, true, false, new Guid("dc076851-5994-484a-9283-80429002a85d"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("94710b33-935d-4d66-845c-817e0dbba4f7"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2467), null, true, false, new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f3b1996b-90cb-4ff4-aa5a-f49606996721"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2438), null, true, false, new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("7decc1c9-2e28-47e8-a21b-2d6d742a0050"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2335), null, true, false, new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c2191e5c-632a-498b-af92-3c995b697db8"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2296), null, true, false, new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("158ae004-525e-483c-a8fe-b916f9c8128d"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2035), null, true, false, new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("a4c97367-4e24-44c1-a566-5aa90ef0c496"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2602), null, true, false, new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("230bcb5c-cb6d-45b1-a230-0cf21a7a04bd"), "usuário administrativo", null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(276), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b39ed824-d706-4d97-b9f8-bb18c4097bdf"), new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, new DateTime(2021, 3, 22, 13, 6, 3, 218, DateTimeKind.Local).AddTicks(1787), null, true, false, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("eb962159-509d-44e9-8640-374db3f38265"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("b39ed824-d706-4d97-b9f8-bb18c4097bdf"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0f969598-11ae-4c5a-8a1c-8113a833a30b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("107c7cf8-bfae-4864-b3d2-7c40d5787bfb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2403d1ca-7d87-4a8a-b691-c4ca95f7ba5f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29492ce3-d629-4316-9f32-afb024f320d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("37214869-9fee-41f6-9cb5-13b122a2cdc4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4b8b1ac3-499a-4d20-bc90-23a34a21ea1d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ccb9077-944d-4341-96e6-df441b3bc66f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("687ce6e1-71c5-421d-940b-2aa1bb9046d0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("752e8583-b8ab-4827-a000-ef6db96823bc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8402416e-e7c2-4eaa-a155-61e95d9fe95b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8671f903-86ad-4876-a9db-42c51d05f4d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("90db599d-6391-4cc2-b1d8-44346e0d3cc4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a17e607e-3e46-4a51-a4e3-3370ae6d3ff6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a4daf52b-1a94-42da-84f9-754be533640c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a5dd00fd-a18d-4b96-b030-12304873a534"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b245027d-43a4-4677-882a-c3f787521487"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b9a845b3-0c72-44b4-8f2c-cf50146824fa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c633af71-f3be-4d9a-91f9-8bd7d2c79952"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c65d933c-d2d8-4edf-85a6-3261189b9161"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c931b032-7b8d-4284-8888-402f5ba020c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ca67aa44-7a0b-4cd8-a9a0-1b60f465ded2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("df720e53-aa99-4d85-ad99-03b0452b719b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("269b7fcf-0ef6-49d8-a937-dbc7a78848d2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("88f210d7-73a5-4e30-80a4-5a3ab5c0be7b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e867c9c5-4138-45fc-b4ef-b6e9e5cbe003"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("514a9596-1dfa-478f-926e-285aa83cad05"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a378e273-0244-44b8-879c-fb93c871db6e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dc076851-5994-484a-9283-80429002a85d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("08eb732c-34d9-49aa-a6f6-181ef09a3bd7"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("324e883a-7016-4637-a5d8-853e6910684a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("9d2a6009-075b-48ab-a5f8-ead6295e3c33"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("02fe5ac5-5929-4140-a9a0-de8b2b166a1f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1ed20729-e6f7-4065-8a98-c4d10d60c726"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1f30583e-b55e-4464-b020-236f1543f5ec"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("229df281-75e2-4d02-907a-4b2dc69c297c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("28195b16-b5d7-4c3b-a1a9-4d9bc71b1f35"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2eab63eb-876f-46d5-876e-8e7c444b4938"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4ba0e271-1819-490a-8871-800da462c329"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4f5c8215-05e6-4dc2-8698-5f6af505283b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("502d7ac3-7f7c-4111-8f9f-573f402d918c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("51efc264-3765-483c-b54d-1aefd4d59758"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ef001ed-3ff6-4ce5-9500-6a16087b15d0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5fd4321e-9b2d-4721-9b04-1e40731a1626"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6c5c97e1-794a-4f44-8c8a-2de7a1667e5d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7e5378e5-d077-4a33-9466-65cc0a574a4c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8082a6fe-4dcf-4929-902a-79630cb68ca6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("84dca31a-32da-4f4d-89ed-c73ce3c1d9cf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9a74cd1c-4fd0-4c4b-90a8-a0c47e8e263f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a1400012-7aa6-4666-8bdd-d1dfd831603d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a75cbd49-3eea-4e2b-8ea3-84839c9861e3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ade80d2b-9cda-4fe3-8e24-fa173d1a5352"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba4fe512-8499-456a-8548-3b94e261ba6b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ce12dad6-aae8-4810-b330-7f856a3b9b1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("125621c4-2582-472b-8605-e3c9312ff10a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("117467e3-2eb8-4a0d-945d-12e015ec0753"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("158ae004-525e-483c-a8fe-b916f9c8128d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2ab991f2-be6b-476f-b0b2-855862e51d82"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("48753d45-c486-4994-a3b7-9b63a655c98d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5b10d85d-cae7-4986-b27f-33827b10774c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5dfba400-bd80-4ad2-82d7-28dd8d1d08e8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7decc1c9-2e28-47e8-a21b-2d6d742a0050"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8851b25c-02f6-4871-b1e7-beee95ab68d6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("91f5db60-9213-4435-8c50-f7964c9305a5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("94710b33-935d-4d66-845c-817e0dbba4f7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a4c97367-4e24-44c1-a566-5aa90ef0c496"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c2191e5c-632a-498b-af92-3c995b697db8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c2e21782-2b5c-4a56-8b57-e29bfc66c1f9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c5a2659a-4096-48a4-9f94-728d4dc32d30"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c5eaa390-f0b8-4b92-8cc8-b9581c6a1d5a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c6cfe0eb-a740-406e-af43-e7232372e159"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cda225c3-58a0-419e-b8c2-2baae4145805"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f3b1996b-90cb-4ff4-aa5a-f49606996721"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f5b02938-a252-49af-a4eb-cf9cdc0f7e23"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f5fd0d86-3f15-492a-8499-adea6ab09f51"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f77eaaea-9250-426d-b124-3d1097549c0e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fe38001b-9b70-45ec-b6b7-d3919c708bf8"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("230bcb5c-cb6d-45b1-a230-0cf21a7a04bd"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"));

            migrationBuilder.DropColumn(
                name: "CompraOnline",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Site",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Whats",
                table: "Events");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, null, null, null, null, new DateTime(2021, 3, 20, 11, 39, 11, 137, DateTimeKind.Local).AddTicks(7191), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(113), true, false, "Administradores", new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("208dd1c6-8003-4c0d-9a38-444cf3c0a7fb"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3369), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("72af9939-9946-43b8-a795-f818ef4ae88f"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3345), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("79b2675c-0d7c-4051-a1a3-35724aeaa942"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3323), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("36c69e23-6ddf-44a0-b8c6-04bfab9bc1fd"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3301), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("0ef528ac-73b6-4ec0-a7c2-3db00ced7d0b"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3276), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("0d3ad4aa-62b1-4968-89ca-244e1886b531"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3254), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("7850b303-83df-4abb-ad35-7d10fbe6f5c7"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3232), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("685f58bf-bfb3-4d1d-b3c3-6684c69dea98"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3210), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("96ccace8-77df-4bdd-a6ee-e3b34023bffb"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3188), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("523139fd-f247-4d11-b8a4-164b4cae4045"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3160), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("0382da53-f1a5-4669-82bd-76e1aa8ec212"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3093), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("82b35d2c-54c5-4059-84c2-c547190378a5"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3071), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("bdc5b11b-586c-488c-ac5e-799d10a62699"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3047), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("7ea0a8fb-aa9e-40b7-8377-2dd219203e37"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3025), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("a277562c-9415-4978-a057-8ae66afef387"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("11977c94-d4ba-4e09-849b-5719bbc865ff"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3003), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("b3826ca6-4c2a-4603-832f-0ffb2fb89c09"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2980), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("4d6d00da-1f7e-4031-93b3-502c24af1192"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2954), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("b1011fd3-4170-4397-b006-049b951998de"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("d4b7bc36-999a-4029-8bd9-43b0e1cc068c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2924), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("9282db58-14cf-4568-abc6-6d566362c831"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("d6bbd68d-6ada-49c1-bada-3f71e499372b"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2898), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("958e9b50-42fd-49dc-8dd4-6b2096812f51"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2861), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("d65d532b-93e2-4de5-bfd2-9a85e32e3d22"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2580), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("1cbcfc76-e9aa-4ac3-ae12-85f237cb2eb8"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3391), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("6f9d3d14-a7ae-4ae9-8ed0-336660852b0b"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8416), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0688878b-5e72-403f-b6c1-c999258c3ce0"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8262), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e4e53154-3aec-4caa-b79f-4662c7ef53cd"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(3925), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8401), null, "", true, false, "groupusers/details", new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8350), null, "", true, false, "groupusers/list", new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8258), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8207), null, "", true, false, "systems/details", new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8156), null, "", true, false, "systems/list", new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8101), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8045), null, "", true, false, "languages/details", new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7994), null, "", true, false, "languages/list", new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7940), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7852), null, "", true, false, "clients/details", new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7800), null, "", true, false, "clients/list", new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7700), null, "", true, false, "menus/details", new Guid("a277562c-9415-4978-a057-8ae66afef387"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7645), null, "", true, false, "menus/list", new Guid("a277562c-9415-4978-a057-8ae66afef387"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a277562c-9415-4978-a057-8ae66afef387"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7588), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7530), null, "", true, false, "users/details", new Guid("b1011fd3-4170-4397-b006-049b951998de"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7396), null, "", true, false, "users/list", new Guid("b1011fd3-4170-4397-b006-049b951998de"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b1011fd3-4170-4397-b006-049b951998de"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7334), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9282db58-14cf-4568-abc6-6d566362c831"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7192), null, "", true, false, "companyoperators/details", new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7134), null, "", true, false, "companyoperators/list", new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7017), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(4172), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7750), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 20, 11, 39, 11, 140, DateTimeKind.Local).AddTicks(2451), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("348e1552-e2aa-4b18-9b53-01942c227004"), null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8502), true, true, false, new Guid("6f9d3d14-a7ae-4ae9-8ed0-336660852b0b"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null },
                    { new Guid("cf7eec30-8bc8-46bc-8207-a45fc9db1ead"), null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(7708), true, true, false, new Guid("e4e53154-3aec-4caa-b79f-4662c7ef53cd"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null },
                    { new Guid("f9a37221-d983-42bf-bcc7-adc69e2d8c1a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8382), true, true, false, new Guid("0688878b-5e72-403f-b6c1-c999258c3ce0"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("5d56619f-d63c-486b-86e9-e1b3ed038019"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8127), null, true, false, new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f627d29a-da26-48c3-9f07-727f0256bff5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8375), null, true, false, new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("51705aa0-3d7f-4993-aba0-ee09273f7575"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8318), null, true, false, new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8080186c-1b6e-42df-9c8d-66f8ee9245e6"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8232), null, true, false, new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("59086292-7900-4d44-be1c-6014628b7716"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8180), null, true, false, new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ab66fa74-8c7e-48de-b19e-d493f436ea5c"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8070), null, true, false, new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46411d8b-70f9-4567-aadd-20188d983fd9"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8018), null, true, false, new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92a2cb47-1041-47af-835e-d02d763bb795"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7967), null, true, false, new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ade5a3ba-6e53-4a53-b7fb-8f8299d0d2d9"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7876), null, true, false, new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c01884b0-d898-4e75-b037-0d2ce1471143"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7823), null, true, false, new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8497ee0d-79bf-44de-bd97-584253ed8d1f"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7774), null, true, false, new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60e5deb9-28dc-4f7d-83f5-ca8cb662e132"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7724), null, true, false, new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bf889e9-7717-4830-b62e-6c3995491c6a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7672), null, true, false, new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e0ef932-ec4b-43e7-8840-240247ae91a5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7611), null, true, false, new Guid("a277562c-9415-4978-a057-8ae66afef387"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("678e5a97-4b91-4cc0-badd-5154722d923a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7560), null, true, false, new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a024adb-dffd-442d-aa0e-7c6abfaaed6e"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7421), null, true, false, new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7cf52ab0-85e3-4210-9c30-8f512b4f76d5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7365), null, true, false, new Guid("b1011fd3-4170-4397-b006-049b951998de"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdd553ef-b6ce-46ab-8baa-b8b93585d10c"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7218), null, true, false, new Guid("9282db58-14cf-4568-abc6-6d566362c831"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("65de6488-07f4-45fb-9013-d87fa30e0d9e"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7161), null, true, false, new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee84f3cf-a2ce-45c6-ba99-173d71a12e80"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7092), null, true, false, new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("31cb0bee-5629-4639-b984-e2c7e7d0490b"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(6294), null, true, false, new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("73c01573-fafb-4389-908d-901df5721da5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8426), null, true, false, new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"), null, new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, null, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(6929), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b600b3aa-c05b-42cd-bf33-618925e2f8a6"), null, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(9360), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462"), new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(2670), null, new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("97c751b1-89d4-42f2-8b16-4f27cd15db0c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7213), null, true, false, new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("3da6cb32-5f8e-43a3-a405-aa29f6a2124d"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7190), null, true, false, new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("8ebd5652-009a-4522-8903-1c3d60959be0"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7166), null, true, false, new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("2d4344a9-0ddb-41d0-b649-2958d2775652"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7139), null, true, false, new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("457f099b-056f-4efa-ae28-fec65fef210c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7109), null, true, false, new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("aac3fddf-c561-46fa-b6fd-dd9cf746b2a6"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7040), null, true, false, new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a3ef2638-4542-4b33-8760-c8ceb2c4b5e3"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7017), null, true, false, new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a3046e42-20bd-4b91-9cc4-4b3b5f27d3e8"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6994), null, true, false, new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("aa16e52a-fb02-42d0-ad83-a15ef1607024"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6971), null, true, false, new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("732fb23d-859b-4210-88b4-aea3dd17980c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6948), null, true, false, new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("addca7d3-afbc-4ba8-87bd-743741a80d8a"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7236), null, true, false, new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("c325911a-dadf-4385-910f-87ea4590ff62"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6898), null, true, false, new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("2ec28884-97d6-4652-998a-9dd6f8fc720d"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6872), null, true, false, new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("d8b0f2b5-d3f3-47b6-8df8-057c050472bd"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6848), null, true, false, new Guid("a277562c-9415-4978-a057-8ae66afef387"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("4d9e4b6a-8f0f-412e-bbb0-d6c5093901e2"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6825), null, true, false, new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("7a8546eb-164a-4f76-94b7-e911e53c3227"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6801), null, true, false, new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("1b52684d-455a-4a24-a1f6-021e57083701"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6773), null, true, false, new Guid("b1011fd3-4170-4397-b006-049b951998de"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("d432731b-eda7-4c81-9943-e04cb3616899"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6749), null, true, false, new Guid("9282db58-14cf-4568-abc6-6d566362c831"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a515dc99-ea6c-429b-acd1-b72918c03bdc"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6723), null, true, false, new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("85d5353a-d17d-4953-ac81-d204e3d9f432"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6681), null, true, false, new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a6ed022c-b843-4fec-b360-7adae4dc55e8"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6441), null, true, false, new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("32cf5aa8-ad9f-44ef-8c0c-1a86c0ba28bc"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6924), null, true, false, new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("aad70c67-4be1-4a11-bf83-d2001770f325"), "usuário administrativo", null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(4904), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("74b1428c-6fbd-4c60-9945-dcccffa73845"), new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, new DateTime(2021, 3, 20, 11, 39, 11, 140, DateTimeKind.Local).AddTicks(5197), null, true, false, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
