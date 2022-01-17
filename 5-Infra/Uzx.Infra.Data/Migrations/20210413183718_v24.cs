using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("79510c62-3499-4e87-a2c5-6cd54f07f93b"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("439f4ac9-42d0-4d49-80fa-5081ce7d264a"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("13c4f29f-8a5c-47de-bef3-022f944d0554"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1cd9cbc5-1f4d-45c9-ba69-bd9763aa4799"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2bd543e3-d5e4-4c5f-ba6c-a26122003f1d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("33e1c891-87e8-4764-8bf7-d49563be0477"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3ae31a77-8b58-431a-aab5-d3e8c5f3e191"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3c358e08-dee9-49dd-9c36-e2bc196c810c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("451cf70f-c14f-4d0c-81ae-68c3dca1bb0d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5988d33a-d013-41c7-ab74-691cbbc42efc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("620fb11c-f8a2-4008-ace5-52a8cbd7e596"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7789127e-17f6-4a42-b794-f3649603f23d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8539cdf6-4c6f-4b7e-a244-dc5938b88e7d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8de998fb-486d-4865-9ce4-4d4eb88d7bc5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("95fe606b-8c3f-4316-bf1d-fa0264148642"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bdb541ff-03b6-450c-892e-04ecf0c142df"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c4d6e8f0-d27a-48b5-a073-d1a5855c7830"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cbe61152-bf18-446f-8abf-cfdf105010db"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cf45b8a2-ed92-4359-a5ef-3ff909ce5aef"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d19688ed-d686-4558-bcc6-64207dc45eab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d1d73d54-fb4a-40ff-96fd-e9f7f848927d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d3c03a60-4f83-4eff-bd1e-0b1b4367aa8f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e7203be7-1cfb-460f-96ef-7508e30acf28"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f3588d13-c51e-4dc6-8376-6b0062dd60fe"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("1bb39a41-f684-4f41-b0b3-bffd66f8dbcc"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8d397a4b-d4dc-4a45-933a-1e37c229668c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e2c00073-dcb5-44be-9873-c580d34a2005"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0038add2-aa36-4927-8ab5-b05dcbdb71b2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("19706795-1bdf-4a15-b096-3790835917b0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("29d056a6-287a-498d-803d-150f851b4d18"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("37ef9eee-4416-480e-a86e-97ad9f90dfc9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3987bb11-734f-474c-8bc5-3813c8ccd8ce"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6ca25f73-0038-4a22-a3d6-00e33d11dc4b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("71eb5029-f151-4ab3-aa39-97f079656e6e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7a8a1804-6467-4edf-adb8-14b448879e70"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7b7ff8bb-3f58-4546-b7b8-73d242b6dba2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("86361567-fc3e-403d-b2f4-1f53aabadce6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a20028ca-0b98-43b5-b517-3246d847df59"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("aa57dd91-2d00-407f-a703-cc49adbbfb0b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ae4b9edb-a5d1-4f31-9d83-136f998588f0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c412e56a-9af8-4e64-86e6-84d883e0d0f3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c6d2fe4a-6798-48bc-91d8-6f97ade11eb3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cea868b5-c309-4d39-b62e-c7d96f40f320"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d714a26e-4e96-4bc8-ab5a-49a41a003c7d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e32f237e-903a-46bf-9fff-f5b686a14319"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e66742aa-1794-47f1-b80e-97e1edc640f6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ec09cbcc-7068-4892-8181-cc43d1ced11b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fbdd5709-9b7a-40be-b6dc-eb8a9ae484ea"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("7651a796-7b83-4286-ae3a-25952b478eb3"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("c47be7e9-e781-4d37-82ec-00e795d12e7b"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("caf66f83-9495-4ed2-af2e-9c324b190c7c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("07f44393-a713-44d3-9dbb-1ec31233142b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("09f06d2b-5354-460b-b259-a10d3ada2ecd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("10a7c955-9873-45ce-8a4e-636a1bfb4621"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("22123234-3831-4b43-b371-95e42c34a4cb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("265996a4-e5d8-4c34-ac3e-12ca602bdb55"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("28498db4-a516-4ab2-8f6d-4362ad8333fd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("44963c40-e848-4f24-8c22-a391074e58b8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("46dad188-540f-47ae-b674-4cab0032a4b2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5795eb65-69d4-4159-a52a-0b09aabb0e7c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6e6cdafa-2e33-4cd1-b00a-10bd249170fe"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8d2b6ff6-695d-4b4f-ac4b-59b58c4aa60f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("966c6d8d-8fe6-441b-8bfe-8dc99f4fb7ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9f85557c-4197-421b-a070-c5e91c8051c1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a480a41c-f822-44c9-849f-570c5477844a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a5ca8991-e6f1-41d3-b986-03735c87db80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba6ade15-2a7a-41c3-a746-b35abbce3527"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bbcc2ba2-6a5d-4139-b8ee-4ec8eb3f663a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c7118c80-a9dd-4dad-bcfd-bd712a2501eb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cbfcc353-684b-4351-a684-5a97f0956892"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ced99f4f-39e0-433c-9fb9-7dd9d9a7608b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ead4185f-e538-43af-bd5f-ffafbaaa1203"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ee4d0891-f2e0-4375-b2c7-9661731ac492"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ba04716c-e090-4804-a4bd-eed2fbf45a9e"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("1b752056-2e83-4ecb-a7d0-212ab6741c07"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("083f159c-35f1-4d84-a404-e648cc4e72b1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0d2f029f-d041-47cd-9b9d-b754bb67ab10"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("10d8d1b3-fa93-4bf5-abe8-bba39e0a2027"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("19241d98-48ee-4ffc-886f-8384c5cd1be7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("204994c5-19b6-4462-a4ae-906971ad0ce6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("20b562c3-ab48-44b1-ba33-8d5087894d30"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3b4e9e7e-73e8-4cdf-b166-f7bfa049c110"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("49548e41-2707-4aff-b49b-68229a3c2d15"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("53667dfd-0d48-4d4d-977a-26b35e91f99e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6c8a08fe-cebb-4a5b-bb2e-9d95c41d4423"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6f954d97-b8e5-4e75-be89-36e29f7e73cf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("72a9f8e2-62c7-490f-8b75-e6156e66bcfe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("73439043-81b9-4334-8ba0-0c084581613e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7859829d-6e9b-4fe3-b058-cf3640d6a295"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a0b2918c-abc9-4ae4-b908-6dc74cf1be95"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b2055c7d-0845-4f58-9834-c3832c916fa8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b2bd4d67-8038-4d2f-9a21-8a5c661da3a5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b4de3f39-61be-4a15-ae80-541fdc953a7b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bc0850c9-76f1-4d09-852c-0c94ee38c1df"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c3d25b99-d1af-4019-bbeb-381e3733552f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c682d473-30f7-4622-91ab-1a96152c9318"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d00b7f1c-6e17-4f45-8952-5b0da47c9fb2"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("669fcaa5-eaa5-4ee4-8449-a08b3774c061"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("451ee304-7a16-4630-b753-5231fab1e38e"));

            migrationBuilder.CreateTable(
                name: "UsersSite",
                columns: table => new
                {
                    UserSiteId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSite", x => x.UserSiteId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, null, null, null, null, new DateTime(2021, 4, 13, 15, 37, 15, 534, DateTimeKind.Local).AddTicks(6880), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(1900), true, false, "Administradores", new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("df449838-6055-4176-a534-f92003b17f6e"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5670), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("ea5c9ed4-8790-49b4-93ff-852d1ad9e9a5"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5646), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("7f7fecd3-6af0-4b2f-8727-0bf0840574be"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5573), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("7c73896c-0412-4c28-b533-4465e089e9f4"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5549), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("f1ba1454-f336-4dbb-abf6-7f2aa487cfaf"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5524), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("6cbd9818-9712-4301-b83c-7f7e3b39b06c"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5501), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("fcb4b9d6-4567-4754-abc2-a8b5c4e4910b"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5477), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("2fc3e754-d16a-409b-80f6-bb39391090c2"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5452), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("f83f33cd-c2ca-4b38-9bf6-40daa7a47b28"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5428), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("d1b642d6-f0c2-4204-a30d-cf1a837cc63a"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5405), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("ec731bf2-ba71-458c-ae13-35048a993977"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5382), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("9da56925-2978-469f-89df-e5d86641faba"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5358), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("227a3363-6b60-49f9-854e-6f2722040498"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("2d17a4ad-0e78-4c1e-9815-ee298346d4bd"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5333), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("17d28e81-e2cf-4f15-b519-dce0e715fe4c"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5310), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("7d37c2aa-e97e-4865-95d9-c97fa04a82d8"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5286), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("f251bee9-73f0-4e28-aace-90e266d2fb8f"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5255), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("bb8da7a5-7ba3-4bfb-b1f7-f51709c46af2"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5226), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("53f57673-86f4-430d-a9b1-d9e81c8491d9"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5200), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("1df5485d-7f72-4456-bee3-a1d92041b972"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5112), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("5257c655-40c9-468a-9ec7-a71a67f63940"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5071), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("40d0b824-6e26-425c-911f-4e6b0db12982"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(4457), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null },
                    { new Guid("85f07777-7c35-4d17-af7b-5bcddaa81cfc"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(5693), new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), true, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("3aea18f3-bf2e-4470-b187-660aecae6cf6"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(67), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9bc96bb1-f321-489f-a1bb-0bca7e1eca09"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(9873), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f39f1187-d59d-47ca-9e6a-1a0001215e28"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(5315), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(9047), null, "", true, false, "groupusers/details", new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8994), null, "", true, false, "groupusers/list", new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8944), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8895), null, "", true, false, "systems/details", new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8846), null, "", true, false, "systems/list", new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8784), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8687), null, "", true, false, "languages/details", new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8635), null, "", true, false, "languages/list", new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8585), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8531), null, "", true, false, "clients/details", new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8479), null, "", true, false, "clients/list", new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("227a3363-6b60-49f9-854e-6f2722040498"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8361), null, "", true, false, "menus/details", new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8222), null, "", true, false, "menus/list", new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8170), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8117), null, "", true, false, "users/details", new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8057), null, "", true, false, "users/list", new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7986), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7798), null, "", true, false, "companyoperators/details", new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7601), null, "", true, false, "companyoperators/list", new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7466), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(3173), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8425), null, "", true, false, "", new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 13, 15, 37, 15, 537, DateTimeKind.Local).AddTicks(6922), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("2c30587b-7796-43f8-b2c6-810c9879d940"), null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(97), true, true, false, new Guid("3aea18f3-bf2e-4470-b187-660aecae6cf6"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null },
                    { new Guid("1dfedb88-1b3a-43c8-af47-3bde0e412fb0"), null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(9511), true, true, false, new Guid("f39f1187-d59d-47ca-9e6a-1a0001215e28"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null },
                    { new Guid("b61c73ec-28eb-434e-8320-88797806c45f"), null, new DateTime(2021, 4, 13, 15, 37, 15, 539, DateTimeKind.Local).AddTicks(3), true, true, false, new Guid("9bc96bb1-f321-489f-a1bb-0bca7e1eca09"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("e6d980ef-2bd0-466b-abdd-cc70757e6a99"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8814), null, true, false, new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1765d3ec-5c18-40da-8c97-f14b752aa57d"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(9016), null, true, false, new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8be78e10-d413-4103-91bf-2dd22af0e470"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8968), null, true, false, new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bd1f7d7f-f6d7-46c4-b513-a86c2fc1b386"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8918), null, true, false, new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("20c7350a-fba9-4d3e-bbb1-74def8f49b1f"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8869), null, true, false, new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2ebdea6c-f535-4586-8669-624fd56c46d5"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8711), null, true, false, new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("82a5b927-d141-4bab-b463-3ade73527d5d"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8658), null, true, false, new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d449d0b-faf3-46db-88f7-861fdd67e1ce"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8608), null, true, false, new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("688b2506-159b-4b47-8e47-bdfd6b27e8cb"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8554), null, true, false, new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d2e0cd5d-50b0-4fa7-bbd0-c123fa27fd81"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8505), null, true, false, new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33feb980-c7da-464a-a4c1-4b9704e84fa7"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8449), null, true, false, new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("07e473b0-85a0-46b3-9d24-7c12984d6125"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8393), null, true, false, new Guid("227a3363-6b60-49f9-854e-6f2722040498"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1b620e04-f26d-45b2-98f7-5615423c3547"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8249), null, true, false, new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("21cd67c6-5257-4e1e-a30e-69023c0a2346"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8192), null, true, false, new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("413ad711-23bb-4135-b697-fa30159c1291"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8141), null, true, false, new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b1534a07-cf99-4ec7-9290-23eefbc41541"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8083), null, true, false, new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdb3e5bc-3bf7-40c0-8e14-7f61963c939e"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(8019), null, true, false, new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3668027b-50e8-45e9-80cb-8c12ffe83f10"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7824), null, true, false, new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("97575aac-4d4d-4ecb-b159-4c7de739dd4e"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7757), null, true, false, new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8ed58637-4acb-42b3-93fd-7d769d5527d0"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(7556), null, true, false, new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28b85dee-101b-4d85-9837-af35edafd15d"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(6377), null, true, false, new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("931bc296-7810-4288-92a3-a91813c9c3d5"), null, new DateTime(2021, 4, 13, 15, 37, 15, 540, DateTimeKind.Local).AddTicks(9070), null, true, false, new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"), null, new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, null, null, new DateTime(2021, 4, 13, 15, 37, 15, 542, DateTimeKind.Local).AddTicks(391), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("42589e48-e92f-4aee-a869-9c69d42c925f"), null, null, new DateTime(2021, 4, 13, 15, 37, 15, 542, DateTimeKind.Local).AddTicks(3831), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00"), new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, new DateTime(2021, 4, 13, 15, 37, 15, 542, DateTimeKind.Local).AddTicks(8027), null, new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"), true, false, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("bbc272b3-827a-4760-aeff-c08ed8aa61a8"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3421), null, true, false, new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("688528bc-84fa-4549-86ad-388b88d58f6a"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3396), null, true, false, new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("a59e177e-88ef-473f-9455-b5625742fd8f"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3374), null, true, false, new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("e4c96689-61ec-4eb0-ba38-340ece849999"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3350), null, true, false, new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("171c8f39-a34e-4aa9-8ae5-8d5981a2a389"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3325), null, true, false, new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("14e92758-1059-479e-86c7-fe5a9a655650"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3302), null, true, false, new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("407908ae-8265-4b8b-88fa-4bf3f473bacc"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3279), null, true, false, new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("d1d65eb2-2eeb-48a2-bc09-acea6813d456"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3255), null, true, false, new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("e91f4210-e013-4e2d-8066-d0a5db21390f"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3231), null, true, false, new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("8c9f025d-fc55-4900-83a8-e67f756a1b14"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3205), null, true, false, new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("22673f39-f746-49b5-969a-43afffa84597"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3444), null, true, false, new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("0fc5a5d1-b2d2-4c96-a649-8406b568c385"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3159), null, true, false, new Guid("227a3363-6b60-49f9-854e-6f2722040498"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("34cdbd51-6cb4-4868-a56b-a414958d33d3"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3132), null, true, false, new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("c935f5b6-809d-4a66-9388-8e0e593882ed"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3032), null, true, false, new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("c8c0508b-60a3-410c-a980-0525e1e3150a"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3008), null, true, false, new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("3da20dcb-9915-445f-9663-74a71059d73b"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2985), null, true, false, new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("9280f1dd-8f1a-47ff-a870-c097824724db"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2956), null, true, false, new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("a11abfad-e57e-4fe4-b1b5-680d22641c23"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2926), null, true, false, new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("8580959e-4335-4fee-9701-7698b8b54429"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2901), null, true, false, new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("4b76566f-551d-41ba-ba2a-957635e0b389"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2864), null, true, false, new Guid("a72b8d04-cee2-4297-845c-2b098a862731"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("93f3cbf1-3ab5-4906-8620-dfb7e91d852b"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(2491), null, true, false, new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") },
                    { new Guid("3625085b-854a-454c-9d23-7756f42c61f1"), true, true, null, new DateTime(2021, 4, 13, 15, 37, 15, 543, DateTimeKind.Local).AddTicks(3182), null, true, false, new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"), true, true, null, null, null, new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("eddfa31b-fc21-404d-b066-f8bb591dd6bf"), "usuário administrativo", null, new DateTime(2021, 4, 13, 15, 37, 15, 541, DateTimeKind.Local).AddTicks(7551), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e5a49ef7-a996-4b8a-8ad6-9e33e985e671"), new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"), null, new DateTime(2021, 4, 13, 15, 37, 15, 538, DateTimeKind.Local).AddTicks(254), null, true, false, new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersSite");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("db6e876d-5fe0-401d-b5fc-149a4375ef55"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("e5a49ef7-a996-4b8a-8ad6-9e33e985e671"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("2c66767f-3bc6-4ad3-9b8c-342d3c303328"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("17d28e81-e2cf-4f15-b519-dce0e715fe4c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1df5485d-7f72-4456-bee3-a1d92041b972"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2d17a4ad-0e78-4c1e-9815-ee298346d4bd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2fc3e754-d16a-409b-80f6-bb39391090c2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("40d0b824-6e26-425c-911f-4e6b0db12982"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5257c655-40c9-468a-9ec7-a71a67f63940"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("53f57673-86f4-430d-a9b1-d9e81c8491d9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6cbd9818-9712-4301-b83c-7f7e3b39b06c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7c73896c-0412-4c28-b533-4465e089e9f4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7d37c2aa-e97e-4865-95d9-c97fa04a82d8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7f7fecd3-6af0-4b2f-8727-0bf0840574be"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("85f07777-7c35-4d17-af7b-5bcddaa81cfc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9da56925-2978-469f-89df-e5d86641faba"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bb8da7a5-7ba3-4bfb-b1f7-f51709c46af2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d1b642d6-f0c2-4204-a30d-cf1a837cc63a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("df449838-6055-4176-a534-f92003b17f6e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ea5c9ed4-8790-49b4-93ff-852d1ad9e9a5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec731bf2-ba71-458c-ae13-35048a993977"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f1ba1454-f336-4dbb-abf6-7f2aa487cfaf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f251bee9-73f0-4e28-aace-90e266d2fb8f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f83f33cd-c2ca-4b38-9bf6-40daa7a47b28"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fcb4b9d6-4567-4754-abc2-a8b5c4e4910b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("3aea18f3-bf2e-4470-b187-660aecae6cf6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9bc96bb1-f321-489f-a1bb-0bca7e1eca09"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f39f1187-d59d-47ca-9e6a-1a0001215e28"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("11685376-35c4-4f4c-ac5a-c1f5a08b5baf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("169dfbd6-44fd-48a9-a316-e7d95d30586b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1db05eed-a99b-4ab2-a0f0-6ad008a79705"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("227a3363-6b60-49f9-854e-6f2722040498"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3d3b9e3f-188f-4016-8746-c1c72eb8a378"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("47065a29-2feb-4864-a7ff-33f27a81bd9e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4c6a0e2f-1f8d-45db-bc2c-b522f2628116"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("50e6734d-4e4e-4853-b261-f93cc9638114"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5bb8a72e-5297-4a26-a2cf-ac5d1099beeb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("693e65aa-756e-4e74-933c-ef2a62a598b8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7b3cdc90-abab-4cf7-8d97-4f9da0e8b581"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("915de700-9edb-4aab-96f1-c49c2b4d2a59"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("953b9a25-9145-4570-bd4c-511570dac7e8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a0230073-4aaf-48e7-92d2-15312659b11a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a72b8d04-cee2-4297-845c-2b098a862731"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a8ae1fa6-a5f0-46f2-9887-2298fb697161"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("afd49b76-8c77-45c1-8ba8-901cc00c08ba"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dfde6073-38f8-4a85-8376-b861ffc7cebe"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e390bd76-afda-4e7d-9800-010cf9aa5f6c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f2823c7b-3fc6-4f1d-a73a-cb2e0ed6577e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f4c0ea99-0e83-497f-8c09-66f1d74418b3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fb9f2042-aee6-493e-bc16-c7759370323d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("1dfedb88-1b3a-43c8-af47-3bde0e412fb0"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("2c30587b-7796-43f8-b2c6-810c9879d940"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("b61c73ec-28eb-434e-8320-88797806c45f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("07e473b0-85a0-46b3-9d24-7c12984d6125"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1765d3ec-5c18-40da-8c97-f14b752aa57d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1b620e04-f26d-45b2-98f7-5615423c3547"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1d449d0b-faf3-46db-88f7-861fdd67e1ce"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("20c7350a-fba9-4d3e-bbb1-74def8f49b1f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("21cd67c6-5257-4e1e-a30e-69023c0a2346"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("28b85dee-101b-4d85-9837-af35edafd15d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2ebdea6c-f535-4586-8669-624fd56c46d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("33feb980-c7da-464a-a4c1-4b9704e84fa7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3668027b-50e8-45e9-80cb-8c12ffe83f10"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("413ad711-23bb-4135-b697-fa30159c1291"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("688b2506-159b-4b47-8e47-bdfd6b27e8cb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("82a5b927-d141-4bab-b463-3ade73527d5d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8be78e10-d413-4103-91bf-2dd22af0e470"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8ed58637-4acb-42b3-93fd-7d769d5527d0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("931bc296-7810-4288-92a3-a91813c9c3d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("97575aac-4d4d-4ecb-b159-4c7de739dd4e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b1534a07-cf99-4ec7-9290-23eefbc41541"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bd1f7d7f-f6d7-46c4-b513-a86c2fc1b386"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cdb3e5bc-3bf7-40c0-8e14-7f61963c939e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d2e0cd5d-50b0-4fa7-bbd0-c123fa27fd81"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e6d980ef-2bd0-466b-abdd-cc70757e6a99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("49bf863d-d09e-4f87-8508-b79f0e474f15"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("42589e48-e92f-4aee-a869-9c69d42c925f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("ee58bd93-fee8-44e8-abdf-33933b4f9e00"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0fc5a5d1-b2d2-4c96-a649-8406b568c385"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("14e92758-1059-479e-86c7-fe5a9a655650"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("171c8f39-a34e-4aa9-8ae5-8d5981a2a389"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("22673f39-f746-49b5-969a-43afffa84597"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("34cdbd51-6cb4-4868-a56b-a414958d33d3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3625085b-854a-454c-9d23-7756f42c61f1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3da20dcb-9915-445f-9663-74a71059d73b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("407908ae-8265-4b8b-88fa-4bf3f473bacc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4b76566f-551d-41ba-ba2a-957635e0b389"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("688528bc-84fa-4549-86ad-388b88d58f6a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8580959e-4335-4fee-9701-7698b8b54429"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8c9f025d-fc55-4900-83a8-e67f756a1b14"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9280f1dd-8f1a-47ff-a870-c097824724db"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("93f3cbf1-3ab5-4906-8620-dfb7e91d852b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a11abfad-e57e-4fe4-b1b5-680d22641c23"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a59e177e-88ef-473f-9455-b5625742fd8f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bbc272b3-827a-4760-aeff-c08ed8aa61a8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c8c0508b-60a3-410c-a980-0525e1e3150a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c935f5b6-809d-4a66-9388-8e0e593882ed"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d1d65eb2-2eeb-48a2-bc09-acea6813d456"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e4c96689-61ec-4eb0-ba38-340ece849999"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e91f4210-e013-4e2d-8066-d0a5db21390f"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("eddfa31b-fc21-404d-b066-f8bb591dd6bf"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("79f7cf4d-8996-43c0-9d67-64cf4b9fe445"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("79510c62-3499-4e87-a2c5-6cd54f07f93b"), null, null, null, null, null, new DateTime(2021, 4, 13, 14, 48, 40, 923, DateTimeKind.Local).AddTicks(1963), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), null, new DateTime(2021, 4, 13, 14, 48, 40, 927, DateTimeKind.Local).AddTicks(5095), true, false, "Administradores", new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("cf45b8a2-ed92-4359-a5ef-3ff909ce5aef"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9896), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("fbdd5709-9b7a-40be-b6dc-eb8a9ae484ea"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("5988d33a-d013-41c7-ab74-691cbbc42efc"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9810), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("7a8a1804-6467-4edf-adb8-14b448879e70"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("c4d6e8f0-d27a-48b5-a073-d1a5855c7830"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9725), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("71eb5029-f151-4ab3-aa39-97f079656e6e"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("1cd9cbc5-1f4d-45c9-ba69-bd9763aa4799"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9636), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("7b7ff8bb-3f58-4546-b7b8-73d242b6dba2"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("f3588d13-c51e-4dc6-8376-6b0062dd60fe"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9483), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("c6d2fe4a-6798-48bc-91d8-6f97ade11eb3"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("3ae31a77-8b58-431a-aab5-d3e8c5f3e191"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9395), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("29d056a6-287a-498d-803d-150f851b4d18"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("7789127e-17f6-4a42-b794-f3649603f23d"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9312), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("86361567-fc3e-403d-b2f4-1f53aabadce6"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("33e1c891-87e8-4764-8bf7-d49563be0477"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9232), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("c412e56a-9af8-4e64-86e6-84d883e0d0f3"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("bdb541ff-03b6-450c-892e-04ecf0c142df"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9147), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("a20028ca-0b98-43b5-b517-3246d847df59"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("d1d73d54-fb4a-40ff-96fd-e9f7f848927d"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9074), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("0038add2-aa36-4927-8ab5-b05dcbdb71b2"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("cbe61152-bf18-446f-8abf-cfdf105010db"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8987), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("ec09cbcc-7068-4892-8181-cc43d1ced11b"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("8de998fb-486d-4865-9ce4-4d4eb88d7bc5"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8903), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("e66742aa-1794-47f1-b80e-97e1edc640f6"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("95fe606b-8c3f-4316-bf1d-fa0264148642"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8809), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("37ef9eee-4416-480e-a86e-97ad9f90dfc9"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("620fb11c-f8a2-4008-ace5-52a8cbd7e596"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8721), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("6ca25f73-0038-4a22-a3d6-00e33d11dc4b"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("8539cdf6-4c6f-4b7e-a244-dc5938b88e7d"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8643), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("ae4b9edb-a5d1-4f31-9d83-136f998588f0"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("13c4f29f-8a5c-47de-bef3-022f944d0554"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8556), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("d714a26e-4e96-4bc8-ab5a-49a41a003c7d"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("d3c03a60-4f83-4eff-bd1e-0b1b4367aa8f"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8464), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("aa57dd91-2d00-407f-a703-cc49adbbfb0b"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("e7203be7-1cfb-460f-96ef-7508e30acf28"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8376), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("3987bb11-734f-474c-8bc5-3813c8ccd8ce"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("3c358e08-dee9-49dd-9c36-e2bc196c810c"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8282), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("cea868b5-c309-4d39-b62e-c7d96f40f320"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("2bd543e3-d5e4-4c5f-ba6c-a26122003f1d"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(8148), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("e32f237e-903a-46bf-9fff-f5b686a14319"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("d19688ed-d686-4558-bcc6-64207dc45eab"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(7392), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null },
                    { new Guid("451cf70f-c14f-4d0c-81ae-68c3dca1bb0d"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 935, DateTimeKind.Local).AddTicks(9976), new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("19706795-1bdf-4a15-b096-3790835917b0"), true, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("e2c00073-dcb5-44be-9873-c580d34a2005"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 4, 13, 14, 48, 40, 927, DateTimeKind.Local).AddTicks(1862), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1bb39a41-f684-4f41-b0b3-bffd66f8dbcc"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 4, 13, 14, 48, 40, 927, DateTimeKind.Local).AddTicks(1556), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d397a4b-d4dc-4a45-933a-1e37c229668c"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 4, 13, 14, 48, 40, 926, DateTimeKind.Local).AddTicks(5173), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("19706795-1bdf-4a15-b096-3790835917b0"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 14, 48, 40, 934, DateTimeKind.Local).AddTicks(388), null, "", true, false, "groupusers/details", new Guid("7a8a1804-6467-4edf-adb8-14b448879e70"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fbdd5709-9b7a-40be-b6dc-eb8a9ae484ea"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 14, 48, 40, 934, DateTimeKind.Local).AddTicks(223), null, "", true, false, "groupusers/list", new Guid("7a8a1804-6467-4edf-adb8-14b448879e70"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7a8a1804-6467-4edf-adb8-14b448879e70"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 4, 13, 14, 48, 40, 934, DateTimeKind.Local).AddTicks(52), null, "", true, false, "", new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("71eb5029-f151-4ab3-aa39-97f079656e6e"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9882), null, "", true, false, "systems/details", new Guid("c6d2fe4a-6798-48bc-91d8-6f97ade11eb3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7b7ff8bb-3f58-4546-b7b8-73d242b6dba2"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9703), null, "", true, false, "systems/list", new Guid("c6d2fe4a-6798-48bc-91d8-6f97ade11eb3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c6d2fe4a-6798-48bc-91d8-6f97ade11eb3"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9497), null, "", true, false, "", new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("29d056a6-287a-498d-803d-150f851b4d18"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9229), null, "", true, false, "languages/details", new Guid("c412e56a-9af8-4e64-86e6-84d883e0d0f3"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("86361567-fc3e-403d-b2f4-1f53aabadce6"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8963), null, "", true, false, "languages/list", new Guid("c412e56a-9af8-4e64-86e6-84d883e0d0f3"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c412e56a-9af8-4e64-86e6-84d883e0d0f3"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8630), null, "", true, false, "", new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a20028ca-0b98-43b5-b517-3246d847df59"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8473), null, "", true, false, "clients/details", new Guid("ec09cbcc-7068-4892-8181-cc43d1ced11b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0038add2-aa36-4927-8ab5-b05dcbdb71b2"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8293), null, "", true, false, "clients/list", new Guid("ec09cbcc-7068-4892-8181-cc43d1ced11b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e66742aa-1794-47f1-b80e-97e1edc640f6"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7954), null, "", true, false, "menus/details", new Guid("6ca25f73-0038-4a22-a3d6-00e33d11dc4b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("37ef9eee-4416-480e-a86e-97ad9f90dfc9"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7701), null, "", true, false, "menus/list", new Guid("6ca25f73-0038-4a22-a3d6-00e33d11dc4b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6ca25f73-0038-4a22-a3d6-00e33d11dc4b"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7517), null, "", true, false, "", new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ae4b9edb-a5d1-4f31-9d83-136f998588f0"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7355), null, "", true, false, "users/details", new Guid("aa57dd91-2d00-407f-a703-cc49adbbfb0b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d714a26e-4e96-4bc8-ab5a-49a41a003c7d"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7179), null, "", true, false, "users/list", new Guid("aa57dd91-2d00-407f-a703-cc49adbbfb0b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("aa57dd91-2d00-407f-a703-cc49adbbfb0b"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(6974), null, "", true, false, "", new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3987bb11-734f-474c-8bc5-3813c8ccd8ce"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(6558), null, "", true, false, "companyoperators/details", new Guid("e32f237e-903a-46bf-9fff-f5b686a14319"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cea868b5-c309-4d39-b62e-c7d96f40f320"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(6367), null, "", true, false, "companyoperators/list", new Guid("e32f237e-903a-46bf-9fff-f5b686a14319"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e32f237e-903a-46bf-9fff-f5b686a14319"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(5912), null, "", true, false, "", new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(126), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ec09cbcc-7068-4892-8181-cc43d1ced11b"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8124), null, "", true, false, "", new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 4, 13, 14, 48, 40, 925, DateTimeKind.Local).AddTicks(8411), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("c47be7e9-e781-4d37-82ec-00e795d12e7b"), null, new DateTime(2021, 4, 13, 14, 48, 40, 927, DateTimeKind.Local).AddTicks(1950), true, true, false, new Guid("e2c00073-dcb5-44be-9873-c580d34a2005"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, null },
                    { new Guid("7651a796-7b83-4286-ae3a-25952b478eb3"), null, new DateTime(2021, 4, 13, 14, 48, 40, 927, DateTimeKind.Local).AddTicks(847), true, true, false, new Guid("8d397a4b-d4dc-4a45-933a-1e37c229668c"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, null },
                    { new Guid("caf66f83-9495-4ed2-af2e-9c324b190c7c"), null, new DateTime(2021, 4, 13, 14, 48, 40, 927, DateTimeKind.Local).AddTicks(1760), true, true, false, new Guid("1bb39a41-f684-4f41-b0b3-bffd66f8dbcc"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("22123234-3831-4b43-b371-95e42c34a4cb"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9600), null, true, false, new Guid("c6d2fe4a-6798-48bc-91d8-6f97ade11eb3"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee4d0891-f2e0-4375-b2c7-9661731ac492"), null, new DateTime(2021, 4, 13, 14, 48, 40, 934, DateTimeKind.Local).AddTicks(307), null, true, false, new Guid("fbdd5709-9b7a-40be-b6dc-eb8a9ae484ea"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5795eb65-69d4-4159-a52a-0b09aabb0e7c"), null, new DateTime(2021, 4, 13, 14, 48, 40, 934, DateTimeKind.Local).AddTicks(133), null, true, false, new Guid("7a8a1804-6467-4edf-adb8-14b448879e70"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a5ca8991-e6f1-41d3-b986-03735c87db80"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9953), null, true, false, new Guid("71eb5029-f151-4ab3-aa39-97f079656e6e"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("09f06d2b-5354-460b-b259-a10d3ada2ecd"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9790), null, true, false, new Guid("7b7ff8bb-3f58-4546-b7b8-73d242b6dba2"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d2b6ff6-695d-4b4f-ac4b-59b58c4aa60f"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9311), null, true, false, new Guid("29d056a6-287a-498d-803d-150f851b4d18"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("44963c40-e848-4f24-8c22-a391074e58b8"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(9106), null, true, false, new Guid("86361567-fc3e-403d-b2f4-1f53aabadce6"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ced99f4f-39e0-433c-9fb9-7dd9d9a7608b"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8716), null, true, false, new Guid("c412e56a-9af8-4e64-86e6-84d883e0d0f3"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("10a7c955-9873-45ce-8a4e-636a1bfb4621"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8553), null, true, false, new Guid("a20028ca-0b98-43b5-b517-3246d847df59"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("07f44393-a713-44d3-9dbb-1ec31233142b"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8377), null, true, false, new Guid("0038add2-aa36-4927-8ab5-b05dcbdb71b2"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("966c6d8d-8fe6-441b-8bfe-8dc99f4fb7ce"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8207), null, true, false, new Guid("ec09cbcc-7068-4892-8181-cc43d1ced11b"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ead4185f-e538-43af-bd5f-ffafbaaa1203"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(8035), null, true, false, new Guid("e66742aa-1794-47f1-b80e-97e1edc640f6"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28498db4-a516-4ab2-8f6d-4362ad8333fd"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7846), null, true, false, new Guid("37ef9eee-4416-480e-a86e-97ad9f90dfc9"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bbcc2ba2-6a5d-4139-b8ee-4ec8eb3f663a"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7599), null, true, false, new Guid("6ca25f73-0038-4a22-a3d6-00e33d11dc4b"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a480a41c-f822-44c9-849f-570c5477844a"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7424), null, true, false, new Guid("ae4b9edb-a5d1-4f31-9d83-136f998588f0"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c7118c80-a9dd-4dad-bcfd-bd712a2501eb"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7263), null, true, false, new Guid("d714a26e-4e96-4bc8-ab5a-49a41a003c7d"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("265996a4-e5d8-4c34-ac3e-12ca602bdb55"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(7079), null, true, false, new Guid("aa57dd91-2d00-407f-a703-cc49adbbfb0b"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9f85557c-4197-421b-a070-c5e91c8051c1"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(6638), null, true, false, new Guid("3987bb11-734f-474c-8bc5-3813c8ccd8ce"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46dad188-540f-47ae-b674-4cab0032a4b2"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(6460), null, true, false, new Guid("cea868b5-c309-4d39-b62e-c7d96f40f320"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ba6ade15-2a7a-41c3-a746-b35abbce3527"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(6139), null, true, false, new Guid("e32f237e-903a-46bf-9fff-f5b686a14319"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cbfcc353-684b-4351-a684-5a97f0956892"), null, new DateTime(2021, 4, 13, 14, 48, 40, 933, DateTimeKind.Local).AddTicks(4468), null, true, false, new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e6cdafa-2e33-4cd1-b00a-10bd249170fe"), null, new DateTime(2021, 4, 13, 14, 48, 40, 934, DateTimeKind.Local).AddTicks(472), null, true, false, new Guid("19706795-1bdf-4a15-b096-3790835917b0"), new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("ba04716c-e090-4804-a4bd-eed2fbf45a9e"), null, new Guid("79510c62-3499-4e87-a2c5-6cd54f07f93b"), null, null, null, new DateTime(2021, 4, 13, 14, 48, 40, 936, DateTimeKind.Local).AddTicks(6279), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1b752056-2e83-4ecb-a7d0-212ab6741c07"), null, null, new DateTime(2021, 4, 13, 14, 48, 40, 937, DateTimeKind.Local).AddTicks(479), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("ba04716c-e090-4804-a4bd-eed2fbf45a9e"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce"), new Guid("79510c62-3499-4e87-a2c5-6cd54f07f93b"), null, new DateTime(2021, 4, 13, 14, 48, 40, 937, DateTimeKind.Local).AddTicks(6292), null, new Guid("03b9bfac-dcef-4bf5-a1b9-fce5946deb25"), true, false, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), new Guid("ba04716c-e090-4804-a4bd-eed2fbf45a9e"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("20b562c3-ab48-44b1-ba33-8d5087894d30"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4818), null, true, false, new Guid("fbdd5709-9b7a-40be-b6dc-eb8a9ae484ea"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("bc0850c9-76f1-4d09-852c-0c94ee38c1df"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4732), null, true, false, new Guid("7a8a1804-6467-4edf-adb8-14b448879e70"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("b2055c7d-0845-4f58-9834-c3832c916fa8"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4645), null, true, false, new Guid("71eb5029-f151-4ab3-aa39-97f079656e6e"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("c3d25b99-d1af-4019-bbeb-381e3733552f"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4568), null, true, false, new Guid("7b7ff8bb-3f58-4546-b7b8-73d242b6dba2"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("6c8a08fe-cebb-4a5b-bb2e-9d95c41d4423"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4459), null, true, false, new Guid("c6d2fe4a-6798-48bc-91d8-6f97ade11eb3"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("3b4e9e7e-73e8-4cdf-b166-f7bfa049c110"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4187), null, true, false, new Guid("29d056a6-287a-498d-803d-150f851b4d18"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("d00b7f1c-6e17-4f45-8952-5b0da47c9fb2"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4097), null, true, false, new Guid("86361567-fc3e-403d-b2f4-1f53aabadce6"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("19241d98-48ee-4ffc-886f-8384c5cd1be7"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4010), null, true, false, new Guid("c412e56a-9af8-4e64-86e6-84d883e0d0f3"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("0d2f029f-d041-47cd-9b9d-b754bb67ab10"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3922), null, true, false, new Guid("a20028ca-0b98-43b5-b517-3246d847df59"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("b2bd4d67-8038-4d2f-9a21-8a5c661da3a5"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3838), null, true, false, new Guid("0038add2-aa36-4927-8ab5-b05dcbdb71b2"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("53667dfd-0d48-4d4d-977a-26b35e91f99e"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(4961), null, true, false, new Guid("19706795-1bdf-4a15-b096-3790835917b0"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("b4de3f39-61be-4a15-ae80-541fdc953a7b"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3667), null, true, false, new Guid("e66742aa-1794-47f1-b80e-97e1edc640f6"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("7859829d-6e9b-4fe3-b058-cf3640d6a295"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3581), null, true, false, new Guid("37ef9eee-4416-480e-a86e-97ad9f90dfc9"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("c682d473-30f7-4622-91ab-1a96152c9318"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3490), null, true, false, new Guid("6ca25f73-0038-4a22-a3d6-00e33d11dc4b"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("204994c5-19b6-4462-a4ae-906971ad0ce6"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3395), null, true, false, new Guid("ae4b9edb-a5d1-4f31-9d83-136f998588f0"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("10d8d1b3-fa93-4bf5-abe8-bba39e0a2027"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3232), null, true, false, new Guid("d714a26e-4e96-4bc8-ab5a-49a41a003c7d"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("083f159c-35f1-4d84-a404-e648cc4e72b1"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3138), null, true, false, new Guid("aa57dd91-2d00-407f-a703-cc49adbbfb0b"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("6f954d97-b8e5-4e75-be89-36e29f7e73cf"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3048), null, true, false, new Guid("3987bb11-734f-474c-8bc5-3813c8ccd8ce"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("a0b2918c-abc9-4ae4-b908-6dc74cf1be95"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(2965), null, true, false, new Guid("cea868b5-c309-4d39-b62e-c7d96f40f320"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("72a9f8e2-62c7-490f-8b75-e6156e66bcfe"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(2851), null, true, false, new Guid("e32f237e-903a-46bf-9fff-f5b686a14319"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("49548e41-2707-4aff-b49b-68229a3c2d15"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(2414), null, true, false, new Guid("e593797d-7dac-4ce7-b82d-b27a9ec77fea"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") },
                    { new Guid("73439043-81b9-4334-8ba0-0c084581613e"), true, true, null, new DateTime(2021, 4, 13, 14, 48, 40, 938, DateTimeKind.Local).AddTicks(3754), null, true, false, new Guid("ec09cbcc-7068-4892-8181-cc43d1ced11b"), true, true, null, null, null, new Guid("6e29b9c4-ae7a-47d7-9b11-97eb09adf5ce") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("669fcaa5-eaa5-4ee4-8449-a08b3774c061"), "usuário administrativo", null, new DateTime(2021, 4, 13, 14, 48, 40, 936, DateTimeKind.Local).AddTicks(2795), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("439f4ac9-42d0-4d49-80fa-5081ce7d264a"), new Guid("79510c62-3499-4e87-a2c5-6cd54f07f93b"), null, new DateTime(2021, 4, 13, 14, 48, 40, 926, DateTimeKind.Local).AddTicks(1395), null, true, false, new Guid("451ee304-7a16-4630-b753-5231fab1e38e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
