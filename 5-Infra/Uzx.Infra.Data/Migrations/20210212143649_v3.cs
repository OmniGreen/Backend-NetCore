using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("a3522caf-3dc4-4d5f-99bc-04cb53ec048c"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("962459e5-7aa7-429f-9229-f803564b8df6"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("16560694-8c27-4dc3-868f-432996b6813f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("167aa248-af28-4a75-be60-efeb3558bcaa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1813b31e-0cbd-44f2-af0a-11855e786a23"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("18467932-d9d3-468d-80b9-592c8cadfc30"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1f9ede27-64b5-4599-9188-7146d83e8ac0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3a97fd05-f153-4be5-bd6e-490f0e601407"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("428562fb-7aea-490b-855e-328c327435cd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("46730a74-efc8-4aba-bed4-ea93cb52665e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4936eb0a-368d-48dc-bd23-0dbe956f09d0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9c5205bd-b47d-4217-800d-8be4a88ad6ea"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("aa1577fd-7bf7-4604-9c0a-1aeee19b2a89"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("abaff8d3-d1cf-4ff3-a9af-36fde1619b2e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b13ebc50-bb22-4ad7-a1d6-cc08e77d2ac3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b17a5f37-32e0-43ac-ab89-3392e6d34952"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b30d0ad9-4d4f-4830-8d12-d70011f9b067"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b5757bb1-a99e-4a23-8da2-c69d6fa9bb1f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c6fbbfb0-7cf5-413a-8d7b-21a97df1a6c6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e33cc6dd-022b-4eff-b775-0c0945ef1674"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e619f786-a834-4586-a6ac-6e2bac9f856f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e6d40e1e-b139-4528-bff4-4b96225acc7e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f2803f46-6783-4176-b904-63eb2813c857"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f6ccbd25-8412-4ad1-aa1f-bec97f6b50b9"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2968576b-d1bc-4867-8cc9-becacbed1688"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("55c8130a-01d3-402c-abef-431f9f210821"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ef907f31-90c2-4c80-a804-9d98a876d2d1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0576896b-a2f2-4610-bc14-e1cb73a71f71"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0f990845-beb9-4a0d-90cb-a6311be1a965"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1068c4c3-53fb-42ea-9a6a-5fd79c331e35"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("15f2f20c-ff5b-4840-b7e7-5a4eef4de3af"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("19a2995f-1896-494e-97c9-dc5fe2663c59"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2f26c4dd-ec11-457f-ac45-4ed69dfb3299"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("39afe650-000a-460b-8749-aa222eb85ea9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("463cbd9a-dd66-4729-a7eb-187f7208c99f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4c03c5c4-66fe-480a-905a-da6ecc7b6536"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4fe47a55-9c25-43fd-b94b-98dd23326fe2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5cbcb384-fc0b-4996-a938-00f664246600"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6ef3247b-3333-4a9c-b1e8-b479b33b79aa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7ce49dfb-e173-4ff1-85d7-c02fac31d27b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("870a6a74-61aa-4ec9-a7d9-9782e24ab99d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b24467f9-ca86-4ab4-a178-0c27f1c52c4c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b7108e98-a057-410b-819e-f235501592a6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bbe01673-7427-40a7-93bc-c91510c6f63a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bcc697c5-5bb3-4c14-8b0e-3f74e8e07ca7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d98b72c3-a0ff-4a09-83e5-223609cbdd9c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fc679e61-ac38-4855-a066-3f66cc294816"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fcfd978e-b33e-478e-b0e3-f4e433c2886f"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("4c97f992-38fc-4d20-8a07-a02ce2d10ba3"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("e4bc1d5d-8bc4-42d0-8b8b-5142a39134b3"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("e6249783-b038-4644-b913-4126604af50b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0968c9ec-2084-40eb-9ef9-7c8917328b53"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0bf11b03-775c-41fa-9c3e-737716a5ae33"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("182820d1-5cf6-48ad-bc92-0da9cfd52e39"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3fae1aed-cb22-4c02-8841-84b8497ee358"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("43c3855d-5be5-4621-82ca-9551a0daec47"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("485ebb40-07a2-4e21-addc-6c2be6486b81"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4aaa34de-059d-4a75-9c98-486a68e88c86"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4dd111ac-8de4-48e4-b93e-b1c2a9c721b8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6a3523d0-d06d-4758-a160-216514f0ff21"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("77765e3d-1232-4b64-8e8f-39adb039ac4a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("90637bd9-cc1f-4dad-a0c9-497e51ed6577"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("98008ed0-d1f6-45cd-aa11-76ba5c5f5b80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9e0b1aa3-9a88-43ff-825f-23610650ea26"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a2760e14-dd00-4ac8-8910-6892e76bc722"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b29d2f04-dc71-4f11-83d9-5e8ed956f343"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c87db485-d953-4065-a9eb-ec21385404c7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cf0b2839-d2c8-42be-87a7-325a2a80515c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d5fba87f-1b66-49aa-a46a-8ef8c4fd41c2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("df65197a-75ac-4c75-ba17-31bf7c595ae6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("efcc0379-46cc-457d-91b9-e1b68dc923bf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f69645a8-e9fa-49f8-87aa-0086e38e7d71"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fe641ee4-8350-435f-94bb-62e90e88bb08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9b89a76b-d060-4b17-8dbc-d19cd78b195e"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("fbf77ae9-60aa-4dde-8ab5-b32b78b75f75"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("048d3720-fc0e-4868-9faa-53d652d2cd48"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("05e0bd97-a6f4-44dd-a266-d5ec99d520a8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0917d35c-cf24-4ddd-93c6-612a158e394d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0db4b208-10e9-4713-a7b9-ed22be68c0c9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("22af1cc2-a622-4d1e-8313-a12398b1a3fb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("31da36a9-7c74-41aa-859d-89841c5d1a7b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("38fa6ad9-c358-464a-bdd2-a43732116fb5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("41be431e-710d-4ef4-bed9-bde46a4bf194"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("442a7706-d068-4272-bd5b-ecb53d84e1c9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6cff3c5c-6855-4e91-becf-061cff542186"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7147ea6b-6edb-4dde-a302-a42880de889e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("71fe5266-f9e9-48e8-bb54-aa0678be6d46"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7245a99e-3829-4c15-872a-8ad1ed2db2a5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7b634c15-0b67-4f4d-bb2a-163e4492136e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("894ad0a1-f46a-4654-af0e-c01bc49aa2c9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("99568c3f-405f-4ce6-848f-3fa55e4eab1c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("becec4e6-de85-4221-9bda-7b203a8f2a6b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c8d2871e-3e06-4a54-a932-243cf40fe883"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cc8e503a-36ba-40d3-ac9f-6f36df484f4e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e7a58e9a-1325-4092-9d13-9d2514ab8bfd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("eef3d23f-33e4-4097-a3a0-86cad3a31487"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("feda64cc-52a0-483a-9c64-11a22c5a1cfd"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("9bcae2e2-02b7-4851-8480-2de22f5df6c0"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"));

            migrationBuilder.AddColumn<string>(
                name: "NameBanner",
                table: "Banners",
                type: "text",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "NameBanner",
                table: "Banners");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a3522caf-3dc4-4d5f-99bc-04cb53ec048c"), null, null, null, null, null, new DateTime(2021, 2, 11, 19, 45, 19, 961, DateTimeKind.Local).AddTicks(9979), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4095), true, false, "Administradores", new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("b13ebc50-bb22-4ad7-a1d6-cc08e77d2ac3"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1939), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("bcc697c5-5bb3-4c14-8b0e-3f74e8e07ca7"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("167aa248-af28-4a75-be60-efeb3558bcaa"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1921), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("2f26c4dd-ec11-457f-ac45-4ed69dfb3299"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("4936eb0a-368d-48dc-bd23-0dbe956f09d0"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1902), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("15f2f20c-ff5b-4840-b7e7-5a4eef4de3af"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("18467932-d9d3-468d-80b9-592c8cadfc30"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1884), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("19a2995f-1896-494e-97c9-dc5fe2663c59"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("46730a74-efc8-4aba-bed4-ea93cb52665e"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1864), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("bbe01673-7427-40a7-93bc-c91510c6f63a"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("e33cc6dd-022b-4eff-b775-0c0945ef1674"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1844), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("0576896b-a2f2-4610-bc14-e1cb73a71f71"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("16560694-8c27-4dc3-868f-432996b6813f"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1826), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("b7108e98-a057-410b-819e-f235501592a6"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("f6ccbd25-8412-4ad1-aa1f-bec97f6b50b9"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1807), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("fcfd978e-b33e-478e-b0e3-f4e433c2886f"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("b17a5f37-32e0-43ac-ab89-3392e6d34952"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1788), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("b24467f9-ca86-4ab4-a178-0c27f1c52c4c"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("c6fbbfb0-7cf5-413a-8d7b-21a97df1a6c6"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1770), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("4fe47a55-9c25-43fd-b94b-98dd23326fe2"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("428562fb-7aea-490b-855e-328c327435cd"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1752), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("6ef3247b-3333-4a9c-b1e8-b479b33b79aa"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("aa1577fd-7bf7-4604-9c0a-1aeee19b2a89"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1733), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("d98b72c3-a0ff-4a09-83e5-223609cbdd9c"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("3a97fd05-f153-4be5-bd6e-490f0e601407"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1685), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("5cbcb384-fc0b-4996-a938-00f664246600"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("9c5205bd-b47d-4217-800d-8be4a88ad6ea"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1662), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("4c03c5c4-66fe-480a-905a-da6ecc7b6536"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("abaff8d3-d1cf-4ff3-a9af-36fde1619b2e"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1644), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("0f990845-beb9-4a0d-90cb-a6311be1a965"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("e6d40e1e-b139-4528-bff4-4b96225acc7e"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1625), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("7ce49dfb-e173-4ff1-85d7-c02fac31d27b"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("f2803f46-6783-4176-b904-63eb2813c857"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1604), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("1068c4c3-53fb-42ea-9a6a-5fd79c331e35"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("b30d0ad9-4d4f-4830-8d12-d70011f9b067"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1585), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("39afe650-000a-460b-8749-aa222eb85ea9"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("1813b31e-0cbd-44f2-af0a-11855e786a23"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1566), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("870a6a74-61aa-4ec9-a7d9-9782e24ab99d"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("b5757bb1-a99e-4a23-8da2-c69d6fa9bb1f"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1543), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("463cbd9a-dd66-4729-a7eb-187f7208c99f"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("1f9ede27-64b5-4599-9188-7146d83e8ac0"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1389), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null },
                    { new Guid("e619f786-a834-4586-a6ac-6e2bac9f856f"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(1957), new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("fc679e61-ac38-4855-a066-3f66cc294816"), true, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("ef907f31-90c2-4c80-a804-9d98a876d2d1"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4056), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("55c8130a-01d3-402c-abef-431f9f210821"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(3977), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2968576b-d1bc-4867-8cc9-becacbed1688"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(3863), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("fc679e61-ac38-4855-a066-3f66cc294816"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9582), null, "", true, false, "groupusers/details", new Guid("2f26c4dd-ec11-457f-ac45-4ed69dfb3299"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bcc697c5-5bb3-4c14-8b0e-3f74e8e07ca7"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9545), null, "", true, false, "groupusers/list", new Guid("2f26c4dd-ec11-457f-ac45-4ed69dfb3299"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2f26c4dd-ec11-457f-ac45-4ed69dfb3299"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9508), null, "", true, false, "", new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("15f2f20c-ff5b-4840-b7e7-5a4eef4de3af"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9449), null, "", true, false, "systems/details", new Guid("bbe01673-7427-40a7-93bc-c91510c6f63a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("19a2995f-1896-494e-97c9-dc5fe2663c59"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9411), null, "", true, false, "systems/list", new Guid("bbe01673-7427-40a7-93bc-c91510c6f63a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bbe01673-7427-40a7-93bc-c91510c6f63a"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9371), null, "", true, false, "", new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0576896b-a2f2-4610-bc14-e1cb73a71f71"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9333), null, "", true, false, "languages/details", new Guid("fcfd978e-b33e-478e-b0e3-f4e433c2886f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b7108e98-a057-410b-819e-f235501592a6"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9295), null, "", true, false, "languages/list", new Guid("fcfd978e-b33e-478e-b0e3-f4e433c2886f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fcfd978e-b33e-478e-b0e3-f4e433c2886f"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9256), null, "", true, false, "", new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b24467f9-ca86-4ab4-a178-0c27f1c52c4c"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9219), null, "", true, false, "clients/details", new Guid("6ef3247b-3333-4a9c-b1e8-b479b33b79aa"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4fe47a55-9c25-43fd-b94b-98dd23326fe2"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9149), null, "", true, false, "clients/list", new Guid("6ef3247b-3333-4a9c-b1e8-b479b33b79aa"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d98b72c3-a0ff-4a09-83e5-223609cbdd9c"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9072), null, "", true, false, "menus/details", new Guid("4c03c5c4-66fe-480a-905a-da6ecc7b6536"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5cbcb384-fc0b-4996-a938-00f664246600"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9028), null, "", true, false, "menus/list", new Guid("4c03c5c4-66fe-480a-905a-da6ecc7b6536"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c03c5c4-66fe-480a-905a-da6ecc7b6536"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(8953), null, "", true, false, "", new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0f990845-beb9-4a0d-90cb-a6311be1a965"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(8910), null, "", true, false, "users/details", new Guid("1068c4c3-53fb-42ea-9a6a-5fd79c331e35"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7ce49dfb-e173-4ff1-85d7-c02fac31d27b"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(7611), null, "", true, false, "users/list", new Guid("1068c4c3-53fb-42ea-9a6a-5fd79c331e35"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1068c4c3-53fb-42ea-9a6a-5fd79c331e35"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4571), null, "", true, false, "", new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("39afe650-000a-460b-8749-aa222eb85ea9"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4505), null, "", true, false, "companyoperators/details", new Guid("463cbd9a-dd66-4729-a7eb-187f7208c99f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("870a6a74-61aa-4ec9-a7d9-9782e24ab99d"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4469), null, "", true, false, "companyoperators/list", new Guid("463cbd9a-dd66-4729-a7eb-187f7208c99f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("463cbd9a-dd66-4729-a7eb-187f7208c99f"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4428), null, "", true, false, "", new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4306), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6ef3247b-3333-4a9c-b1e8-b479b33b79aa"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9112), null, "", true, false, "", new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(3679), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("e4bc1d5d-8bc4-42d0-8b8b-5142a39134b3"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4074), true, true, false, new Guid("ef907f31-90c2-4c80-a804-9d98a876d2d1"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, null },
                    { new Guid("e6249783-b038-4644-b913-4126604af50b"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(3920), true, true, false, new Guid("2968576b-d1bc-4867-8cc9-becacbed1688"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, null },
                    { new Guid("4c97f992-38fc-4d20-8a07-a02ce2d10ba3"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4037), true, true, false, new Guid("55c8130a-01d3-402c-abef-431f9f210821"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("43c3855d-5be5-4621-82ca-9551a0daec47"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9390), null, true, false, new Guid("bbe01673-7427-40a7-93bc-c91510c6f63a"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c87db485-d953-4065-a9eb-ec21385404c7"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9562), null, true, false, new Guid("bcc697c5-5bb3-4c14-8b0e-3f74e8e07ca7"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("98008ed0-d1f6-45cd-aa11-76ba5c5f5b80"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9525), null, true, false, new Guid("2f26c4dd-ec11-457f-ac45-4ed69dfb3299"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("90637bd9-cc1f-4dad-a0c9-497e51ed6577"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9488), null, true, false, new Guid("15f2f20c-ff5b-4840-b7e7-5a4eef4de3af"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("182820d1-5cf6-48ad-bc92-0da9cfd52e39"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9428), null, true, false, new Guid("19a2995f-1896-494e-97c9-dc5fe2663c59"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df65197a-75ac-4c75-ba17-31bf7c595ae6"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9350), null, true, false, new Guid("0576896b-a2f2-4610-bc14-e1cb73a71f71"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b29d2f04-dc71-4f11-83d9-5e8ed956f343"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9313), null, true, false, new Guid("b7108e98-a057-410b-819e-f235501592a6"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3fae1aed-cb22-4c02-8841-84b8497ee358"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9274), null, true, false, new Guid("fcfd978e-b33e-478e-b0e3-f4e433c2886f"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a2760e14-dd00-4ac8-8910-6892e76bc722"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9237), null, true, false, new Guid("b24467f9-ca86-4ab4-a178-0c27f1c52c4c"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fe641ee4-8350-435f-94bb-62e90e88bb08"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9167), null, true, false, new Guid("4fe47a55-9c25-43fd-b94b-98dd23326fe2"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4dd111ac-8de4-48e4-b93e-b1c2a9c721b8"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9129), null, true, false, new Guid("6ef3247b-3333-4a9c-b1e8-b479b33b79aa"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6a3523d0-d06d-4758-a160-216514f0ff21"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9090), null, true, false, new Guid("d98b72c3-a0ff-4a09-83e5-223609cbdd9c"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cf0b2839-d2c8-42be-87a7-325a2a80515c"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9050), null, true, false, new Guid("5cbcb384-fc0b-4996-a938-00f664246600"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("efcc0379-46cc-457d-91b9-e1b68dc923bf"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(8971), null, true, false, new Guid("4c03c5c4-66fe-480a-905a-da6ecc7b6536"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4aaa34de-059d-4a75-9c98-486a68e88c86"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(8931), null, true, false, new Guid("0f990845-beb9-4a0d-90cb-a6311be1a965"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("77765e3d-1232-4b64-8e8f-39adb039ac4a"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(8837), null, true, false, new Guid("7ce49dfb-e173-4ff1-85d7-c02fac31d27b"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("485ebb40-07a2-4e21-addc-6c2be6486b81"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4591), null, true, false, new Guid("1068c4c3-53fb-42ea-9a6a-5fd79c331e35"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0968c9ec-2084-40eb-9ef9-7c8917328b53"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4522), null, true, false, new Guid("39afe650-000a-460b-8749-aa222eb85ea9"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f69645a8-e9fa-49f8-87aa-0086e38e7d71"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4486), null, true, false, new Guid("870a6a74-61aa-4ec9-a7d9-9782e24ab99d"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d5fba87f-1b66-49aa-a46a-8ef8c4fd41c2"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4446), null, true, false, new Guid("463cbd9a-dd66-4729-a7eb-187f7208c99f"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0bf11b03-775c-41fa-9c3e-737716a5ae33"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(4373), null, true, false, new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9e0b1aa3-9a88-43ff-825f-23610650ea26"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(9599), null, true, false, new Guid("fc679e61-ac38-4855-a066-3f66cc294816"), new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9b89a76b-d060-4b17-8dbc-d19cd78b195e"), null, new Guid("a3522caf-3dc4-4d5f-99bc-04cb53ec048c"), null, null, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(3869), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("fbf77ae9-60aa-4dde-8ab5-b32b78b75f75"), null, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(5077), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("9b89a76b-d060-4b17-8dbc-d19cd78b195e"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f"), new Guid("a3522caf-3dc4-4d5f-99bc-04cb53ec048c"), null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(6619), null, new Guid("8f9ff0c8-24b2-469e-8b77-505a2321560a"), true, false, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), new Guid("9b89a76b-d060-4b17-8dbc-d19cd78b195e"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("e7a58e9a-1325-4092-9d13-9d2514ab8bfd"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8740), null, true, false, new Guid("bcc697c5-5bb3-4c14-8b0e-3f74e8e07ca7"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("becec4e6-de85-4221-9bda-7b203a8f2a6b"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8721), null, true, false, new Guid("2f26c4dd-ec11-457f-ac45-4ed69dfb3299"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("0db4b208-10e9-4713-a7b9-ed22be68c0c9"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8703), null, true, false, new Guid("15f2f20c-ff5b-4840-b7e7-5a4eef4de3af"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("99568c3f-405f-4ce6-848f-3fa55e4eab1c"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8685), null, true, false, new Guid("19a2995f-1896-494e-97c9-dc5fe2663c59"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("31da36a9-7c74-41aa-859d-89841c5d1a7b"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8665), null, true, false, new Guid("bbe01673-7427-40a7-93bc-c91510c6f63a"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("048d3720-fc0e-4868-9faa-53d652d2cd48"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8646), null, true, false, new Guid("0576896b-a2f2-4610-bc14-e1cb73a71f71"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("7147ea6b-6edb-4dde-a302-a42880de889e"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8627), null, true, false, new Guid("b7108e98-a057-410b-819e-f235501592a6"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("feda64cc-52a0-483a-9c64-11a22c5a1cfd"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8605), null, true, false, new Guid("fcfd978e-b33e-478e-b0e3-f4e433c2886f"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("71fe5266-f9e9-48e8-bb54-aa0678be6d46"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8558), null, true, false, new Guid("b24467f9-ca86-4ab4-a178-0c27f1c52c4c"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("7245a99e-3829-4c15-872a-8ad1ed2db2a5"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8539), null, true, false, new Guid("4fe47a55-9c25-43fd-b94b-98dd23326fe2"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("22af1cc2-a622-4d1e-8313-a12398b1a3fb"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8758), null, true, false, new Guid("fc679e61-ac38-4855-a066-3f66cc294816"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("894ad0a1-f46a-4654-af0e-c01bc49aa2c9"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8502), null, true, false, new Guid("d98b72c3-a0ff-4a09-83e5-223609cbdd9c"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("41be431e-710d-4ef4-bed9-bde46a4bf194"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8482), null, true, false, new Guid("5cbcb384-fc0b-4996-a938-00f664246600"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("38fa6ad9-c358-464a-bdd2-a43732116fb5"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8463), null, true, false, new Guid("4c03c5c4-66fe-480a-905a-da6ecc7b6536"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("05e0bd97-a6f4-44dd-a266-d5ec99d520a8"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8444), null, true, false, new Guid("0f990845-beb9-4a0d-90cb-a6311be1a965"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("eef3d23f-33e4-4097-a3a0-86cad3a31487"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8421), null, true, false, new Guid("7ce49dfb-e173-4ff1-85d7-c02fac31d27b"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("0917d35c-cf24-4ddd-93c6-612a158e394d"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8400), null, true, false, new Guid("1068c4c3-53fb-42ea-9a6a-5fd79c331e35"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("c8d2871e-3e06-4a54-a932-243cf40fe883"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8380), null, true, false, new Guid("39afe650-000a-460b-8749-aa222eb85ea9"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("cc8e503a-36ba-40d3-ac9f-6f36df484f4e"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8361), null, true, false, new Guid("870a6a74-61aa-4ec9-a7d9-9782e24ab99d"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("442a7706-d068-4272-bd5b-ecb53d84e1c9"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8338), null, true, false, new Guid("463cbd9a-dd66-4729-a7eb-187f7208c99f"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("6cff3c5c-6855-4e91-becf-061cff542186"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8210), null, true, false, new Guid("626cf842-9037-4cbc-b47c-bf619fc03133"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") },
                    { new Guid("7b634c15-0b67-4f4d-bb2a-163e4492136e"), true, true, null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(8520), null, true, false, new Guid("6ef3247b-3333-4a9c-b1e8-b479b33b79aa"), true, true, null, null, null, new Guid("b5479153-2f24-4f15-b92f-4567b711fc9f") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9bcae2e2-02b7-4851-8480-2de22f5df6c0"), "usuário administrativo", null, new DateTime(2021, 2, 11, 19, 45, 19, 964, DateTimeKind.Local).AddTicks(2713), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("962459e5-7aa7-429f-9229-f803564b8df6"), new Guid("a3522caf-3dc4-4d5f-99bc-04cb53ec048c"), null, new DateTime(2021, 2, 11, 19, 45, 19, 963, DateTimeKind.Local).AddTicks(3794), null, true, false, new Guid("f1089980-b5bb-4263-b90f-0f7057a23825"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
