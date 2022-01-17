using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("14625b02-62cf-4810-8d45-8d03e869d100"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("83e7f151-664a-469e-b0d8-a5260e5d2e20"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05cd35ab-16b1-440a-82ec-e560d6174170"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05e6c34f-4596-4bd9-943e-3a546b47b535"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0f4f6666-2fb1-4b0c-920b-0e47fb085f11"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1288efae-fb92-4370-bc91-db05d023b07f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("334096b4-d30b-4564-b642-916e44c99f48"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("38fdba99-4591-4abd-aec7-289c34d7fb06"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3e37266e-481c-4b06-a9ee-2abfab5f48ad"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5233fb2d-8e22-4eef-89e5-dc59882cf42d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("52a5a627-40b1-47ee-8fdc-54c7389d10eb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("584304f9-1990-480f-a918-dfe0e718b5e4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("59451cd9-c085-4ca3-bb25-78ce66e8eea4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("698feb2a-0a6f-4593-b9f0-0210df5ee0ab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("76c08676-9717-4ea2-b7f2-00cdc9438879"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8792684a-2405-4939-a67b-ce8e0be69994"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("88795365-a81b-463b-b97a-13745df5f376"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("889c5e06-82b1-4507-a266-f2a91b50af46"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("92495ed9-f1eb-4813-bb18-f648be908390"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9f215775-6144-4df2-9c7d-e01f381cb781"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a6112c57-bc82-4f97-bc50-e3034f2d8ca7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cbf6e08c-0146-4c83-b79e-63aa06e5f739"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d8721517-b63f-4d22-a1a0-56941e333e11"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f0e925a2-45d2-4ab2-95bf-3d0ceb935a80"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d8eeae24-bbec-4edf-8e11-13fc01548cc0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e6711223-7778-417e-a13a-a20e306600b4"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e6e69c03-8f1c-414f-bf6c-cfe4b979111e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("339c3306-462f-4395-9711-06d0d8bf8713"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4d301736-a1d4-4134-9f88-57830514d627"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b3d94456-6c56-4343-b483-af199326b2a5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("40d3bafc-adfd-4189-8be9-415039538d46"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("afcd707d-019a-443a-8f1f-1ef9de3a265d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("cdd75575-1b38-4897-9839-e6a68a3d21f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("04b795ce-e9a4-4b02-899a-31134ec496ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("080aea41-8a23-4f14-8812-04ea86fa2b2f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("293c53b8-30e7-4c9d-824a-f33c5d53bc94"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2bc103b7-c69e-41c1-94f4-9e50f3dadc19"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4e04ae67-0793-444c-a0f7-b82fd4ab0228"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("53756d44-a100-4280-a104-c443d26da9cb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("668cf82f-fed9-4fe6-96d3-36780b4f5e82"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6e1fef9e-c5a3-4559-92cf-015dc9f8ec43"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("708b35a3-3c2a-4a90-9710-4f2d92b3085a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8281576d-1c33-40a7-89cd-f2634e32000c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8a796db6-d14d-4171-9594-1275b02ec8c9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8c01cced-b345-40f1-9b77-65c06918763d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8cf381d7-598b-4960-8152-7ffa219fe66e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a33c14c8-e454-4e47-8e03-a846575adc80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bad19f53-02fa-441d-be60-71cafd11866d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c1ecca0c-cca6-44a3-9522-9b19f39be3f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c43a9a3b-3bd5-48ab-9604-f16aca670ee9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d49018d9-da74-4d87-ad10-60b9a3c759e2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e98bbe18-91ea-47a0-b5a4-fb82a2ed1e5b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ecacd594-63e8-4386-bdbe-847d4304e868"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f7ee741a-fe30-4154-b3b8-8be78b9878e3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f8606d86-bf91-41ef-9d74-43672af7cc25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("acfdcefb-9c22-4fdc-96ed-1c50f9f1dcb4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("05785714-fe2d-4c68-995f-32e2cea31dd3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0b20640c-e98f-4ac9-a4d7-4cc8dc79e018"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("14853d7f-eb0c-4f96-a3f2-0ba7790f62df"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1cb940ca-6e08-4226-90c6-7c9c0eb338e6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("24a15367-79f2-4acc-ae77-85ea84af1c5e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2a9a895e-0426-4ca9-a401-c04543aa1e02"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3b294238-523c-4af5-8db0-03e05530d23f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3c9557b8-f7d8-4e8c-ad4e-4769feaf4eb1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("46744193-3031-42fb-8eaf-e5fea1619501"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("51beb53a-9425-4208-a746-5b84179df225"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("53d15809-75d2-4ec8-b9a7-91c3933f4732"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("56b35b75-85e6-4815-8379-8e02c850bf71"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("61326e93-bf72-41d6-b6ed-fdeab5e4047e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("65163df7-dfe7-42e5-8692-6ae8c614220d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("768334b5-678b-4f51-b43d-11b3c77b85a6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("78dba7d2-07e1-42dc-b11e-947721f2ce38"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("80bd0bec-262d-44d5-805e-77dbf39ab079"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a622c100-f46b-4e34-899a-2462b58c2e15"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d89a378b-d679-486e-b533-72475538a47c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e3aa32b9-bd39-487f-8d69-b474ba07dd6c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ea506768-15ad-43d2-a476-a0ce48ff7d6b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f1fc4d1a-a91c-4552-b706-e79651952ad7"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("2626cc90-5fbe-41ac-8284-f67946656662"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDenied",
                table: "CustomersGhost",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("427cb26a-ae66-4f57-a2e0-28d75e232a90"), null, null, null, null, null, new DateTime(2021, 4, 29, 15, 23, 51, 995, DateTimeKind.Local).AddTicks(4233), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), null, new DateTime(2021, 4, 29, 15, 23, 52, 0, DateTimeKind.Local).AddTicks(4142), true, false, "Administradores", new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("879440f2-baff-4b16-9191-44dbde544ef0"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2440), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("a5efedbf-bfa3-4a81-9134-89c5f251d481"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("92f33c53-2f2c-4fbc-8536-ce3888c1da3e"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2406), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("370c9b1f-838d-41d9-b06c-67834a813c0a"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("ca553161-3e6a-4a18-93ac-a04073f44f80"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2372), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("4ab1d337-3716-479d-8050-3a8de883f091"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("9e98358d-fc21-4fd4-b20e-0ab098fd7210"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2337), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("9966c8d2-c85b-4626-af3f-7ea147894c23"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("13b1c920-6141-45d5-9f6b-2600f22a484e"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2299), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("d76c8fd4-c300-4ed1-bb43-e219a5368575"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("043ac48b-e120-4850-9e17-b9587efb01b6"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2264), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("ec27f2d0-e744-4661-a5bd-a97d051dcd64"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("8433d536-7e9f-4399-a726-bf4783f3f7f5"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2229), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("7ac6cd1c-7485-4045-aa97-44e91de34879"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("c34f5079-ceab-45dd-88bc-216ce9944daf"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2193), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("76b0e600-6737-4678-a259-fc8778c8155f"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("0a457b29-f950-47c0-860e-5348634ea439"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2155), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("31553d73-12a0-4fb7-ba88-9b603683986a"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("e85bf7be-119e-44c1-a766-eb23c5cfdaa2"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2118), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("95a9d6df-3c81-4035-99ed-a96170f7f5e7"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("b457ab6d-9eed-4806-a0d3-7a4b6ef53f44"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2022), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("3a61cf5e-418b-441c-a4e7-63d2504abf35"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("efbf35fc-0832-433f-9f42-b686facef5e6"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1987), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("71fc58e3-6bee-4b34-a5af-7c33b529582f"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("1a51b7d3-55b8-4fd1-8d48-32ba5ddf7133"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1950), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("9c4e16f3-2a48-46a6-a0cc-b7881d239228"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("d54f2d31-f1e5-4d8f-a19e-449784624a8d"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1915), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("f44d1ea4-df3a-4154-81a5-96ca4ed212e7"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("b2d66a6a-9c0f-43bf-bfe7-5fd4a10f36a3"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1880), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("1d2e4b42-cc82-400a-9c69-50eba2c0ae39"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("6104a10a-4042-4cfe-a636-addd9e69bad5"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1844), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("3fd97908-e698-49e7-b7dd-742795719b79"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("94d1214e-d00f-4ab1-a51d-10d809015f25"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1795), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("3c16a586-1806-47eb-b7a0-8e1f658cc5da"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("c39133c1-a89f-400c-b7bd-799155a0f3ae"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1760), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("c0df838d-05a5-49ee-a1ce-f3e2ab1f080f"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("7a661207-0dab-4752-9c5d-4528a40806c8"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1722), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("1a2d027a-952b-453f-a12e-6050c613141b"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("de1f0c33-705f-497d-a9f9-199c52ea77e6"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1670), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("1035f036-5226-4748-9052-b6da6a5ec9d9"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("8efa3fe5-9550-4099-946f-b07ce6f61946"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(1282), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null },
                    { new Guid("e0153080-ba51-4b62-a6fc-cbe1b1836c19"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(2479), new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("2df4db39-4fd6-4afc-9d75-b556e4edcd74"), true, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("7b7b5354-7196-4df0-8b57-5fd1f69a88ee"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 29, 15, 23, 52, 0, DateTimeKind.Local).AddTicks(1881), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8395d2d1-f7b8-42df-83c6-ac661fcbe9fc"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 29, 15, 23, 52, 0, DateTimeKind.Local).AddTicks(1697), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9372ceed-8f99-46fd-8658-cfacc4ca8911"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 29, 15, 23, 51, 999, DateTimeKind.Local).AddTicks(6155), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("2df4db39-4fd6-4afc-9d75-b556e4edcd74"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5607), null, "", true, false, "groupusers/details", new Guid("370c9b1f-838d-41d9-b06c-67834a813c0a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a5efedbf-bfa3-4a81-9134-89c5f251d481"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5536), null, "", true, false, "groupusers/list", new Guid("370c9b1f-838d-41d9-b06c-67834a813c0a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("370c9b1f-838d-41d9-b06c-67834a813c0a"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5374), null, "", true, false, "", new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4ab1d337-3716-479d-8050-3a8de883f091"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5205), null, "", true, false, "systems/details", new Guid("d76c8fd4-c300-4ed1-bb43-e219a5368575"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9966c8d2-c85b-4626-af3f-7ea147894c23"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5137), null, "", true, false, "systems/list", new Guid("d76c8fd4-c300-4ed1-bb43-e219a5368575"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d76c8fd4-c300-4ed1-bb43-e219a5368575"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5057), null, "", true, false, "", new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ec27f2d0-e744-4661-a5bd-a97d051dcd64"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4988), null, "", true, false, "languages/details", new Guid("76b0e600-6737-4678-a259-fc8778c8155f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7ac6cd1c-7485-4045-aa97-44e91de34879"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4920), null, "", true, false, "languages/list", new Guid("76b0e600-6737-4678-a259-fc8778c8155f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("76b0e600-6737-4678-a259-fc8778c8155f"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4842), null, "", true, false, "", new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("31553d73-12a0-4fb7-ba88-9b603683986a"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4625), null, "", true, false, "clients/details", new Guid("3a61cf5e-418b-441c-a4e7-63d2504abf35"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("95a9d6df-3c81-4035-99ed-a96170f7f5e7"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4559), null, "", true, false, "clients/list", new Guid("3a61cf5e-418b-441c-a4e7-63d2504abf35"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("71fc58e3-6bee-4b34-a5af-7c33b529582f"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4424), null, "", true, false, "menus/details", new Guid("f44d1ea4-df3a-4154-81a5-96ca4ed212e7"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c4e16f3-2a48-46a6-a0cc-b7881d239228"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4346), null, "", true, false, "menus/list", new Guid("f44d1ea4-df3a-4154-81a5-96ca4ed212e7"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f44d1ea4-df3a-4154-81a5-96ca4ed212e7"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4275), null, "", true, false, "", new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d2e4b42-cc82-400a-9c69-50eba2c0ae39"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4197), null, "", true, false, "users/details", new Guid("3c16a586-1806-47eb-b7a0-8e1f658cc5da"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3fd97908-e698-49e7-b7dd-742795719b79"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4061), null, "", true, false, "users/list", new Guid("3c16a586-1806-47eb-b7a0-8e1f658cc5da"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3c16a586-1806-47eb-b7a0-8e1f658cc5da"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(3975), null, "", true, false, "", new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c0df838d-05a5-49ee-a1ce-f3e2ab1f080f"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(3795), null, "", true, false, "companyoperators/details", new Guid("1035f036-5226-4748-9052-b6da6a5ec9d9"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1a2d027a-952b-453f-a12e-6050c613141b"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(3722), null, "", true, false, "companyoperators/list", new Guid("1035f036-5226-4748-9052-b6da6a5ec9d9"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1035f036-5226-4748-9052-b6da6a5ec9d9"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(3559), null, "", true, false, "", new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 29, 15, 23, 52, 0, DateTimeKind.Local).AddTicks(9754), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3a61cf5e-418b-441c-a4e7-63d2504abf35"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4492), null, "", true, false, "", new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 29, 15, 23, 51, 998, DateTimeKind.Local).AddTicks(8707), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("964b0b15-2153-47ae-bf7c-f3dbddd39f69"), null, new DateTime(2021, 4, 29, 15, 23, 52, 0, DateTimeKind.Local).AddTicks(2032), true, true, false, new Guid("7b7b5354-7196-4df0-8b57-5fd1f69a88ee"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, null },
                    { new Guid("fecd5004-10a9-415f-a5f6-5ffe007f747d"), null, new DateTime(2021, 4, 29, 15, 23, 52, 0, DateTimeKind.Local).AddTicks(1304), true, true, false, new Guid("9372ceed-8f99-46fd-8658-cfacc4ca8911"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, null },
                    { new Guid("4e35c486-9bb7-42d9-931e-5176e6e43a30"), null, new DateTime(2021, 4, 29, 15, 23, 52, 0, DateTimeKind.Local).AddTicks(1836), true, true, false, new Guid("8395d2d1-f7b8-42df-83c6-ac661fcbe9fc"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("488853ff-f0ce-453e-be63-ac95b42c4906"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5094), null, true, false, new Guid("d76c8fd4-c300-4ed1-bb43-e219a5368575"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d758df86-485c-4685-b361-930a8b52998c"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5568), null, true, false, new Guid("a5efedbf-bfa3-4a81-9134-89c5f251d481"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cb27a674-22d1-4791-996c-d28dc6735d11"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5493), null, true, false, new Guid("370c9b1f-838d-41d9-b06c-67834a813c0a"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0fff52e-03c0-490f-ad69-103997f90ef0"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5325), null, true, false, new Guid("4ab1d337-3716-479d-8050-3a8de883f091"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ab7b9836-a97c-4483-a3b3-7f15674bc80f"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5168), null, true, false, new Guid("9966c8d2-c85b-4626-af3f-7ea147894c23"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ec9661f4-93b9-4697-870c-00cdd67a7691"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5020), null, true, false, new Guid("ec27f2d0-e744-4661-a5bd-a97d051dcd64"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6ca6d4ac-360b-49b9-a7db-0734531ea85e"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4952), null, true, false, new Guid("7ac6cd1c-7485-4045-aa97-44e91de34879"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e3d9a444-bb0e-4244-a3ab-f8c6a2e470c6"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4883), null, true, false, new Guid("76b0e600-6737-4678-a259-fc8778c8155f"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4d55956a-67b4-493a-a84a-5e7a30580b19"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4657), null, true, false, new Guid("31553d73-12a0-4fb7-ba88-9b603683986a"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2827cf3b-bb65-4310-bcef-53c1c872487c"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4591), null, true, false, new Guid("95a9d6df-3c81-4035-99ed-a96170f7f5e7"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ea90770-4fa4-4105-848e-36b91d46091e"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4524), null, true, false, new Guid("3a61cf5e-418b-441c-a4e7-63d2504abf35"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ca2a493b-a58b-4590-93f5-768293580fbb"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4456), null, true, false, new Guid("71fc58e3-6bee-4b34-a5af-7c33b529582f"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("73c197e6-154d-4b5a-a6d6-f2c52e3bf4eb"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4381), null, true, false, new Guid("9c4e16f3-2a48-46a6-a0cc-b7881d239228"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e4895298-9024-4cc6-ad73-300fc3fd0a7c"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4308), null, true, false, new Guid("f44d1ea4-df3a-4154-81a5-96ca4ed212e7"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92597185-30d5-4b47-bf25-ebebdb4d4873"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4238), null, true, false, new Guid("1d2e4b42-cc82-400a-9c69-50eba2c0ae39"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46b05daf-ff4f-4c1e-afb1-8376905c190a"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4093), null, true, false, new Guid("3fd97908-e698-49e7-b7dd-742795719b79"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9cc21c4a-9c22-4e7c-be81-f81e9f13d5ef"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(4014), null, true, false, new Guid("3c16a586-1806-47eb-b7a0-8e1f658cc5da"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c40aa096-23f5-436f-9b9c-7ab2a424b97f"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(3828), null, true, false, new Guid("c0df838d-05a5-49ee-a1ce-f3e2ab1f080f"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("84c466c3-c2a3-4cd7-9a6f-61c2cafb23e0"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(3758), null, true, false, new Guid("1a2d027a-952b-453f-a12e-6050c613141b"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ed076dd7-9c19-45da-99b0-9c28626b526d"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(3666), null, true, false, new Guid("1035f036-5226-4748-9052-b6da6a5ec9d9"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("03ef0a05-dc37-4a83-9687-fd51b73a42ef"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(2550), null, true, false, new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("98946837-a1fc-4d8b-a8c8-077b30923cb5"), null, new DateTime(2021, 4, 29, 15, 23, 52, 1, DateTimeKind.Local).AddTicks(5639), null, true, false, new Guid("2df4db39-4fd6-4afc-9d75-b556e4edcd74"), new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9077c339-1bb1-4a66-8d07-25933eeaaf37"), null, new Guid("427cb26a-ae66-4f57-a2e0-28d75e232a90"), null, null, null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(7343), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("ec01a832-fc1b-497d-999b-885ef62737be"), null, null, new DateTime(2021, 4, 29, 15, 23, 52, 3, DateTimeKind.Local).AddTicks(720), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("9077c339-1bb1-4a66-8d07-25933eeaaf37"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf"), new Guid("427cb26a-ae66-4f57-a2e0-28d75e232a90"), null, new DateTime(2021, 4, 29, 15, 23, 52, 3, DateTimeKind.Local).AddTicks(5527), null, new Guid("e55fccd5-afb2-4314-8b87-e528466af018"), true, false, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), new Guid("9077c339-1bb1-4a66-8d07-25933eeaaf37"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("e1a95a65-e115-4c0e-a1e9-4a95972f347c"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1699), null, true, false, new Guid("a5efedbf-bfa3-4a81-9134-89c5f251d481"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("21e4288d-dffb-4177-8980-e09de29e48b3"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1663), null, true, false, new Guid("370c9b1f-838d-41d9-b06c-67834a813c0a"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("d6dea8c3-9e55-4c4c-8bc1-f7d59bcd4c0e"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1624), null, true, false, new Guid("4ab1d337-3716-479d-8050-3a8de883f091"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("1c98ad80-853a-414f-9f48-a0ecdfcd34be"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1588), null, true, false, new Guid("9966c8d2-c85b-4626-af3f-7ea147894c23"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("a66dea19-6645-4b9c-a651-025adf727593"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1548), null, true, false, new Guid("d76c8fd4-c300-4ed1-bb43-e219a5368575"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("047b6174-6aa2-4950-9454-b683970c0ef0"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1508), null, true, false, new Guid("ec27f2d0-e744-4661-a5bd-a97d051dcd64"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("cfc5de2d-65b1-4cea-a381-96935cb7c19d"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1417), null, true, false, new Guid("7ac6cd1c-7485-4045-aa97-44e91de34879"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("d44fcf64-0bf8-4a5a-8bab-0af693e80831"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1381), null, true, false, new Guid("76b0e600-6737-4678-a259-fc8778c8155f"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("0ba35fdc-6b79-448a-a5e5-979031644ec2"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1346), null, true, false, new Guid("31553d73-12a0-4fb7-ba88-9b603683986a"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("11aa465e-e969-4df4-b77d-0ca57d4ee45d"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1310), null, true, false, new Guid("95a9d6df-3c81-4035-99ed-a96170f7f5e7"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("a056d96d-117d-40e7-a1ab-4fc08a12be52"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1734), null, true, false, new Guid("2df4db39-4fd6-4afc-9d75-b556e4edcd74"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("d91bf94a-2e54-4fe1-b0a3-e88b20779071"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1235), null, true, false, new Guid("71fc58e3-6bee-4b34-a5af-7c33b529582f"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("5d43f4f9-edfe-4d62-8180-63eced01b9cb"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1196), null, true, false, new Guid("9c4e16f3-2a48-46a6-a0cc-b7881d239228"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("aca6b0e6-62f5-4e56-bb6a-81cb788c27c1"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1160), null, true, false, new Guid("f44d1ea4-df3a-4154-81a5-96ca4ed212e7"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("c8d36cc9-03bc-4bc5-8e07-a6ab73ce2622"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1124), null, true, false, new Guid("1d2e4b42-cc82-400a-9c69-50eba2c0ae39"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("1ac1b083-0058-4c6a-b15f-e9d8f629edd6"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1088), null, true, false, new Guid("3fd97908-e698-49e7-b7dd-742795719b79"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("e9fb49c3-02c6-4618-8679-8666cf51129d"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1045), null, true, false, new Guid("3c16a586-1806-47eb-b7a0-8e1f658cc5da"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("921d192a-cb15-4fc5-a809-94c74e32f491"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1006), null, true, false, new Guid("c0df838d-05a5-49ee-a1ce-f3e2ab1f080f"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("85300e6c-629f-41b3-910f-32f179bf4683"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(959), null, true, false, new Guid("1a2d027a-952b-453f-a12e-6050c613141b"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("b0216ed7-3497-4b7f-b3fe-267b54928d13"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(905), null, true, false, new Guid("1035f036-5226-4748-9052-b6da6a5ec9d9"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("45f9e73c-52cf-4f8f-b467-5093dd647983"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(508), null, true, false, new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") },
                    { new Guid("42a28ad4-9fd8-47e8-a3d4-b3f2d4b046b6"), true, true, null, new DateTime(2021, 4, 29, 15, 23, 52, 4, DateTimeKind.Local).AddTicks(1270), null, true, false, new Guid("3a61cf5e-418b-441c-a4e7-63d2504abf35"), true, true, null, null, null, new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("35468e75-3a19-4822-8674-61c0dbe050e5"), "usuário administrativo", null, new DateTime(2021, 4, 29, 15, 23, 52, 2, DateTimeKind.Local).AddTicks(4519), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9c7c0f70-dc05-4a54-9863-183773d4580c"), new Guid("427cb26a-ae66-4f57-a2e0-28d75e232a90"), null, new DateTime(2021, 4, 29, 15, 23, 51, 999, DateTimeKind.Local).AddTicks(1573), null, true, false, new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("427cb26a-ae66-4f57-a2e0-28d75e232a90"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("9c7c0f70-dc05-4a54-9863-183773d4580c"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("e55fccd5-afb2-4314-8b87-e528466af018"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("043ac48b-e120-4850-9e17-b9587efb01b6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0a457b29-f950-47c0-860e-5348634ea439"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("13b1c920-6141-45d5-9f6b-2600f22a484e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1a51b7d3-55b8-4fd1-8d48-32ba5ddf7133"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6104a10a-4042-4cfe-a636-addd9e69bad5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7a661207-0dab-4752-9c5d-4528a40806c8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8433d536-7e9f-4399-a726-bf4783f3f7f5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("879440f2-baff-4b16-9191-44dbde544ef0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8efa3fe5-9550-4099-946f-b07ce6f61946"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("92f33c53-2f2c-4fbc-8536-ce3888c1da3e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("94d1214e-d00f-4ab1-a51d-10d809015f25"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9e98358d-fc21-4fd4-b20e-0ab098fd7210"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b2d66a6a-9c0f-43bf-bfe7-5fd4a10f36a3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b457ab6d-9eed-4806-a0d3-7a4b6ef53f44"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c34f5079-ceab-45dd-88bc-216ce9944daf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c39133c1-a89f-400c-b7bd-799155a0f3ae"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ca553161-3e6a-4a18-93ac-a04073f44f80"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d54f2d31-f1e5-4d8f-a19e-449784624a8d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("de1f0c33-705f-497d-a9f9-199c52ea77e6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e0153080-ba51-4b62-a6fc-cbe1b1836c19"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e85bf7be-119e-44c1-a766-eb23c5cfdaa2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("efbf35fc-0832-433f-9f42-b686facef5e6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7b7b5354-7196-4df0-8b57-5fd1f69a88ee"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8395d2d1-f7b8-42df-83c6-ac661fcbe9fc"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9372ceed-8f99-46fd-8658-cfacc4ca8911"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1035f036-5226-4748-9052-b6da6a5ec9d9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1a2d027a-952b-453f-a12e-6050c613141b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1d2e4b42-cc82-400a-9c69-50eba2c0ae39"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2df4db39-4fd6-4afc-9d75-b556e4edcd74"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("31553d73-12a0-4fb7-ba88-9b603683986a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("370c9b1f-838d-41d9-b06c-67834a813c0a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3a61cf5e-418b-441c-a4e7-63d2504abf35"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3c16a586-1806-47eb-b7a0-8e1f658cc5da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3fd97908-e698-49e7-b7dd-742795719b79"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4ab1d337-3716-479d-8050-3a8de883f091"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("60697207-dbd7-4e56-ba0b-8f6b25794100"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("71fc58e3-6bee-4b34-a5af-7c33b529582f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("76b0e600-6737-4678-a259-fc8778c8155f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7ac6cd1c-7485-4045-aa97-44e91de34879"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("95a9d6df-3c81-4035-99ed-a96170f7f5e7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9966c8d2-c85b-4626-af3f-7ea147894c23"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9c4e16f3-2a48-46a6-a0cc-b7881d239228"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a5efedbf-bfa3-4a81-9134-89c5f251d481"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c0df838d-05a5-49ee-a1ce-f3e2ab1f080f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d76c8fd4-c300-4ed1-bb43-e219a5368575"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ec27f2d0-e744-4661-a5bd-a97d051dcd64"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f44d1ea4-df3a-4154-81a5-96ca4ed212e7"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("4e35c486-9bb7-42d9-931e-5176e6e43a30"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("964b0b15-2153-47ae-bf7c-f3dbddd39f69"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("fecd5004-10a9-415f-a5f6-5ffe007f747d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("03ef0a05-dc37-4a83-9687-fd51b73a42ef"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0ea90770-4fa4-4105-848e-36b91d46091e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2827cf3b-bb65-4310-bcef-53c1c872487c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("46b05daf-ff4f-4c1e-afb1-8376905c190a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("488853ff-f0ce-453e-be63-ac95b42c4906"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4d55956a-67b4-493a-a84a-5e7a30580b19"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6ca6d4ac-360b-49b9-a7db-0734531ea85e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("73c197e6-154d-4b5a-a6d6-f2c52e3bf4eb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("84c466c3-c2a3-4cd7-9a6f-61c2cafb23e0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("92597185-30d5-4b47-bf25-ebebdb4d4873"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("98946837-a1fc-4d8b-a8c8-077b30923cb5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9cc21c4a-9c22-4e7c-be81-f81e9f13d5ef"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ab7b9836-a97c-4483-a3b3-7f15674bc80f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c40aa096-23f5-436f-9b9c-7ab2a424b97f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ca2a493b-a58b-4590-93f5-768293580fbb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cb27a674-22d1-4791-996c-d28dc6735d11"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d0fff52e-03c0-490f-ad69-103997f90ef0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d758df86-485c-4685-b361-930a8b52998c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e3d9a444-bb0e-4244-a3ab-f8c6a2e470c6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e4895298-9024-4cc6-ad73-300fc3fd0a7c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ec9661f4-93b9-4697-870c-00cdd67a7691"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ed076dd7-9c19-45da-99b0-9c28626b526d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9077c339-1bb1-4a66-8d07-25933eeaaf37"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("ec01a832-fc1b-497d-999b-885ef62737be"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("9d4baf28-8964-4716-8d66-07cc957cb5bf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("047b6174-6aa2-4950-9454-b683970c0ef0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0ba35fdc-6b79-448a-a5e5-979031644ec2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("11aa465e-e969-4df4-b77d-0ca57d4ee45d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1ac1b083-0058-4c6a-b15f-e9d8f629edd6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1c98ad80-853a-414f-9f48-a0ecdfcd34be"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("21e4288d-dffb-4177-8980-e09de29e48b3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("42a28ad4-9fd8-47e8-a3d4-b3f2d4b046b6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("45f9e73c-52cf-4f8f-b467-5093dd647983"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5d43f4f9-edfe-4d62-8180-63eced01b9cb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("85300e6c-629f-41b3-910f-32f179bf4683"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("921d192a-cb15-4fc5-a809-94c74e32f491"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a056d96d-117d-40e7-a1ab-4fc08a12be52"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a66dea19-6645-4b9c-a651-025adf727593"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aca6b0e6-62f5-4e56-bb6a-81cb788c27c1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b0216ed7-3497-4b7f-b3fe-267b54928d13"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c8d36cc9-03bc-4bc5-8e07-a6ab73ce2622"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cfc5de2d-65b1-4cea-a381-96935cb7c19d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d44fcf64-0bf8-4a5a-8bab-0af693e80831"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d6dea8c3-9e55-4c4c-8bc1-f7d59bcd4c0e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d91bf94a-2e54-4fe1-b0a3-e88b20779071"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e1a95a65-e115-4c0e-a1e9-4a95972f347c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e9fb49c3-02c6-4618-8679-8666cf51129d"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("35468e75-3a19-4822-8674-61c0dbe050e5"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("49942e0b-16a7-4d5b-98bd-4e5c9815dbf5"));

            migrationBuilder.DropColumn(
                name: "IsDenied",
                table: "CustomersGhost");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, null, null, null, null, new DateTime(2021, 4, 22, 16, 20, 41, 235, DateTimeKind.Local).AddTicks(1070), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(115), true, false, "Administradores", new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("a6112c57-bc82-4f97-bc50-e3034f2d8ca7"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3874), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("05cd35ab-16b1-440a-82ec-e560d6174170"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3854), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("3e37266e-481c-4b06-a9ee-2abfab5f48ad"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3832), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("584304f9-1990-480f-a918-dfe0e718b5e4"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3808), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("76c08676-9717-4ea2-b7f2-00cdc9438879"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3786), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("1288efae-fb92-4370-bc91-db05d023b07f"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3765), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("334096b4-d30b-4564-b642-916e44c99f48"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3744), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("4d301736-a1d4-4134-9f88-57830514d627"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("f0e925a2-45d2-4ab2-95bf-3d0ceb935a80"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3724), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("05e6c34f-4596-4bd9-943e-3a546b47b535"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3703), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("38fdba99-4591-4abd-aec7-289c34d7fb06"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3682), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("8792684a-2405-4939-a67b-ce8e0be69994"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3661), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("9f215775-6144-4df2-9c7d-e01f381cb781"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3633), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("d8721517-b63f-4d22-a1a0-56941e333e11"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3562), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("92495ed9-f1eb-4813-bb18-f648be908390"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3542), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("59451cd9-c085-4ca3-bb25-78ce66e8eea4"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3520), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("698feb2a-0a6f-4593-b9f0-0210df5ee0ab"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3498), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("889c5e06-82b1-4507-a266-f2a91b50af46"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3473), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("cbf6e08c-0146-4c83-b79e-63aa06e5f739"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3451), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("5233fb2d-8e22-4eef-89e5-dc59882cf42d"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3426), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("52a5a627-40b1-47ee-8fdc-54c7389d10eb"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3382), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("0f4f6666-2fb1-4b0c-920b-0e47fb085f11"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3064), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null },
                    { new Guid("88795365-a81b-463b-b97a-13745df5f376"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(3895), new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), true, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("e6e69c03-8f1c-414f-bf6c-cfe4b979111e"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8471), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e6711223-7778-417e-a13a-a20e306600b4"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8246), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d8eeae24-bbec-4edf-8e11-13fc01548cc0"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(4842), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8538), null, "", true, false, "groupusers/details", new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8492), null, "", true, false, "groupusers/list", new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8447), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8350), null, "", true, false, "systems/details", new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8307), null, "", true, false, "systems/list", new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8257), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8210), null, "", true, false, "languages/details", new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4d301736-a1d4-4134-9f88-57830514d627"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8164), null, "", true, false, "languages/list", new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8118), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7784), null, "", true, false, "clients/details", new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7634), null, "", true, false, "clients/list", new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7545), null, "", true, false, "menus/details", new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7499), null, "", true, false, "menus/list", new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7455), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7405), null, "", true, false, "users/details", new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7302), null, "", true, false, "users/list", new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7248), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7121), null, "", true, false, "companyoperators/details", new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7069), null, "", true, false, "companyoperators/list", new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(6960), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(4171), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7587), null, "", true, false, "", new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 22, 16, 20, 41, 237, DateTimeKind.Local).AddTicks(8214), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("afcd707d-019a-443a-8f1f-1ef9de3a265d"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8512), true, true, false, new Guid("e6e69c03-8f1c-414f-bf6c-cfe4b979111e"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null },
                    { new Guid("cdd75575-1b38-4897-9839-e6a68a3d21f2"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(7942), true, true, false, new Guid("d8eeae24-bbec-4edf-8e11-13fc01548cc0"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null },
                    { new Guid("40d3bafc-adfd-4189-8be9-415039538d46"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(8349), true, true, false, new Guid("e6711223-7778-417e-a13a-a20e306600b4"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("04b795ce-e9a4-4b02-899a-31134ec496ce"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8280), null, true, false, new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("080aea41-8a23-4f14-8812-04ea86fa2b2f"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8512), null, true, false, new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e04ae67-0793-444c-a0f7-b82fd4ab0228"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8469), null, true, false, new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8a796db6-d14d-4171-9594-1275b02ec8c9"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8371), null, true, false, new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8c01cced-b345-40f1-9b77-65c06918763d"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8328), null, true, false, new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bad19f53-02fa-441d-be60-71cafd11866d"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8230), null, true, false, new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e98bbe18-91ea-47a0-b5a4-fb82a2ed1e5b"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8184), null, true, false, new Guid("4d301736-a1d4-4134-9f88-57830514d627"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d49018d9-da74-4d87-ad10-60b9a3c759e2"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8140), null, true, false, new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("293c53b8-30e7-4c9d-824a-f33c5d53bc94"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8088), null, true, false, new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("708b35a3-3c2a-4a90-9710-4f2d92b3085a"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7742), null, true, false, new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53756d44-a100-4280-a104-c443d26da9cb"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7608), null, true, false, new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e1fef9e-c5a3-4559-92cf-015dc9f8ec43"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7565), null, true, false, new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f8606d86-bf91-41ef-9d74-43672af7cc25"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7521), null, true, false, new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c43a9a3b-3bd5-48ab-9604-f16aca670ee9"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7475), null, true, false, new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f7ee741a-fe30-4154-b3b8-8be78b9878e3"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7426), null, true, false, new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8281576d-1c33-40a7-89cd-f2634e32000c"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7377), null, true, false, new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("668cf82f-fed9-4fe6-96d3-36780b4f5e82"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7276), null, true, false, new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ecacd594-63e8-4386-bdbe-847d4304e868"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7142), null, true, false, new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2bc103b7-c69e-41c1-94f4-9e50f3dadc19"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7091), null, true, false, new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8cf381d7-598b-4960-8152-7ffa219fe66e"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(7029), null, true, false, new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c1ecca0c-cca6-44a3-9522-9b19f39be3f2"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(6239), null, true, false, new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a33c14c8-e454-4e47-8e03-a846575adc80"), null, new DateTime(2021, 4, 22, 16, 20, 41, 239, DateTimeKind.Local).AddTicks(8558), null, true, false, new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"), null, new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, null, null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(7514), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("acfdcefb-9c22-4fdc-96ed-1c50f9f1dcb4"), null, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(86), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68"), new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(4526), null, new Guid("887b7db4-6f1d-4ca4-8b00-8a32ab08ee84"), true, false, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), new Guid("5605e647-4d6d-43b3-906a-2937fb8ee3f5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("e3aa32b9-bd39-487f-8d69-b474ba07dd6c"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9335), null, true, false, new Guid("c86cace6-30f1-4c7e-864e-498b24fe0b7d"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("53d15809-75d2-4ec8-b9a7-91c3933f4732"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9315), null, true, false, new Guid("339c3306-462f-4395-9711-06d0d8bf8713"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("3b294238-523c-4af5-8db0-03e05530d23f"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9293), null, true, false, new Guid("899c332a-11d2-4651-ae68-cb43c071af7d"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("3c9557b8-f7d8-4e8c-ad4e-4769feaf4eb1"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9271), null, true, false, new Guid("863ec611-e6f1-4c9b-9e2a-f5d0cd366cca"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("05785714-fe2d-4c68-995f-32e2cea31dd3"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9247), null, true, false, new Guid("df7cfbbe-905c-4444-a16d-cc840f552bd9"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("78dba7d2-07e1-42dc-b11e-947721f2ce38"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9222), null, true, false, new Guid("b3d94456-6c56-4343-b483-af199326b2a5"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("61326e93-bf72-41d6-b6ed-fdeab5e4047e"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9196), null, true, false, new Guid("4d301736-a1d4-4134-9f88-57830514d627"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("a622c100-f46b-4e34-899a-2462b58c2e15"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9124), null, true, false, new Guid("bc0bb622-25ea-45af-a5db-e06512ce9c82"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("ea506768-15ad-43d2-a476-a0ce48ff7d6b"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9103), null, true, false, new Guid("9b8bb812-d8f0-4786-9b42-4ceafd2e1941"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("2a9a895e-0426-4ca9-a401-c04543aa1e02"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9081), null, true, false, new Guid("0f17ac4c-8796-43c2-8d65-7fab6bd760b4"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("24a15367-79f2-4acc-ae77-85ea84af1c5e"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9356), null, true, false, new Guid("5ba1028e-0a5d-489d-86f5-97bcfb1fccaa"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("14853d7f-eb0c-4f96-a3f2-0ba7790f62df"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9038), null, true, false, new Guid("b09db71e-e697-4169-ad3a-ff3ce4dd7c53"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("56b35b75-85e6-4815-8379-8e02c850bf71"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9013), null, true, false, new Guid("f97d203e-7cc1-4c0e-b098-6d99ef8826e5"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("0b20640c-e98f-4ac9-a4d7-4cc8dc79e018"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8986), null, true, false, new Guid("699cec88-b98a-4547-b9a5-e06e2b6ce8bc"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("d89a378b-d679-486e-b533-72475538a47c"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8965), null, true, false, new Guid("1f2bd79e-66db-4ebe-890b-6417092fcdcd"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("f1fc4d1a-a91c-4552-b706-e79651952ad7"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8943), null, true, false, new Guid("faa6e48f-fc84-498c-a2df-7658f0e2b20c"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("1cb940ca-6e08-4226-90c6-7c9c0eb338e6"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8918), null, true, false, new Guid("27bd13e1-36f4-497a-89ca-c49a183bfac3"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("80bd0bec-262d-44d5-805e-77dbf39ab079"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8896), null, true, false, new Guid("d3e31620-2cbb-46b3-8550-202abacb0606"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("768334b5-678b-4f51-b43d-11b3c77b85a6"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8871), null, true, false, new Guid("6958b355-8f77-40d2-84d4-dfeed9cdb0e3"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("51beb53a-9425-4208-a746-5b84179df225"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8828), null, true, false, new Guid("414b2ed7-bcca-4f6e-b305-062c68877bfc"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("46744193-3031-42fb-8eaf-e5fea1619501"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(8552), null, true, false, new Guid("d037d4b3-786b-4122-bb12-6fff932854b9"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") },
                    { new Guid("65163df7-dfe7-42e5-8692-6ae8c614220d"), true, true, null, new DateTime(2021, 4, 22, 16, 20, 41, 241, DateTimeKind.Local).AddTicks(9060), null, true, false, new Guid("4f130b00-f074-4613-bc2d-9dacfcc33c41"), true, true, null, null, null, new Guid("b4875fa7-932a-4b6e-9e1e-95f5b9f11d68") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("2626cc90-5fbe-41ac-8284-f67946656662"), "usuário administrativo", null, new DateTime(2021, 4, 22, 16, 20, 41, 240, DateTimeKind.Local).AddTicks(5460), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("83e7f151-664a-469e-b0d8-a5260e5d2e20"), new Guid("14625b02-62cf-4810-8d45-8d03e869d100"), null, new DateTime(2021, 4, 22, 16, 20, 41, 238, DateTimeKind.Local).AddTicks(1100), null, true, false, new Guid("b24841f5-aa22-400f-9b24-7dfa668bc748"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
