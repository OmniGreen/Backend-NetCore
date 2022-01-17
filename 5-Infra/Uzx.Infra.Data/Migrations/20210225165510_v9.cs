using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("389f28b1-44d1-4b2f-8a2c-55c777414c89"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("09b099e8-d3aa-4ac7-95e5-4bb0eb457b2a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0bb6192a-ada3-449b-ad36-b783c70a98e6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1080123c-8650-4eff-a0d7-b9de4a35c4d6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29e784b2-388e-4e4d-b218-953251e442cc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2cc94739-345c-4c42-af27-cc8d0fd20551"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2d018120-12d0-4070-9a1d-2d9c4d0fd8a9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3007be7c-9a22-4357-a152-0b0fccc6ae13"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4369843f-bc8f-4e3d-9c1b-65e5d3487c07"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4624d78e-5360-4eb3-8ff8-abbdb58bf1ee"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("60be98b2-3aa6-4c83-acb0-0106ba917b2c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7383e1ab-9b2e-46d1-9977-62b84c8518a7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7429ac95-fb49-43f3-8ca1-93c3420e07c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("75a90bb5-abaa-4dbb-afae-1171baf22a0a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("83da8e00-d424-47ca-ad83-d6421c87d4e7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8b203b25-6b5e-4ffa-bdde-9a59a8a28135"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8c9dafe0-b14f-405c-a378-bb085ecf201e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("942f7d6b-4db4-4053-8054-fd8c95be1095"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b47bed69-ffb1-4034-940c-0db0d96088aa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("baf20a3f-81ae-4153-9889-cd3304ad2fe8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e98e4602-809d-46f6-9081-8b44c440cd0b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec69f0c3-127c-4d2c-aeb4-21fa667ccb60"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ece3fb7d-8c6a-402b-aa8b-90ecf6b794ac"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("03090d0b-6338-4a36-9241-fbb3104140c0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("cb2650bb-d3f8-4b45-88fe-6610919576bd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ef81d6f6-8f59-42f8-b327-47c0ddcee435"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("744aeb02-0288-4ba4-817c-103185a96718"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("6257ccdc-6717-456a-b59b-658bfcb8400a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("65951ba1-de61-46f7-8936-c2a0bf993d3a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("c40e757b-2da9-43e4-9787-3e2b3a470e67"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("03aeec1f-0a1d-4ed8-9753-f036c40dadbd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("10be4f5d-1835-4696-ad9e-e34dac345524"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("193ba98b-a12e-46b8-9167-15ee80fd0fea"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1daa91ed-dc2a-434b-a270-fbe428bf8a0e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1dbe0c06-ccdb-4226-b274-fd4ba50a2da9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2abb33f9-7294-4bd3-87cd-9b8861d1befb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3326e25c-7479-4361-b493-135fe84e1748"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("356d5ca8-eb85-43fc-8f3f-2cf5caffc35c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("583e4a0d-4a79-4942-a04f-b0b9b89a3266"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5f1a3f2d-8886-4f8b-9e75-a5138202399e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7028abc3-4af3-4fe6-97c9-80438b1f8932"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7151affe-385f-41e6-819d-ba42ab4ee13c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8ec3d665-9440-4181-9d2c-79b323f7435e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("946869a2-f0d5-464e-87a4-8de3c106f316"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a0e35bd7-42d6-410d-8dd1-c34132e00ab5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a65135d4-096d-45b2-992c-20a30c5d8824"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a7a5b125-35a3-4274-ad26-83cba4015558"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba6b1f12-c70a-4dca-973c-7700893c871e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d78ff3d8-9d6c-4802-8cda-efae34b07a80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e63f52ac-0eca-45ff-b778-dbf343510a6b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f940f1ba-e519-4d17-9111-8c86d9135c12"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("fd9a1cd9-8506-46b0-b40b-e1e8ec0ba85c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("787fe36a-82f6-4027-bae4-b24e14889153"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0843a74d-1d66-424f-9c98-e185c81c8b9b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0a8174e9-81de-4d92-bb3d-3dbb29ce6f18"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2122167a-8a28-4278-99ad-7dc863609fb5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2dc5ae93-e47a-42b9-a251-b20a8ee24aa6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("30ef7bbc-8fa9-4bdf-979c-2b301d661e4a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("50e817e7-9bc7-4eae-a23f-d155f73301c8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5d96bac9-1291-4835-af06-06955320e4c6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6f4c39e0-e97b-46fd-b7c0-f7b9580969ff"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6fb542aa-4941-4206-94ae-1b9c38025000"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7c5c57ff-c6b6-44e0-8807-947d5a76fd36"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7fa19468-5bfb-4528-9ef7-fc29d3bfa72d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("85f3231a-9cd9-4ec5-a2aa-8082162e8573"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8ebcee38-759c-4bd8-9259-f595a1591c29"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9202e232-02bd-4380-b0a9-8e293c78065d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ad2502c8-dfd0-4159-b7f9-ac14e4b705c2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b11c2b30-a499-4793-b0dc-8bf59342212e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c6b90981-da26-4a61-89b6-6a0abc3bda3d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c9866a25-ae45-4407-9a27-42fbb76a4235"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e93ab32f-2d13-49aa-a8a2-c0860a171f6a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("eb8a1453-5caf-4864-a997-335ba7c26bc0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ec106864-8f27-4ca8-a9dc-de595b233ea9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f0641e2c-246a-4dce-be3e-34546cca4a91"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("6a78ba23-f085-4485-a2b1-a26cf849f42e"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"));

            migrationBuilder.RenameColumn(
                name: "Titel",
                table: "Events",
                newName: "Title");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Title",
                table: "Events",
                newName: "Titel");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, null, null, null, null, new DateTime(2021, 2, 25, 12, 50, 6, 486, DateTimeKind.Local).AddTicks(9855), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(5762), true, false, "Administradores", new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("83da8e00-d424-47ca-ad83-d6421c87d4e7"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9240), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("e98e4602-809d-46f6-9081-8b44c440cd0b"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9219), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("942f7d6b-4db4-4053-8054-fd8c95be1095"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9197), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("60be98b2-3aa6-4c83-acb0-0106ba917b2c"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9176), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("4369843f-bc8f-4e3d-9c1b-65e5d3487c07"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9152), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("2d018120-12d0-4070-9a1d-2d9c4d0fd8a9"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9131), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("2cc94739-345c-4c42-af27-cc8d0fd20551"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9106), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("8c9dafe0-b14f-405c-a378-bb085ecf201e"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9038), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("3007be7c-9a22-4357-a152-0b0fccc6ae13"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9016), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("baf20a3f-81ae-4153-9889-cd3304ad2fe8"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8995), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("744aeb02-0288-4ba4-817c-103185a96718"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("7383e1ab-9b2e-46d1-9977-62b84c8518a7"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8973), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("75a90bb5-abaa-4dbb-afae-1171baf22a0a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8952), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("ece3fb7d-8c6a-402b-aa8b-90ecf6b794ac"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8929), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("09b099e8-d3aa-4ac7-95e5-4bb0eb457b2a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8908), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("b47bed69-ffb1-4034-940c-0db0d96088aa"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8886), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("4624d78e-5360-4eb3-8ff8-abbdb58bf1ee"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8859), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("1080123c-8650-4eff-a0d7-b9de4a35c4d6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8833), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("0bb6192a-ada3-449b-ad36-b783c70a98e6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8812), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("29e784b2-388e-4e4d-b218-953251e442cc"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8788), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("8b203b25-6b5e-4ffa-bdde-9a59a8a28135"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8752), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("ec69f0c3-127c-4d2c-aeb4-21fa667ccb60"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(8431), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null },
                    { new Guid("7429ac95-fb49-43f3-8ca1-93c3420e07c7"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(9262), new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), true, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("03090d0b-6338-4a36-9241-fbb3104140c0"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4326), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef81d6f6-8f59-42f8-b327-47c0ddcee435"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4203), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cb2650bb-d3f8-4b45-88fe-6610919576bd"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(964), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(4096), null, "", true, false, "groupusers/details", new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3997), null, "", true, false, "groupusers/list", new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3951), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3904), null, "", true, false, "systems/details", new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3852), null, "", true, false, "systems/list", new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3798), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3748), null, "", true, false, "languages/details", new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3661), null, "", true, false, "languages/list", new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3610), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3557), null, "", true, false, "clients/details", new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("744aeb02-0288-4ba4-817c-103185a96718"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3510), null, "", true, false, "clients/list", new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3411), null, "", true, false, "menus/details", new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3354), null, "", true, false, "menus/list", new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3229), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3177), null, "", true, false, "users/details", new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3128), null, "", true, false, "users/list", new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3068), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2930), null, "", true, false, "companyoperators/details", new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2877), null, "", true, false, "companyoperators/list", new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2757), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(9651), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3461), null, "", true, false, "", new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 25, 12, 50, 6, 489, DateTimeKind.Local).AddTicks(4431), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("c40e757b-2da9-43e4-9787-3e2b3a470e67"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4357), true, true, false, new Guid("03090d0b-6338-4a36-9241-fbb3104140c0"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null },
                    { new Guid("65951ba1-de61-46f7-8936-c2a0bf993d3a"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(3933), true, true, false, new Guid("cb2650bb-d3f8-4b45-88fe-6610919576bd"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null },
                    { new Guid("6257ccdc-6717-456a-b59b-658bfcb8400a"), null, new DateTime(2021, 2, 25, 12, 50, 6, 490, DateTimeKind.Local).AddTicks(4294), true, true, false, new Guid("ef81d6f6-8f59-42f8-b327-47c0ddcee435"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("2abb33f9-7294-4bd3-87cd-9b8861d1befb"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3821), null, true, false, new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f940f1ba-e519-4d17-9111-8c86d9135c12"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(4018), null, true, false, new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fd9a1cd9-8506-46b0-b40b-e1e8ec0ba85c"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3973), null, true, false, new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("03aeec1f-0a1d-4ed8-9753-f036c40dadbd"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3926), null, true, false, new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("356d5ca8-eb85-43fc-8f3f-2cf5caffc35c"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3877), null, true, false, new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d78ff3d8-9d6c-4802-8cda-efae34b07a80"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3772), null, true, false, new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("946869a2-f0d5-464e-87a4-8de3c106f316"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3720), null, true, false, new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a65135d4-096d-45b2-992c-20a30c5d8824"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3635), null, true, false, new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1daa91ed-dc2a-434b-a270-fbe428bf8a0e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3579), null, true, false, new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1dbe0c06-ccdb-4226-b274-fd4ba50a2da9"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3532), null, true, false, new Guid("744aeb02-0288-4ba4-817c-103185a96718"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a0e35bd7-42d6-410d-8dd1-c34132e00ab5"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3485), null, true, false, new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5f1a3f2d-8886-4f8b-9e75-a5138202399e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3434), null, true, false, new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7151affe-385f-41e6-819d-ba42ab4ee13c"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3380), null, true, false, new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7028abc3-4af3-4fe6-97c9-80438b1f8932"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3319), null, true, false, new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e63f52ac-0eca-45ff-b778-dbf343510a6b"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3202), null, true, false, new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3326e25c-7479-4361-b493-135fe84e1748"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3151), null, true, false, new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("583e4a0d-4a79-4942-a04f-b0b9b89a3266"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(3096), null, true, false, new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a7a5b125-35a3-4274-ad26-83cba4015558"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2953), null, true, false, new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("193ba98b-a12e-46b8-9167-15ee80fd0fea"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2903), null, true, false, new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8ec3d665-9440-4181-9d2c-79b323f7435e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2833), null, true, false, new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ba6b1f12-c70a-4dca-973c-7700893c871e"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(2014), null, true, false, new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("10be4f5d-1835-4696-ad9e-e34dac345524"), null, new DateTime(2021, 2, 25, 12, 50, 6, 491, DateTimeKind.Local).AddTicks(4122), null, true, false, new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"), null, new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, null, null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(2953), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("787fe36a-82f6-4027-bae4-b24e14889153"), null, null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(5429), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b"), new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(8712), null, new Guid("dcb99cb0-d912-45c2-8175-406f7675c4cd"), true, false, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), new Guid("6acde0fe-4bbb-42de-bd86-ab8b64712343"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("0a8174e9-81de-4d92-bb3d-3dbb29ce6f18"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3198), null, true, false, new Guid("8bd34a4c-24e7-47cc-966e-754662fc9aa8"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("5d96bac9-1291-4835-af06-06955320e4c6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3174), null, true, false, new Guid("2fd853db-9232-492e-aa4d-41a3dd8083e4"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("ad2502c8-dfd0-4159-b7f9-ac14e4b705c2"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3146), null, true, false, new Guid("8f22a4e3-699e-43dc-838e-fb49de702649"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("7fa19468-5bfb-4528-9ef7-fc29d3bfa72d"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3028), null, true, false, new Guid("6aaa04e7-3e6f-4520-b73b-40fbf5253319"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("30ef7bbc-8fa9-4bdf-979c-2b301d661e4a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3004), null, true, false, new Guid("4b52bbd1-13dc-4e2b-8fe0-36678b272fa5"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("f0641e2c-246a-4dce-be3e-34546cca4a91"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2982), null, true, false, new Guid("266548c4-9282-4231-8686-1b9b0f8d49db"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("2122167a-8a28-4278-99ad-7dc863609fb5"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2959), null, true, false, new Guid("16549b40-8e40-4d5e-842b-e11b4a2d3124"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("50e817e7-9bc7-4eae-a23f-d155f73301c8"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2937), null, true, false, new Guid("89e526c1-adc1-4915-a122-fd624b9d006f"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("ec106864-8f27-4ca8-a9dc-de595b233ea9"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2914), null, true, false, new Guid("c8da1897-82ea-48e8-869d-a7ca8d889cde"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("7c5c57ff-c6b6-44e0-8807-947d5a76fd36"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2890), null, true, false, new Guid("744aeb02-0288-4ba4-817c-103185a96718"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("6f4c39e0-e97b-46fd-b7c0-f7b9580969ff"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(3221), null, true, false, new Guid("f8693bc7-80a4-4b87-a300-e808b96a0983"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("eb8a1453-5caf-4864-a997-335ba7c26bc0"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2845), null, true, false, new Guid("c0b2c31b-08c4-432d-854c-6f51f7e44bfa"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("e93ab32f-2d13-49aa-a8a2-c0860a171f6a"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2821), null, true, false, new Guid("9c6bd378-01a7-45df-997f-bc81448bd6f6"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("85f3231a-9cd9-4ec5-a2aa-8082162e8573"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2798), null, true, false, new Guid("45ea7c7e-97fb-4162-b213-5cf1bd1ded55"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("c9866a25-ae45-4407-9a27-42fbb76a4235"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2775), null, true, false, new Guid("2ba24d9c-e1f3-4278-95bb-73822070fc75"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("b11c2b30-a499-4793-b0dc-8bf59342212e"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2753), null, true, false, new Guid("5e91c7be-43e3-4591-8ea0-b9c9f668664b"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("0843a74d-1d66-424f-9c98-e185c81c8b9b"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2724), null, true, false, new Guid("c89b1377-2f94-4dd5-bc28-b39548649cfb"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("c6b90981-da26-4a61-89b6-6a0abc3bda3d"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2693), null, true, false, new Guid("0a939875-dcbf-4b32-8bba-981b9fee11ea"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("6fb542aa-4941-4206-94ae-1b9c38025000"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2601), null, true, false, new Guid("17381e11-d15c-4ec7-a74d-8b09e3cbdb07"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("2dc5ae93-e47a-42b9-a251-b20a8ee24aa6"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2565), null, true, false, new Guid("9b0ee588-dcae-41c0-b877-fd15db26c458"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("9202e232-02bd-4380-b0a9-8e293c78065d"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2321), null, true, false, new Guid("0ba94ebb-dd7d-40f2-8d65-53cd977e9bf0"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") },
                    { new Guid("8ebcee38-759c-4bd8-9259-f595a1591c29"), true, true, null, new DateTime(2021, 2, 25, 12, 50, 6, 493, DateTimeKind.Local).AddTicks(2867), null, true, false, new Guid("9a3ea24d-81a9-4c2b-93ef-504d65a1565e"), true, true, null, null, null, new Guid("e1faefc3-4f26-4c21-8d76-4df1cb74345b") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("6a78ba23-f085-4485-a2b1-a26cf849f42e"), "usuário administrativo", null, new DateTime(2021, 2, 25, 12, 50, 6, 492, DateTimeKind.Local).AddTicks(899), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("389f28b1-44d1-4b2f-8a2c-55c777414c89"), new Guid("dddb5fcf-4798-4cdb-bc29-b11aaff5d093"), null, new DateTime(2021, 2, 25, 12, 50, 6, 489, DateTimeKind.Local).AddTicks(7190), null, true, false, new Guid("53f26e76-eeb4-4a01-81fa-e36ca720342b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
