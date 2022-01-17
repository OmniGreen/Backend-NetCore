using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("5ef66acb-8974-407e-a491-c540245fa0c1"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("3fbc1891-38ea-4a8d-ac19-a967e098e8f7"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0d020060-16e4-4b86-abdf-2f7e6ebecc42"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0e1bae22-d0f7-4b6a-8e33-5ddbf0b72bc9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0f0510c3-3d1f-414f-9e1e-3b103d68c367"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1a8efd0c-fc96-494d-ad82-6a76606cc6db"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1d0e7e4f-5e20-4bc4-9f12-971b10795b7a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2e29cb87-f8da-4977-a02e-2e2cbf7eacc4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3672491f-6a94-40a3-9954-38998592e4f2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("50077a38-a97c-4014-a423-13df06ea9d9c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("51d76e3e-0492-4afa-943f-f9616cdd0e2f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5de576ce-fbb6-4ede-b55e-725920ab35c5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5fcf75cb-bbd1-434d-8536-1d277fc048c6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("61e8d0cd-1efe-45b9-acb3-f7a23212769a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("631a80ab-1fc6-444d-8744-7872308072e0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6e7ede13-448a-4cf4-9153-500211500f91"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7ab452b8-08b8-43ab-adb6-e9fe62cd9e8b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8d461023-c673-4de8-b45b-7a2243bf71bb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8fba5e2a-9799-4146-b1b1-899d94fb6bfa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a95ab5f5-2fce-4af6-906b-d655325c2c7b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cee79ff2-1855-4eee-9d03-a3b44dfae8d8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d2dc3230-7c11-49fe-a73f-81d0eccbaa8a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f55e57d6-6468-4822-9289-437c35ab28db"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f89fde05-6af5-49c4-b3ab-56ee2d96836b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("226e0058-4430-4cd0-b3f9-57f9a38fbaa7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4bd28fa0-e514-4243-945d-adc6ab8f78f1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("50fea971-cb17-4ee0-b103-a8e66c5f0c7e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("35541b2a-6fef-49b9-b4ff-8cc85eb778d8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("439d43e3-6af0-40a6-a963-930ee18d6925"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4e94654c-4851-4287-b70b-f732fec2dba5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5b286c00-6a0d-4ead-93fb-bb5d7cbfd084"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("645064be-baef-477d-932a-f3b0b914cc50"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6ef4849e-6a33-49ea-ab25-93e3a703917b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("79ed0d9d-af46-4245-a996-a680e35e7fa3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7fe15440-787a-4a0d-8478-e58d808680d0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8c5cba44-6d98-4b7e-b8ff-4b0df8f5f649"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8d465f41-f3f9-4b28-8bfc-38e57477cbbe"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("90b355b4-12b8-437c-90f0-d4d0a5a56d83"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9bfdbea4-210a-476f-a8a6-64d02204e5e2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a0d62a99-c1e8-4788-9823-1bd5838bba97"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b26d3095-7715-4690-82f6-0d870479174a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b782699c-75c5-4ca3-9191-94acc251c4fa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b9866ec9-d795-425d-912c-99b1428771a8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e126d7f8-d382-4e3f-afe2-66c612695717"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e5ec526f-152f-4f86-8c2c-608392d3db50"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e920c130-12f2-48d6-b0b4-490ab69520b4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("edeca874-691d-421b-ad6b-78156d553629"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fcf9fc59-eced-437c-ab6b-46894b7c06ff"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("aae6abe5-1035-497e-9be2-7cc9829cf6ed"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("d8ddd232-6fb5-4643-8dcb-ea8a51fe0e25"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("ef163369-e6a8-45e3-9c2b-1e29af4916c0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0c7146ca-87a6-41fa-8786-fa6ce928c517"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("17ee929a-0d4c-4c4f-9f51-e06d230d805f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1e535b10-7ebb-4d1c-82b6-05c1a79d20f0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1f2e8aec-8561-4869-918f-abb460b11878"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("32121eb1-6257-4822-bdd5-1533860ddb7d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5c0a698a-1bb4-4591-ab8f-fea95e6e785f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("798d4221-b84d-45f7-907e-4de3f4320b49"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8059889f-9355-4dcc-8c51-36faf48d3a64"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("83a0ea3d-f01a-44bc-aacb-ae7509ca0ac6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("899f91ed-c397-4968-99a0-d142892b99dc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8b0bd0e9-3e99-4a28-accb-9bfd2593b37d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("90cff260-2c99-4309-b3c6-9fb0ed25735a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a155958f-3d59-44cf-986c-d4b214958041"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a3a9fdd5-3ceb-4a7b-a4b4-4549690a0e0b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b8f0469f-6096-4f59-b403-3f94b94c3d8d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b94237e8-4fe5-42f5-9477-0c5d967a355c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bba14803-ec07-4442-9d1b-a49a2ab830d9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cc721e86-162c-40b0-848c-f44a8950d7d4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cf11963e-f705-44f8-9526-e30e26c82553"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d88c8fb9-fc1d-4f4c-89dd-8511bad1ca1c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dc5a3d96-9a30-4179-a027-9d9ed8185cd4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("eed53925-fc44-4549-bafb-f153c2befe30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c34c6af6-85e7-4571-bd11-ee8680bbe73b"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("a9083d2b-5303-4695-8b5a-6667b08196c1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("02eef34a-f73e-4a26-bec1-a77d94a42d93"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0b893bf0-43db-4df8-b9c9-e387f9b895a9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1fea6b76-75ca-4f12-9d56-7818647a64b2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("38dfd5ee-abec-4da4-8879-d710ca9eec97"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3a47191c-8d07-4da8-aae8-2e121e757a91"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("47a55b58-bbe8-42c3-b8f1-8fbf2662009a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6496ab22-946c-431a-85c7-431b7661822d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("67872ef4-c6b7-49df-8eda-42227c1543c6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("70b074ca-3ccf-4f83-9152-e63c5fbd7b13"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("75f73031-d936-4bb4-900b-57497ece3f8f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7d825bc8-c039-4f15-a110-38d0761d909d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("80cf919b-0cf4-45a0-8aef-080c5a16ea07"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("839078c9-e464-49dd-9451-ec5721da4038"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("84a840af-e157-4f39-9c19-815ac9078c5c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b2df59b7-f707-4d49-93b7-d7827b9fdb24"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b4bc14b6-9c47-4cb9-8cfe-3270e835071d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d7eb6023-de32-4b4d-837c-0acd5f75688b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("de70aeeb-3019-474b-99eb-258a9338e225"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e1cfa648-a0cb-43aa-88a2-bf9a5f2c2941"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e84f0730-dc31-484a-bdc6-b4cb73909b7a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("edb3a59f-13a7-4d29-98d8-434bf11ad7ef"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fbcd5647-facb-4efe-aadd-2739a1eed49e"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("3770068e-391b-45c2-b2ef-afbaabac55c7"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("22121237-6316-4144-b290-b4f406b7be19"));

            migrationBuilder.RenameColumn(
                name: "CustomersId",
                table: "Events",
                newName: "CustomerId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("4b225149-8225-461b-9bd0-14a5b05b74fc"), null, null, null, null, null, new DateTime(2021, 2, 25, 15, 26, 29, 709, DateTimeKind.Local).AddTicks(2975), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(2777), true, false, "Administradores", new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("103e02ab-21f7-4820-96d4-c7d8d621f35a"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5895), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("e9746b19-175c-4de6-b6a4-6dbf7aa69a74"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("c6264ef5-11d7-4baf-b3da-232933d96612"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5875), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("7ceeae1c-9e7e-4367-8574-e526b6a3df50"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("0ef704ba-8837-4143-a8a1-f0758f47a98a"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5854), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("788c17a5-1adb-4648-bd26-28fd64158a94"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("74b63467-7248-47e1-845c-026299ee505b"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5831), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("8d4fb395-a961-445d-9d8c-957a15ea401b"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("7865df6a-d03c-4fd3-8fa0-8106866a80a9"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5768), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("1b480aed-3a9b-41e1-8cdc-9da51288fdb4"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("90c12934-f709-41b1-987d-f7a4a397f06c"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5748), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("a9fc267a-0d48-4ebe-8488-a8e895b752a6"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("789d6287-52d3-429c-b754-a65ce445631a"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5728), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("364e3baf-1c52-42c5-92ff-2b58f9d6a9cc"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("fc4f141f-3eed-42f6-9d5d-6f27013e83f6"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5708), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("2535b0cf-edbc-4c19-8e7f-6e15b1ef9e9b"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("0e4ef021-0219-4b35-8a6f-e6520b7034d4"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5687), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("91d9c2b3-a534-4cbf-b19f-f1d3bdaa0059"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("ec524d8a-8091-4336-8c41-431266926e16"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5667), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("48e7551a-0771-464c-9a7c-ec7a860df4a9"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("a9e5fd50-8bc4-4fda-9c94-c85c35c75268"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5645), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("cf7cf921-e21f-40fb-aeae-7235b38f1880"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("bda00d72-8f2e-47bd-b814-39ce8509be0c"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5622), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("eb23a2ce-340c-4371-984d-facb9f1b16a7"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("4ac304c6-55fe-446f-814c-39786eb8099b"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5599), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("303e0f1d-e91a-4702-83d3-b7e9963bd76e"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("30da5cea-0616-4a23-a5a8-681bc06c7d4b"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5579), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("97fada48-2826-4680-b3d4-785489af7d40"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("ef70322b-80fe-4f01-86b5-9d631e9d6a3b"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5558), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("6bbd5b33-678d-41c5-9e8b-1c51083f27d7"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("4e6d7a38-aa80-4f32-b693-c3a5969b9d61"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5537), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("4def72af-b4cc-46d9-9cb5-5b51d43f2437"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("2367c10a-ee0f-461b-b5b3-670f80e03931"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5511), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("41e233eb-fb90-473f-9208-c7c258feb347"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("aeebc5ac-73a2-4626-953c-50800f051f18"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5489), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("7ed4d5db-0d0a-469a-a14b-c1f3372de8b0"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("f02bd084-a756-40e3-a082-a78069f550f4"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5463), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("7b8f0a64-5d52-48c2-a4f5-ceb53eb462bd"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("16ce140a-3fa0-4137-b3b0-ed5693072598"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5420), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("4cdabeb7-dcae-4f3a-9807-793a9a4a417c"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("115f39ce-88d3-4f7f-8f76-2fc52e02af5e"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5081), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null },
                    { new Guid("5ea75f5f-3b60-4979-be24-35e81d0e3891"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(5915), new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("f608a62f-aa01-475e-89bc-b5b8432f03a4"), true, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("4ba56599-8472-4b9c-a74b-70e837cb1cc3"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(1324), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1804a90a-929f-4a1d-912d-df84fa6ebdd4"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(1202), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("86a836a3-c9fb-4cf7-8fa6-a1269c431fab"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 25, 15, 26, 29, 712, DateTimeKind.Local).AddTicks(7897), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f608a62f-aa01-475e-89bc-b5b8432f03a4"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(955), null, "", true, false, "groupusers/details", new Guid("7ceeae1c-9e7e-4367-8574-e526b6a3df50"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e9746b19-175c-4de6-b6a4-6dbf7aa69a74"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(913), null, "", true, false, "groupusers/list", new Guid("7ceeae1c-9e7e-4367-8574-e526b6a3df50"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7ceeae1c-9e7e-4367-8574-e526b6a3df50"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(869), null, "", true, false, "", new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("788c17a5-1adb-4648-bd26-28fd64158a94"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(821), null, "", true, false, "systems/details", new Guid("1b480aed-3a9b-41e1-8cdc-9da51288fdb4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d4fb395-a961-445d-9d8c-957a15ea401b"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(778), null, "", true, false, "systems/list", new Guid("1b480aed-3a9b-41e1-8cdc-9da51288fdb4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1b480aed-3a9b-41e1-8cdc-9da51288fdb4"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(728), null, "", true, false, "", new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a9fc267a-0d48-4ebe-8488-a8e895b752a6"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(611), null, "", true, false, "languages/details", new Guid("2535b0cf-edbc-4c19-8e7f-6e15b1ef9e9b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("364e3baf-1c52-42c5-92ff-2b58f9d6a9cc"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(566), null, "", true, false, "languages/list", new Guid("2535b0cf-edbc-4c19-8e7f-6e15b1ef9e9b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2535b0cf-edbc-4c19-8e7f-6e15b1ef9e9b"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(523), null, "", true, false, "", new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("91d9c2b3-a534-4cbf-b19f-f1d3bdaa0059"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(479), null, "", true, false, "clients/details", new Guid("cf7cf921-e21f-40fb-aeae-7235b38f1880"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("48e7551a-0771-464c-9a7c-ec7a860df4a9"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(436), null, "", true, false, "clients/list", new Guid("cf7cf921-e21f-40fb-aeae-7235b38f1880"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eb23a2ce-340c-4371-984d-facb9f1b16a7"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(344), null, "", true, false, "menus/details", new Guid("97fada48-2826-4680-b3d4-785489af7d40"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("303e0f1d-e91a-4702-83d3-b7e9963bd76e"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(251), null, "", true, false, "menus/list", new Guid("97fada48-2826-4680-b3d4-785489af7d40"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("97fada48-2826-4680-b3d4-785489af7d40"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(206), null, "", true, false, "", new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bbd5b33-678d-41c5-9e8b-1c51083f27d7"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(156), null, "", true, false, "users/details", new Guid("41e233eb-fb90-473f-9208-c7c258feb347"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4def72af-b4cc-46d9-9cb5-5b51d43f2437"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(110), null, "", true, false, "users/list", new Guid("41e233eb-fb90-473f-9208-c7c258feb347"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("41e233eb-fb90-473f-9208-c7c258feb347"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(53), null, "", true, false, "", new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7ed4d5db-0d0a-469a-a14b-c1f3372de8b0"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(9922), null, "", true, false, "companyoperators/details", new Guid("4cdabeb7-dcae-4f3a-9807-793a9a4a417c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7b8f0a64-5d52-48c2-a4f5-ceb53eb462bd"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(9861), null, "", true, false, "companyoperators/list", new Guid("4cdabeb7-dcae-4f3a-9807-793a9a4a417c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4cdabeb7-dcae-4f3a-9807-793a9a4a417c"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(9685), null, "", true, false, "", new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(6892), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cf7cf921-e21f-40fb-aeae-7235b38f1880"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(388), null, "", true, false, "", new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 25, 15, 26, 29, 712, DateTimeKind.Local).AddTicks(1404), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("84c6f47d-9870-49fd-9b90-7c079ef34d53"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(1366), true, true, false, new Guid("4ba56599-8472-4b9c-a74b-70e837cb1cc3"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, null },
                    { new Guid("58b17399-e6e6-4e62-8907-e421c2845d14"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(934), true, true, false, new Guid("86a836a3-c9fb-4cf7-8fa6-a1269c431fab"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, null },
                    { new Guid("1fad11a5-f872-4cd7-959b-617a8b237666"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(1289), true, true, false, new Guid("1804a90a-929f-4a1d-912d-df84fa6ebdd4"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("e53fbab1-b753-4c50-a8eb-7e08822b0735"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(753), null, true, false, new Guid("1b480aed-3a9b-41e1-8cdc-9da51288fdb4"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c2f87a67-f4d9-4385-a954-c7395806e1e1"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(933), null, true, false, new Guid("e9746b19-175c-4de6-b6a4-6dbf7aa69a74"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c4f69e66-3f2c-416f-8458-75df9e7109d7"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(889), null, true, false, new Guid("7ceeae1c-9e7e-4367-8574-e526b6a3df50"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bdc3fa8b-7eae-418a-8831-e3c3bc1b5af8"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(842), null, true, false, new Guid("788c17a5-1adb-4648-bd26-28fd64158a94"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("55403b85-4c40-43a9-8330-15aea801814f"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(799), null, true, false, new Guid("8d4fb395-a961-445d-9d8c-957a15ea401b"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0d217f6d-1a26-4f67-b04c-cc3a077a3ba3"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(633), null, true, false, new Guid("a9fc267a-0d48-4ebe-8488-a8e895b752a6"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a1dc4623-6476-4ece-8dec-34ce9b644735"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(585), null, true, false, new Guid("364e3baf-1c52-42c5-92ff-2b58f9d6a9cc"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d717431f-6dc4-4143-813b-1b9fc8bc47eb"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(544), null, true, false, new Guid("2535b0cf-edbc-4c19-8e7f-6e15b1ef9e9b"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f751db3f-0855-4c44-8de6-59a1a5b35907"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(500), null, true, false, new Guid("91d9c2b3-a534-4cbf-b19f-f1d3bdaa0059"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9b2a68d6-b7a4-490c-8d59-32bb2ac5e1e7"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(457), null, true, false, new Guid("48e7551a-0771-464c-9a7c-ec7a860df4a9"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d899d2c1-940f-4313-b79d-3058d3a0eba0"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(410), null, true, false, new Guid("cf7cf921-e21f-40fb-aeae-7235b38f1880"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f14d9e77-32e1-423f-b62b-021d80b562d9"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(365), null, true, false, new Guid("eb23a2ce-340c-4371-984d-facb9f1b16a7"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d35de874-52db-4d64-bdb8-d031961ee35a"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(316), null, true, false, new Guid("303e0f1d-e91a-4702-83d3-b7e9963bd76e"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6f8ae9f4-6346-49f1-9702-e4876ce46a17"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(226), null, true, false, new Guid("97fada48-2826-4680-b3d4-785489af7d40"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5831ea76-fbba-43eb-b7d0-a89bb6190b16"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(177), null, true, false, new Guid("6bbd5b33-678d-41c5-9e8b-1c51083f27d7"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5f287ca6-31eb-4a4c-9ab3-29d1492c2d57"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(132), null, true, false, new Guid("4def72af-b4cc-46d9-9cb5-5b51d43f2437"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bcd33141-c8d2-4a9b-b62c-40552a3a7b45"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(81), null, true, false, new Guid("41e233eb-fb90-473f-9208-c7c258feb347"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("891435da-1c98-42bb-9832-5450aaddef64"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(9945), null, true, false, new Guid("7ed4d5db-0d0a-469a-a14b-c1f3372de8b0"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c555780-60bf-4520-a407-8fb8ea9368b4"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(9885), null, true, false, new Guid("7b8f0a64-5d52-48c2-a4f5-ceb53eb462bd"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a6ecd7f8-2a7a-4920-9d38-ad7fe68eb72c"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(9816), null, true, false, new Guid("4cdabeb7-dcae-4f3a-9807-793a9a4a417c"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("98481ef1-df91-4011-977d-f7f9544b4c94"), null, new DateTime(2021, 2, 25, 15, 26, 29, 713, DateTimeKind.Local).AddTicks(8969), null, true, false, new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b6495ef-a95b-4a9f-95c0-5310298a44f2"), null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(975), null, true, false, new Guid("f608a62f-aa01-475e-89bc-b5b8432f03a4"), new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("f24e8527-756f-499f-844e-6c662856d28e"), null, new Guid("4b225149-8225-461b-9bd0-14a5b05b74fc"), null, null, null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(9521), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("7e69e74d-e640-47fa-a599-8bcb9fc83014"), null, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(1993), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("f24e8527-756f-499f-844e-6c662856d28e"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c"), new Guid("4b225149-8225-461b-9bd0-14a5b05b74fc"), null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(5294), null, new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"), true, false, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), new Guid("f24e8527-756f-499f-844e-6c662856d28e"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("fef53de1-aed9-4f86-b3e3-95b7f6b77fec"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9634), null, true, false, new Guid("e9746b19-175c-4de6-b6a4-6dbf7aa69a74"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("a3bb86f0-871e-4e01-b458-17e94ff415fd"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9614), null, true, false, new Guid("7ceeae1c-9e7e-4367-8574-e526b6a3df50"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("e89b82f9-415a-4efe-a4cd-1b48597cfa54"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9594), null, true, false, new Guid("788c17a5-1adb-4648-bd26-28fd64158a94"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("602c999a-b40f-45bc-8db6-4046785d3ae4"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9573), null, true, false, new Guid("8d4fb395-a961-445d-9d8c-957a15ea401b"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("e95ab356-0356-4d59-a62e-403fd3e08687"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9550), null, true, false, new Guid("1b480aed-3a9b-41e1-8cdc-9da51288fdb4"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("2dcafbd1-b512-496a-947b-095ab9235eaa"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9527), null, true, false, new Guid("a9fc267a-0d48-4ebe-8488-a8e895b752a6"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("2baf098c-bc5d-4162-81be-09d5982bf8dd"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9507), null, true, false, new Guid("364e3baf-1c52-42c5-92ff-2b58f9d6a9cc"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("f4bb963c-c27f-4a01-8647-6995ba15469f"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9486), null, true, false, new Guid("2535b0cf-edbc-4c19-8e7f-6e15b1ef9e9b"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("5e72685c-6c6d-45a6-a555-3550e0664ac1"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9465), null, true, false, new Guid("91d9c2b3-a534-4cbf-b19f-f1d3bdaa0059"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("d1adecb5-eef7-4629-b3a7-b30ddd8e7447"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9444), null, true, false, new Guid("48e7551a-0771-464c-9a7c-ec7a860df4a9"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("a8fd9076-f6a7-402f-bfca-feee99971451"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9693), null, true, false, new Guid("f608a62f-aa01-475e-89bc-b5b8432f03a4"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("02546694-7c6a-4c9d-96d3-e95e000d9763"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9402), null, true, false, new Guid("eb23a2ce-340c-4371-984d-facb9f1b16a7"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("82aaa10b-3e7a-467a-a520-db6fd5c01b5e"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9378), null, true, false, new Guid("303e0f1d-e91a-4702-83d3-b7e9963bd76e"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("b8188b55-b6b7-4ebc-9c91-fc41fe725340"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9351), null, true, false, new Guid("97fada48-2826-4680-b3d4-785489af7d40"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("ddf7b7e2-806a-4892-9db1-f2f6241b553a"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9326), null, true, false, new Guid("6bbd5b33-678d-41c5-9e8b-1c51083f27d7"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("016d27e7-9dce-404b-84ce-60b95eac72e2"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9257), null, true, false, new Guid("4def72af-b4cc-46d9-9cb5-5b51d43f2437"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("b8dd8f13-ce5b-4ae7-9077-538fd9a9c699"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9232), null, true, false, new Guid("41e233eb-fb90-473f-9208-c7c258feb347"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("96d1e52a-d694-4875-b60d-2b5595dafe2a"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9209), null, true, false, new Guid("7ed4d5db-0d0a-469a-a14b-c1f3372de8b0"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("7ed8c7b4-da05-413d-b966-6ea604842201"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9185), null, true, false, new Guid("7b8f0a64-5d52-48c2-a4f5-ceb53eb462bd"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("4463a38d-b49b-4dd7-8b74-d4011641b9ac"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9148), null, true, false, new Guid("4cdabeb7-dcae-4f3a-9807-793a9a4a417c"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("51ce9df3-21c4-49c9-8f73-1da066d7a932"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(8897), null, true, false, new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") },
                    { new Guid("88a6e81c-9e09-477b-bc40-f17637a45a3f"), true, true, null, new DateTime(2021, 2, 25, 15, 26, 29, 715, DateTimeKind.Local).AddTicks(9424), null, true, false, new Guid("cf7cf921-e21f-40fb-aeae-7235b38f1880"), true, true, null, null, null, new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9270a0f7-f56f-4e13-aaee-25e35a6a8ad6"), "usuário administrativo", null, new DateTime(2021, 2, 25, 15, 26, 29, 714, DateTimeKind.Local).AddTicks(7395), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6e72b2fe-a7fd-4db2-8bdc-70395095b588"), new Guid("4b225149-8225-461b-9bd0-14a5b05b74fc"), null, new DateTime(2021, 2, 25, 15, 26, 29, 712, DateTimeKind.Local).AddTicks(4202), null, true, false, new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("4b225149-8225-461b-9bd0-14a5b05b74fc"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("6e72b2fe-a7fd-4db2-8bdc-70395095b588"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("a9ffb5b1-efaf-4fad-b8bf-7487778c5cc6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0e4ef021-0219-4b35-8a6f-e6520b7034d4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0ef704ba-8837-4143-a8a1-f0758f47a98a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("103e02ab-21f7-4820-96d4-c7d8d621f35a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("115f39ce-88d3-4f7f-8f76-2fc52e02af5e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("16ce140a-3fa0-4137-b3b0-ed5693072598"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2367c10a-ee0f-461b-b5b3-670f80e03931"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("30da5cea-0616-4a23-a5a8-681bc06c7d4b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4ac304c6-55fe-446f-814c-39786eb8099b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4e6d7a38-aa80-4f32-b693-c3a5969b9d61"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ea75f5f-3b60-4979-be24-35e81d0e3891"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("74b63467-7248-47e1-845c-026299ee505b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7865df6a-d03c-4fd3-8fa0-8106866a80a9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("789d6287-52d3-429c-b754-a65ce445631a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("90c12934-f709-41b1-987d-f7a4a397f06c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a9e5fd50-8bc4-4fda-9c94-c85c35c75268"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("aeebc5ac-73a2-4626-953c-50800f051f18"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bda00d72-8f2e-47bd-b814-39ce8509be0c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c6264ef5-11d7-4baf-b3da-232933d96612"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec524d8a-8091-4336-8c41-431266926e16"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ef70322b-80fe-4f01-86b5-9d631e9d6a3b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f02bd084-a756-40e3-a082-a78069f550f4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fc4f141f-3eed-42f6-9d5d-6f27013e83f6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("1804a90a-929f-4a1d-912d-df84fa6ebdd4"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4ba56599-8472-4b9c-a74b-70e837cb1cc3"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("86a836a3-c9fb-4cf7-8fa6-a1269c431fab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1b480aed-3a9b-41e1-8cdc-9da51288fdb4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2535b0cf-edbc-4c19-8e7f-6e15b1ef9e9b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("303e0f1d-e91a-4702-83d3-b7e9963bd76e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("364e3baf-1c52-42c5-92ff-2b58f9d6a9cc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("41e233eb-fb90-473f-9208-c7c258feb347"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("48e7551a-0771-464c-9a7c-ec7a860df4a9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4cdabeb7-dcae-4f3a-9807-793a9a4a417c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4def72af-b4cc-46d9-9cb5-5b51d43f2437"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6bbd5b33-678d-41c5-9e8b-1c51083f27d7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("788c17a5-1adb-4648-bd26-28fd64158a94"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7b8f0a64-5d52-48c2-a4f5-ceb53eb462bd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7ceeae1c-9e7e-4367-8574-e526b6a3df50"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7ed4d5db-0d0a-469a-a14b-c1f3372de8b0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("84911973-5846-4561-a6ed-04cf1677c4e6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8d4fb395-a961-445d-9d8c-957a15ea401b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("91d9c2b3-a534-4cbf-b19f-f1d3bdaa0059"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("97fada48-2826-4680-b3d4-785489af7d40"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a9fc267a-0d48-4ebe-8488-a8e895b752a6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cf7cf921-e21f-40fb-aeae-7235b38f1880"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e9746b19-175c-4de6-b6a4-6dbf7aa69a74"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("eb23a2ce-340c-4371-984d-facb9f1b16a7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f608a62f-aa01-475e-89bc-b5b8432f03a4"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("1fad11a5-f872-4cd7-959b-617a8b237666"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("58b17399-e6e6-4e62-8907-e421c2845d14"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("84c6f47d-9870-49fd-9b90-7c079ef34d53"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0d217f6d-1a26-4f67-b04c-cc3a077a3ba3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3b6495ef-a95b-4a9f-95c0-5310298a44f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4c555780-60bf-4520-a407-8fb8ea9368b4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("55403b85-4c40-43a9-8330-15aea801814f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5831ea76-fbba-43eb-b7d0-a89bb6190b16"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5f287ca6-31eb-4a4c-9ab3-29d1492c2d57"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6f8ae9f4-6346-49f1-9702-e4876ce46a17"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("891435da-1c98-42bb-9832-5450aaddef64"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("98481ef1-df91-4011-977d-f7f9544b4c94"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9b2a68d6-b7a4-490c-8d59-32bb2ac5e1e7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a1dc4623-6476-4ece-8dec-34ce9b644735"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a6ecd7f8-2a7a-4920-9d38-ad7fe68eb72c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bcd33141-c8d2-4a9b-b62c-40552a3a7b45"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bdc3fa8b-7eae-418a-8831-e3c3bc1b5af8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c2f87a67-f4d9-4385-a954-c7395806e1e1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c4f69e66-3f2c-416f-8458-75df9e7109d7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d35de874-52db-4d64-bdb8-d031961ee35a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d717431f-6dc4-4143-813b-1b9fc8bc47eb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d899d2c1-940f-4313-b79d-3058d3a0eba0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e53fbab1-b753-4c50-a8eb-7e08822b0735"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f14d9e77-32e1-423f-b62b-021d80b562d9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f751db3f-0855-4c44-8de6-59a1a5b35907"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f24e8527-756f-499f-844e-6c662856d28e"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("7e69e74d-e640-47fa-a599-8bcb9fc83014"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("8ddabc4f-5a3c-4dca-9f55-19a279c8c16c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("016d27e7-9dce-404b-84ce-60b95eac72e2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("02546694-7c6a-4c9d-96d3-e95e000d9763"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2baf098c-bc5d-4162-81be-09d5982bf8dd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2dcafbd1-b512-496a-947b-095ab9235eaa"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4463a38d-b49b-4dd7-8b74-d4011641b9ac"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("51ce9df3-21c4-49c9-8f73-1da066d7a932"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5e72685c-6c6d-45a6-a555-3550e0664ac1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("602c999a-b40f-45bc-8db6-4046785d3ae4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7ed8c7b4-da05-413d-b966-6ea604842201"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("82aaa10b-3e7a-467a-a520-db6fd5c01b5e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("88a6e81c-9e09-477b-bc40-f17637a45a3f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("96d1e52a-d694-4875-b60d-2b5595dafe2a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3bb86f0-871e-4e01-b458-17e94ff415fd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a8fd9076-f6a7-402f-bfca-feee99971451"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b8188b55-b6b7-4ebc-9c91-fc41fe725340"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b8dd8f13-ce5b-4ae7-9077-538fd9a9c699"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d1adecb5-eef7-4629-b3a7-b30ddd8e7447"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ddf7b7e2-806a-4892-9db1-f2f6241b553a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e89b82f9-415a-4efe-a4cd-1b48597cfa54"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e95ab356-0356-4d59-a62e-403fd3e08687"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f4bb963c-c27f-4a01-8647-6995ba15469f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fef53de1-aed9-4f86-b3e3-95b7f6b77fec"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("9270a0f7-f56f-4e13-aaee-25e35a6a8ad6"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("6cee5ae1-3c14-41fc-806c-ae591211ff3c"));

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Events",
                newName: "CustomersId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5ef66acb-8974-407e-a491-c540245fa0c1"), null, null, null, null, null, new DateTime(2021, 2, 25, 13, 55, 8, 879, DateTimeKind.Local).AddTicks(8867), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(4912), true, false, "Administradores", new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("2e29cb87-f8da-4977-a02e-2e2cbf7eacc4"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7984), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("8c5cba44-6d98-4b7e-b8ff-4b0df8f5f649"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("cee79ff2-1855-4eee-9d03-a3b44dfae8d8"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7923), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("6ef4849e-6a33-49ea-ab25-93e3a703917b"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("8fba5e2a-9799-4146-b1b1-899d94fb6bfa"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7902), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("b9866ec9-d795-425d-912c-99b1428771a8"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("a95ab5f5-2fce-4af6-906b-d655325c2c7b"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7878), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("b26d3095-7715-4690-82f6-0d870479174a"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("51d76e3e-0492-4afa-943f-f9616cdd0e2f"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7855), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("e5ec526f-152f-4f86-8c2c-608392d3db50"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("1d0e7e4f-5e20-4bc4-9f12-971b10795b7a"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7833), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("a0d62a99-c1e8-4788-9823-1bd5838bba97"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("5de576ce-fbb6-4ede-b55e-725920ab35c5"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7812), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("4e94654c-4851-4287-b70b-f732fec2dba5"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("f55e57d6-6468-4822-9289-437c35ab28db"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7791), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("90b355b4-12b8-437c-90f0-d4d0a5a56d83"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("61e8d0cd-1efe-45b9-acb3-f7a23212769a"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7770), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("645064be-baef-477d-932a-f3b0b914cc50"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("0f0510c3-3d1f-414f-9e1e-3b103d68c367"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7747), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("edeca874-691d-421b-ad6b-78156d553629"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("0e1bae22-d0f7-4b6a-8e33-5ddbf0b72bc9"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7726), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("e920c130-12f2-48d6-b0b4-490ab69520b4"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("6e7ede13-448a-4cf4-9153-500211500f91"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7702), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("8d465f41-f3f9-4b28-8bfc-38e57477cbbe"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("3672491f-6a94-40a3-9954-38998592e4f2"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7679), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("7fe15440-787a-4a0d-8478-e58d808680d0"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("7ab452b8-08b8-43ab-adb6-e9fe62cd9e8b"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7657), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("79ed0d9d-af46-4245-a996-a680e35e7fa3"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("d2dc3230-7c11-49fe-a73f-81d0eccbaa8a"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7636), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("b782699c-75c5-4ca3-9191-94acc251c4fa"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("631a80ab-1fc6-444d-8744-7872308072e0"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7614), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("e126d7f8-d382-4e3f-afe2-66c612695717"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("f89fde05-6af5-49c4-b3ab-56ee2d96836b"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7586), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("fcf9fc59-eced-437c-ab6b-46894b7c06ff"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("0d020060-16e4-4b86-abdf-2f7e6ebecc42"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7522), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("35541b2a-6fef-49b9-b4ff-8cc85eb778d8"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("5fcf75cb-bbd1-434d-8536-1d277fc048c6"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7498), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("9bfdbea4-210a-476f-a8a6-64d02204e5e2"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("50077a38-a97c-4014-a423-13df06ea9d9c"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7457), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("5b286c00-6a0d-4ead-93fb-bb5d7cbfd084"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("1a8efd0c-fc96-494d-ad82-6a76606cc6db"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(7186), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null },
                    { new Guid("8d461023-c673-4de8-b45b-7a2243bf71bb"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(8007), new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("439d43e3-6af0-40a6-a963-930ee18d6925"), true, new Guid("22121237-6316-4144-b290-b4f406b7be19"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("4bd28fa0-e514-4243-945d-adc6ab8f78f1"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(3444), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("50fea971-cb17-4ee0-b103-a8e66c5f0c7e"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(3325), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("226e0058-4430-4cd0-b3f9-57f9a38fbaa7"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(95), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("439d43e3-6af0-40a6-a963-930ee18d6925"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2914), null, "", true, false, "groupusers/details", new Guid("6ef4849e-6a33-49ea-ab25-93e3a703917b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8c5cba44-6d98-4b7e-b8ff-4b0df8f5f649"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2869), null, "", true, false, "groupusers/list", new Guid("6ef4849e-6a33-49ea-ab25-93e3a703917b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6ef4849e-6a33-49ea-ab25-93e3a703917b"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2826), null, "", true, false, "", new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b9866ec9-d795-425d-912c-99b1428771a8"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2778), null, "", true, false, "systems/details", new Guid("e5ec526f-152f-4f86-8c2c-608392d3db50"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b26d3095-7715-4690-82f6-0d870479174a"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2734), null, "", true, false, "systems/list", new Guid("e5ec526f-152f-4f86-8c2c-608392d3db50"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e5ec526f-152f-4f86-8c2c-608392d3db50"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2646), null, "", true, false, "", new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0d62a99-c1e8-4788-9823-1bd5838bba97"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2600), null, "", true, false, "languages/details", new Guid("90b355b4-12b8-437c-90f0-d4d0a5a56d83"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e94654c-4851-4287-b70b-f732fec2dba5"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2553), null, "", true, false, "languages/list", new Guid("90b355b4-12b8-437c-90f0-d4d0a5a56d83"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("90b355b4-12b8-437c-90f0-d4d0a5a56d83"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2510), null, "", true, false, "", new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("645064be-baef-477d-932a-f3b0b914cc50"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2466), null, "", true, false, "clients/details", new Guid("e920c130-12f2-48d6-b0b4-490ab69520b4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("edeca874-691d-421b-ad6b-78156d553629"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2420), null, "", true, false, "clients/list", new Guid("e920c130-12f2-48d6-b0b4-490ab69520b4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d465f41-f3f9-4b28-8bfc-38e57477cbbe"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2202), null, "", true, false, "menus/details", new Guid("79ed0d9d-af46-4245-a996-a680e35e7fa3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7fe15440-787a-4a0d-8478-e58d808680d0"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2152), null, "", true, false, "menus/list", new Guid("79ed0d9d-af46-4245-a996-a680e35e7fa3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("79ed0d9d-af46-4245-a996-a680e35e7fa3"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2103), null, "", true, false, "", new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b782699c-75c5-4ca3-9191-94acc251c4fa"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2053), null, "", true, false, "users/details", new Guid("fcf9fc59-eced-437c-ab6b-46894b7c06ff"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e126d7f8-d382-4e3f-afe2-66c612695717"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2004), null, "", true, false, "users/list", new Guid("fcf9fc59-eced-437c-ab6b-46894b7c06ff"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fcf9fc59-eced-437c-ab6b-46894b7c06ff"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1948), null, "", true, false, "", new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("35541b2a-6fef-49b9-b4ff-8cc85eb778d8"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1760), null, "", true, false, "companyoperators/details", new Guid("5b286c00-6a0d-4ead-93fb-bb5d7cbfd084"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9bfdbea4-210a-476f-a8a6-64d02204e5e2"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1700), null, "", true, false, "companyoperators/list", new Guid("5b286c00-6a0d-4ead-93fb-bb5d7cbfd084"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5b286c00-6a0d-4ead-93fb-bb5d7cbfd084"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1593), null, "", true, false, "", new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(8840), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e920c130-12f2-48d6-b0b4-490ab69520b4"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2362), null, "", true, false, "", new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("22121237-6316-4144-b290-b4f406b7be19"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 25, 13, 55, 8, 882, DateTimeKind.Local).AddTicks(3571), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("d8ddd232-6fb5-4643-8dcb-ea8a51fe0e25"), null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(3482), true, true, false, new Guid("4bd28fa0-e514-4243-945d-adc6ab8f78f1"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, null },
                    { new Guid("ef163369-e6a8-45e3-9c2b-1e29af4916c0"), null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(3072), true, true, false, new Guid("226e0058-4430-4cd0-b3f9-57f9a38fbaa7"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, null },
                    { new Guid("aae6abe5-1035-497e-9be2-7cc9829cf6ed"), null, new DateTime(2021, 2, 25, 13, 55, 8, 883, DateTimeKind.Local).AddTicks(3413), true, true, false, new Guid("50fea971-cb17-4ee0-b103-a8e66c5f0c7e"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("1e535b10-7ebb-4d1c-82b6-05c1a79d20f0"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2706), null, true, false, new Guid("e5ec526f-152f-4f86-8c2c-608392d3db50"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b94237e8-4fe5-42f5-9477-0c5d967a355c"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2890), null, true, false, new Guid("8c5cba44-6d98-4b7e-b8ff-4b0df8f5f649"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5c0a698a-1bb4-4591-ab8f-fea95e6e785f"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2846), null, true, false, new Guid("6ef4849e-6a33-49ea-ab25-93e3a703917b"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("899f91ed-c397-4968-99a0-d142892b99dc"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2800), null, true, false, new Guid("b9866ec9-d795-425d-912c-99b1428771a8"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc5a3d96-9a30-4179-a027-9d9ed8185cd4"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2755), null, true, false, new Guid("b26d3095-7715-4690-82f6-0d870479174a"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("798d4221-b84d-45f7-907e-4de3f4320b49"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2621), null, true, false, new Guid("a0d62a99-c1e8-4788-9823-1bd5838bba97"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cf11963e-f705-44f8-9526-e30e26c82553"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2574), null, true, false, new Guid("4e94654c-4851-4287-b70b-f732fec2dba5"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8b0bd0e9-3e99-4a28-accb-9bfd2593b37d"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2530), null, true, false, new Guid("90b355b4-12b8-437c-90f0-d4d0a5a56d83"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0c7146ca-87a6-41fa-8786-fa6ce928c517"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2487), null, true, false, new Guid("645064be-baef-477d-932a-f3b0b914cc50"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f2e8aec-8561-4869-918f-abb460b11878"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2441), null, true, false, new Guid("edeca874-691d-421b-ad6b-78156d553629"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a155958f-3d59-44cf-986c-d4b214958041"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2391), null, true, false, new Guid("e920c130-12f2-48d6-b0b4-490ab69520b4"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b8f0469f-6096-4f59-b403-3f94b94c3d8d"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2223), null, true, false, new Guid("8d465f41-f3f9-4b28-8bfc-38e57477cbbe"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d88c8fb9-fc1d-4f4c-89dd-8511bad1ca1c"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2176), null, true, false, new Guid("7fe15440-787a-4a0d-8478-e58d808680d0"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("32121eb1-6257-4822-bdd5-1533860ddb7d"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2125), null, true, false, new Guid("79ed0d9d-af46-4245-a996-a680e35e7fa3"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a3a9fdd5-3ceb-4a7b-a4b4-4549690a0e0b"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2075), null, true, false, new Guid("b782699c-75c5-4ca3-9191-94acc251c4fa"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bba14803-ec07-4442-9d1b-a49a2ab830d9"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2027), null, true, false, new Guid("e126d7f8-d382-4e3f-afe2-66c612695717"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cc721e86-162c-40b0-848c-f44a8950d7d4"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1977), null, true, false, new Guid("fcf9fc59-eced-437c-ab6b-46894b7c06ff"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("83a0ea3d-f01a-44bc-aacb-ae7509ca0ac6"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1839), null, true, false, new Guid("35541b2a-6fef-49b9-b4ff-8cc85eb778d8"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("17ee929a-0d4c-4c4f-9f51-e06d230d805f"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1726), null, true, false, new Guid("9bfdbea4-210a-476f-a8a6-64d02204e5e2"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8059889f-9355-4dcc-8c51-36faf48d3a64"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(1662), null, true, false, new Guid("5b286c00-6a0d-4ead-93fb-bb5d7cbfd084"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eed53925-fc44-4549-bafb-f153c2befe30"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(889), null, true, false, new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("90cff260-2c99-4309-b3c6-9fb0ed25735a"), null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(2935), null, true, false, new Guid("439d43e3-6af0-40a6-a963-930ee18d6925"), new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c34c6af6-85e7-4571-bd11-ee8680bbe73b"), null, new Guid("5ef66acb-8974-407e-a491-c540245fa0c1"), null, null, null, new DateTime(2021, 2, 25, 13, 55, 8, 885, DateTimeKind.Local).AddTicks(1544), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a9083d2b-5303-4695-8b5a-6667b08196c1"), null, null, new DateTime(2021, 2, 25, 13, 55, 8, 885, DateTimeKind.Local).AddTicks(4047), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("c34c6af6-85e7-4571-bd11-ee8680bbe73b"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d"), new Guid("5ef66acb-8974-407e-a491-c540245fa0c1"), null, new DateTime(2021, 2, 25, 13, 55, 8, 885, DateTimeKind.Local).AddTicks(7366), null, new Guid("f27278de-5f4f-4225-b71f-cb1312c22a8d"), true, false, new Guid("22121237-6316-4144-b290-b4f406b7be19"), new Guid("c34c6af6-85e7-4571-bd11-ee8680bbe73b"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("fbcd5647-facb-4efe-aadd-2739a1eed49e"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1705), null, true, false, new Guid("8c5cba44-6d98-4b7e-b8ff-4b0df8f5f649"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("7d825bc8-c039-4f15-a110-38d0761d909d"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1684), null, true, false, new Guid("6ef4849e-6a33-49ea-ab25-93e3a703917b"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("edb3a59f-13a7-4d29-98d8-434bf11ad7ef"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1663), null, true, false, new Guid("b9866ec9-d795-425d-912c-99b1428771a8"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("02eef34a-f73e-4a26-bec1-a77d94a42d93"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1642), null, true, false, new Guid("b26d3095-7715-4690-82f6-0d870479174a"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("70b074ca-3ccf-4f83-9152-e63c5fbd7b13"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1619), null, true, false, new Guid("e5ec526f-152f-4f86-8c2c-608392d3db50"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("de70aeeb-3019-474b-99eb-258a9338e225"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1595), null, true, false, new Guid("a0d62a99-c1e8-4788-9823-1bd5838bba97"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("1fea6b76-75ca-4f12-9d56-7818647a64b2"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1574), null, true, false, new Guid("4e94654c-4851-4287-b70b-f732fec2dba5"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("84a840af-e157-4f39-9c19-815ac9078c5c"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1553), null, true, false, new Guid("90b355b4-12b8-437c-90f0-d4d0a5a56d83"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("b2df59b7-f707-4d49-93b7-d7827b9fdb24"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1532), null, true, false, new Guid("645064be-baef-477d-932a-f3b0b914cc50"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("38dfd5ee-abec-4da4-8879-d710ca9eec97"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1510), null, true, false, new Guid("edeca874-691d-421b-ad6b-78156d553629"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("b4bc14b6-9c47-4cb9-8cfe-3270e835071d"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1727), null, true, false, new Guid("439d43e3-6af0-40a6-a963-930ee18d6925"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("e84f0730-dc31-484a-bdc6-b4cb73909b7a"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1465), null, true, false, new Guid("8d465f41-f3f9-4b28-8bfc-38e57477cbbe"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("67872ef4-c6b7-49df-8eda-42227c1543c6"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1394), null, true, false, new Guid("7fe15440-787a-4a0d-8478-e58d808680d0"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("839078c9-e464-49dd-9451-ec5721da4038"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1369), null, true, false, new Guid("79ed0d9d-af46-4245-a996-a680e35e7fa3"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("e1cfa648-a0cb-43aa-88a2-bf9a5f2c2941"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1348), null, true, false, new Guid("b782699c-75c5-4ca3-9191-94acc251c4fa"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("3a47191c-8d07-4da8-aae8-2e121e757a91"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1326), null, true, false, new Guid("e126d7f8-d382-4e3f-afe2-66c612695717"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("6496ab22-946c-431a-85c7-431b7661822d"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1301), null, true, false, new Guid("fcf9fc59-eced-437c-ab6b-46894b7c06ff"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("80cf919b-0cf4-45a0-8aef-080c5a16ea07"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1280), null, true, false, new Guid("35541b2a-6fef-49b9-b4ff-8cc85eb778d8"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("d7eb6023-de32-4b4d-837c-0acd5f75688b"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1256), null, true, false, new Guid("9bfdbea4-210a-476f-a8a6-64d02204e5e2"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("75f73031-d936-4bb4-900b-57497ece3f8f"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1222), null, true, false, new Guid("5b286c00-6a0d-4ead-93fb-bb5d7cbfd084"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("47a55b58-bbe8-42c3-b8f1-8fbf2662009a"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(995), null, true, false, new Guid("ccfac54e-6237-42f1-bed1-101aa2ed8577"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") },
                    { new Guid("0b893bf0-43db-4df8-b9c9-e387f9b895a9"), true, true, null, new DateTime(2021, 2, 25, 13, 55, 8, 886, DateTimeKind.Local).AddTicks(1489), null, true, false, new Guid("e920c130-12f2-48d6-b0b4-490ab69520b4"), true, true, null, null, null, new Guid("2876a46e-cb6a-40d1-8c04-d58717e31f9d") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3770068e-391b-45c2-b2ef-afbaabac55c7"), "usuário administrativo", null, new DateTime(2021, 2, 25, 13, 55, 8, 884, DateTimeKind.Local).AddTicks(9489), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3fbc1891-38ea-4a8d-ac19-a967e098e8f7"), new Guid("5ef66acb-8974-407e-a491-c540245fa0c1"), null, new DateTime(2021, 2, 25, 13, 55, 8, 882, DateTimeKind.Local).AddTicks(6421), null, true, false, new Guid("22121237-6316-4144-b290-b4f406b7be19"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
