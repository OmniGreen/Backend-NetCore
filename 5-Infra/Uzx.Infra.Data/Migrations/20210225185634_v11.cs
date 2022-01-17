using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventId");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("fcc8e58b-18e2-4a98-a80f-6490d82d0741"), null, null, null, null, null, new DateTime(2021, 2, 25, 15, 56, 32, 586, DateTimeKind.Local).AddTicks(8823), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(9756), true, false, "Administradores", new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("68b621d3-03db-4e75-830f-6bca52bd429c"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(3113), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("7128888c-580d-4d5e-96ed-28c6615294e8"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("356b38ef-9a4a-4c9b-afd7-d35249565afa"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(3091), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("2de4a1d0-399f-45ab-bb63-3629af714305"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("f4521167-9e11-4216-8a30-e944197c35aa"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(3067), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("a84433c2-f3a4-4ec3-846c-e67a89ddbf09"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("633e4b37-a290-4bcd-a466-239615f6d709"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(3046), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("9e634169-7ac6-48b5-ad0b-fe6c2b03d520"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("c6791862-f1f0-44f4-995e-b06c6ff2d258"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(3021), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("6b94aa8e-02cf-473b-b44d-aa11f5ef0880"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("5d767da3-5684-487c-8bbe-6f287c2aa51c"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(3000), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("efa722a9-45d2-4fb7-bc95-06336ef4e746"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("8fc92d86-ec93-45d8-a2c3-78dee00e4ee9"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2978), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("124d5326-6d6b-40d5-a6a8-851cb4ee28d6"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("9bc41a2e-e430-49b3-aa34-852f4697b84b"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2953), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("f1ebd283-7078-4f18-9f5f-e43adaf387b3"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("a7d88813-dc60-4ea6-b88a-769e19f5c4f1"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2884), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("da92afab-d74f-41b0-b58a-5e8a7fd9245a"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("3b1421d8-a340-4583-8fb1-c793defcdd47"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2862), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("7bbb79bd-6f16-4bcc-9820-415114db1f24"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("7cb07c76-a501-4554-aa78-03604b9fc309"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2839), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("b3daa628-d3dd-45b0-8831-ebd88e67ec5d"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("77fdc9ab-40a5-434c-8af2-201c154c1333"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2816), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("d90cbcd7-9935-4727-b04d-42235d5eac2a"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("f56cafa8-70e3-41dc-8d79-5b7f52cdabb7"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2793), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("ebe6ea32-4daf-4f3d-8e0f-e6d5c439d145"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("70498ee1-807f-4399-9c4c-c828de9d19f0"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2771), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("4779c14a-a0f5-4e39-adcc-19ceae6812ac"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("7127f403-006f-4df6-946c-e0430039a4ab"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2749), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("20bb2474-27bf-476f-ac6d-a1600ffb11ae"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("564b0701-9800-47f4-9882-9bd7bbce02b4"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2727), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("3c7e89f9-c39a-4e94-a462-2609405dcf4e"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("cccd2241-e66b-4ab0-9287-cd988550298a"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2702), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("4bdbc463-435d-4b44-ac73-6630cab8c1f3"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("77a2518b-ad58-480c-92f7-a2340b49338a"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2679), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("daa1c489-a719-4497-8ab2-b907b29fc222"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("715886c4-9285-4ae7-9c29-873ddc77a8ec"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2651), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("fa81d95b-fefb-4ff7-9df4-42a1780d5cee"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("f64499ba-0f0b-4c2f-b111-8a1edbdb1522"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2613), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("95e97cf7-4814-406e-aae3-a488494bc3ed"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("38ffd9d2-c08f-4833-ad5c-32b32a6eb000"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(2314), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null },
                    { new Guid("94648464-51f8-40e8-8b57-e7b4e2a6dccb"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(3135), new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("deeb88c6-7560-462e-a451-f13bb4673fab"), true, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("d1bc30eb-bf7b-4e44-adb6-b228caed3216"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(8284), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d3e57d66-9adc-4c05-90f5-ab4b2c4fb767"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(8165), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("01ff44b8-d2a3-4537-984f-2179f64daba4"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(4701), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("deeb88c6-7560-462e-a451-f13bb4673fab"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(8034), null, "", true, false, "groupusers/details", new Guid("2de4a1d0-399f-45ab-bb63-3629af714305"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7128888c-580d-4d5e-96ed-28c6615294e8"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7944), null, "", true, false, "groupusers/list", new Guid("2de4a1d0-399f-45ab-bb63-3629af714305"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2de4a1d0-399f-45ab-bb63-3629af714305"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7897), null, "", true, false, "", new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a84433c2-f3a4-4ec3-846c-e67a89ddbf09"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7851), null, "", true, false, "systems/details", new Guid("6b94aa8e-02cf-473b-b44d-aa11f5ef0880"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9e634169-7ac6-48b5-ad0b-fe6c2b03d520"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7806), null, "", true, false, "systems/list", new Guid("6b94aa8e-02cf-473b-b44d-aa11f5ef0880"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6b94aa8e-02cf-473b-b44d-aa11f5ef0880"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7756), null, "", true, false, "", new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("efa722a9-45d2-4fb7-bc95-06336ef4e746"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7706), null, "", true, false, "languages/details", new Guid("f1ebd283-7078-4f18-9f5f-e43adaf387b3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("124d5326-6d6b-40d5-a6a8-851cb4ee28d6"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7658), null, "", true, false, "languages/list", new Guid("f1ebd283-7078-4f18-9f5f-e43adaf387b3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f1ebd283-7078-4f18-9f5f-e43adaf387b3"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7573), null, "", true, false, "", new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("da92afab-d74f-41b0-b58a-5e8a7fd9245a"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7527), null, "", true, false, "clients/details", new Guid("b3daa628-d3dd-45b0-8831-ebd88e67ec5d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7bbb79bd-6f16-4bcc-9820-415114db1f24"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7477), null, "", true, false, "clients/list", new Guid("b3daa628-d3dd-45b0-8831-ebd88e67ec5d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d90cbcd7-9935-4727-b04d-42235d5eac2a"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7383), null, "", true, false, "menus/details", new Guid("4779c14a-a0f5-4e39-adcc-19ceae6812ac"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ebe6ea32-4daf-4f3d-8e0f-e6d5c439d145"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7332), null, "", true, false, "menus/list", new Guid("4779c14a-a0f5-4e39-adcc-19ceae6812ac"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4779c14a-a0f5-4e39-adcc-19ceae6812ac"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7275), null, "", true, false, "", new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("20bb2474-27bf-476f-ac6d-a1600ffb11ae"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7180), null, "", true, false, "users/details", new Guid("4bdbc463-435d-4b44-ac73-6630cab8c1f3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3c7e89f9-c39a-4e94-a462-2609405dcf4e"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7126), null, "", true, false, "users/list", new Guid("4bdbc463-435d-4b44-ac73-6630cab8c1f3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4bdbc463-435d-4b44-ac73-6630cab8c1f3"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7071), null, "", true, false, "", new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("daa1c489-a719-4497-8ab2-b907b29fc222"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(6937), null, "", true, false, "companyoperators/details", new Guid("95e97cf7-4814-406e-aae3-a488494bc3ed"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fa81d95b-fefb-4ff7-9df4-42a1780d5cee"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(6887), null, "", true, false, "companyoperators/list", new Guid("95e97cf7-4814-406e-aae3-a488494bc3ed"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("95e97cf7-4814-406e-aae3-a488494bc3ed"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(6771), null, "", true, false, "", new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(3897), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b3daa628-d3dd-45b0-8831-ebd88e67ec5d"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7431), null, "", true, false, "", new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 25, 15, 56, 32, 589, DateTimeKind.Local).AddTicks(7883), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("8a27645d-7848-4638-974e-b194578c50a5"), null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(8310), true, true, false, new Guid("d1bc30eb-bf7b-4e44-adb6-b228caed3216"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, null },
                    { new Guid("f34eaea1-fdc8-42d5-93cf-cd39fa883478"), null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(7897), true, true, false, new Guid("01ff44b8-d2a3-4537-984f-2179f64daba4"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, null },
                    { new Guid("b6014788-7f10-496e-9321-af73d76bae71"), null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(8254), true, true, false, new Guid("d3e57d66-9adc-4c05-90f5-ab4b2c4fb767"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("3cd35345-7ee5-43d9-b32d-73e81d179d4f"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7780), null, true, false, new Guid("6b94aa8e-02cf-473b-b44d-aa11f5ef0880"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("052385d5-694c-4927-a9e0-a1d490b86061"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(8007), null, true, false, new Guid("7128888c-580d-4d5e-96ed-28c6615294e8"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d8ba827f-81b8-4b53-b197-5e4f9c9f92ac"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7917), null, true, false, new Guid("2de4a1d0-399f-45ab-bb63-3629af714305"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c1bf820a-6971-43a6-90f4-3fe9c1bb3d2e"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7873), null, true, false, new Guid("a84433c2-f3a4-4ec3-846c-e67a89ddbf09"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a57db573-81d8-4878-8176-4635110d96da"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7827), null, true, false, new Guid("9e634169-7ac6-48b5-ad0b-fe6c2b03d520"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("638273d2-c124-4b57-b4c9-929167e05576"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7727), null, true, false, new Guid("efa722a9-45d2-4fb7-bc95-06336ef4e746"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7db572b0-4399-4ff3-b832-716aa3ef050b"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7681), null, true, false, new Guid("124d5326-6d6b-40d5-a6a8-851cb4ee28d6"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("afb77f13-10db-4257-bec1-e38c273948c5"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7594), null, true, false, new Guid("f1ebd283-7078-4f18-9f5f-e43adaf387b3"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("03425519-aa35-4194-962f-e995eca4e636"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7548), null, true, false, new Guid("da92afab-d74f-41b0-b58a-5e8a7fd9245a"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bf2061a0-1ae1-4c04-afe9-272d02e58409"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7500), null, true, false, new Guid("7bbb79bd-6f16-4bcc-9820-415114db1f24"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cca9e4fb-e219-4f16-b26f-140afc0d189f"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7453), null, true, false, new Guid("b3daa628-d3dd-45b0-8831-ebd88e67ec5d"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1c6d5102-32ba-4d74-95e0-77233a1c0312"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7406), null, true, false, new Guid("d90cbcd7-9935-4727-b04d-42235d5eac2a"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b6f03b03-e80a-4444-b7cb-9d6a699c8e0e"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7355), null, true, false, new Guid("ebe6ea32-4daf-4f3d-8e0f-e6d5c439d145"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("95133a3b-7bcd-4b82-a3f7-d29aca8c219f"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7300), null, true, false, new Guid("4779c14a-a0f5-4e39-adcc-19ceae6812ac"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("09be160e-63c7-46ca-90ff-5562f84dd965"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7202), null, true, false, new Guid("20bb2474-27bf-476f-ac6d-a1600ffb11ae"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2f400048-4fbb-427c-8bdf-a582440e6720"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7155), null, true, false, new Guid("3c7e89f9-c39a-4e94-a462-2609405dcf4e"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60358153-c71d-4cdd-9d0c-949fa245253c"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(7099), null, true, false, new Guid("4bdbc463-435d-4b44-ac73-6630cab8c1f3"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("056cbdf5-1b05-478f-832f-cbf32129653a"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(6959), null, true, false, new Guid("daa1c489-a719-4497-8ab2-b907b29fc222"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f0d9ab11-a57d-4864-a9a8-aaa09a5882bb"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(6911), null, true, false, new Guid("fa81d95b-fefb-4ff7-9df4-42a1780d5cee"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e40a211f-14aa-4115-a3e2-28ece928c5b3"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(6844), null, true, false, new Guid("95e97cf7-4814-406e-aae3-a488494bc3ed"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b4737f55-92c8-4fde-8ce8-8fc7994d1902"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(5948), null, true, false, new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4a424dd4-f242-41f9-8e35-de647d80f8b6"), null, new DateTime(2021, 2, 25, 15, 56, 32, 591, DateTimeKind.Local).AddTicks(8056), null, true, false, new Guid("deeb88c6-7560-462e-a451-f13bb4673fab"), new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("fd2b57ce-58bc-402e-9ac7-c3e7252d6ec5"), null, new Guid("fcc8e58b-18e2-4a98-a80f-6490d82d0741"), null, null, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(6818), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("87ccc1c6-b414-42b5-8b43-089fcdaf81fe"), null, null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(9347), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("fd2b57ce-58bc-402e-9ac7-c3e7252d6ec5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3"), new Guid("fcc8e58b-18e2-4a98-a80f-6490d82d0741"), null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(2922), null, new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"), true, false, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), new Guid("fd2b57ce-58bc-402e-9ac7-c3e7252d6ec5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("1abf584f-7d66-4ae2-8fef-4e0f0a94be3e"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7601), null, true, false, new Guid("7128888c-580d-4d5e-96ed-28c6615294e8"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("75f277de-2e77-4608-b89b-3f4f2f3eef1a"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7578), null, true, false, new Guid("2de4a1d0-399f-45ab-bb63-3629af714305"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("ed2b113b-eff3-48a7-8467-72658a6a0fd5"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7555), null, true, false, new Guid("a84433c2-f3a4-4ec3-846c-e67a89ddbf09"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("cd02f185-a049-44cd-82ca-b3bc8d4ffca2"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7531), null, true, false, new Guid("9e634169-7ac6-48b5-ad0b-fe6c2b03d520"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("7c377b15-dc1d-4fc2-b29c-e1345551a553"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7466), null, true, false, new Guid("6b94aa8e-02cf-473b-b44d-aa11f5ef0880"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("4ade6889-f8fc-42a6-a984-d1d171126aa1"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7444), null, true, false, new Guid("efa722a9-45d2-4fb7-bc95-06336ef4e746"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("4ce7393f-773c-4767-a8b8-72cea3029978"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7422), null, true, false, new Guid("124d5326-6d6b-40d5-a6a8-851cb4ee28d6"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("29295d03-f85d-4b0c-8d65-06aca9d44106"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7400), null, true, false, new Guid("f1ebd283-7078-4f18-9f5f-e43adaf387b3"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("8a63fd7e-5f6b-4efc-9e99-86f9cd9500d8"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7378), null, true, false, new Guid("da92afab-d74f-41b0-b58a-5e8a7fd9245a"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("3af043f3-4bc2-4d46-8c5a-2027cb20626c"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7356), null, true, false, new Guid("7bbb79bd-6f16-4bcc-9820-415114db1f24"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("08e4644c-6657-45a4-b027-236c1da41dec"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7623), null, true, false, new Guid("deeb88c6-7560-462e-a451-f13bb4673fab"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("a51c7d4f-cfc2-4eb0-a171-020477b9bca6"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7309), null, true, false, new Guid("d90cbcd7-9935-4727-b04d-42235d5eac2a"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("a3a13db7-33c3-4dd7-a199-a1076ef4b305"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7267), null, true, false, new Guid("ebe6ea32-4daf-4f3d-8e0f-e6d5c439d145"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("5ca78068-99c2-4d4a-885f-ae624aa38fb4"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7244), null, true, false, new Guid("4779c14a-a0f5-4e39-adcc-19ceae6812ac"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("ba82139a-60ab-4ae7-b18d-2a6ce335ed47"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7222), null, true, false, new Guid("20bb2474-27bf-476f-ac6d-a1600ffb11ae"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("107210a7-b1b8-4de2-9f3f-186f8699132c"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7200), null, true, false, new Guid("3c7e89f9-c39a-4e94-a462-2609405dcf4e"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("979f1090-ad81-45df-b811-e2dc5ccb0fc8"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7173), null, true, false, new Guid("4bdbc463-435d-4b44-ac73-6630cab8c1f3"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("31172fae-8819-4e4e-8e64-1578cf17cf83"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7149), null, true, false, new Guid("daa1c489-a719-4497-8ab2-b907b29fc222"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("aa568bd0-9c4a-41d6-bbca-be1f7129b93d"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7122), null, true, false, new Guid("fa81d95b-fefb-4ff7-9df4-42a1780d5cee"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("6032c4b2-6446-4927-b48d-d5fc0ab6f293"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7036), null, true, false, new Guid("95e97cf7-4814-406e-aae3-a488494bc3ed"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("6cdc4dc8-3c43-46f5-ba30-b7d17d9350bc"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(6745), null, true, false, new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") },
                    { new Guid("993944fe-ee6d-4f86-909a-c5c0642e6732"), true, true, null, new DateTime(2021, 2, 25, 15, 56, 32, 593, DateTimeKind.Local).AddTicks(7333), null, true, false, new Guid("b3daa628-d3dd-45b0-8831-ebd88e67ec5d"), true, true, null, null, null, new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("671dd612-ce98-4602-9c3b-da5d441de7c1"), "usuário administrativo", null, new DateTime(2021, 2, 25, 15, 56, 32, 592, DateTimeKind.Local).AddTicks(4666), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3a1029b4-3a13-438f-88a8-dbf3da76d010"), new Guid("fcc8e58b-18e2-4a98-a80f-6490d82d0741"), null, new DateTime(2021, 2, 25, 15, 56, 32, 590, DateTimeKind.Local).AddTicks(786), null, true, false, new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("fcc8e58b-18e2-4a98-a80f-6490d82d0741"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("3a1029b4-3a13-438f-88a8-dbf3da76d010"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("a1fe931d-52b7-44d8-9ac6-5a106d165f59"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("356b38ef-9a4a-4c9b-afd7-d35249565afa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("38ffd9d2-c08f-4833-ad5c-32b32a6eb000"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3b1421d8-a340-4583-8fb1-c793defcdd47"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("564b0701-9800-47f4-9882-9bd7bbce02b4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5d767da3-5684-487c-8bbe-6f287c2aa51c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("633e4b37-a290-4bcd-a466-239615f6d709"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("68b621d3-03db-4e75-830f-6bca52bd429c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("70498ee1-807f-4399-9c4c-c828de9d19f0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7127f403-006f-4df6-946c-e0430039a4ab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("715886c4-9285-4ae7-9c29-873ddc77a8ec"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("77a2518b-ad58-480c-92f7-a2340b49338a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("77fdc9ab-40a5-434c-8af2-201c154c1333"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7cb07c76-a501-4554-aa78-03604b9fc309"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8fc92d86-ec93-45d8-a2c3-78dee00e4ee9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("94648464-51f8-40e8-8b57-e7b4e2a6dccb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9bc41a2e-e430-49b3-aa34-852f4697b84b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a7d88813-dc60-4ea6-b88a-769e19f5c4f1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c6791862-f1f0-44f4-995e-b06c6ff2d258"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cccd2241-e66b-4ab0-9287-cd988550298a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f4521167-9e11-4216-8a30-e944197c35aa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f56cafa8-70e3-41dc-8d79-5b7f52cdabb7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f64499ba-0f0b-4c2f-b111-8a1edbdb1522"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("01ff44b8-d2a3-4537-984f-2179f64daba4"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d1bc30eb-bf7b-4e44-adb6-b228caed3216"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("d3e57d66-9adc-4c05-90f5-ab4b2c4fb767"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("124d5326-6d6b-40d5-a6a8-851cb4ee28d6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("20bb2474-27bf-476f-ac6d-a1600ffb11ae"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2de4a1d0-399f-45ab-bb63-3629af714305"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3c7e89f9-c39a-4e94-a462-2609405dcf4e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4779c14a-a0f5-4e39-adcc-19ceae6812ac"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4bdbc463-435d-4b44-ac73-6630cab8c1f3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6b94aa8e-02cf-473b-b44d-aa11f5ef0880"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7128888c-580d-4d5e-96ed-28c6615294e8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7bbb79bd-6f16-4bcc-9820-415114db1f24"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("95e97cf7-4814-406e-aae3-a488494bc3ed"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9e634169-7ac6-48b5-ad0b-fe6c2b03d520"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a84433c2-f3a4-4ec3-846c-e67a89ddbf09"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("aa0eb554-ebea-4b2b-a1ac-c4137aca32bb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b3daa628-d3dd-45b0-8831-ebd88e67ec5d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d90cbcd7-9935-4727-b04d-42235d5eac2a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("da92afab-d74f-41b0-b58a-5e8a7fd9245a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("daa1c489-a719-4497-8ab2-b907b29fc222"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("deeb88c6-7560-462e-a451-f13bb4673fab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ebe6ea32-4daf-4f3d-8e0f-e6d5c439d145"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("efa722a9-45d2-4fb7-bc95-06336ef4e746"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f1ebd283-7078-4f18-9f5f-e43adaf387b3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fa81d95b-fefb-4ff7-9df4-42a1780d5cee"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("8a27645d-7848-4638-974e-b194578c50a5"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("b6014788-7f10-496e-9321-af73d76bae71"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("f34eaea1-fdc8-42d5-93cf-cd39fa883478"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("03425519-aa35-4194-962f-e995eca4e636"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("052385d5-694c-4927-a9e0-a1d490b86061"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("056cbdf5-1b05-478f-832f-cbf32129653a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("09be160e-63c7-46ca-90ff-5562f84dd965"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1c6d5102-32ba-4d74-95e0-77233a1c0312"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2f400048-4fbb-427c-8bdf-a582440e6720"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3cd35345-7ee5-43d9-b32d-73e81d179d4f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4a424dd4-f242-41f9-8e35-de647d80f8b6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("60358153-c71d-4cdd-9d0c-949fa245253c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("638273d2-c124-4b57-b4c9-929167e05576"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7db572b0-4399-4ff3-b832-716aa3ef050b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("95133a3b-7bcd-4b82-a3f7-d29aca8c219f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a57db573-81d8-4878-8176-4635110d96da"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("afb77f13-10db-4257-bec1-e38c273948c5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b4737f55-92c8-4fde-8ce8-8fc7994d1902"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b6f03b03-e80a-4444-b7cb-9d6a699c8e0e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bf2061a0-1ae1-4c04-afe9-272d02e58409"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c1bf820a-6971-43a6-90f4-3fe9c1bb3d2e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cca9e4fb-e219-4f16-b26f-140afc0d189f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d8ba827f-81b8-4b53-b197-5e4f9c9f92ac"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e40a211f-14aa-4115-a3e2-28ece928c5b3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f0d9ab11-a57d-4864-a9a8-aaa09a5882bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("fd2b57ce-58bc-402e-9ac7-c3e7252d6ec5"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("87ccc1c6-b414-42b5-8b43-089fcdaf81fe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("b3499b39-9b67-408b-8b97-33647b23d6c3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("08e4644c-6657-45a4-b027-236c1da41dec"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("107210a7-b1b8-4de2-9f3f-186f8699132c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1abf584f-7d66-4ae2-8fef-4e0f0a94be3e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("29295d03-f85d-4b0c-8d65-06aca9d44106"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("31172fae-8819-4e4e-8e64-1578cf17cf83"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3af043f3-4bc2-4d46-8c5a-2027cb20626c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4ade6889-f8fc-42a6-a984-d1d171126aa1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4ce7393f-773c-4767-a8b8-72cea3029978"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5ca78068-99c2-4d4a-885f-ae624aa38fb4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6032c4b2-6446-4927-b48d-d5fc0ab6f293"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6cdc4dc8-3c43-46f5-ba30-b7d17d9350bc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("75f277de-2e77-4608-b89b-3f4f2f3eef1a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7c377b15-dc1d-4fc2-b29c-e1345551a553"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8a63fd7e-5f6b-4efc-9e99-86f9cd9500d8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("979f1090-ad81-45df-b811-e2dc5ccb0fc8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("993944fe-ee6d-4f86-909a-c5c0642e6732"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3a13db7-33c3-4dd7-a199-a1076ef4b305"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a51c7d4f-cfc2-4eb0-a171-020477b9bca6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aa568bd0-9c4a-41d6-bbca-be1f7129b93d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ba82139a-60ab-4ae7-b18d-2a6ce335ed47"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cd02f185-a049-44cd-82ca-b3bc8d4ffca2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ed2b113b-eff3-48a7-8467-72658a6a0fd5"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("671dd612-ce98-4602-9c3b-da5d441de7c1"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("86802de2-a1c6-4d71-ae2e-cefd82f6299e"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "CategoryId");

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
    }
}
