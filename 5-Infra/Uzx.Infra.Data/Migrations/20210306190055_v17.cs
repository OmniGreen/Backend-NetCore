using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDestaque",
                table: "Categories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, null, null, null, null, new DateTime(2021, 3, 6, 16, 0, 52, 663, DateTimeKind.Local).AddTicks(1668), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(4669), true, false, "Administradores", new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("ec48c1ec-c601-41e9-971c-4648b6a449d2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2634), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("9ff83155-67e8-4be1-96c9-dea9e9fe3eb1"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2543), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("2fed3648-4b7b-4e57-b535-4c342998d2c1"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2476), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("bf33c25b-3012-477b-a112-c2c06b4379a2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2395), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("a7b06f99-f01a-4c57-a95f-0f83c00703b3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2306), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("64a55d82-31a5-4e69-9c1c-82e7edc527c3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2213), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("095c4ea9-de48-4856-9650-772334833a99"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("06b6ca61-b538-4027-ad8e-4044c3aff455"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2031), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("66f432e3-836f-4a36-be77-d91648021afb"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("1ff65062-cd81-40d4-a9a2-118b7cf22981"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1945), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("f26501c1-10ab-437b-a638-87633c9f877c"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1862), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("ead8cf04-1e04-4940-8cf5-ce441bd3a07b"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1773), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("e7271a40-44fb-463e-90ed-dea28dcd12a3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1725), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("98d8d0dd-5ddd-48f7-8acb-3b12e4ceb481"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1644), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("1eb1037e-7123-4b85-9c9b-c012794f75e6"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1558), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("c76fed81-a3c6-4de9-b3df-aa6ec03bc143"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1481), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("e94e3fad-98b8-461e-8c79-07aca68017b2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1396), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("7cabd423-e5f5-43ef-9abe-dea2cc91ff2f"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1319), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("7034bee1-e58f-4b6d-8a8a-068e4d64fe82"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1222), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("e8d9bc71-3779-4036-8b3b-27e9353909d5"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1125), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("4f231292-2273-4873-85fe-62765fd891f0"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("02c94584-5e83-4190-9649-193020a2b0d2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1043), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("46e4c471-3543-4e26-9ab8-52f692b92f83"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(925), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("58f2b4fa-4d8e-4d92-9719-ec36b124e1de"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(61), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("1c7358cc-f643-4b69-9b94-397690948112"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("daf2c116-3a14-4cfa-82bd-9573174f46d3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2718), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("8b1f91d0-fab4-4063-a118-37a20c36eeb5"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(2254), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e3f315aa-0c70-417d-ace7-09a4c92914f5"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(1942), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0c60c192-6e89-4216-8347-bb31bcd389f8"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 6, 16, 0, 52, 669, DateTimeKind.Local).AddTicks(6629), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(3030), null, "", true, false, "groupusers/details", new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2947), null, "", true, false, "groupusers/list", new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2868), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2788), null, "", true, false, "systems/details", new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2706), null, "", true, false, "systems/list", new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2600), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("095c4ea9-de48-4856-9650-772334833a99"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2491), null, "", true, false, "languages/details", new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("66f432e3-836f-4a36-be77-d91648021afb"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(1922), null, "", true, false, "languages/list", new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(990), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(822), null, "", true, false, "clients/details", new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(663), null, "", true, false, "clients/list", new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(338), null, "", true, false, "menus/details", new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(148), null, "", true, false, "menus/list", new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9890), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9665), null, "", true, false, "users/details", new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(8109), null, "", true, false, "users/list", new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(7315), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f231292-2273-4873-85fe-62765fd891f0"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6456), null, "", true, false, "companyoperators/details", new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6282), null, "", true, false, "companyoperators/list", new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(5967), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1c7358cc-f643-4b69-9b94-397690948112"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(1318), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(500), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 6, 16, 0, 52, 668, DateTimeKind.Local).AddTicks(5874), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("67969798-295c-47cb-9410-cad71472099a"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(2336), true, true, false, new Guid("8b1f91d0-fab4-4063-a118-37a20c36eeb5"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null },
                    { new Guid("b571b431-1a84-49df-81f9-6dbccaf2024a"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(1494), true, true, false, new Guid("0c60c192-6e89-4216-8347-bb31bcd389f8"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null },
                    { new Guid("8a3e2184-4915-467e-8642-41ad23140238"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(2153), true, true, false, new Guid("e3f315aa-0c70-417d-ace7-09a4c92914f5"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("d26b7278-6fa2-475a-af3a-2ebfcb6a1f62"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2650), null, true, false, new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("78859365-6655-44e3-a2cb-e93188c5d435"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2984), null, true, false, new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("738d340a-1c0b-4954-a582-82246b4853fc"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2905), null, true, false, new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24778eb9-40d3-4ea6-b0d7-eb7b50bff7f5"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2827), null, true, false, new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef6b6148-074a-49a1-9f29-b37c0382039f"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2745), null, true, false, new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6384ae32-0ef5-40a4-a941-93b263903192"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2548), null, true, false, new Guid("095c4ea9-de48-4856-9650-772334833a99"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ff4d5bd-f7b8-4e8f-82be-4be7e9cf713b"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2242), null, true, false, new Guid("66f432e3-836f-4a36-be77-d91648021afb"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a37a55e-6018-47ec-b3ab-0d8b335f82cf"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(1066), null, true, false, new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bf65963a-c4b1-4bd5-93ba-cc8aee73008e"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(902), null, true, false, new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ca6e9eb-da27-40a2-a320-8f71caa844e8"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(743), null, true, false, new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee7a9947-b675-4b14-a7f6-b57216076126"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(579), null, true, false, new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1fdd00c6-3a1b-4b70-9e50-a7ab765671a7"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(421), null, true, false, new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bb1deb70-05f3-4379-86c1-88aeee70becc"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(242), null, true, false, new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ba22f94-d7c5-4e98-a807-b0ba8b27c112"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9971), null, true, false, new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c25343c4-83a2-461f-a8f5-e03d23031d0a"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9788), null, true, false, new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f973b7f4-9dae-4243-82e6-e80b1786f967"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9375), null, true, false, new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("43b9a30d-59eb-4651-b776-e3b1cd52b6fa"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(8002), null, true, false, new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3cb110d6-6020-4b4a-bc33-524d9b2015f2"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6533), null, true, false, new Guid("4f231292-2273-4873-85fe-62765fd891f0"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4430e88d-d267-48b9-9b0c-e6a722fd8553"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6366), null, true, false, new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("800b314d-6cfa-4183-b70c-cde5c9e1d6b0"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6166), null, true, false, new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("58d2a224-299d-453e-ab7b-7026fe560fad"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(4651), null, true, false, new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3749f04a-2b39-4bce-a3bd-4f9cb4fd3aad"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(3245), null, true, false, new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"), null, new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, null, null, new DateTime(2021, 3, 6, 16, 0, 52, 676, DateTimeKind.Local).AddTicks(7567), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("92b38245-12e7-4bf5-a1dd-8b65da81971a"), null, null, new DateTime(2021, 3, 6, 16, 0, 52, 677, DateTimeKind.Local).AddTicks(1940), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297"), new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, new DateTime(2021, 3, 6, 16, 0, 52, 677, DateTimeKind.Local).AddTicks(7632), null, new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("6a811ce7-d453-4a5f-868c-273898071912"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9647), null, true, false, new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("8359c908-bfc8-4549-b0eb-3a45815cf53a"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9607), null, true, false, new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("fdd9ea1b-5e7c-434e-89e3-62db71e00d71"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9505), null, true, false, new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("a57254ad-34c0-4ecb-87f8-2c5a7e6d3177"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9467), null, true, false, new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("582faaf1-9c85-432c-b3c6-0d6480025a57"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9425), null, true, false, new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("a805f0c3-2f69-435c-99ac-2ffdda312655"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9388), null, true, false, new Guid("095c4ea9-de48-4856-9650-772334833a99"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("1c770ab8-79e4-4346-b89d-e31ff9539236"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9352), null, true, false, new Guid("66f432e3-836f-4a36-be77-d91648021afb"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("5a5be487-2237-4213-8ef0-4d32c9d0cc97"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9315), null, true, false, new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("2258c20b-7252-4f16-8063-d4d1ecdea58f"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9273), null, true, false, new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("69856507-1ad4-4b57-bf1c-cac633fa38fe"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9238), null, true, false, new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("7572f4d8-edbf-4a64-a3e8-5943444de904"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9684), null, true, false, new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("e9804be2-13d3-4fae-8e2f-1ea364a8be82"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9166), null, true, false, new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("2eb138e7-1cbd-4f88-b2c7-9e3f3357c629"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9121), null, true, false, new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("4d7cac32-9391-4b16-888e-1b554958380b"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9082), null, true, false, new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("69e8a936-d00a-4af2-b36f-2387c6ec30a4"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9040), null, true, false, new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("d7a548d8-7960-4b22-b49f-338c054ef3da"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(8953), null, true, false, new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("c4a1fff1-49c2-459e-b5e3-ff4606663b0c"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(8566), null, true, false, new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("271190a6-19d0-4d57-ac90-8e3d9f545b5c"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(7982), null, true, false, new Guid("4f231292-2273-4873-85fe-62765fd891f0"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("61637a4e-8330-4d9b-aebd-47a6de764961"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(5660), null, true, false, new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("4ee892be-4260-4131-8cb6-3271f28f1482"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(4817), null, true, false, new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("28c5961a-868f-4976-ada7-d647bd801459"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(4242), null, true, false, new Guid("1c7358cc-f643-4b69-9b94-397690948112"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("a4668510-a86c-499b-88c0-d9745f2a71ff"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9203), null, true, false, new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("40b98801-8ca6-49f9-aa60-f04ed709bb98"), "usuário administrativo", null, new DateTime(2021, 3, 6, 16, 0, 52, 676, DateTimeKind.Local).AddTicks(3030), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3b38e6c9-6daa-4156-89a2-e548757dcf4a"), new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, new DateTime(2021, 3, 6, 16, 0, 52, 669, DateTimeKind.Local).AddTicks(311), null, true, false, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("3b38e6c9-6daa-4156-89a2-e548757dcf4a"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("02c94584-5e83-4190-9649-193020a2b0d2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("06b6ca61-b538-4027-ad8e-4044c3aff455"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1eb1037e-7123-4b85-9c9b-c012794f75e6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1ff65062-cd81-40d4-a9a2-118b7cf22981"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2fed3648-4b7b-4e57-b535-4c342998d2c1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("46e4c471-3543-4e26-9ab8-52f692b92f83"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("58f2b4fa-4d8e-4d92-9719-ec36b124e1de"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("64a55d82-31a5-4e69-9c1c-82e7edc527c3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7034bee1-e58f-4b6d-8a8a-068e4d64fe82"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7cabd423-e5f5-43ef-9abe-dea2cc91ff2f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("98d8d0dd-5ddd-48f7-8acb-3b12e4ceb481"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9ff83155-67e8-4be1-96c9-dea9e9fe3eb1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a7b06f99-f01a-4c57-a95f-0f83c00703b3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bf33c25b-3012-477b-a112-c2c06b4379a2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c76fed81-a3c6-4de9-b3df-aa6ec03bc143"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("daf2c116-3a14-4cfa-82bd-9573174f46d3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e7271a40-44fb-463e-90ed-dea28dcd12a3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e8d9bc71-3779-4036-8b3b-27e9353909d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e94e3fad-98b8-461e-8c79-07aca68017b2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ead8cf04-1e04-4940-8cf5-ce441bd3a07b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec48c1ec-c601-41e9-971c-4648b6a449d2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f26501c1-10ab-437b-a638-87633c9f877c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0c60c192-6e89-4216-8347-bb31bcd389f8"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8b1f91d0-fab4-4063-a118-37a20c36eeb5"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e3f315aa-0c70-417d-ace7-09a4c92914f5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("095c4ea9-de48-4856-9650-772334833a99"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1c7358cc-f643-4b69-9b94-397690948112"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("244bba94-a296-4c91-b855-5924b11c80b5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4f231292-2273-4873-85fe-62765fd891f0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("66f432e3-836f-4a36-be77-d91648021afb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d227929b-80cf-4854-9762-0892c5e934fd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("67969798-295c-47cb-9410-cad71472099a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("8a3e2184-4915-467e-8642-41ad23140238"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("b571b431-1a84-49df-81f9-6dbccaf2024a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1fdd00c6-3a1b-4b70-9e50-a7ab765671a7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("24778eb9-40d3-4ea6-b0d7-eb7b50bff7f5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3749f04a-2b39-4bce-a3bd-4f9cb4fd3aad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3cb110d6-6020-4b4a-bc33-524d9b2015f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3ff4d5bd-f7b8-4e8f-82be-4be7e9cf713b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("43b9a30d-59eb-4651-b776-e3b1cd52b6fa"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4430e88d-d267-48b9-9b0c-e6a722fd8553"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("58d2a224-299d-453e-ab7b-7026fe560fad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5a37a55e-6018-47ec-b3ab-0d8b335f82cf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ba22f94-d7c5-4e98-a807-b0ba8b27c112"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ca6e9eb-da27-40a2-a320-8f71caa844e8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6384ae32-0ef5-40a4-a941-93b263903192"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("738d340a-1c0b-4954-a582-82246b4853fc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("78859365-6655-44e3-a2cb-e93188c5d435"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("800b314d-6cfa-4183-b70c-cde5c9e1d6b0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bb1deb70-05f3-4379-86c1-88aeee70becc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bf65963a-c4b1-4bd5-93ba-cc8aee73008e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c25343c4-83a2-461f-a8f5-e03d23031d0a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d26b7278-6fa2-475a-af3a-2ebfcb6a1f62"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ee7a9947-b675-4b14-a7f6-b57216076126"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ef6b6148-074a-49a1-9f29-b37c0382039f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f973b7f4-9dae-4243-82e6-e80b1786f967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("92b38245-12e7-4bf5-a1dd-8b65da81971a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1c770ab8-79e4-4346-b89d-e31ff9539236"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2258c20b-7252-4f16-8063-d4d1ecdea58f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("271190a6-19d0-4d57-ac90-8e3d9f545b5c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("28c5961a-868f-4976-ada7-d647bd801459"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2eb138e7-1cbd-4f88-b2c7-9e3f3357c629"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4d7cac32-9391-4b16-888e-1b554958380b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4ee892be-4260-4131-8cb6-3271f28f1482"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("582faaf1-9c85-432c-b3c6-0d6480025a57"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5a5be487-2237-4213-8ef0-4d32c9d0cc97"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("61637a4e-8330-4d9b-aebd-47a6de764961"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("69856507-1ad4-4b57-bf1c-cac633fa38fe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("69e8a936-d00a-4af2-b36f-2387c6ec30a4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6a811ce7-d453-4a5f-868c-273898071912"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7572f4d8-edbf-4a64-a3e8-5943444de904"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8359c908-bfc8-4549-b0eb-3a45815cf53a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a4668510-a86c-499b-88c0-d9745f2a71ff"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a57254ad-34c0-4ecb-87f8-2c5a7e6d3177"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a805f0c3-2f69-435c-99ac-2ffdda312655"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c4a1fff1-49c2-459e-b5e3-ff4606663b0c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d7a548d8-7960-4b22-b49f-338c054ef3da"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e9804be2-13d3-4fae-8e2f-1ea364a8be82"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fdd9ea1b-5e7c-434e-89e3-62db71e00d71"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("40b98801-8ca6-49f9-aa60-f04ed709bb98"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"));

            migrationBuilder.DropColumn(
                name: "IsDestaque",
                table: "Categories");

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
    }
}
