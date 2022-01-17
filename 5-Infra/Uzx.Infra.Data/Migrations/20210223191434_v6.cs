using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Categories",
                newName: "Color");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Categories",
                newName: "Url");

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
    }
}
