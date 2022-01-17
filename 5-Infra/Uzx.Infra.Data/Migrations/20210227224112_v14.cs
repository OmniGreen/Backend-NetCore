using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("c2e009bc-464c-46da-840c-eefadcdc9785"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("264bdf3e-babc-45b5-9e4a-260b2cecca9f"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("01ea8a21-9832-4f69-80b7-1eb5a171966d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("02195c99-eb2c-4ad1-a7cc-24c8c2987a45"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("049a2d2e-8f3f-4a22-925c-9ce15c33ecee"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("049be398-bf76-4a45-84df-435ca5f94020"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("08a3ed1f-b064-47c1-a16b-d09cadb0e447"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1540b6e6-72fe-459a-a1d9-eb566d49abf3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("22492de7-2d2e-411c-8b53-d7ac26c669a0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29337931-de4f-4b0f-9dc7-e3c2a6b9400c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29b981cb-3420-4bf7-80a8-2850a9b576dd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3589093c-5757-4866-a259-e8bddc4bb276"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("38447021-665d-4dca-a862-fc478e408062"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("56ad703e-0f18-4c1b-a655-4131b7611696"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("816b09ff-a856-4027-9745-9d13bd12c566"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8da3a587-fbe3-4336-9da0-f2c85d73efc7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("99dd2ce5-6e09-485f-99a3-64b507f397bf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a21eb32d-efaa-4b81-9b59-a2d1707cf0a0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b5947076-142a-4a72-8f5e-cca6aa06b7f1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bf1bb8e1-055b-4b50-8304-eb8b3ace6392"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c5406ee5-55eb-4e72-a67b-da9a07c18f5c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c755f263-cbf7-4399-ae06-998b9c6d814c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f4592d7a-45ef-47fb-b2dc-e8f6b97e77bd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fef0c5cb-004b-4e55-9738-6ab13478e4e0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("370d5c10-c79b-4558-b513-c8f3bf2b3de8"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("467f9c1d-ede4-415c-ba31-9d4194845138"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("869208d1-27f5-4f1f-b107-c976b4a57b67"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0106d5d6-9cee-4480-85c1-00e1698d91fa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("02c20c00-b2cc-489f-9ca5-5cf952d87eea"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("02f194ed-6d41-4893-9a2a-998891f6e422"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0e528a94-4929-4dc3-ad54-182ac8f56fb2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0f5c849e-32a2-4899-b0c9-cd17fcbcb82a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("13109c4d-d638-4f46-bf9e-a200a77f5bbc"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("217a614b-cc9c-431f-8353-6278795209a5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("28063d43-17a5-4054-9775-d1655ddb1dc9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2cc615cc-ba02-4c14-b060-f40b2777183e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("327a7fda-7335-4130-b3b0-7b27112bab43"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3612275f-53ae-4d6d-bec5-fa1917b1684c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4767b7e0-910d-4819-b6cb-e552e3652d92"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4921edbc-334f-4b70-8c2d-df7c7d87aa28"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4ac79749-eb76-4701-bf0d-28713e0c815c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("911be499-cbf2-4b81-9d3d-c997e314e010"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a739b19f-142c-45e0-ac23-ceaa2ed6591b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b0606a0f-1012-443d-8213-870160bb029d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b2f89214-3206-4a14-9867-4b66d772c80f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b8872b5a-e206-4e40-ad99-b49d3343f59a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ddded12a-edc6-4c9d-ac5a-fc67afc3c644"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e35a4c49-1391-43cc-9d51-82be7053208d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("49409d32-5de5-4ae8-b545-a341236482e9"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("596d6b1c-c78b-45e3-9e26-4bde52510dbe"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("619b5c49-da11-4167-9212-483fc300c47c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("09723d7b-c648-4c5e-980a-1b6ab77b73b2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0d16ef9f-a396-4b41-8047-0fe6a4eac4f7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0d50676d-fa8e-4c8c-9f0d-4de789d3d2ae"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1d6bd2a0-e8f3-4720-b013-8aa74149f1b9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("28096b21-89ae-4dbc-8168-64fed6366cbf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("37c3e06f-e09e-492e-b8f5-7304cfacbe58"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("37f52731-1057-4dea-a2d1-d4591cecf89d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("56c1ea0f-59b6-4e09-bb21-d4668b42d5f6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6696f6ad-9ac6-4823-b827-268358a0eed9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6d090c71-b57f-4b7a-aac2-2a23a28e19e8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7168530d-1cf2-4ab3-9223-7dfa3787627d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("77918df3-9bb4-4579-9734-de35fc12e0c5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("89229eb5-6e2e-4500-8e7e-55521d6d57fb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b192687b-a1fe-43ab-b937-fe6a7bc53eb3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c178d96f-33ca-492e-a117-597a5a0e6a2b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cbc5ec50-54d6-4baa-93f5-e22a8f22f109"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dbf8dbee-3c0b-4a48-b5f1-86ec04e8ba78"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dd17352e-023b-4d8f-bfb4-3735e1c09708"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dd7f8065-ccbb-4a81-82fd-153f88390843"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dfcc19aa-a4fb-42dc-8bb4-a86ac70e0128"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fa3e2628-044e-4a15-9a5b-f98965e1f69f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fd4290dc-80cf-4be2-8fc0-166d780ad41e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("64e1c109-f9e3-44cb-8095-2ebffa3a0af0"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("9639c590-2579-45d9-b4fa-f233f2cae828"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("04707b34-7725-4e5f-83a5-d79ed2ab0159"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2e2c23ff-df1a-4b90-b2fd-e03564765da6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("42b730c7-de53-4eef-b328-19325052745b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("44fdb7f1-6f90-4797-96ae-cb1aa9610f50"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("610796fa-cf9b-423c-9004-2e8c3143cf26"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("63f7a115-6fa5-48a1-9d51-9e71c59d091a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("74c528bb-b94e-4377-8f2e-38e5d95cfb12"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7dd908bd-bb8a-468c-b9c5-e5c0950028da"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("89e51b94-10b4-498c-bf0c-2c5a7478c40a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9cc00e8a-3032-492d-96df-c9bfe2235cc1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3a84d2b-4cb6-4957-8f4b-689525279316"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a470aca1-6345-4e5e-a821-93a952a8689a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b76a76a5-6d7b-4568-8300-856b6864d258"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ba6a13f0-c842-4741-8a49-f97c25e7802c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("be9eba49-7aa7-4a0a-9ec7-df1dce8fd11e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c3dee48b-d1b3-437d-aba2-1bb2edd5a73e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c65868ab-e2ca-4be2-9ca6-24efc0c2c956"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d4ddd09a-4b86-4cd8-8dc2-2491013e5559"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e9b9a4d5-6157-4e3f-9592-17fe036ae566"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ebbfe93d-2397-49e3-b5d9-c50acac0d568"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("edd9a397-88de-494d-9d96-d4c6337d4910"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f6ed8f95-507f-4c96-ad8d-bf596ef9d5bc"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("3f018660-8e30-4802-ab21-6a3cb0bceab9"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("dd803525-c46d-417e-b2c1-5466a792d542"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDestaque",
                table: "SalePlans",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, null, null, null, null, new DateTime(2021, 2, 27, 19, 41, 10, 559, DateTimeKind.Local).AddTicks(8353), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(5914), true, false, "Administradores", new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("a5526eda-1923-44cf-8768-967b439e81a1"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7234), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("69263d5a-f475-491e-a83a-4563d0e857ed"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7139), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("9eec35ec-1f74-45cb-9c4d-45ec39e2f351"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7097), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("df3c2ad6-597a-4cbc-9a61-af2b73f8205c"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7059), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("aee13dab-55bf-4b02-9782-d76c63de8dbc"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7017), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("ffa152eb-1c47-479c-b3c0-8614357e699d"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6980), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("d1e3bee0-4040-4ee4-a6b5-a2e344648c20"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6943), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("c9914482-5141-4d72-a71b-249079be6ec5"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6906), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("d4fd0c1b-a161-403f-8618-3404bb209341"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6870), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("8408e7cf-3444-4aa3-9d72-453ad8f0f4c6"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6835), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("9ce35bc2-96d3-4144-9a4f-1dfc931bd5f3"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6796), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("4096656b-df16-45c6-9a28-8fa86f5a5340"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6760), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("4e1b2c6f-3a1e-4770-80ba-04b0fdb8c2e9"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6721), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("fef552e6-c514-4a78-bc87-c31ab6093026"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6684), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("885c25b1-24b1-432c-a635-e085b8370259"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6646), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("245e454f-904e-40be-b1c0-c348db6edb5a"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6607), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("4d7b9e5e-def1-45a5-b304-0be49056c2d8"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6560), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("c575494b-abbe-49d1-ba87-5231535865d5"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6430), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("1ee4aa5d-4714-49c1-b34c-883e3c1664e0"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6378), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("7e4281c2-ab66-41a5-a1fe-1aa2bc1f19c4"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(6308), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("05239893-f52e-4bb3-936d-26d6c4c10241"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(5770), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null },
                    { new Guid("21b3a942-0cd8-4c6e-aff1-1234569ff976"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(7273), new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), true, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("65d3e4df-f4b0-4052-967b-84aeefcf3478"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3564), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3a66f80a-c685-48f4-bed5-ba2c87dd7cd1"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3290), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dd1bdef9-277e-4231-8bec-9521144ad818"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 27, 19, 41, 10, 563, DateTimeKind.Local).AddTicks(7721), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9120), null, "", true, false, "groupusers/details", new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9051), null, "", true, false, "groupusers/list", new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8981), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8906), null, "", true, false, "systems/details", new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8832), null, "", true, false, "systems/list", new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8691), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8605), null, "", true, false, "languages/details", new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8530), null, "", true, false, "languages/list", new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8455), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8382), null, "", true, false, "clients/details", new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8304), null, "", true, false, "clients/list", new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7981), null, "", true, false, "menus/details", new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7897), null, "", true, false, "menus/list", new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7817), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7743), null, "", true, false, "users/details", new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7664), null, "", true, false, "users/list", new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7559), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7298), null, "", true, false, "companyoperators/details", new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7107), null, "", true, false, "companyoperators/list", new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(6931), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(2540), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8191), null, "", true, false, "", new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 27, 19, 41, 10, 562, DateTimeKind.Local).AddTicks(7189), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("68ef487f-656d-47b7-8c28-dcc999f269d2"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3634), true, true, false, new Guid("65d3e4df-f4b0-4052-967b-84aeefcf3478"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null },
                    { new Guid("aa558ad5-dd29-4179-b420-4f34e21cfda2"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(2588), true, true, false, new Guid("dd1bdef9-277e-4231-8bec-9521144ad818"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null },
                    { new Guid("ced8a8bc-3dd7-437a-9485-ba0a36191de0"), null, new DateTime(2021, 2, 27, 19, 41, 10, 564, DateTimeKind.Local).AddTicks(3487), true, true, false, new Guid("3a66f80a-c685-48f4-bed5-ba2c87dd7cd1"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("2b9bd656-1e11-4924-8945-ae1c1a093b99"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8788), null, true, false, new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a2f65e4d-d1fe-47ea-ae9d-e3e4b54f4615"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9083), null, true, false, new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5e69a354-d43b-43bb-a8cd-668932fcbde7"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9012), null, true, false, new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("19797bae-0382-474b-a861-a33a5665017f"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8941), null, true, false, new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("907ac2cf-78e5-42bc-ad0b-68e5026572f2"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8865), null, true, false, new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c8aa871e-c63e-4aa3-a233-1b2fca8d4cbf"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8643), null, true, false, new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24849eb1-97b7-4efc-ae7f-1856a5dc945e"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8566), null, true, false, new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0d87b2c-b035-4f03-ac66-29ffcf301564"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8491), null, true, false, new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("befffa5e-2002-41f3-b9b9-30becb405e88"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8415), null, true, false, new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b82ceba9-f365-4949-83ce-b3e74a7c4cc6"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8339), null, true, false, new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b7b032dc-15bc-4bf6-9083-bf5974731e45"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8230), null, true, false, new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f8b11550-deec-4e05-8621-fb83d3b53182"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(8138), null, true, false, new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9daa6ac0-93aa-4029-9756-755cc90f3b69"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7938), null, true, false, new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bcf853d9-91d2-48f8-87e2-5c3b21e3c969"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7851), null, true, false, new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("076002df-80c6-4efc-8888-89936006d946"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7778), null, true, false, new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("32787569-cef3-41c1-b4c3-48055babd87d"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7701), null, true, false, new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4a8766f3-387f-4e63-9d23-aee66c73e5d5"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7604), null, true, false, new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92422c56-ee11-47fb-a27c-e888a9f7604b"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7348), null, true, false, new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e9f3bcf5-d30b-4d3c-9a56-5b4f3a3140ed"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7144), null, true, false, new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60158115-b1c2-46ad-bb69-5ab373dc7edf"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(7046), null, true, false, new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ea091ae-1592-4834-a45d-253b1a8d5d55"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(5864), null, true, false, new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0be3fc51-5973-42f1-b27f-8168dfa3ba97"), null, new DateTime(2021, 2, 27, 19, 41, 10, 565, DateTimeKind.Local).AddTicks(9153), null, true, false, new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"), null, new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, null, null, new DateTime(2021, 2, 27, 19, 41, 10, 567, DateTimeKind.Local).AddTicks(2530), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("4e17dc11-2c34-454a-b95f-33e4e59907ca"), null, null, new DateTime(2021, 2, 27, 19, 41, 10, 567, DateTimeKind.Local).AddTicks(5957), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5dd68006-3167-449c-85db-826ede251049"), new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, new DateTime(2021, 2, 27, 19, 41, 10, 567, DateTimeKind.Local).AddTicks(9477), null, new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"), true, false, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("74019d1a-9034-47b3-bbba-734dc7a0d6d1"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4212), null, true, false, new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("7a07eead-8f23-4d5e-9d92-5c9138c141b6"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4190), null, true, false, new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e2705b11-725e-488c-af86-c5ee5f7f8110"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4167), null, true, false, new Guid("b6352257-8e94-4907-b158-6872dbaedf58"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("dae6f319-a3cc-4f92-b817-9f6c0d9f0690"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4144), null, true, false, new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("03955a04-b87f-4b31-a4a3-802d52da9a4f"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4117), null, true, false, new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("7fb5d275-c301-48b9-80b5-14069e08faab"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4094), null, true, false, new Guid("d2894634-91de-4fec-8058-e6395fee4d06"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("0eb2d8c6-1f0e-4a10-9a37-7ba399bf8cc4"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4072), null, true, false, new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("95bc1dd7-eaba-4fc6-b5b9-9ff1786dac16"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4050), null, true, false, new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("ee3328f0-59c3-41af-af0a-d1ceb52324bc"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4028), null, true, false, new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("94e3d27d-123f-47ae-b7ec-b5b3acabe674"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4006), null, true, false, new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("53c15963-8fab-4d8e-8366-eae0075e24d5"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(4235), null, true, false, new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("05aa5830-234c-4782-918c-31ff342c282d"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3959), null, true, false, new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("0f6f0458-ee3f-450a-999b-f31988727754"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3833), null, true, false, new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("54fcac41-34c0-48ed-bf36-ac8ba27857b2"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3811), null, true, false, new Guid("61aaec20-111e-407d-b7c3-909adb57584d"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e68600b4-521a-4639-b242-2c924a1f18f9"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3788), null, true, false, new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("619dff44-ecd3-4e01-aa03-8501a0d3b1e4"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3765), null, true, false, new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e3e8215b-f4fb-4b8b-8991-3462378d1288"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3738), null, true, false, new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("cec6005e-acd4-4306-be3a-2cacb196a846"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3714), null, true, false, new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("aa746fcf-41a3-4a63-b880-01474cdb7f41"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3688), null, true, false, new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("5ed26dff-18ba-4727-8cfa-c1e834eafff8"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3649), null, true, false, new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("e61f97a8-3eb1-427a-9fb5-bc17594ad51c"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3367), null, true, false, new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") },
                    { new Guid("0b5616b1-3829-4fc1-8ccb-83ba306f8390"), true, true, null, new DateTime(2021, 2, 27, 19, 41, 10, 568, DateTimeKind.Local).AddTicks(3983), null, true, false, new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"), true, true, null, null, null, new Guid("5dd68006-3167-449c-85db-826ede251049") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("125e6d70-2a8a-45be-aebb-1707094dfa1d"), "usuário administrativo", null, new DateTime(2021, 2, 27, 19, 41, 10, 566, DateTimeKind.Local).AddTicks(9544), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("57e67f20-879c-4830-83b6-de6063337e5c"), new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"), null, new DateTime(2021, 2, 27, 19, 41, 10, 563, DateTimeKind.Local).AddTicks(1880), null, true, false, new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("9015e175-ec92-4c3d-a77c-38bd3ee8ea0b"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("57e67f20-879c-4830-83b6-de6063337e5c"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("f5b6b38e-6e01-43ea-ac25-725947c709de"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05239893-f52e-4bb3-936d-26d6c4c10241"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1ee4aa5d-4714-49c1-b34c-883e3c1664e0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("21b3a942-0cd8-4c6e-aff1-1234569ff976"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("245e454f-904e-40be-b1c0-c348db6edb5a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4096656b-df16-45c6-9a28-8fa86f5a5340"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4d7b9e5e-def1-45a5-b304-0be49056c2d8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4e1b2c6f-3a1e-4770-80ba-04b0fdb8c2e9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("69263d5a-f475-491e-a83a-4563d0e857ed"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7e4281c2-ab66-41a5-a1fe-1aa2bc1f19c4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8408e7cf-3444-4aa3-9d72-453ad8f0f4c6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("885c25b1-24b1-432c-a635-e085b8370259"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9ce35bc2-96d3-4144-9a4f-1dfc931bd5f3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9eec35ec-1f74-45cb-9c4d-45ec39e2f351"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a5526eda-1923-44cf-8768-967b439e81a1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("aee13dab-55bf-4b02-9782-d76c63de8dbc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c575494b-abbe-49d1-ba87-5231535865d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c9914482-5141-4d72-a71b-249079be6ec5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d1e3bee0-4040-4ee4-a6b5-a2e344648c20"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d4fd0c1b-a161-403f-8618-3404bb209341"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("df3c2ad6-597a-4cbc-9a61-af2b73f8205c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fef552e6-c514-4a78-bc87-c31ab6093026"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ffa152eb-1c47-479c-b3c0-8614357e699d"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("3a66f80a-c685-48f4-bed5-ba2c87dd7cd1"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("65d3e4df-f4b0-4052-967b-84aeefcf3478"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("dd1bdef9-277e-4231-8bec-9521144ad818"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0deaeefe-4dfe-4aaf-b5e1-e008a2dd1b66"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1b5b0d4a-f2ed-4016-ae15-0ad1dbee1e42"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("22764eab-220f-4f76-8490-e7408f0c9a2b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("27dfc2e3-23d6-41c5-bcfe-422733be8743"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2c80fe55-49c6-49fd-98ea-1d34d8f30eeb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3ed488f0-fd26-4724-85cd-2c98c3ce395a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("40f1c46c-cf12-408d-8264-6860b45b3012"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4a0e3a9f-1361-49f9-bf3c-05fb253740d5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4c88a3bb-fa61-4b99-8638-4bd140037163"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5070631c-29b2-48a0-a6da-08bcd545d28c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("534a0b8c-acdd-47ce-84fc-0f39b1cd846b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("61aaec20-111e-407d-b7c3-909adb57584d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("79efc838-8ac1-441d-a31f-2d2f7c9c93f1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8352e868-738e-443a-8d9c-18cafa14a15e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("88c3d810-52ca-4ba6-b059-7c674139bba0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("90dde6f9-3a36-4c7a-b9d6-f168a0fc116f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b3091cc2-fb9d-4683-be37-27baca1e2ee5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b6352257-8e94-4907-b158-6872dbaedf58"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c0227e5d-a43e-408d-9b40-b2bbcc8b0ae8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c5d64dfb-697c-46b0-8909-69fe2d9c30d7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c8bad62d-4091-45e4-b072-d9b640c9d4aa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d2894634-91de-4fec-8058-e6395fee4d06"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("68ef487f-656d-47b7-8c28-dcc999f269d2"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("aa558ad5-dd29-4179-b420-4f34e21cfda2"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("ced8a8bc-3dd7-437a-9485-ba0a36191de0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("076002df-80c6-4efc-8888-89936006d946"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0be3fc51-5973-42f1-b27f-8168dfa3ba97"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("19797bae-0382-474b-a861-a33a5665017f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("24849eb1-97b7-4efc-ae7f-1856a5dc945e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2b9bd656-1e11-4924-8945-ae1c1a093b99"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("32787569-cef3-41c1-b4c3-48055babd87d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3ea091ae-1592-4834-a45d-253b1a8d5d55"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4a8766f3-387f-4e63-9d23-aee66c73e5d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5e69a354-d43b-43bb-a8cd-668932fcbde7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("60158115-b1c2-46ad-bb69-5ab373dc7edf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("907ac2cf-78e5-42bc-ad0b-68e5026572f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("92422c56-ee11-47fb-a27c-e888a9f7604b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9daa6ac0-93aa-4029-9756-755cc90f3b69"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a0d87b2c-b035-4f03-ac66-29ffcf301564"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a2f65e4d-d1fe-47ea-ae9d-e3e4b54f4615"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b7b032dc-15bc-4bf6-9083-bf5974731e45"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b82ceba9-f365-4949-83ce-b3e74a7c4cc6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bcf853d9-91d2-48f8-87e2-5c3b21e3c969"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("befffa5e-2002-41f3-b9b9-30becb405e88"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c8aa871e-c63e-4aa3-a233-1b2fca8d4cbf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e9f3bcf5-d30b-4d3c-9a56-5b4f3a3140ed"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f8b11550-deec-4e05-8621-fb83d3b53182"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("894faf08-7afe-4bd1-8e75-4788233ac792"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("4e17dc11-2c34-454a-b95f-33e4e59907ca"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("5dd68006-3167-449c-85db-826ede251049"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("03955a04-b87f-4b31-a4a3-802d52da9a4f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("05aa5830-234c-4782-918c-31ff342c282d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0b5616b1-3829-4fc1-8ccb-83ba306f8390"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0eb2d8c6-1f0e-4a10-9a37-7ba399bf8cc4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0f6f0458-ee3f-450a-999b-f31988727754"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("53c15963-8fab-4d8e-8366-eae0075e24d5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("54fcac41-34c0-48ed-bf36-ac8ba27857b2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5ed26dff-18ba-4727-8cfa-c1e834eafff8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("619dff44-ecd3-4e01-aa03-8501a0d3b1e4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("74019d1a-9034-47b3-bbba-734dc7a0d6d1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7a07eead-8f23-4d5e-9d92-5c9138c141b6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7fb5d275-c301-48b9-80b5-14069e08faab"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("94e3d27d-123f-47ae-b7ec-b5b3acabe674"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("95bc1dd7-eaba-4fc6-b5b9-9ff1786dac16"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aa746fcf-41a3-4a63-b880-01474cdb7f41"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cec6005e-acd4-4306-be3a-2cacb196a846"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("dae6f319-a3cc-4f92-b817-9f6c0d9f0690"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e2705b11-725e-488c-af86-c5ee5f7f8110"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e3e8215b-f4fb-4b8b-8991-3462378d1288"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e61f97a8-3eb1-427a-9fb5-bc17594ad51c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e68600b4-521a-4639-b242-2c924a1f18f9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ee3328f0-59c3-41af-af0a-d1ceb52324bc"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("125e6d70-2a8a-45be-aebb-1707094dfa1d"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("450afe22-1e3b-4af4-b4dc-58a3e04683f7"));

            migrationBuilder.DropColumn(
                name: "IsDestaque",
                table: "SalePlans");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c2e009bc-464c-46da-840c-eefadcdc9785"), null, null, null, null, null, new DateTime(2021, 2, 26, 13, 55, 11, 180, DateTimeKind.Local).AddTicks(6181), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), null, new DateTime(2021, 2, 26, 13, 55, 11, 186, DateTimeKind.Local).AddTicks(7626), true, false, "Administradores", new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("f4592d7a-45ef-47fb-b2dc-e8f6b97e77bd"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4790), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("4921edbc-334f-4b70-8c2d-df7c7d87aa28"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("3589093c-5757-4866-a259-e8bddc4bb276"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4750), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("0f5c849e-32a2-4899-b0c9-cd17fcbcb82a"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("22492de7-2d2e-411c-8b53-d7ac26c669a0"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4706), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("0106d5d6-9cee-4480-85c1-00e1698d91fa"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("fef0c5cb-004b-4e55-9738-6ab13478e4e0"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4663), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("2cc615cc-ba02-4c14-b060-f40b2777183e"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("049a2d2e-8f3f-4a22-925c-9ce15c33ecee"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4616), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("02f194ed-6d41-4893-9a2a-998891f6e422"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("816b09ff-a856-4027-9745-9d13bd12c566"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4572), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("28063d43-17a5-4054-9775-d1655ddb1dc9"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("049be398-bf76-4a45-84df-435ca5f94020"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4520), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("a739b19f-142c-45e0-ac23-ceaa2ed6591b"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("38447021-665d-4dca-a862-fc478e408062"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4478), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("13109c4d-d638-4f46-bf9e-a200a77f5bbc"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("99dd2ce5-6e09-485f-99a3-64b507f397bf"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4434), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("b2f89214-3206-4a14-9867-4b66d772c80f"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("b5947076-142a-4a72-8f5e-cca6aa06b7f1"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4392), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("4ac79749-eb76-4701-bf0d-28713e0c815c"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("c755f263-cbf7-4399-ae06-998b9c6d814c"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4349), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("b0606a0f-1012-443d-8213-870160bb029d"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("01ea8a21-9832-4f69-80b7-1eb5a171966d"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4307), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("b8872b5a-e206-4e40-ad99-b49d3343f59a"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("1540b6e6-72fe-459a-a1d9-eb566d49abf3"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4262), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("0e528a94-4929-4dc3-ad54-182ac8f56fb2"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("29337931-de4f-4b0f-9dc7-e3c2a6b9400c"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4220), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("3612275f-53ae-4d6d-bec5-fa1917b1684c"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("08a3ed1f-b064-47c1-a16b-d09cadb0e447"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4164), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("ddded12a-edc6-4c9d-ac5a-fc67afc3c644"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("a21eb32d-efaa-4b81-9b59-a2d1707cf0a0"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4111), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("e35a4c49-1391-43cc-9d51-82be7053208d"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("56ad703e-0f18-4c1b-a655-4131b7611696"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(3965), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("911be499-cbf2-4b81-9d3d-c997e314e010"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("c5406ee5-55eb-4e72-a67b-da9a07c18f5c"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(3918), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("02c20c00-b2cc-489f-9ca5-5cf952d87eea"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("bf1bb8e1-055b-4b50-8304-eb8b3ace6392"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(3871), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("4767b7e0-910d-4819-b6cb-e552e3652d92"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("8da3a587-fbe3-4336-9da0-f2c85d73efc7"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(3793), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("327a7fda-7335-4130-b3b0-7b27112bab43"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("29b981cb-3420-4bf7-80a8-2850a9b576dd"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(2737), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null },
                    { new Guid("02195c99-eb2c-4ad1-a7cc-24c8c2987a45"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(4986), new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("217a614b-cc9c-431f-8353-6278795209a5"), true, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("869208d1-27f5-4f1f-b107-c976b4a57b67"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 26, 13, 55, 11, 186, DateTimeKind.Local).AddTicks(4932), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("370d5c10-c79b-4558-b513-c8f3bf2b3de8"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 26, 13, 55, 11, 186, DateTimeKind.Local).AddTicks(4626), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("467f9c1d-ede4-415c-ba31-9d4194845138"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 26, 13, 55, 11, 185, DateTimeKind.Local).AddTicks(9081), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("217a614b-cc9c-431f-8353-6278795209a5"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1353), null, "", true, false, "groupusers/details", new Guid("0f5c849e-32a2-4899-b0c9-cd17fcbcb82a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4921edbc-334f-4b70-8c2d-df7c7d87aa28"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1266), null, "", true, false, "groupusers/list", new Guid("0f5c849e-32a2-4899-b0c9-cd17fcbcb82a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0f5c849e-32a2-4899-b0c9-cd17fcbcb82a"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1183), null, "", true, false, "", new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0106d5d6-9cee-4480-85c1-00e1698d91fa"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1098), null, "", true, false, "systems/details", new Guid("02f194ed-6d41-4893-9a2a-998891f6e422"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2cc615cc-ba02-4c14-b060-f40b2777183e"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1005), null, "", true, false, "systems/list", new Guid("02f194ed-6d41-4893-9a2a-998891f6e422"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("02f194ed-6d41-4893-9a2a-998891f6e422"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(860), null, "", true, false, "", new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28063d43-17a5-4054-9775-d1655ddb1dc9"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(774), null, "", true, false, "languages/details", new Guid("13109c4d-d638-4f46-bf9e-a200a77f5bbc"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a739b19f-142c-45e0-ac23-ceaa2ed6591b"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(690), null, "", true, false, "languages/list", new Guid("13109c4d-d638-4f46-bf9e-a200a77f5bbc"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("13109c4d-d638-4f46-bf9e-a200a77f5bbc"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(602), null, "", true, false, "", new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b2f89214-3206-4a14-9867-4b66d772c80f"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(516), null, "", true, false, "clients/details", new Guid("b0606a0f-1012-443d-8213-870160bb029d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4ac79749-eb76-4701-bf0d-28713e0c815c"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(430), null, "", true, false, "clients/list", new Guid("b0606a0f-1012-443d-8213-870160bb029d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b8872b5a-e206-4e40-ad99-b49d3343f59a"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(125), null, "", true, false, "menus/details", new Guid("3612275f-53ae-4d6d-bec5-fa1917b1684c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0e528a94-4929-4dc3-ad54-182ac8f56fb2"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(38), null, "", true, false, "menus/list", new Guid("3612275f-53ae-4d6d-bec5-fa1917b1684c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3612275f-53ae-4d6d-bec5-fa1917b1684c"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9956), null, "", true, false, "", new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ddded12a-edc6-4c9d-ac5a-fc67afc3c644"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9877), null, "", true, false, "users/details", new Guid("911be499-cbf2-4b81-9d3d-c997e314e010"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e35a4c49-1391-43cc-9d51-82be7053208d"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9789), null, "", true, false, "users/list", new Guid("911be499-cbf2-4b81-9d3d-c997e314e010"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("911be499-cbf2-4b81-9d3d-c997e314e010"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9681), null, "", true, false, "", new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("02c20c00-b2cc-489f-9ca5-5cf952d87eea"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9288), null, "", true, false, "companyoperators/details", new Guid("327a7fda-7335-4130-b3b0-7b27112bab43"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4767b7e0-910d-4819-b6cb-e552e3652d92"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9200), null, "", true, false, "companyoperators/list", new Guid("327a7fda-7335-4130-b3b0-7b27112bab43"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("327a7fda-7335-4130-b3b0-7b27112bab43"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(8989), null, "", true, false, "", new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(4477), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b0606a0f-1012-443d-8213-870160bb029d"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(216), null, "", true, false, "", new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 26, 13, 55, 11, 184, DateTimeKind.Local).AddTicks(7789), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("49409d32-5de5-4ae8-b545-a341236482e9"), null, new DateTime(2021, 2, 26, 13, 55, 11, 186, DateTimeKind.Local).AddTicks(4988), true, true, false, new Guid("869208d1-27f5-4f1f-b107-c976b4a57b67"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, null },
                    { new Guid("619b5c49-da11-4167-9212-483fc300c47c"), null, new DateTime(2021, 2, 26, 13, 55, 11, 186, DateTimeKind.Local).AddTicks(4097), true, true, false, new Guid("467f9c1d-ede4-415c-ba31-9d4194845138"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, null },
                    { new Guid("596d6b1c-c78b-45e3-9e26-4bde52510dbe"), null, new DateTime(2021, 2, 26, 13, 55, 11, 186, DateTimeKind.Local).AddTicks(4839), true, true, false, new Guid("370d5c10-c79b-4558-b513-c8f3bf2b3de8"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("37c3e06f-e09e-492e-b8f5-7304cfacbe58"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(904), null, true, false, new Guid("02f194ed-6d41-4893-9a2a-998891f6e422"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("56c1ea0f-59b6-4e09-bb21-d4668b42d5f6"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1307), null, true, false, new Guid("4921edbc-334f-4b70-8c2d-df7c7d87aa28"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6696f6ad-9ac6-4823-b827-268358a0eed9"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1224), null, true, false, new Guid("0f5c849e-32a2-4899-b0c9-cd17fcbcb82a"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("37f52731-1057-4dea-a2d1-d4591cecf89d"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1139), null, true, false, new Guid("0106d5d6-9cee-4480-85c1-00e1698d91fa"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fa3e2628-044e-4a15-9a5b-f98965e1f69f"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1049), null, true, false, new Guid("2cc615cc-ba02-4c14-b060-f40b2777183e"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0d16ef9f-a396-4b41-8047-0fe6a4eac4f7"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(814), null, true, false, new Guid("28063d43-17a5-4054-9775-d1655ddb1dc9"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b192687b-a1fe-43ab-b937-fe6a7bc53eb3"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(729), null, true, false, new Guid("a739b19f-142c-45e0-ac23-ceaa2ed6591b"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fd4290dc-80cf-4be2-8fc0-166d780ad41e"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(641), null, true, false, new Guid("13109c4d-d638-4f46-bf9e-a200a77f5bbc"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c178d96f-33ca-492e-a117-597a5a0e6a2b"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(556), null, true, false, new Guid("b2f89214-3206-4a14-9867-4b66d772c80f"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28096b21-89ae-4dbc-8168-64fed6366cbf"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(470), null, true, false, new Guid("4ac79749-eb76-4701-bf0d-28713e0c815c"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dd17352e-023b-4d8f-bfb4-3735e1c09708"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(379), null, true, false, new Guid("b0606a0f-1012-443d-8213-870160bb029d"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dd7f8065-ccbb-4a81-82fd-153f88390843"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(166), null, true, false, new Guid("b8872b5a-e206-4e40-ad99-b49d3343f59a"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("77918df3-9bb4-4579-9734-de35fc12e0c5"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(79), null, true, false, new Guid("0e528a94-4929-4dc3-ad54-182ac8f56fb2"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6d090c71-b57f-4b7a-aac2-2a23a28e19e8"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9993), null, true, false, new Guid("3612275f-53ae-4d6d-bec5-fa1917b1684c"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dfcc19aa-a4fb-42dc-8bb4-a86ac70e0128"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9914), null, true, false, new Guid("ddded12a-edc6-4c9d-ac5a-fc67afc3c644"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("09723d7b-c648-4c5e-980a-1b6ab77b73b2"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9828), null, true, false, new Guid("e35a4c49-1391-43cc-9d51-82be7053208d"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dbf8dbee-3c0b-4a48-b5f1-86ec04e8ba78"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9742), null, true, false, new Guid("911be499-cbf2-4b81-9d3d-c997e314e010"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0d50676d-fa8e-4c8c-9f0d-4de789d3d2ae"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9329), null, true, false, new Guid("02c20c00-b2cc-489f-9ca5-5cf952d87eea"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7168530d-1cf2-4ab3-9223-7dfa3787627d"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9242), null, true, false, new Guid("4767b7e0-910d-4819-b6cb-e552e3652d92"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cbc5ec50-54d6-4baa-93f5-e22a8f22f109"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(9121), null, true, false, new Guid("327a7fda-7335-4130-b3b0-7b27112bab43"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d6bd2a0-e8f3-4720-b013-8aa74149f1b9"), null, new DateTime(2021, 2, 26, 13, 55, 11, 187, DateTimeKind.Local).AddTicks(7774), null, true, false, new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("89229eb5-6e2e-4500-8e7e-55521d6d57fb"), null, new DateTime(2021, 2, 26, 13, 55, 11, 188, DateTimeKind.Local).AddTicks(1393), null, true, false, new Guid("217a614b-cc9c-431f-8353-6278795209a5"), new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("64e1c109-f9e3-44cb-8095-2ebffa3a0af0"), null, new Guid("c2e009bc-464c-46da-840c-eefadcdc9785"), null, null, null, new DateTime(2021, 2, 26, 13, 55, 11, 191, DateTimeKind.Local).AddTicks(1644), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9639c590-2579-45d9-b4fa-f233f2cae828"), null, null, new DateTime(2021, 2, 26, 13, 55, 11, 192, DateTimeKind.Local).AddTicks(3669), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("64e1c109-f9e3-44cb-8095-2ebffa3a0af0"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4"), new Guid("c2e009bc-464c-46da-840c-eefadcdc9785"), null, new DateTime(2021, 2, 26, 13, 55, 11, 192, DateTimeKind.Local).AddTicks(9834), null, new Guid("61ae6684-ec7c-4931-acc5-79f9436ae439"), true, false, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), new Guid("64e1c109-f9e3-44cb-8095-2ebffa3a0af0"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("9cc00e8a-3032-492d-96df-c9bfe2235cc1"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7993), null, true, false, new Guid("4921edbc-334f-4b70-8c2d-df7c7d87aa28"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("44fdb7f1-6f90-4797-96ae-cb1aa9610f50"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7948), null, true, false, new Guid("0f5c849e-32a2-4899-b0c9-cd17fcbcb82a"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("c3dee48b-d1b3-437d-aba2-1bb2edd5a73e"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7903), null, true, false, new Guid("0106d5d6-9cee-4480-85c1-00e1698d91fa"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("e9b9a4d5-6157-4e3f-9592-17fe036ae566"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7856), null, true, false, new Guid("2cc615cc-ba02-4c14-b060-f40b2777183e"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("be9eba49-7aa7-4a0a-9ec7-df1dce8fd11e"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7806), null, true, false, new Guid("02f194ed-6d41-4893-9a2a-998891f6e422"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("d4ddd09a-4b86-4cd8-8dc2-2491013e5559"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7759), null, true, false, new Guid("28063d43-17a5-4054-9775-d1655ddb1dc9"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("ebbfe93d-2397-49e3-b5d9-c50acac0d568"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7714), null, true, false, new Guid("a739b19f-142c-45e0-ac23-ceaa2ed6591b"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("ba6a13f0-c842-4741-8a49-f97c25e7802c"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7668), null, true, false, new Guid("13109c4d-d638-4f46-bf9e-a200a77f5bbc"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("2e2c23ff-df1a-4b90-b2fd-e03564765da6"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7618), null, true, false, new Guid("b2f89214-3206-4a14-9867-4b66d772c80f"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("b76a76a5-6d7b-4568-8300-856b6864d258"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7571), null, true, false, new Guid("4ac79749-eb76-4701-bf0d-28713e0c815c"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("42b730c7-de53-4eef-b328-19325052745b"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(8039), null, true, false, new Guid("217a614b-cc9c-431f-8353-6278795209a5"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("63f7a115-6fa5-48a1-9d51-9e71c59d091a"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7393), null, true, false, new Guid("b8872b5a-e206-4e40-ad99-b49d3343f59a"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("7dd908bd-bb8a-468c-b9c5-e5c0950028da"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7343), null, true, false, new Guid("0e528a94-4929-4dc3-ad54-182ac8f56fb2"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("a470aca1-6345-4e5e-a821-93a952a8689a"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7296), null, true, false, new Guid("3612275f-53ae-4d6d-bec5-fa1917b1684c"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("04707b34-7725-4e5f-83a5-d79ed2ab0159"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7250), null, true, false, new Guid("ddded12a-edc6-4c9d-ac5a-fc67afc3c644"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("610796fa-cf9b-423c-9004-2e8c3143cf26"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7203), null, true, false, new Guid("e35a4c49-1391-43cc-9d51-82be7053208d"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("74c528bb-b94e-4377-8f2e-38e5d95cfb12"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7132), null, true, false, new Guid("911be499-cbf2-4b81-9d3d-c997e314e010"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("89e51b94-10b4-498c-bf0c-2c5a7478c40a"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7082), null, true, false, new Guid("02c20c00-b2cc-489f-9ca5-5cf952d87eea"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("f6ed8f95-507f-4c96-ad8d-bf596ef9d5bc"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7031), null, true, false, new Guid("4767b7e0-910d-4819-b6cb-e552e3652d92"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("a3a84d2b-4cb6-4957-8f4b-689525279316"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(6966), null, true, false, new Guid("327a7fda-7335-4130-b3b0-7b27112bab43"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("edd9a397-88de-494d-9d96-d4c6337d4910"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(6496), null, true, false, new Guid("4f66619b-8e72-4f0c-bd49-61d0d86097c3"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") },
                    { new Guid("c65868ab-e2ca-4be2-9ca6-24efc0c2c956"), true, true, null, new DateTime(2021, 2, 26, 13, 55, 11, 193, DateTimeKind.Local).AddTicks(7519), null, true, false, new Guid("b0606a0f-1012-443d-8213-870160bb029d"), true, true, null, null, null, new Guid("94866b4a-1247-4773-a6d5-9b1443cdbaa4") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3f018660-8e30-4802-ab21-6a3cb0bceab9"), "usuário administrativo", null, new DateTime(2021, 2, 26, 13, 55, 11, 190, DateTimeKind.Local).AddTicks(7984), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("264bdf3e-babc-45b5-9e4a-260b2cecca9f"), new Guid("c2e009bc-464c-46da-840c-eefadcdc9785"), null, new DateTime(2021, 2, 26, 13, 55, 11, 185, DateTimeKind.Local).AddTicks(2728), null, true, false, new Guid("dd803525-c46d-417e-b2c1-5466a792d542"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
