using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("5b6b9a75-3a0a-4c5a-9ceb-a6ce74dd3314"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05745628-45bd-4df5-ba79-e01a2546f0ca"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0846e863-8584-43e5-bc02-c31fbd182c11"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0d7e18c4-b16b-45ca-86c2-a99b3913916a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1f88c03e-ca68-4347-a8b9-6d3aefae5f30"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2376255d-201c-48a3-b897-5d9b281ecd2f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2e0b0fd7-5810-4726-9b82-8dc5b06045a4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4134c574-7440-4b06-832e-9dd8d7071092"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ad39e04-d8d8-4302-8f26-30e9a58fe1f3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("64d5775b-5b79-4175-8af1-33ce5f1722c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7bec2834-4e0b-4896-b655-0cce6a15a3ff"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7d479fcb-66a5-46fc-80f4-d7052d623fca"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("87918ea1-5b72-4f18-8341-73a68b807391"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("903185c4-0153-4656-be6b-4bf56f13b73e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("905c2810-f46a-4fa3-896a-39c1cf5124b8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a0b4dcbd-1720-48fc-ba4f-b04aabcb1b7e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ac189a4d-6e52-4d16-a37f-cc2990404b17"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c210b22a-59eb-4711-8f79-177d9c292e88"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ce6a9ea7-c741-484c-9124-77852318abe4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d7ccc363-aff5-482a-a21a-486832fbc81d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("debd44d5-3f7b-48f3-ab2f-e89a9d0f95d3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec710fad-dbfb-43ae-b433-878fb0b46820"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f1d882ae-ed3c-42f7-8eef-488201b642ad"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("26b615d8-bdf5-421e-93cc-cf7c3a31678a"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("44f655c9-7f09-4927-8c98-c84bd4bf565f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("eba4653a-4637-4e0b-b723-364042b908da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3859f496-ee61-437b-9faf-253d37559890"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e1324608-1eb2-4481-9897-a271069d3865"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("1649523f-75a5-4704-b6ac-f818e8e97677"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("5b367650-3a53-4165-845a-956ca4a52f5d"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("6091e668-c2e8-4ef3-a436-4557db04a3c3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("21a43c60-f0b2-4380-8d4a-69729e8b60de"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2cf3fef3-bb82-4950-8e93-c505c94f00bb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3b5bcf80-22e9-4d66-ac41-44f3d7f45d9f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3dd7da17-563a-497e-928f-be875fdbe504"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4597226d-6611-4fff-9c57-88c36521071b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("45b64c5d-5b56-4bd1-86c9-c7261828ac7a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4e62103a-19f4-47bf-9bc7-6c5538aa92f5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4fee2935-b013-47d6-abb2-da265f35b0aa"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5f58f7c3-5d4a-4a18-b48b-b1705bc510b2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6a2124c6-5663-4ffa-90dc-60ba31bbbf55"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("78fe3934-cb5c-4365-bcb5-d05a993ea176"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("80f3c3e8-ab11-409c-9148-72f0d5571b02"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("832f3b0f-e29f-40c1-a724-3e4f67bc7e1b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("89d76425-e052-40e9-89eb-efbac1b5ff1e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b91a3b59-f4af-48ec-82e6-4792991c9cc3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c59793b1-c08a-4d0d-ac56-eaedf5c61f99"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cc068159-a9a7-4baa-83eb-97e4c2b0ee51"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("df4dcb39-c96c-432c-a0ca-e1d79cb7a094"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e6d14052-d1c2-4bc9-8461-11e391d9f629"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f1560717-e1a7-45d0-8c35-6617313e56b6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f40a4bf5-f970-47c1-a404-7dff16a08889"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f46c627c-ad07-460d-a04a-a44fe42f095a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("e8324380-d77c-4adf-b2d0-2d455ec6d34d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("e72542da-9df9-4289-a651-871306885488"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("047e6fac-df48-4bb4-b853-4a9bf491d09d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0c439b93-2008-4433-b3fb-47cee3ed6453"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1250c0b1-33d0-4c7c-ab60-9112f444f82d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2deb651a-41bb-4769-891d-5ff55cdb659f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("30f6ff85-fa6b-4ee3-abbc-6cacda6bf5d6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3a8f3d95-9dbf-483b-855e-e0f4129511cf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("43d42f06-4291-4169-897e-5292d8673363"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("45fcff05-c80e-4f5b-a946-1261c7b98c70"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9860c8ba-134f-4d9a-a53e-6a16ba167914"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9ebaeaa5-00e1-4fda-9639-e0ec628f4007"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9fa8b80f-11ed-4e4a-9cc1-074ad2a865c0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a0c28a15-e7ec-4796-8dc4-b34695f7b7cf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a692cf27-353b-49cf-bace-09bd81479412"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("adf85610-d920-4e15-aee7-d944bcb7d130"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b1a574a8-724e-406d-aace-d141d463677e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bd6e85c2-422a-43c9-9e01-f850c460bb05"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ca497547-a372-4bb3-ad44-d254d7d6a36c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d562794b-0b7a-4659-828b-49d7334c4aae"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("de2930ac-e1c7-45a6-b576-49154377ecb5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f3002d79-2e18-430a-950f-e7675a6ad2f1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fb198050-afe6-4f9c-af3c-4bf2386ce346"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fbf23c11-1849-453b-b06c-97459e7cae10"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("98d2d482-7492-4e62-9b9a-54421d8bff30"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("93fceab7-9c84-4520-b930-370035caf145"));

            migrationBuilder.AddColumn<bool>(
                name: "IsEvent",
                table: "Categories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, null, null, null, null, new DateTime(2021, 3, 20, 11, 39, 11, 137, DateTimeKind.Local).AddTicks(7191), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(113), true, false, "Administradores", new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("208dd1c6-8003-4c0d-9a38-444cf3c0a7fb"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3369), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("72af9939-9946-43b8-a795-f818ef4ae88f"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3345), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("79b2675c-0d7c-4051-a1a3-35724aeaa942"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3323), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("36c69e23-6ddf-44a0-b8c6-04bfab9bc1fd"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3301), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("0ef528ac-73b6-4ec0-a7c2-3db00ced7d0b"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3276), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("0d3ad4aa-62b1-4968-89ca-244e1886b531"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3254), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("7850b303-83df-4abb-ad35-7d10fbe6f5c7"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3232), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("685f58bf-bfb3-4d1d-b3c3-6684c69dea98"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3210), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("96ccace8-77df-4bdd-a6ee-e3b34023bffb"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3188), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("523139fd-f247-4d11-b8a4-164b4cae4045"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3160), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("0382da53-f1a5-4669-82bd-76e1aa8ec212"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3093), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("82b35d2c-54c5-4059-84c2-c547190378a5"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3071), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("bdc5b11b-586c-488c-ac5e-799d10a62699"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3047), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("7ea0a8fb-aa9e-40b7-8377-2dd219203e37"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3025), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("a277562c-9415-4978-a057-8ae66afef387"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("11977c94-d4ba-4e09-849b-5719bbc865ff"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3003), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("b3826ca6-4c2a-4603-832f-0ffb2fb89c09"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2980), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("4d6d00da-1f7e-4031-93b3-502c24af1192"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2954), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("b1011fd3-4170-4397-b006-049b951998de"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("d4b7bc36-999a-4029-8bd9-43b0e1cc068c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2924), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("9282db58-14cf-4568-abc6-6d566362c831"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("d6bbd68d-6ada-49c1-bada-3f71e499372b"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2898), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("958e9b50-42fd-49dc-8dd4-6b2096812f51"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2861), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("d65d532b-93e2-4de5-bfd2-9a85e32e3d22"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(2580), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null },
                    { new Guid("1cbcfc76-e9aa-4ac3-ae12-85f237cb2eb8"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(3391), new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), true, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("6f9d3d14-a7ae-4ae9-8ed0-336660852b0b"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8416), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0688878b-5e72-403f-b6c1-c999258c3ce0"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8262), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e4e53154-3aec-4caa-b79f-4662c7ef53cd"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(3925), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8401), null, "", true, false, "groupusers/details", new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8350), null, "", true, false, "groupusers/list", new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8258), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8207), null, "", true, false, "systems/details", new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8156), null, "", true, false, "systems/list", new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8101), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8045), null, "", true, false, "languages/details", new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7994), null, "", true, false, "languages/list", new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7940), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7852), null, "", true, false, "clients/details", new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7800), null, "", true, false, "clients/list", new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7700), null, "", true, false, "menus/details", new Guid("a277562c-9415-4978-a057-8ae66afef387"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7645), null, "", true, false, "menus/list", new Guid("a277562c-9415-4978-a057-8ae66afef387"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a277562c-9415-4978-a057-8ae66afef387"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7588), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7530), null, "", true, false, "users/details", new Guid("b1011fd3-4170-4397-b006-049b951998de"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7396), null, "", true, false, "users/list", new Guid("b1011fd3-4170-4397-b006-049b951998de"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b1011fd3-4170-4397-b006-049b951998de"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7334), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9282db58-14cf-4568-abc6-6d566362c831"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7192), null, "", true, false, "companyoperators/details", new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7134), null, "", true, false, "companyoperators/list", new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7017), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(4172), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7750), null, "", true, false, "", new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 20, 11, 39, 11, 140, DateTimeKind.Local).AddTicks(2451), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("348e1552-e2aa-4b18-9b53-01942c227004"), null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8502), true, true, false, new Guid("6f9d3d14-a7ae-4ae9-8ed0-336660852b0b"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null },
                    { new Guid("cf7eec30-8bc8-46bc-8207-a45fc9db1ead"), null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(7708), true, true, false, new Guid("e4e53154-3aec-4caa-b79f-4662c7ef53cd"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null },
                    { new Guid("f9a37221-d983-42bf-bcc7-adc69e2d8c1a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 141, DateTimeKind.Local).AddTicks(8382), true, true, false, new Guid("0688878b-5e72-403f-b6c1-c999258c3ce0"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("5d56619f-d63c-486b-86e9-e1b3ed038019"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8127), null, true, false, new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f627d29a-da26-48c3-9f07-727f0256bff5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8375), null, true, false, new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("51705aa0-3d7f-4993-aba0-ee09273f7575"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8318), null, true, false, new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8080186c-1b6e-42df-9c8d-66f8ee9245e6"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8232), null, true, false, new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("59086292-7900-4d44-be1c-6014628b7716"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8180), null, true, false, new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ab66fa74-8c7e-48de-b19e-d493f436ea5c"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8070), null, true, false, new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46411d8b-70f9-4567-aadd-20188d983fd9"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8018), null, true, false, new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("92a2cb47-1041-47af-835e-d02d763bb795"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7967), null, true, false, new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ade5a3ba-6e53-4a53-b7fb-8f8299d0d2d9"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7876), null, true, false, new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c01884b0-d898-4e75-b037-0d2ce1471143"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7823), null, true, false, new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8497ee0d-79bf-44de-bd97-584253ed8d1f"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7774), null, true, false, new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("60e5deb9-28dc-4f7d-83f5-ca8cb662e132"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7724), null, true, false, new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bf889e9-7717-4830-b62e-6c3995491c6a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7672), null, true, false, new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e0ef932-ec4b-43e7-8840-240247ae91a5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7611), null, true, false, new Guid("a277562c-9415-4978-a057-8ae66afef387"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("678e5a97-4b91-4cc0-badd-5154722d923a"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7560), null, true, false, new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a024adb-dffd-442d-aa0e-7c6abfaaed6e"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7421), null, true, false, new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7cf52ab0-85e3-4210-9c30-8f512b4f76d5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7365), null, true, false, new Guid("b1011fd3-4170-4397-b006-049b951998de"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdd553ef-b6ce-46ab-8baa-b8b93585d10c"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7218), null, true, false, new Guid("9282db58-14cf-4568-abc6-6d566362c831"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("65de6488-07f4-45fb-9013-d87fa30e0d9e"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7161), null, true, false, new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee84f3cf-a2ce-45c6-ba99-173d71a12e80"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(7092), null, true, false, new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("31cb0bee-5629-4639-b984-e2c7e7d0490b"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(6294), null, true, false, new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("73c01573-fafb-4389-908d-901df5721da5"), null, new DateTime(2021, 3, 20, 11, 39, 11, 142, DateTimeKind.Local).AddTicks(8426), null, true, false, new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"), null, new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, null, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(6929), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b600b3aa-c05b-42cd-bf33-618925e2f8a6"), null, null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(9360), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462"), new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(2670), null, new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"), true, false, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("97c751b1-89d4-42f2-8b16-4f27cd15db0c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7213), null, true, false, new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("3da6cb32-5f8e-43a3-a405-aa29f6a2124d"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7190), null, true, false, new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("8ebd5652-009a-4522-8903-1c3d60959be0"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7166), null, true, false, new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("2d4344a9-0ddb-41d0-b649-2958d2775652"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7139), null, true, false, new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("457f099b-056f-4efa-ae28-fec65fef210c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7109), null, true, false, new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("aac3fddf-c561-46fa-b6fd-dd9cf746b2a6"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7040), null, true, false, new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a3ef2638-4542-4b33-8760-c8ceb2c4b5e3"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7017), null, true, false, new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a3046e42-20bd-4b91-9cc4-4b3b5f27d3e8"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6994), null, true, false, new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("aa16e52a-fb02-42d0-ad83-a15ef1607024"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6971), null, true, false, new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("732fb23d-859b-4210-88b4-aea3dd17980c"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6948), null, true, false, new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("addca7d3-afbc-4ba8-87bd-743741a80d8a"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(7236), null, true, false, new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("c325911a-dadf-4385-910f-87ea4590ff62"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6898), null, true, false, new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("2ec28884-97d6-4652-998a-9dd6f8fc720d"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6872), null, true, false, new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("d8b0f2b5-d3f3-47b6-8df8-057c050472bd"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6848), null, true, false, new Guid("a277562c-9415-4978-a057-8ae66afef387"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("4d9e4b6a-8f0f-412e-bbb0-d6c5093901e2"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6825), null, true, false, new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("7a8546eb-164a-4f76-94b7-e911e53c3227"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6801), null, true, false, new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("1b52684d-455a-4a24-a1f6-021e57083701"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6773), null, true, false, new Guid("b1011fd3-4170-4397-b006-049b951998de"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("d432731b-eda7-4c81-9943-e04cb3616899"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6749), null, true, false, new Guid("9282db58-14cf-4568-abc6-6d566362c831"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a515dc99-ea6c-429b-acd1-b72918c03bdc"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6723), null, true, false, new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("85d5353a-d17d-4953-ac81-d204e3d9f432"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6681), null, true, false, new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("a6ed022c-b843-4fec-b360-7adae4dc55e8"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6441), null, true, false, new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") },
                    { new Guid("32cf5aa8-ad9f-44ef-8c0c-1a86c0ba28bc"), true, true, null, new DateTime(2021, 3, 20, 11, 39, 11, 144, DateTimeKind.Local).AddTicks(6924), null, true, false, new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"), true, true, null, null, null, new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("aad70c67-4be1-4a11-bf83-d2001770f325"), "usuário administrativo", null, new DateTime(2021, 3, 20, 11, 39, 11, 143, DateTimeKind.Local).AddTicks(4904), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("74b1428c-6fbd-4c60-9945-dcccffa73845"), new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"), null, new DateTime(2021, 3, 20, 11, 39, 11, 140, DateTimeKind.Local).AddTicks(5197), null, true, false, new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("525726ab-cda7-43fd-a75f-2f0ddc2bb3f1"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("74b1428c-6fbd-4c60-9945-dcccffa73845"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("58dea5db-1cef-4421-b0e6-3ca32853596a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0382da53-f1a5-4669-82bd-76e1aa8ec212"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0d3ad4aa-62b1-4968-89ca-244e1886b531"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0ef528ac-73b6-4ec0-a7c2-3db00ced7d0b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("11977c94-d4ba-4e09-849b-5719bbc865ff"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1cbcfc76-e9aa-4ac3-ae12-85f237cb2eb8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("208dd1c6-8003-4c0d-9a38-444cf3c0a7fb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("36c69e23-6ddf-44a0-b8c6-04bfab9bc1fd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4d6d00da-1f7e-4031-93b3-502c24af1192"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("523139fd-f247-4d11-b8a4-164b4cae4045"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("685f58bf-bfb3-4d1d-b3c3-6684c69dea98"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("72af9939-9946-43b8-a795-f818ef4ae88f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7850b303-83df-4abb-ad35-7d10fbe6f5c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("79b2675c-0d7c-4051-a1a3-35724aeaa942"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7ea0a8fb-aa9e-40b7-8377-2dd219203e37"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("82b35d2c-54c5-4059-84c2-c547190378a5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("958e9b50-42fd-49dc-8dd4-6b2096812f51"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("96ccace8-77df-4bdd-a6ee-e3b34023bffb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b3826ca6-4c2a-4603-832f-0ffb2fb89c09"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bdc5b11b-586c-488c-ac5e-799d10a62699"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d4b7bc36-999a-4029-8bd9-43b0e1cc068c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d65d532b-93e2-4de5-bfd2-9a85e32e3d22"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d6bbd68d-6ada-49c1-bada-3f71e499372b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0688878b-5e72-403f-b6c1-c999258c3ce0"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("6f9d3d14-a7ae-4ae9-8ed0-336660852b0b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e4e53154-3aec-4caa-b79f-4662c7ef53cd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1cc75dd5-74d5-416b-b967-5496e8569ce2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("332bf3f6-c7cd-4702-8d0b-009cdc84d405"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("33b5fd19-e65a-48d3-ba0c-2123029079ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3885ca3a-a89d-43e0-a722-35b13e5518c1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("46a5f624-2718-47e5-b32c-96b4f791dab6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4820dfd5-784b-4efc-a2b7-13aa426008da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("57b2191f-1889-43e7-b04f-17e11b318b6f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("713134bd-6432-4fc7-8685-4a28e22465d1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("73e6354e-9910-45a5-b346-20ffdcbcb6f2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8952a1c4-8a71-4175-a8a8-e18152200fdb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8df485d4-4ac6-461e-bdf2-bbf0aef501f7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("904d0a11-ece8-4d30-84e9-627916afdcac"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9282db58-14cf-4568-abc6-6d566362c831"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a277562c-9415-4978-a057-8ae66afef387"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a6654347-97d8-4a0c-b848-fd67dfbafa14"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b1011fd3-4170-4397-b006-049b951998de"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b53be01f-d45e-4c7e-a9b5-4ccc0dde33a6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bf468eed-4c6e-4d4c-96ac-102d834a50c0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d28da520-4dcf-4960-9d29-7d89d95b824d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d3361f20-8567-4194-aedb-8cf94a2d5b91"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fc697d2f-e221-4192-a7a1-77098f64a365"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fcadd957-ab58-43a9-ac1d-c112cba931d1"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("348e1552-e2aa-4b18-9b53-01942c227004"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("cf7eec30-8bc8-46bc-8207-a45fc9db1ead"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("f9a37221-d983-42bf-bcc7-adc69e2d8c1a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("31cb0bee-5629-4639-b984-e2c7e7d0490b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("46411d8b-70f9-4567-aadd-20188d983fd9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("51705aa0-3d7f-4993-aba0-ee09273f7575"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("59086292-7900-4d44-be1c-6014628b7716"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5a024adb-dffd-442d-aa0e-7c6abfaaed6e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5d56619f-d63c-486b-86e9-e1b3ed038019"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("60e5deb9-28dc-4f7d-83f5-ca8cb662e132"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("65de6488-07f4-45fb-9013-d87fa30e0d9e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("678e5a97-4b91-4cc0-badd-5154722d923a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6bf889e9-7717-4830-b62e-6c3995491c6a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6e0ef932-ec4b-43e7-8840-240247ae91a5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("73c01573-fafb-4389-908d-901df5721da5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7cf52ab0-85e3-4210-9c30-8f512b4f76d5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8080186c-1b6e-42df-9c8d-66f8ee9245e6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8497ee0d-79bf-44de-bd97-584253ed8d1f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("92a2cb47-1041-47af-835e-d02d763bb795"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ab66fa74-8c7e-48de-b19e-d493f436ea5c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ade5a3ba-6e53-4a53-b7fb-8f8299d0d2d9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c01884b0-d898-4e75-b037-0d2ce1471143"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cdd553ef-b6ce-46ab-8baa-b8b93585d10c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ee84f3cf-a2ce-45c6-ba99-173d71a12e80"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f627d29a-da26-48c3-9f07-727f0256bff5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("45a3d63e-09b6-47d5-a231-bf6a1badc1c8"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("b600b3aa-c05b-42cd-bf33-618925e2f8a6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("fcb016ed-0f32-456a-a7d6-faa7c3796462"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1b52684d-455a-4a24-a1f6-021e57083701"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2d4344a9-0ddb-41d0-b649-2958d2775652"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2ec28884-97d6-4652-998a-9dd6f8fc720d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("32cf5aa8-ad9f-44ef-8c0c-1a86c0ba28bc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3da6cb32-5f8e-43a3-a405-aa29f6a2124d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("457f099b-056f-4efa-ae28-fec65fef210c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4d9e4b6a-8f0f-412e-bbb0-d6c5093901e2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("732fb23d-859b-4210-88b4-aea3dd17980c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7a8546eb-164a-4f76-94b7-e911e53c3227"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("85d5353a-d17d-4953-ac81-d204e3d9f432"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8ebd5652-009a-4522-8903-1c3d60959be0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("97c751b1-89d4-42f2-8b16-4f27cd15db0c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3046e42-20bd-4b91-9cc4-4b3b5f27d3e8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a3ef2638-4542-4b33-8760-c8ceb2c4b5e3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a515dc99-ea6c-429b-acd1-b72918c03bdc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a6ed022c-b843-4fec-b360-7adae4dc55e8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aa16e52a-fb02-42d0-ad83-a15ef1607024"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aac3fddf-c561-46fa-b6fd-dd9cf746b2a6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("addca7d3-afbc-4ba8-87bd-743741a80d8a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c325911a-dadf-4385-910f-87ea4590ff62"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d432731b-eda7-4c81-9943-e04cb3616899"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d8b0f2b5-d3f3-47b6-8df8-057c050472bd"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("aad70c67-4be1-4a11-bf83-d2001770f325"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("dd870742-7b69-4c1f-9621-10cbca6ebeb7"));

            migrationBuilder.DropColumn(
                name: "IsEvent",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, null, null, null, null, new DateTime(2021, 3, 10, 22, 19, 42, 131, DateTimeKind.Local).AddTicks(553), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(7954), true, false, "Administradores", new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("7bec2834-4e0b-4896-b655-0cce6a15a3ff"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1371), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("0846e863-8584-43e5-bc02-c31fbd182c11"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1311), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("1f88c03e-ca68-4347-a8b9-6d3aefae5f30"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1289), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("05745628-45bd-4df5-ba79-e01a2546f0ca"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1267), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("87918ea1-5b72-4f18-8341-73a68b807391"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1243), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("ac189a4d-6e52-4d16-a37f-cc2990404b17"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1221), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("a0b4dcbd-1720-48fc-ba4f-b04aabcb1b7e"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1199), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("c210b22a-59eb-4711-8f79-177d9c292e88"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1173), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("2e0b0fd7-5810-4726-9b82-8dc5b06045a4"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1151), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("f1d882ae-ed3c-42f7-8eef-488201b642ad"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1129), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("903185c4-0153-4656-be6b-4bf56f13b73e"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1107), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("2376255d-201c-48a3-b897-5d9b281ecd2f"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1084), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("3859f496-ee61-437b-9faf-253d37559890"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("debd44d5-3f7b-48f3-ab2f-e89a9d0f95d3"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1060), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("ce6a9ea7-c741-484c-9124-77852318abe4"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1037), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("4134c574-7440-4b06-832e-9dd8d7071092"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1015), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("ec710fad-dbfb-43ae-b433-878fb0b46820"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(986), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("e1324608-1eb2-4481-9897-a271069d3865"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("5ad39e04-d8d8-4302-8f26-30e9a58fe1f3"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(958), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("0d7e18c4-b16b-45ca-86c2-a99b3913916a"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(893), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("d7ccc363-aff5-482a-a21a-486832fbc81d"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(869), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("7d479fcb-66a5-46fc-80f4-d7052d623fca"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(830), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("64d5775b-5b79-4175-8af1-33ce5f1722c7"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(520), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null },
                    { new Guid("905c2810-f46a-4fa3-896a-39c1cf5124b8"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(1395), new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), true, new Guid("93fceab7-9c84-4520-b930-370035caf145"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("44f655c9-7f09-4927-8c98-c84bd4bf565f"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6452), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("26b615d8-bdf5-421e-93cc-cf7c3a31678a"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6330), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eba4653a-4637-4e0b-b723-364042b908da"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(2650), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6263), null, "", true, false, "groupusers/details", new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6133), null, "", true, false, "groupusers/list", new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6087), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6040), null, "", true, false, "systems/details", new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5991), null, "", true, false, "systems/list", new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5899), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5850), null, "", true, false, "languages/details", new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5802), null, "", true, false, "languages/list", new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5755), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5705), null, "", true, false, "clients/details", new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5655), null, "", true, false, "clients/list", new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3859f496-ee61-437b-9faf-253d37559890"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5464), null, "", true, false, "menus/details", new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5410), null, "", true, false, "menus/list", new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5361), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5313), null, "", true, false, "users/details", new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e1324608-1eb2-4481-9897-a271069d3865"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5262), null, "", true, false, "users/list", new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5200), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5058), null, "", true, false, "companyoperators/details", new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4915), null, "", true, false, "companyoperators/list", new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4803), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(1980), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5606), null, "", true, false, "", new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("93fceab7-9c84-4520-b930-370035caf145"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 10, 22, 19, 42, 133, DateTimeKind.Local).AddTicks(5834), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("1649523f-75a5-4704-b6ac-f818e8e97677"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6478), true, true, false, new Guid("44f655c9-7f09-4927-8c98-c84bd4bf565f"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null },
                    { new Guid("6091e668-c2e8-4ef3-a436-4557db04a3c3"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6061), true, true, false, new Guid("eba4653a-4637-4e0b-b723-364042b908da"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null },
                    { new Guid("5b367650-3a53-4165-845a-956ca4a52f5d"), null, new DateTime(2021, 3, 10, 22, 19, 42, 134, DateTimeKind.Local).AddTicks(6421), true, true, false, new Guid("26b615d8-bdf5-421e-93cc-cf7c3a31678a"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f46c627c-ad07-460d-a04a-a44fe42f095a"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5959), null, true, false, new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5f58f7c3-5d4a-4a18-b48b-b1705bc510b2"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6209), null, true, false, new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e6d14052-d1c2-4bc9-8461-11e391d9f629"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6109), null, true, false, new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("78fe3934-cb5c-4365-bcb5-d05a993ea176"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6062), null, true, false, new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2cf3fef3-bb82-4950-8e93-c505c94f00bb"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6014), null, true, false, new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("80f3c3e8-ab11-409c-9148-72f0d5571b02"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5873), null, true, false, new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e62103a-19f4-47bf-9bc7-6c5538aa92f5"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5825), null, true, false, new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f1560717-e1a7-45d0-8c35-6617313e56b6"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5777), null, true, false, new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b5bcf80-22e9-4d66-ac41-44f3d7f45d9f"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5727), null, true, false, new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f40a4bf5-f970-47c1-a404-7dff16a08889"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5681), null, true, false, new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("832f3b0f-e29f-40c1-a724-3e4f67bc7e1b"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5630), null, true, false, new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4597226d-6611-4fff-9c57-88c36521071b"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5487), null, true, false, new Guid("3859f496-ee61-437b-9faf-253d37559890"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("45b64c5d-5b56-4bd1-86c9-c7261828ac7a"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5435), null, true, false, new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b91a3b59-f4af-48ec-82e6-4792991c9cc3"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5383), null, true, false, new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("21a43c60-f0b2-4380-8d4a-69729e8b60de"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5335), null, true, false, new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cc068159-a9a7-4baa-83eb-97e4c2b0ee51"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5288), null, true, false, new Guid("e1324608-1eb2-4481-9897-a271069d3865"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4fee2935-b013-47d6-abb2-da265f35b0aa"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5228), null, true, false, new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("89d76425-e052-40e9-89eb-efbac1b5ff1e"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(5085), null, true, false, new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df4dcb39-c96c-432c-a0ca-e1d79cb7a094"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4941), null, true, false, new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3dd7da17-563a-497e-928f-be875fdbe504"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4872), null, true, false, new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6a2124c6-5663-4ffa-90dc-60ba31bbbf55"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(4034), null, true, false, new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c59793b1-c08a-4d0d-ac56-eaedf5c61f99"), null, new DateTime(2021, 3, 10, 22, 19, 42, 135, DateTimeKind.Local).AddTicks(6287), null, true, false, new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"), null, new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, null, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(5049), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e8324380-d77c-4adf-b2d0-2d455ec6d34d"), null, null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(7606), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e72542da-9df9-4289-a651-871306885488"), new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(1017), null, new Guid("0a8bfd48-5051-4f5b-963d-0859ef7603bd"), true, false, new Guid("93fceab7-9c84-4520-b930-370035caf145"), new Guid("3bd843b8-906b-4935-8d8c-f7f7ed666599"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("a692cf27-353b-49cf-bace-09bd81479412"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5561), null, true, false, new Guid("117482ad-2035-4c3a-aad7-10e9406a468d"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("fbf23c11-1849-453b-b06c-97459e7cae10"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5537), null, true, false, new Guid("7042dcd8-b4c0-4234-98c9-afdee63f4933"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("bd6e85c2-422a-43c9-9e01-f850c460bb05"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5515), null, true, false, new Guid("6e52ca9f-f065-4e66-a1eb-c62b15b48d98"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("047e6fac-df48-4bb4-b853-4a9bf491d09d"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5492), null, true, false, new Guid("50a10053-6dc8-46f3-8d08-afb396dce96e"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("9fa8b80f-11ed-4e4a-9cc1-074ad2a865c0"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5468), null, true, false, new Guid("23961e8f-5172-4a63-9727-0f8d6347828f"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("1250c0b1-33d0-4c7c-ab60-9112f444f82d"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5446), null, true, false, new Guid("8f220da9-2ebe-4f7d-9824-ba572deefbe9"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("3a8f3d95-9dbf-483b-855e-e0f4129511cf"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5423), null, true, false, new Guid("ea51744a-c786-4e75-a7e8-6eff31c55f3a"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("ca497547-a372-4bb3-ad44-d254d7d6a36c"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5400), null, true, false, new Guid("22df59d0-a3d9-4f27-93f5-31e4c56807e6"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("0c439b93-2008-4433-b3fb-47cee3ed6453"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5377), null, true, false, new Guid("b2093824-5ff9-4982-b89c-aa3e40dfced9"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("43d42f06-4291-4169-897e-5292d8673363"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5352), null, true, false, new Guid("b78bc2ff-3302-4890-b9d3-fd2a149e1fab"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("d562794b-0b7a-4659-828b-49d7334c4aae"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5584), null, true, false, new Guid("b2a8a5d2-9dd9-4479-af64-2920374c777f"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("f3002d79-2e18-430a-950f-e7675a6ad2f1"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5305), null, true, false, new Guid("3859f496-ee61-437b-9faf-253d37559890"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("2deb651a-41bb-4769-891d-5ff55cdb659f"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5230), null, true, false, new Guid("a2e47b1e-d1c1-4b11-8243-44bd42a5c6c5"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("fb198050-afe6-4f9c-af3c-4bf2386ce346"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5207), null, true, false, new Guid("c71695ab-39d9-448a-8192-9f1843c0d188"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("b1a574a8-724e-406d-aace-d141d463677e"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5185), null, true, false, new Guid("a173b5ee-30bd-484c-adbf-41457281cb5c"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("de2930ac-e1c7-45a6-b576-49154377ecb5"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5162), null, true, false, new Guid("e1324608-1eb2-4481-9897-a271069d3865"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("a0c28a15-e7ec-4796-8dc4-b34695f7b7cf"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5135), null, true, false, new Guid("cdc9e9e4-f751-4647-ade8-b5c001ad04c4"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("45fcff05-c80e-4f5b-a946-1261c7b98c70"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5105), null, true, false, new Guid("194aaf3d-d27e-41ba-9a0e-2ef4627167c2"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("9ebaeaa5-00e1-4fda-9639-e0ec628f4007"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5081), null, true, false, new Guid("bf74e6f9-695a-4823-adab-3d3b2f9a6744"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("9860c8ba-134f-4d9a-a53e-6a16ba167914"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5043), null, true, false, new Guid("3c48f73b-96e6-47a0-9dd3-aae3fa1e8506"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("30f6ff85-fa6b-4ee3-abbc-6cacda6bf5d6"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(4806), null, true, false, new Guid("a99f8b49-df52-41d4-8a3f-eed5f031ce29"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") },
                    { new Guid("adf85610-d920-4e15-aee7-d944bcb7d130"), true, true, null, new DateTime(2021, 3, 10, 22, 19, 42, 137, DateTimeKind.Local).AddTicks(5329), null, true, false, new Guid("c43afac2-8018-49e0-95ca-634a5f1c8800"), true, true, null, null, null, new Guid("e72542da-9df9-4289-a651-871306885488") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("98d2d482-7492-4e62-9b9a-54421d8bff30"), "usuário administrativo", null, new DateTime(2021, 3, 10, 22, 19, 42, 136, DateTimeKind.Local).AddTicks(2923), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5b6b9a75-3a0a-4c5a-9ceb-a6ce74dd3314"), new Guid("b23b3bbc-a616-4ac9-8e43-665c7ed2c148"), null, new DateTime(2021, 3, 10, 22, 19, 42, 133, DateTimeKind.Local).AddTicks(8847), null, true, false, new Guid("93fceab7-9c84-4520-b930-370035caf145"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
