using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("3b38e6c9-6daa-4156-89a2-e548757dcf4a"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("02c94584-5e83-4190-9649-193020a2b0d2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("06b6ca61-b538-4027-ad8e-4044c3aff455"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1eb1037e-7123-4b85-9c9b-c012794f75e6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1ff65062-cd81-40d4-a9a2-118b7cf22981"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2fed3648-4b7b-4e57-b535-4c342998d2c1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("46e4c471-3543-4e26-9ab8-52f692b92f83"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("58f2b4fa-4d8e-4d92-9719-ec36b124e1de"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("64a55d82-31a5-4e69-9c1c-82e7edc527c3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7034bee1-e58f-4b6d-8a8a-068e4d64fe82"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7cabd423-e5f5-43ef-9abe-dea2cc91ff2f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("98d8d0dd-5ddd-48f7-8acb-3b12e4ceb481"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9ff83155-67e8-4be1-96c9-dea9e9fe3eb1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a7b06f99-f01a-4c57-a95f-0f83c00703b3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("bf33c25b-3012-477b-a112-c2c06b4379a2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c76fed81-a3c6-4de9-b3df-aa6ec03bc143"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("daf2c116-3a14-4cfa-82bd-9573174f46d3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e7271a40-44fb-463e-90ed-dea28dcd12a3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e8d9bc71-3779-4036-8b3b-27e9353909d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e94e3fad-98b8-461e-8c79-07aca68017b2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ead8cf04-1e04-4940-8cf5-ce441bd3a07b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec48c1ec-c601-41e9-971c-4648b6a449d2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f26501c1-10ab-437b-a638-87633c9f877c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0c60c192-6e89-4216-8347-bb31bcd389f8"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8b1f91d0-fab4-4063-a118-37a20c36eeb5"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e3f315aa-0c70-417d-ace7-09a4c92914f5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("095c4ea9-de48-4856-9650-772334833a99"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1c7358cc-f643-4b69-9b94-397690948112"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("244bba94-a296-4c91-b855-5924b11c80b5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4f231292-2273-4873-85fe-62765fd891f0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("66f432e3-836f-4a36-be77-d91648021afb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d227929b-80cf-4854-9762-0892c5e934fd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("67969798-295c-47cb-9410-cad71472099a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("8a3e2184-4915-467e-8642-41ad23140238"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("b571b431-1a84-49df-81f9-6dbccaf2024a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1fdd00c6-3a1b-4b70-9e50-a7ab765671a7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("24778eb9-40d3-4ea6-b0d7-eb7b50bff7f5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3749f04a-2b39-4bce-a3bd-4f9cb4fd3aad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3cb110d6-6020-4b4a-bc33-524d9b2015f2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3ff4d5bd-f7b8-4e8f-82be-4be7e9cf713b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("43b9a30d-59eb-4651-b776-e3b1cd52b6fa"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4430e88d-d267-48b9-9b0c-e6a722fd8553"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("58d2a224-299d-453e-ab7b-7026fe560fad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5a37a55e-6018-47ec-b3ab-0d8b335f82cf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ba22f94-d7c5-4e98-a807-b0ba8b27c112"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ca6e9eb-da27-40a2-a320-8f71caa844e8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6384ae32-0ef5-40a4-a941-93b263903192"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("738d340a-1c0b-4954-a582-82246b4853fc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("78859365-6655-44e3-a2cb-e93188c5d435"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("800b314d-6cfa-4183-b70c-cde5c9e1d6b0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bb1deb70-05f3-4379-86c1-88aeee70becc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bf65963a-c4b1-4bd5-93ba-cc8aee73008e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c25343c4-83a2-461f-a8f5-e03d23031d0a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d26b7278-6fa2-475a-af3a-2ebfcb6a1f62"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ee7a9947-b675-4b14-a7f6-b57216076126"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ef6b6148-074a-49a1-9f29-b37c0382039f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f973b7f4-9dae-4243-82e6-e80b1786f967"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("92b38245-12e7-4bf5-a1dd-8b65da81971a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1c770ab8-79e4-4346-b89d-e31ff9539236"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2258c20b-7252-4f16-8063-d4d1ecdea58f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("271190a6-19d0-4d57-ac90-8e3d9f545b5c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("28c5961a-868f-4976-ada7-d647bd801459"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2eb138e7-1cbd-4f88-b2c7-9e3f3357c629"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4d7cac32-9391-4b16-888e-1b554958380b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4ee892be-4260-4131-8cb6-3271f28f1482"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("582faaf1-9c85-432c-b3c6-0d6480025a57"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5a5be487-2237-4213-8ef0-4d32c9d0cc97"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("61637a4e-8330-4d9b-aebd-47a6de764961"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("69856507-1ad4-4b57-bf1c-cac633fa38fe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("69e8a936-d00a-4af2-b36f-2387c6ec30a4"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6a811ce7-d453-4a5f-868c-273898071912"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7572f4d8-edbf-4a64-a3e8-5943444de904"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8359c908-bfc8-4549-b0eb-3a45815cf53a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a4668510-a86c-499b-88c0-d9745f2a71ff"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a57254ad-34c0-4ecb-87f8-2c5a7e6d3177"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a805f0c3-2f69-435c-99ac-2ffdda312655"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c4a1fff1-49c2-459e-b5e3-ff4606663b0c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d7a548d8-7960-4b22-b49f-338c054ef3da"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e9804be2-13d3-4fae-8e2f-1ea364a8be82"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fdd9ea1b-5e7c-434e-89e3-62db71e00d71"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("40b98801-8ca6-49f9-aa60-f04ed709bb98"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"));

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Timetable",
                columns: table => new
                {
                    TimetableId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    hrs24 = table.Column<bool>(type: "boolean", nullable: false),
                    AllDays = table.Column<bool>(type: "boolean", nullable: false),
                    AllDaysIn = table.Column<string>(type: "text", nullable: true),
                    AllDaysOut = table.Column<string>(type: "text", nullable: true),
                    Monday = table.Column<bool>(type: "boolean", nullable: false),
                    MondayIn = table.Column<string>(type: "text", nullable: true),
                    MondayOut = table.Column<string>(type: "text", nullable: true),
                    Tuesday = table.Column<bool>(type: "boolean", nullable: false),
                    TuesdayIn = table.Column<string>(type: "text", nullable: true),
                    TuesdayOut = table.Column<string>(type: "text", nullable: true),
                    Wednesday = table.Column<bool>(type: "boolean", nullable: false),
                    WednesdayIn = table.Column<string>(type: "text", nullable: true),
                    WednesdayOut = table.Column<string>(type: "text", nullable: true),
                    Thursday = table.Column<bool>(type: "boolean", nullable: false),
                    ThursdayIn = table.Column<string>(type: "text", nullable: true),
                    ThursdayOut = table.Column<string>(type: "text", nullable: true),
                    Friday = table.Column<bool>(type: "boolean", nullable: false),
                    FridayIn = table.Column<string>(type: "text", nullable: true),
                    FridayOut = table.Column<string>(type: "text", nullable: true),
                    Saturday = table.Column<bool>(type: "boolean", nullable: false),
                    SaturdayIn = table.Column<string>(type: "text", nullable: true),
                    SaturdayOut = table.Column<string>(type: "text", nullable: true),
                    Sunday = table.Column<string>(type: "text", nullable: true),
                    SundayIn = table.Column<string>(type: "text", nullable: true),
                    SundayOut = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    UserIdInsert = table.Column<Guid>(type: "uuid", nullable: true),
                    DtInsert = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DtDeleted = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdDeleted = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    DtLastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UserIdUpdate = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetable", x => x.TimetableId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, null, null, null, null, new DateTime(2021, 3, 6, 18, 12, 32, 64, DateTimeKind.Local).AddTicks(1216), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(4440), true, false, "Administradores", new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("b0a1be5b-4310-4e2b-9c3b-40344a8bb5ee"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4541), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("f7781238-569c-44d2-a64a-5c6b9736ecfe"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4506), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("7529b803-5b42-4122-a01c-f1ecbd6031d4"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4472), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("d2287672-40ca-4f09-9de3-a121ccb51bc2"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4436), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("ca6a0802-86c2-4857-a2da-be1cbcd88f03"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4394), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("9c07d216-48c1-4234-934c-5e5b610ecc4e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4359), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("88523520-8020-407d-8080-b3920c2da18e"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("f83defd1-3b80-4114-8dde-ac31e99ba9be"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4323), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("7f3b2ec6-f008-43c9-8d63-0dadb0ff5280"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4284), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("39f0a325-1133-43b5-a9c9-adf8eda32d60"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4181), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("c9231007-fd12-42ae-a2d6-bd9294e3e766"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4147), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("8ce9f76d-c295-459c-9bac-9704cd35af1b"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4114), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("b8cb71bf-1246-4fe4-9374-af7db5aed1ab"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4079), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("a1f90a20-de24-4e63-af30-ea29a0e14eba"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4037), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("1e12e0b4-dadd-4811-9674-d828ac88f059"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4003), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("d76f2088-58a2-4151-a31f-251029d9ee30"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3969), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("e84d79d8-cc7e-4b98-9cba-7d7fe96ffce4"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3935), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("b1a9b4d1-bb4e-40ff-91bb-75c9ed439ea6"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3894), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("4c2e8417-feec-456f-aa64-033a8b6ddd6e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3860), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("dabcf7dd-9a54-48fa-aa31-6b68f8dac382"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3823), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("186f8263-f821-4110-83d1-05e2bded6880"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3766), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("23b907d9-55e7-47f0-b577-bad40ed67a5b"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(3315), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null },
                    { new Guid("880490c5-c149-4a64-b803-3c14ba317a00"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(4575), new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), true, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f2e83ebe-aa89-47b7-ad77-63f51f617c6a"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2817), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3c3f4080-695b-4cf7-96b2-c8b23b0ba152"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2662), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7776f4dc-859c-48ee-bd8a-439f3dbc34b6"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 6, 18, 12, 32, 67, DateTimeKind.Local).AddTicks(9033), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7317), null, "", true, false, "groupusers/details", new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7189), null, "", true, false, "groupusers/list", new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7119), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7044), null, "", true, false, "systems/details", new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6973), null, "", true, false, "systems/list", new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6896), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("88523520-8020-407d-8080-b3920c2da18e"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6821), null, "", true, false, "languages/details", new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6740), null, "", true, false, "languages/list", new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6612), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6541), null, "", true, false, "clients/details", new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6465), null, "", true, false, "clients/list", new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6318), null, "", true, false, "menus/details", new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6241), null, "", true, false, "menus/list", new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6161), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6014), null, "", true, false, "users/details", new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5943), null, "", true, false, "users/list", new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5859), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5613), null, "", true, false, "companyoperators/details", new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5518), null, "", true, false, "companyoperators/list", new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5259), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(698), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6387), null, "", true, false, "", new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 6, 18, 12, 32, 67, DateTimeKind.Local).AddTicks(1529), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("7992b767-e38e-4c88-b9c0-bbc08274a58e"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2847), true, true, false, new Guid("f2e83ebe-aa89-47b7-ad77-63f51f617c6a"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null },
                    { new Guid("f0a121f2-e103-47a9-ac56-5c6aab1744db"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2372), true, true, false, new Guid("7776f4dc-859c-48ee-bd8a-439f3dbc34b6"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null },
                    { new Guid("2f1f190e-fcca-4b2f-b37e-c5c7f6524882"), null, new DateTime(2021, 3, 6, 18, 12, 32, 68, DateTimeKind.Local).AddTicks(2771), true, true, false, new Guid("3c3f4080-695b-4cf7-96b2-c8b23b0ba152"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("b61d8c6a-3576-4236-9089-deecd8e3daad"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6932), null, true, false, new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9cc5a663-236c-48de-8303-2e8bbac2eb4c"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7276), null, true, false, new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc39de64-bace-4414-b45e-c66badf89626"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7150), null, true, false, new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("64ed43ac-e680-4053-ab39-83920cbad76d"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7077), null, true, false, new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9685bcee-86a4-466e-974d-1dbe004ed16c"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7006), null, true, false, new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ded99cf2-b06c-4c3d-b25e-9077699e7abf"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6855), null, true, false, new Guid("88523520-8020-407d-8080-b3920c2da18e"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("99cc25c5-564c-49cf-bbbf-c1225915782b"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6776), null, true, false, new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("19018968-b46d-442e-9ced-25219f7c4c96"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6645), null, true, false, new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a56c90cb-cc75-46e4-88ea-75bc8e9c8181"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6573), null, true, false, new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("53b3cc02-38ff-4c2f-8775-72c94fc17714"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6500), null, true, false, new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0c07e7e-a9da-4cf2-928c-6041195fe43e"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6420), null, true, false, new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("caefb70a-4876-4761-ba50-8480811fed84"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6350), null, true, false, new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b1f07851-4414-4a17-80f0-a2422f9f6fcd"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6278), null, true, false, new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("32969a75-0b30-4492-9511-6b64a040536a"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6199), null, true, false, new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d72616f6-72dd-404d-83f8-935563f952b8"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(6047), null, true, false, new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("16c8706f-5a69-4391-816d-3c4e67496926"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5977), null, true, false, new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9698c8a6-38c8-44a2-896b-10453d8b8ffb"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5900), null, true, false, new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c4301d59-0ffa-4e4e-9bf9-9ad3a62fa514"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5648), null, true, false, new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b8e28b64-95bf-4c2e-a423-ab8867b74755"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5557), null, true, false, new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("99d37e20-0121-4328-8499-6180dc951168"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(5448), null, true, false, new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("acd25e60-ab87-45f0-86b0-0fc9998e6ca8"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(4061), null, true, false, new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bbb36dc-7da9-47a4-a337-728089689a8f"), null, new DateTime(2021, 3, 6, 18, 12, 32, 69, DateTimeKind.Local).AddTicks(7349), null, true, false, new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("476104fe-3136-4df5-8420-9698b62169bb"), null, new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, null, null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(9714), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("27a4d08c-7857-4189-856e-0d5a222c7f06"), null, null, new DateTime(2021, 3, 6, 18, 12, 32, 71, DateTimeKind.Local).AddTicks(3313), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("476104fe-3136-4df5-8420-9698b62169bb"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8"), new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, new DateTime(2021, 3, 6, 18, 12, 32, 71, DateTimeKind.Local).AddTicks(8129), null, new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"), true, false, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), new Guid("476104fe-3136-4df5-8420-9698b62169bb"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("3e0dc115-78bb-4815-9b65-a3607fa25aa0"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4470), null, true, false, new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("152d5134-a3ef-40f4-9bf2-c250cdafbe89"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4435), null, true, false, new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("b7e19874-b6f4-4fe1-8750-3ae9fcd15935"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4401), null, true, false, new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("83093f4b-bf92-4ec4-b67f-7a0a50e7c299"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4356), null, true, false, new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("0926895a-0438-45f3-b538-a2c56a746b45"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4163), null, true, false, new Guid("a67fb92f-806c-43ea-9339-eb301638d750"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("ba8ced89-bd7f-4007-8684-9d6694a5fd1e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4129), null, true, false, new Guid("88523520-8020-407d-8080-b3920c2da18e"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("5462b482-7106-41e0-8c48-5e3dd480d44c"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4094), null, true, false, new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("3dea9c07-3ab8-4e94-b5d5-39caf86b1831"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4061), null, true, false, new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("26f9bfbb-e8f6-4e78-85f4-01fa90e7d8a7"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4028), null, true, false, new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("de25be93-7838-4fb2-97f9-ff081b7510e1"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3995), null, true, false, new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("72b1e21a-3dc6-480a-b80a-30b77965fef1"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(4504), null, true, false, new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("8df6ad74-e4b0-4102-b549-1f1f4ff254e7"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3927), null, true, false, new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("011796e3-ba18-4069-b060-746183615d98"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3891), null, true, false, new Guid("be03e597-f466-4a8c-8c58-b4003890d686"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("ea2c3953-36a0-479f-b552-b367aa1e157e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3856), null, true, false, new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("12696dc5-1aeb-460d-b972-fdac9fbdc58c"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3814), null, true, false, new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("e1b39dfe-91bc-4c5f-b26b-9d1aae8b4e7b"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3780), null, true, false, new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("ec9e1129-2b4c-4b1b-9a23-3bbdc12ba302"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3741), null, true, false, new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("6ca9bb92-c0c0-49fe-a663-4172de75044e"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3706), null, true, false, new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("1e708230-51a6-44ec-bdae-9f808d95977f"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3666), null, true, false, new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("c6c71232-ccac-4cea-83dd-e39f36744c76"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3539), null, true, false, new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("6c036cf9-f490-4ff7-b095-a0693076e941"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3165), null, true, false, new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") },
                    { new Guid("b6f10169-2eec-41a9-bc97-89501db73b8c"), true, true, null, new DateTime(2021, 3, 6, 18, 12, 32, 72, DateTimeKind.Local).AddTicks(3962), null, true, false, new Guid("3486f369-d661-4fac-972d-8f01b51adc22"), true, true, null, null, null, new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("40a48f66-7faf-47c7-9ab6-14bc2c7ae7e6"), "usuário administrativo", null, new DateTime(2021, 3, 6, 18, 12, 32, 70, DateTimeKind.Local).AddTicks(6781), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("46635be6-40ae-4045-9d15-351c8a0732bb"), new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"), null, new DateTime(2021, 3, 6, 18, 12, 32, 67, DateTimeKind.Local).AddTicks(4691), null, true, false, new Guid("d687793c-7785-4978-91bc-af41c966bb4e"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Timetable");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("9d8cf559-0f77-4741-b79c-6b7bc289bd83"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("46635be6-40ae-4045-9d15-351c8a0732bb"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("8255f52d-769a-4f36-98c3-fdb438d456bb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("186f8263-f821-4110-83d1-05e2bded6880"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1e12e0b4-dadd-4811-9674-d828ac88f059"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("23b907d9-55e7-47f0-b577-bad40ed67a5b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("39f0a325-1133-43b5-a9c9-adf8eda32d60"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4c2e8417-feec-456f-aa64-033a8b6ddd6e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7529b803-5b42-4122-a01c-f1ecbd6031d4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7f3b2ec6-f008-43c9-8d63-0dadb0ff5280"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("880490c5-c149-4a64-b803-3c14ba317a00"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8ce9f76d-c295-459c-9bac-9704cd35af1b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9c07d216-48c1-4234-934c-5e5b610ecc4e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a1f90a20-de24-4e63-af30-ea29a0e14eba"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b0a1be5b-4310-4e2b-9c3b-40344a8bb5ee"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b1a9b4d1-bb4e-40ff-91bb-75c9ed439ea6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b8cb71bf-1246-4fe4-9374-af7db5aed1ab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c9231007-fd12-42ae-a2d6-bd9294e3e766"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ca6a0802-86c2-4857-a2da-be1cbcd88f03"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d2287672-40ca-4f09-9de3-a121ccb51bc2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d76f2088-58a2-4151-a31f-251029d9ee30"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("dabcf7dd-9a54-48fa-aa31-6b68f8dac382"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e84d79d8-cc7e-4b98-9cba-7d7fe96ffce4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f7781238-569c-44d2-a64a-5c6b9736ecfe"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f83defd1-3b80-4114-8dde-ac31e99ba9be"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("3c3f4080-695b-4cf7-96b2-c8b23b0ba152"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("7776f4dc-859c-48ee-bd8a-439f3dbc34b6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f2e83ebe-aa89-47b7-ad77-63f51f617c6a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0498536a-6d62-4fcf-95d8-b2d472b98996"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("12364c11-1b08-4d93-9abf-0d5a2524cf06"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("180710aa-772b-44fb-971d-dfc0fb3c5017"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1e102d81-dba2-4790-a89f-9ffcbde777ac"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3486f369-d661-4fac-972d-8f01b51adc22"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("36810eb2-c8a1-4036-a90b-b9ff79c89e95"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("414ceeaa-f153-4296-9441-fc20bbae509e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("754f8ceb-0bbd-4e76-88a5-f34731802959"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("761abdc4-9168-4f35-9422-b8a73eb57eda"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("82b6e5d3-acad-4c8c-ada2-b1479f89fcfb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("88523520-8020-407d-8080-b3920c2da18e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9077b86b-d30d-4759-b9ad-aaafebcdfa89"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a67fb92f-806c-43ea-9339-eb301638d750"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a74cf6f5-016e-4e63-af10-a52d01b846ab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b0ca9e53-da61-416b-b046-c3af653d8ee4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b17ca606-1cca-45e3-8296-9307595b83e4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b2e2511f-2e52-489b-8ce1-c11b32995f08"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("be03e597-f466-4a8c-8c58-b4003890d686"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c90bf591-ab18-4a2f-b35c-030dec4bdde0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ceb5d59b-8ba8-45aa-915b-bb6941e64c9a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("da3582f1-13c6-4c71-a7c2-a296200dcf2d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("df0b572e-61a9-4e63-8f5e-878e81354b09"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("2f1f190e-fcca-4b2f-b37e-c5c7f6524882"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("7992b767-e38e-4c88-b9c0-bbc08274a58e"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("f0a121f2-e103-47a9-ac56-5c6aab1744db"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("16c8706f-5a69-4391-816d-3c4e67496926"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("19018968-b46d-442e-9ced-25219f7c4c96"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("32969a75-0b30-4492-9511-6b64a040536a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("53b3cc02-38ff-4c2f-8775-72c94fc17714"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("64ed43ac-e680-4053-ab39-83920cbad76d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6bbb36dc-7da9-47a4-a337-728089689a8f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9685bcee-86a4-466e-974d-1dbe004ed16c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9698c8a6-38c8-44a2-896b-10453d8b8ffb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("99cc25c5-564c-49cf-bbbf-c1225915782b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("99d37e20-0121-4328-8499-6180dc951168"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9cc5a663-236c-48de-8303-2e8bbac2eb4c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a56c90cb-cc75-46e4-88ea-75bc8e9c8181"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("acd25e60-ab87-45f0-86b0-0fc9998e6ca8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b1f07851-4414-4a17-80f0-a2422f9f6fcd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b61d8c6a-3576-4236-9089-deecd8e3daad"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b8e28b64-95bf-4c2e-a423-ab8867b74755"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c4301d59-0ffa-4e4e-9bf9-9ad3a62fa514"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("caefb70a-4876-4761-ba50-8480811fed84"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d0c07e7e-a9da-4cf2-928c-6041195fe43e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d72616f6-72dd-404d-83f8-935563f952b8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("dc39de64-bace-4414-b45e-c66badf89626"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ded99cf2-b06c-4c3d-b25e-9077699e7abf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("476104fe-3136-4df5-8420-9698b62169bb"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("27a4d08c-7857-4189-856e-0d5a222c7f06"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("84e63763-c4a4-4f96-ac35-7f8e7f7399c8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("011796e3-ba18-4069-b060-746183615d98"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0926895a-0438-45f3-b538-a2c56a746b45"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("12696dc5-1aeb-460d-b972-fdac9fbdc58c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("152d5134-a3ef-40f4-9bf2-c250cdafbe89"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1e708230-51a6-44ec-bdae-9f808d95977f"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("26f9bfbb-e8f6-4e78-85f4-01fa90e7d8a7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3dea9c07-3ab8-4e94-b5d5-39caf86b1831"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3e0dc115-78bb-4815-9b65-a3607fa25aa0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5462b482-7106-41e0-8c48-5e3dd480d44c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6c036cf9-f490-4ff7-b095-a0693076e941"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("6ca9bb92-c0c0-49fe-a663-4172de75044e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("72b1e21a-3dc6-480a-b80a-30b77965fef1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("83093f4b-bf92-4ec4-b67f-7a0a50e7c299"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8df6ad74-e4b0-4102-b549-1f1f4ff254e7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b6f10169-2eec-41a9-bc97-89501db73b8c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b7e19874-b6f4-4fe1-8750-3ae9fcd15935"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ba8ced89-bd7f-4007-8684-9d6694a5fd1e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c6c71232-ccac-4cea-83dd-e39f36744c76"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("de25be93-7838-4fb2-97f9-ff081b7510e1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e1b39dfe-91bc-4c5f-b26b-9d1aae8b4e7b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ea2c3953-36a0-479f-b552-b367aa1e157e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ec9e1129-2b4c-4b1b-9a23-3bbdc12ba302"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("40a48f66-7faf-47c7-9ab6-14bc2c7ae7e6"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("d687793c-7785-4978-91bc-af41c966bb4e"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, null, null, null, null, new DateTime(2021, 3, 6, 16, 0, 52, 663, DateTimeKind.Local).AddTicks(1668), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(4669), true, false, "Administradores", new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("ec48c1ec-c601-41e9-971c-4648b6a449d2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2634), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("9ff83155-67e8-4be1-96c9-dea9e9fe3eb1"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2543), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("2fed3648-4b7b-4e57-b535-4c342998d2c1"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2476), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("bf33c25b-3012-477b-a112-c2c06b4379a2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2395), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("a7b06f99-f01a-4c57-a95f-0f83c00703b3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2306), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("64a55d82-31a5-4e69-9c1c-82e7edc527c3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2213), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("095c4ea9-de48-4856-9650-772334833a99"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("06b6ca61-b538-4027-ad8e-4044c3aff455"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2031), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("66f432e3-836f-4a36-be77-d91648021afb"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("1ff65062-cd81-40d4-a9a2-118b7cf22981"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1945), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("f26501c1-10ab-437b-a638-87633c9f877c"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1862), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("ead8cf04-1e04-4940-8cf5-ce441bd3a07b"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1773), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("e7271a40-44fb-463e-90ed-dea28dcd12a3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1725), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("98d8d0dd-5ddd-48f7-8acb-3b12e4ceb481"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1644), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("1eb1037e-7123-4b85-9c9b-c012794f75e6"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1558), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("c76fed81-a3c6-4de9-b3df-aa6ec03bc143"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1481), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("e94e3fad-98b8-461e-8c79-07aca68017b2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1396), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("7cabd423-e5f5-43ef-9abe-dea2cc91ff2f"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1319), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("7034bee1-e58f-4b6d-8a8a-068e4d64fe82"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1222), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("e8d9bc71-3779-4036-8b3b-27e9353909d5"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1125), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("4f231292-2273-4873-85fe-62765fd891f0"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("02c94584-5e83-4190-9649-193020a2b0d2"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(1043), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("46e4c471-3543-4e26-9ab8-52f692b92f83"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(925), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("58f2b4fa-4d8e-4d92-9719-ec36b124e1de"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(61), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("1c7358cc-f643-4b69-9b94-397690948112"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null },
                    { new Guid("daf2c116-3a14-4cfa-82bd-9573174f46d3"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 674, DateTimeKind.Local).AddTicks(2718), new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), true, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("8b1f91d0-fab4-4063-a118-37a20c36eeb5"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(2254), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e3f315aa-0c70-417d-ace7-09a4c92914f5"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(1942), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0c60c192-6e89-4216-8347-bb31bcd389f8"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 6, 16, 0, 52, 669, DateTimeKind.Local).AddTicks(6629), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(3030), null, "", true, false, "groupusers/details", new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2947), null, "", true, false, "groupusers/list", new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2868), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2788), null, "", true, false, "systems/details", new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2706), null, "", true, false, "systems/list", new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2600), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("095c4ea9-de48-4856-9650-772334833a99"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2491), null, "", true, false, "languages/details", new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("66f432e3-836f-4a36-be77-d91648021afb"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(1922), null, "", true, false, "languages/list", new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(990), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(822), null, "", true, false, "clients/details", new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(663), null, "", true, false, "clients/list", new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(338), null, "", true, false, "menus/details", new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(148), null, "", true, false, "menus/list", new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9890), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9665), null, "", true, false, "users/details", new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(8109), null, "", true, false, "users/list", new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(7315), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f231292-2273-4873-85fe-62765fd891f0"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6456), null, "", true, false, "companyoperators/details", new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6282), null, "", true, false, "companyoperators/list", new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(5967), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1c7358cc-f643-4b69-9b94-397690948112"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(1318), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(500), null, "", true, false, "", new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 6, 16, 0, 52, 668, DateTimeKind.Local).AddTicks(5874), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("67969798-295c-47cb-9410-cad71472099a"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(2336), true, true, false, new Guid("8b1f91d0-fab4-4063-a118-37a20c36eeb5"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null },
                    { new Guid("b571b431-1a84-49df-81f9-6dbccaf2024a"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(1494), true, true, false, new Guid("0c60c192-6e89-4216-8347-bb31bcd389f8"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null },
                    { new Guid("8a3e2184-4915-467e-8642-41ad23140238"), null, new DateTime(2021, 3, 6, 16, 0, 52, 670, DateTimeKind.Local).AddTicks(2153), true, true, false, new Guid("e3f315aa-0c70-417d-ace7-09a4c92914f5"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("d26b7278-6fa2-475a-af3a-2ebfcb6a1f62"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2650), null, true, false, new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("78859365-6655-44e3-a2cb-e93188c5d435"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2984), null, true, false, new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("738d340a-1c0b-4954-a582-82246b4853fc"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2905), null, true, false, new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24778eb9-40d3-4ea6-b0d7-eb7b50bff7f5"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2827), null, true, false, new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef6b6148-074a-49a1-9f29-b37c0382039f"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2745), null, true, false, new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6384ae32-0ef5-40a4-a941-93b263903192"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2548), null, true, false, new Guid("095c4ea9-de48-4856-9650-772334833a99"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ff4d5bd-f7b8-4e8f-82be-4be7e9cf713b"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(2242), null, true, false, new Guid("66f432e3-836f-4a36-be77-d91648021afb"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a37a55e-6018-47ec-b3ab-0d8b335f82cf"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(1066), null, true, false, new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bf65963a-c4b1-4bd5-93ba-cc8aee73008e"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(902), null, true, false, new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ca6e9eb-da27-40a2-a320-8f71caa844e8"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(743), null, true, false, new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee7a9947-b675-4b14-a7f6-b57216076126"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(579), null, true, false, new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1fdd00c6-3a1b-4b70-9e50-a7ab765671a7"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(421), null, true, false, new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bb1deb70-05f3-4379-86c1-88aeee70becc"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(242), null, true, false, new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ba22f94-d7c5-4e98-a807-b0ba8b27c112"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9971), null, true, false, new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c25343c4-83a2-461f-a8f5-e03d23031d0a"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9788), null, true, false, new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f973b7f4-9dae-4243-82e6-e80b1786f967"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(9375), null, true, false, new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("43b9a30d-59eb-4651-b776-e3b1cd52b6fa"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(8002), null, true, false, new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3cb110d6-6020-4b4a-bc33-524d9b2015f2"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6533), null, true, false, new Guid("4f231292-2273-4873-85fe-62765fd891f0"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4430e88d-d267-48b9-9b0c-e6a722fd8553"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6366), null, true, false, new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("800b314d-6cfa-4183-b70c-cde5c9e1d6b0"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(6166), null, true, false, new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("58d2a224-299d-453e-ab7b-7026fe560fad"), null, new DateTime(2021, 3, 6, 16, 0, 52, 671, DateTimeKind.Local).AddTicks(4651), null, true, false, new Guid("1c7358cc-f643-4b69-9b94-397690948112"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3749f04a-2b39-4bce-a3bd-4f9cb4fd3aad"), null, new DateTime(2021, 3, 6, 16, 0, 52, 672, DateTimeKind.Local).AddTicks(3245), null, true, false, new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"), null, new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, null, null, new DateTime(2021, 3, 6, 16, 0, 52, 676, DateTimeKind.Local).AddTicks(7567), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("92b38245-12e7-4bf5-a1dd-8b65da81971a"), null, null, new DateTime(2021, 3, 6, 16, 0, 52, 677, DateTimeKind.Local).AddTicks(1940), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297"), new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, new DateTime(2021, 3, 6, 16, 0, 52, 677, DateTimeKind.Local).AddTicks(7632), null, new Guid("7d81e97b-605d-4056-b5bb-d1a7bc105f70"), true, false, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), new Guid("d17cb9a1-bd87-4f26-bb18-f7f3572b6e3a"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("6a811ce7-d453-4a5f-868c-273898071912"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9647), null, true, false, new Guid("d2c47872-ac64-4571-a11e-84eb8531f620"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("8359c908-bfc8-4549-b0eb-3a45815cf53a"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9607), null, true, false, new Guid("2ea1b2f5-4ae0-45b3-abe0-a3c9ebf7ac12"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("fdd9ea1b-5e7c-434e-89e3-62db71e00d71"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9505), null, true, false, new Guid("0711edf6-d497-4835-92ca-ab2ae2bbdca0"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("a57254ad-34c0-4ecb-87f8-2c5a7e6d3177"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9467), null, true, false, new Guid("d227929b-80cf-4854-9762-0892c5e934fd"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("582faaf1-9c85-432c-b3c6-0d6480025a57"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9425), null, true, false, new Guid("ddfdf983-28d9-4bc3-80b6-49760b0563d8"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("a805f0c3-2f69-435c-99ac-2ffdda312655"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9388), null, true, false, new Guid("095c4ea9-de48-4856-9650-772334833a99"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("1c770ab8-79e4-4346-b89d-e31ff9539236"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9352), null, true, false, new Guid("66f432e3-836f-4a36-be77-d91648021afb"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("5a5be487-2237-4213-8ef0-4d32c9d0cc97"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9315), null, true, false, new Guid("9fa72b05-a78f-4133-9d6c-d489fcf7cabd"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("2258c20b-7252-4f16-8063-d4d1ecdea58f"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9273), null, true, false, new Guid("244bba94-a296-4c91-b855-5924b11c80b5"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("69856507-1ad4-4b57-bf1c-cac633fa38fe"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9238), null, true, false, new Guid("f97abc89-1c9b-403d-9bcf-f1e228656ef8"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("7572f4d8-edbf-4a64-a3e8-5943444de904"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9684), null, true, false, new Guid("780dd1a7-4823-488a-9cfa-39a7d61f626c"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("e9804be2-13d3-4fae-8e2f-1ea364a8be82"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9166), null, true, false, new Guid("ee55338b-a632-4f2e-91d0-00cc85b84beb"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("2eb138e7-1cbd-4f88-b2c7-9e3f3357c629"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9121), null, true, false, new Guid("ea499a11-42d2-4bec-b0f3-e8be15b5f67e"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("4d7cac32-9391-4b16-888e-1b554958380b"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9082), null, true, false, new Guid("0cbc6e68-022f-4301-8096-9f162ff6b180"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("69e8a936-d00a-4af2-b36f-2387c6ec30a4"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9040), null, true, false, new Guid("c4fa29a8-c268-423c-83be-0bad4453e8f4"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("d7a548d8-7960-4b22-b49f-338c054ef3da"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(8953), null, true, false, new Guid("7b221794-199c-4c93-bb86-d21b2fec7455"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("c4a1fff1-49c2-459e-b5e3-ff4606663b0c"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(8566), null, true, false, new Guid("8da8e2c9-337a-49a1-8929-a9bdded121da"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("271190a6-19d0-4d57-ac90-8e3d9f545b5c"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(7982), null, true, false, new Guid("4f231292-2273-4873-85fe-62765fd891f0"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("61637a4e-8330-4d9b-aebd-47a6de764961"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(5660), null, true, false, new Guid("1259a8d0-a9b0-4a65-9c4e-62dc6d044545"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("4ee892be-4260-4131-8cb6-3271f28f1482"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(4817), null, true, false, new Guid("0a34160d-2c91-42d3-ac12-4980c24f6b3f"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("28c5961a-868f-4976-ada7-d647bd801459"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(4242), null, true, false, new Guid("1c7358cc-f643-4b69-9b94-397690948112"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") },
                    { new Guid("a4668510-a86c-499b-88c0-d9745f2a71ff"), true, true, null, new DateTime(2021, 3, 6, 16, 0, 52, 678, DateTimeKind.Local).AddTicks(9203), null, true, false, new Guid("403941cf-2b60-406b-a97e-bd755fdf45ad"), true, true, null, null, null, new Guid("503db23d-1e1a-44c2-bb2b-bdf8a238e297") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("40b98801-8ca6-49f9-aa60-f04ed709bb98"), "usuário administrativo", null, new DateTime(2021, 3, 6, 16, 0, 52, 676, DateTimeKind.Local).AddTicks(3030), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("3b38e6c9-6daa-4156-89a2-e548757dcf4a"), new Guid("c0bff6ae-0572-4c98-a5be-6e2dd6133fdf"), null, new DateTime(2021, 3, 6, 16, 0, 52, 669, DateTimeKind.Local).AddTicks(311), null, true, false, new Guid("c2bbed0e-0b29-4bf1-87d4-85349e69529b"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
