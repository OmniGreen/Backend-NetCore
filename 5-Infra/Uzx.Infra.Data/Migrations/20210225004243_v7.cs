using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("b13dcd2f-6680-44e0-b3e6-0148936ac1f9"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("aa73c33a-ce84-4342-ad64-771d4ec64625"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("13ada215-8bfd-48fb-8844-89e811a13835"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("164f866a-937f-4a69-919e-b33a1f899ebd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("18701c52-7808-4981-8619-17391777702e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("19f20e50-145f-4ec2-b0a5-8cae2ab3955b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1f0e723b-b684-4de8-9831-c48a408995ab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("268d87fe-4bfb-4dc7-91b7-556c1f0b5fa9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("27a642da-8671-4a47-9ff7-5f30726326c5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3b326fd1-44a3-486f-a9d8-5c59dcf8a72b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3cfb10f4-fb6a-46f1-b5b8-0f8820615ba7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("51de321a-41fd-4b8f-a99b-bd2544048d03"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5efd2b46-1612-4e54-95e4-4ef59c51f128"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5fbe3d72-6552-4bea-952a-a5cbf05d63d8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("64665393-b978-463d-98c5-34147b06cde9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("78bcc037-5ed4-4137-8004-d509fa87ac08"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("82762c44-a724-4844-9015-615d0580161e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8679b572-7052-46e8-a0db-33da8c38b5b1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9508c352-78ef-41dc-bd7e-0d3bcc7a1dc0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b27c7c04-8e84-4439-b847-04939e337bf8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bd3f5aaa-2427-41f8-9bb5-671abd4233c0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e0e91a03-a6c1-4ac8-8843-da619fd10a7e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f867e574-b33b-4620-a02e-0e18b6d2f990"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fa7d3862-6b4e-4229-9edc-fc64cd813f3f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("28ab2c91-01de-4829-81e6-63b5b73ff746"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8016a938-9a8c-475c-adef-95f2c70abdae"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8626b0d4-534b-43b7-a548-bd11d49d79a9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("096fad4d-35cf-4397-b8b3-1120acad458a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1d4eab66-8cf5-422a-92cc-9171ee81e027"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2b5dd6f8-5061-47c7-b224-572732adf465"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("34a9c37e-8d6d-4632-b23e-af497d3c03c7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("413c1af5-7e65-409d-a78f-a21b78b33894"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4451093a-d1d8-4b82-970d-0071c848490e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("46774297-761c-4bc8-bf95-c0b01d1d92ed"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("49498df0-a380-48be-82ab-95fb0d79302c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("50b09f12-2c62-4aec-aab2-5640cfc45d05"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("50f65112-2ce0-4240-809e-9c6d026cda44"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6ee1d2a7-b886-487c-b6a5-94d7ce23b149"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8aa7461f-e2a6-4a5e-93f1-a95ac6e5204b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8fb8ca0c-b1cc-4261-8894-ee2c00328150"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9044d562-63db-40a5-a481-90c801affea0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("92d5473b-bd12-4892-8c92-a2223862f6b7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("94624ad0-6215-4963-a88c-1cb2594ac138"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("99d8c185-dfc4-4009-8216-81c3cf4c2c91"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a7578166-d225-4728-8713-982779523bba"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("aa8f351e-3cf2-4e01-80ec-9ddb26fc6680"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b6b3a118-c462-4359-a09d-be362bef5fb8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("daf44ea7-539c-409d-9ce1-7154fa73ae7b"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("58b6d9ab-d76b-4b3c-b09d-e097bed9ed33"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("8109a77c-79f2-4afd-83d5-86c9075ae5d5"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("c886f003-2964-4345-95a8-feffe614a917"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("18b1f421-5501-4407-9d27-68ef17a83878"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("20a34b3d-8bd0-4c9f-9abe-dd8637a8a4b0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("24adeb6a-2a74-4e11-81ab-970d937bcc1b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2c01b715-0128-45b9-8619-b91712c31979"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2e01659d-e471-4f97-a5e5-b9beea534952"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2f7b284c-25f4-4a5d-9959-e1edfb87b6e6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5830abb2-41d4-436e-a3bb-60b0c44edbc1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ba67035-2345-46d3-86ad-f45194cdb130"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6b3a2451-4a89-4194-aff0-fe240824c1fa"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7a5519e8-d11c-4cd9-b3e7-ed1686d136de"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("861c6fe4-9733-4a43-b4ed-da6c628ba9fd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("881f95f6-71ed-4dd0-b9dc-2b1849884e5e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8d866491-ff04-446f-87e7-c4009e889dfa"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8d9387bc-2e59-44ef-a7e6-c03234f8184b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9bc5c477-f461-438b-9bff-459001705364"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9cc350a5-910e-42ae-a1aa-8d2b5bddd29e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("be4fe5dd-14e6-4c79-8054-3f8c780ecde3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c5ea3b23-f7b1-44fc-a336-dfa6accb8c2a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d6b9ef35-c32a-43c7-b18d-393eb6c2e674"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("eaf9c3f5-f158-4aff-b55a-243dace8fc46"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("eef34f1b-322e-4074-9225-31651441bcb6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f6828b8f-1cc9-49b7-8737-5622adfa4ec4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3cddc745-b603-4f99-8be6-70ea25d9b9a7"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("b2cb7c06-c84e-4bf7-99d9-7c760a8d07cf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("10862cf6-2a83-4a2f-b255-d75212fb2aa6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1a04d3e1-3401-41df-8b21-01e2bbe44707"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("23dd079c-2e63-46ba-bb2c-4f3ea4667ca4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2bd66e26-6e26-4afa-9b2a-6963be19f148"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2d3b51f3-d6cd-41cf-9ebe-fc2f766f876d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2d92acbb-ee52-4c6c-b3f2-c2d56ae99e06"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4230f371-e513-4c78-93a0-b227f0cd3fc3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("54ada482-5873-4056-af01-2af1e5d68da7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("628b5c90-3274-409e-988b-7337a01d3ecb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("65a2426a-83a2-4065-a565-f6b5711c98a4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("68845f99-0607-4244-a433-0c7aa823fe7e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6a7d0e41-c7f9-45cb-9f39-071bbd30e72e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("78ab8506-2d39-4ac5-ad7f-42b9faca205a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("86c6139a-7d7f-433c-ab23-d1a6ce8f75bf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8c90b560-0301-41c9-beb2-4f8499048e0f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("96c14114-ce92-4105-a106-7963a1b5aa7c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9f939341-9ea8-47f0-b542-03b6e2f5a817"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("be292278-0aea-4767-be7c-c3afc1b33c84"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c29aa404-c881-4a61-85fd-c1c1bf441409"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("de9ddf9c-711d-4cfd-ab9a-4aa8d5a21d94"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e43212b1-7bac-41f2-aae4-4029cfe33bbd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f0610ddb-0f24-42e8-8517-6fa710fe7e7b"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("c8883840-078b-426c-8473-484f7b8d1c02"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtEnd",
                table: "Customers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtStart",
                table: "Customers",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SalePlanId",
                table: "Customers",
                type: "uuid",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DtEnd",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DtStart",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SalePlanId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b13dcd2f-6680-44e0-b3e6-0148936ac1f9"), null, null, null, null, null, new DateTime(2021, 2, 23, 16, 14, 32, 266, DateTimeKind.Local).AddTicks(8445), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), null, new DateTime(2021, 2, 23, 16, 14, 32, 271, DateTimeKind.Local).AddTicks(9640), true, false, "Administradores", new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("5fbe3d72-6552-4bea-952a-a5cbf05d63d8"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(8140), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("4451093a-d1d8-4b82-970d-0071c848490e"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("3cfb10f4-fb6a-46f1-b5b8-0f8820615ba7"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(8107), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("daf44ea7-539c-409d-9ce1-7154fa73ae7b"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("b27c7c04-8e84-4439-b847-04939e337bf8"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(8074), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("8aa7461f-e2a6-4a5e-93f1-a95ac6e5204b"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("51de321a-41fd-4b8f-a99b-bd2544048d03"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(8038), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("46774297-761c-4bc8-bf95-c0b01d1d92ed"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("27a642da-8671-4a47-9ff7-5f30726326c5"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(8002), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("50b09f12-2c62-4aec-aab2-5640cfc45d05"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("8679b572-7052-46e8-a0db-33da8c38b5b1"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7970), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("49498df0-a380-48be-82ab-95fb0d79302c"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("e0e91a03-a6c1-4ac8-8843-da619fd10a7e"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7938), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("34a9c37e-8d6d-4632-b23e-af497d3c03c7"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("19f20e50-145f-4ec2-b0a5-8cae2ab3955b"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7904), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("6ee1d2a7-b886-487c-b6a5-94d7ce23b149"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("3b326fd1-44a3-486f-a9d8-5c59dcf8a72b"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7871), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("1d4eab66-8cf5-422a-92cc-9171ee81e027"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("1f0e723b-b684-4de8-9831-c48a408995ab"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7836), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("9044d562-63db-40a5-a481-90c801affea0"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("82762c44-a724-4844-9015-615d0580161e"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7803), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("50f65112-2ce0-4240-809e-9c6d026cda44"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("fa7d3862-6b4e-4229-9edc-fc64cd813f3f"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7766), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("096fad4d-35cf-4397-b8b3-1120acad458a"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("f867e574-b33b-4620-a02e-0e18b6d2f990"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7729), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("a7578166-d225-4728-8713-982779523bba"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("5efd2b46-1612-4e54-95e4-4ef59c51f128"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7632), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("8fb8ca0c-b1cc-4261-8894-ee2c00328150"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("64665393-b978-463d-98c5-34147b06cde9"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7599), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("99d8c185-dfc4-4009-8216-81c3cf4c2c91"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("bd3f5aaa-2427-41f8-9bb5-671abd4233c0"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7565), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("2b5dd6f8-5061-47c7-b224-572732adf465"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("78bcc037-5ed4-4137-8004-d509fa87ac08"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7526), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("413c1af5-7e65-409d-a78f-a21b78b33894"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("18701c52-7808-4981-8619-17391777702e"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7491), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("b6b3a118-c462-4359-a09d-be362bef5fb8"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("164f866a-937f-4a69-919e-b33a1f899ebd"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7454), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("92d5473b-bd12-4892-8c92-a2223862f6b7"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("9508c352-78ef-41dc-bd7e-0d3bcc7a1dc0"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(7402), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("94624ad0-6215-4963-a88c-1cb2594ac138"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("13ada215-8bfd-48fb-8844-89e811a13835"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(6973), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null },
                    { new Guid("268d87fe-4bfb-4dc7-91b7-556c1f0b5fa9"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(8173), new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("aa8f351e-3cf2-4e01-80ec-9ddb26fc6680"), true, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("8626b0d4-534b-43b7-a548-bd11d49d79a9"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 23, 16, 14, 32, 271, DateTimeKind.Local).AddTicks(7642), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8016a938-9a8c-475c-adef-95f2c70abdae"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 23, 16, 14, 32, 271, DateTimeKind.Local).AddTicks(7467), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28ab2c91-01de-4829-81e6-63b5b73ff746"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 23, 16, 14, 32, 271, DateTimeKind.Local).AddTicks(2635), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("aa8f351e-3cf2-4e01-80ec-9ddb26fc6680"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(1175), null, "", true, false, "groupusers/details", new Guid("daf44ea7-539c-409d-9ce1-7154fa73ae7b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4451093a-d1d8-4b82-970d-0071c848490e"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(1104), null, "", true, false, "groupusers/list", new Guid("daf44ea7-539c-409d-9ce1-7154fa73ae7b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("daf44ea7-539c-409d-9ce1-7154fa73ae7b"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(1030), null, "", true, false, "", new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8aa7461f-e2a6-4a5e-93f1-a95ac6e5204b"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(953), null, "", true, false, "systems/details", new Guid("50b09f12-2c62-4aec-aab2-5640cfc45d05"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46774297-761c-4bc8-bf95-c0b01d1d92ed"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(814), null, "", true, false, "systems/list", new Guid("50b09f12-2c62-4aec-aab2-5640cfc45d05"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("50b09f12-2c62-4aec-aab2-5640cfc45d05"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(738), null, "", true, false, "", new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("49498df0-a380-48be-82ab-95fb0d79302c"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(666), null, "", true, false, "languages/details", new Guid("6ee1d2a7-b886-487c-b6a5-94d7ce23b149"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("34a9c37e-8d6d-4632-b23e-af497d3c03c7"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(593), null, "", true, false, "languages/list", new Guid("6ee1d2a7-b886-487c-b6a5-94d7ce23b149"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6ee1d2a7-b886-487c-b6a5-94d7ce23b149"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(521), null, "", true, false, "", new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d4eab66-8cf5-422a-92cc-9171ee81e027"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(449), null, "", true, false, "clients/details", new Guid("50f65112-2ce0-4240-809e-9c6d026cda44"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9044d562-63db-40a5-a481-90c801affea0"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(309), null, "", true, false, "clients/list", new Guid("50f65112-2ce0-4240-809e-9c6d026cda44"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("096fad4d-35cf-4397-b8b3-1120acad458a"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(162), null, "", true, false, "menus/details", new Guid("8fb8ca0c-b1cc-4261-8894-ee2c00328150"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a7578166-d225-4728-8713-982779523bba"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(88), null, "", true, false, "menus/list", new Guid("8fb8ca0c-b1cc-4261-8894-ee2c00328150"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8fb8ca0c-b1cc-4261-8894-ee2c00328150"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(15), null, "", true, false, "", new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("99d8c185-dfc4-4009-8216-81c3cf4c2c91"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9940), null, "", true, false, "users/details", new Guid("413c1af5-7e65-409d-a78f-a21b78b33894"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2b5dd6f8-5061-47c7-b224-572732adf465"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9867), null, "", true, false, "users/list", new Guid("413c1af5-7e65-409d-a78f-a21b78b33894"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("413c1af5-7e65-409d-a78f-a21b78b33894"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9684), null, "", true, false, "", new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b6b3a118-c462-4359-a09d-be362bef5fb8"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9478), null, "", true, false, "companyoperators/details", new Guid("94624ad0-6215-4963-a88c-1cb2594ac138"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92d5473b-bd12-4892-8c92-a2223862f6b7"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9394), null, "", true, false, "companyoperators/list", new Guid("94624ad0-6215-4963-a88c-1cb2594ac138"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("94624ad0-6215-4963-a88c-1cb2594ac138"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9226), null, "", true, false, "", new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(5367), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("50f65112-2ce0-4240-809e-9c6d026cda44"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(234), null, "", true, false, "", new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 23, 16, 14, 32, 270, DateTimeKind.Local).AddTicks(3640), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("8109a77c-79f2-4afd-83d5-86c9075ae5d5"), null, new DateTime(2021, 2, 23, 16, 14, 32, 271, DateTimeKind.Local).AddTicks(7696), true, true, false, new Guid("8626b0d4-534b-43b7-a548-bd11d49d79a9"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, null },
                    { new Guid("58b6d9ab-d76b-4b3c-b09d-e097bed9ed33"), null, new DateTime(2021, 2, 23, 16, 14, 32, 271, DateTimeKind.Local).AddTicks(6998), true, true, false, new Guid("28ab2c91-01de-4829-81e6-63b5b73ff746"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, null },
                    { new Guid("c886f003-2964-4345-95a8-feffe614a917"), null, new DateTime(2021, 2, 23, 16, 14, 32, 271, DateTimeKind.Local).AddTicks(7595), true, true, false, new Guid("8016a938-9a8c-475c-adef-95f2c70abdae"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("5830abb2-41d4-436e-a3bb-60b0c44edbc1"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(774), null, true, false, new Guid("50b09f12-2c62-4aec-aab2-5640cfc45d05"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("be4fe5dd-14e6-4c79-8054-3f8c780ecde3"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(1138), null, true, false, new Guid("4451093a-d1d8-4b82-970d-0071c848490e"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eaf9c3f5-f158-4aff-b55a-243dace8fc46"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(1065), null, true, false, new Guid("daf44ea7-539c-409d-9ce1-7154fa73ae7b"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6b3a2451-4a89-4194-aff0-fe240824c1fa"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(989), null, true, false, new Guid("8aa7461f-e2a6-4a5e-93f1-a95ac6e5204b"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("881f95f6-71ed-4dd0-b9dc-2b1849884e5e"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(848), null, true, false, new Guid("46774297-761c-4bc8-bf95-c0b01d1d92ed"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2c01b715-0128-45b9-8619-b91712c31979"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(699), null, true, false, new Guid("49498df0-a380-48be-82ab-95fb0d79302c"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5ea3b23-f7b1-44fc-a336-dfa6accb8c2a"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(626), null, true, false, new Guid("34a9c37e-8d6d-4632-b23e-af497d3c03c7"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("20a34b3d-8bd0-4c9f-9abe-dd8637a8a4b0"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(555), null, true, false, new Guid("6ee1d2a7-b886-487c-b6a5-94d7ce23b149"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ba67035-2345-46d3-86ad-f45194cdb130"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(483), null, true, false, new Guid("1d4eab66-8cf5-422a-92cc-9171ee81e027"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7a5519e8-d11c-4cd9-b3e7-ed1686d136de"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(407), null, true, false, new Guid("9044d562-63db-40a5-a481-90c801affea0"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2e01659d-e471-4f97-a5e5-b9beea534952"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(267), null, true, false, new Guid("50f65112-2ce0-4240-809e-9c6d026cda44"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f6828b8f-1cc9-49b7-8737-5622adfa4ec4"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(196), null, true, false, new Guid("096fad4d-35cf-4397-b8b3-1120acad458a"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9bc5c477-f461-438b-9bff-459001705364"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(123), null, true, false, new Guid("a7578166-d225-4728-8713-982779523bba"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d9387bc-2e59-44ef-a7e6-c03234f8184b"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(48), null, true, false, new Guid("8fb8ca0c-b1cc-4261-8894-ee2c00328150"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("18b1f421-5501-4407-9d27-68ef17a83878"), null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9973), null, true, false, new Guid("99d8c185-dfc4-4009-8216-81c3cf4c2c91"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eef34f1b-322e-4074-9225-31651441bcb6"), null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9902), null, true, false, new Guid("2b5dd6f8-5061-47c7-b224-572732adf465"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2f7b284c-25f4-4a5d-9959-e1edfb87b6e6"), null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9816), null, true, false, new Guid("413c1af5-7e65-409d-a78f-a21b78b33894"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9cc350a5-910e-42ae-a1aa-8d2b5bddd29e"), null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9511), null, true, false, new Guid("b6b3a118-c462-4359-a09d-be362bef5fb8"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d866491-ff04-446f-87e7-c4009e889dfa"), null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9431), null, true, false, new Guid("92d5473b-bd12-4892-8c92-a2223862f6b7"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24adeb6a-2a74-4e11-81ab-970d937bcc1b"), null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(9337), null, true, false, new Guid("94624ad0-6215-4963-a88c-1cb2594ac138"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("861c6fe4-9733-4a43-b4ed-da6c628ba9fd"), null, new DateTime(2021, 2, 23, 16, 14, 32, 272, DateTimeKind.Local).AddTicks(8232), null, true, false, new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d6b9ef35-c32a-43c7-b18d-393eb6c2e674"), null, new DateTime(2021, 2, 23, 16, 14, 32, 273, DateTimeKind.Local).AddTicks(1208), null, true, false, new Guid("aa8f351e-3cf2-4e01-80ec-9ddb26fc6680"), new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3cddc745-b603-4f99-8be6-70ea25d9b9a7"), null, new Guid("b13dcd2f-6680-44e0-b3e6-0148936ac1f9"), null, null, null, new DateTime(2021, 2, 23, 16, 14, 32, 274, DateTimeKind.Local).AddTicks(3274), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b2cb7c06-c84e-4bf7-99d9-7c760a8d07cf"), null, null, new DateTime(2021, 2, 23, 16, 14, 32, 274, DateTimeKind.Local).AddTicks(6654), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("3cddc745-b603-4f99-8be6-70ea25d9b9a7"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243"), new Guid("b13dcd2f-6680-44e0-b3e6-0148936ac1f9"), null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(1239), null, new Guid("c238648a-a067-4758-8fd9-67ae9273a19b"), true, false, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), new Guid("3cddc745-b603-4f99-8be6-70ea25d9b9a7"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("68845f99-0607-4244-a433-0c7aa823fe7e"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7553), null, true, false, new Guid("4451093a-d1d8-4b82-970d-0071c848490e"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("8c90b560-0301-41c9-beb2-4f8499048e0f"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7517), null, true, false, new Guid("daf44ea7-539c-409d-9ce1-7154fa73ae7b"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("de9ddf9c-711d-4cfd-ab9a-4aa8d5a21d94"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7482), null, true, false, new Guid("8aa7461f-e2a6-4a5e-93f1-a95ac6e5204b"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("54ada482-5873-4056-af01-2af1e5d68da7"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7447), null, true, false, new Guid("46774297-761c-4bc8-bf95-c0b01d1d92ed"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("2d92acbb-ee52-4c6c-b3f2-c2d56ae99e06"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7410), null, true, false, new Guid("50b09f12-2c62-4aec-aab2-5640cfc45d05"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("628b5c90-3274-409e-988b-7337a01d3ecb"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7370), null, true, false, new Guid("49498df0-a380-48be-82ab-95fb0d79302c"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("4230f371-e513-4c78-93a0-b227f0cd3fc3"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7335), null, true, false, new Guid("34a9c37e-8d6d-4632-b23e-af497d3c03c7"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("f0610ddb-0f24-42e8-8517-6fa710fe7e7b"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7300), null, true, false, new Guid("6ee1d2a7-b886-487c-b6a5-94d7ce23b149"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("e43212b1-7bac-41f2-aae4-4029cfe33bbd"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7259), null, true, false, new Guid("1d4eab66-8cf5-422a-92cc-9171ee81e027"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("9f939341-9ea8-47f0-b542-03b6e2f5a817"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7132), null, true, false, new Guid("9044d562-63db-40a5-a481-90c801affea0"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("23dd079c-2e63-46ba-bb2c-4f3ea4667ca4"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7588), null, true, false, new Guid("aa8f351e-3cf2-4e01-80ec-9ddb26fc6680"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("be292278-0aea-4767-be7c-c3afc1b33c84"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7065), null, true, false, new Guid("096fad4d-35cf-4397-b8b3-1120acad458a"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("65a2426a-83a2-4065-a565-f6b5711c98a4"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7027), null, true, false, new Guid("a7578166-d225-4728-8713-982779523bba"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("6a7d0e41-c7f9-45cb-9f39-071bbd30e72e"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6986), null, true, false, new Guid("8fb8ca0c-b1cc-4261-8894-ee2c00328150"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("10862cf6-2a83-4a2f-b255-d75212fb2aa6"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6953), null, true, false, new Guid("99d8c185-dfc4-4009-8216-81c3cf4c2c91"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("2bd66e26-6e26-4afa-9b2a-6963be19f148"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6918), null, true, false, new Guid("2b5dd6f8-5061-47c7-b224-572732adf465"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("86c6139a-7d7f-433c-ab23-d1a6ce8f75bf"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6878), null, true, false, new Guid("413c1af5-7e65-409d-a78f-a21b78b33894"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("1a04d3e1-3401-41df-8b21-01e2bbe44707"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6843), null, true, false, new Guid("b6b3a118-c462-4359-a09d-be362bef5fb8"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("96c14114-ce92-4105-a106-7963a1b5aa7c"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6807), null, true, false, new Guid("92d5473b-bd12-4892-8c92-a2223862f6b7"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("78ab8506-2d39-4ac5-ad7f-42b9faca205a"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6759), null, true, false, new Guid("94624ad0-6215-4963-a88c-1cb2594ac138"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("2d3b51f3-d6cd-41cf-9ebe-fc2f766f876d"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(6418), null, true, false, new Guid("7a8f92f7-6697-4d0b-9b71-558debb262ef"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") },
                    { new Guid("c29aa404-c881-4a61-85fd-c1c1bf441409"), true, true, null, new DateTime(2021, 2, 23, 16, 14, 32, 275, DateTimeKind.Local).AddTicks(7099), null, true, false, new Guid("50f65112-2ce0-4240-809e-9c6d026cda44"), true, true, null, null, null, new Guid("de79fb72-35ea-4c9c-b3da-e05c16f49243") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c8883840-078b-426c-8473-484f7b8d1c02"), "usuário administrativo", null, new DateTime(2021, 2, 23, 16, 14, 32, 274, DateTimeKind.Local).AddTicks(315), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("aa73c33a-ce84-4342-ad64-771d4ec64625"), new Guid("b13dcd2f-6680-44e0-b3e6-0148936ac1f9"), null, new DateTime(2021, 2, 23, 16, 14, 32, 270, DateTimeKind.Local).AddTicks(7529), null, true, false, new Guid("93502c5d-4ed6-49ce-94c2-464f8c1d0f47"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
