using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("79aa661f-8295-44ff-8907-5035e8a224eb"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("064a7434-28d8-4697-a9e7-52ab22c01f16"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1848adbe-0e45-44fd-a4b7-1cf7cd669843"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("19dd981c-3c7e-47a4-9d68-db5a47f5d52f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2eb562e6-c21e-4326-bbba-15196cdb4540"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2f465dfe-3a6c-406e-a405-2113b2aa11a4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("33404e06-3426-4c5c-8f26-bc6c93c9bfd6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("345670d9-088f-4438-9792-87ab3c8d5e32"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3bc4dba6-dc6e-40a4-b9c0-d298354da918"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4123d725-6c83-474c-8a0f-19cb2caad5a9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("51585175-d0e0-4246-9263-e3cdf278f766"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5b88d341-a20c-4b79-9df8-6eb966cd7e3e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("69fe413b-c40b-43df-a5c9-8313a885a736"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6a06ba84-557a-42f0-a323-ff486966ae38"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7904522d-f9ca-4735-9495-aec66a31ff7d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8fb18f8b-c07a-4399-9ced-0630644318b5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9ed3c04d-5056-41da-9b35-1b2e93a29d41"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a5c82b2c-c369-4f87-8e58-3e1e386392d2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b27ff508-2c0d-453c-9b3c-63688388759f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c3b2dd53-a49c-4772-81c0-b47fe7ba49e8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c3b9095e-fe10-4648-b4c5-6cf145e0e7d2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e0d70980-c014-4f54-9676-71bccf1009ab"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f9bf76a4-3d22-4aff-bec6-4e8ea0729b2f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5349fff1-bf54-46ed-a5f4-36406f6a7ef5"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9cd3f2a6-7af4-451e-bc2f-c4742ed407cf"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b2df024f-08f3-4c1d-a290-913477944a28"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2719eae5-4ad5-4c99-af55-28198485502f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3da018f3-d91f-49f1-af95-415be4305329"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("55de40d5-958f-4e81-934a-8757a088343a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a86139fd-8f06-4088-92cb-192eba775d42"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e00e9432-231b-401f-a031-745ac31cb733"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("716c7e89-b5b2-42d5-aab2-c0841ca039ba"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("82629ade-64e4-4c27-b24c-fc225bf30a5a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("97667267-f8e8-4cbc-acab-38aa9ceb8017"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0dd69290-06a5-49cd-96ae-3f3a687c2c08"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0e77bff5-18a0-4dbf-bd2f-0f3847f80eed"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0ee387c0-c8b5-4dc1-a020-e00ab6ef9354"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1d20d558-2c89-4932-82ce-636c902a74fd"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("24b1764f-5c54-405f-af3a-07e81a640b00"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("462cf482-a45b-4fd5-b296-6d41cf868855"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5c65b4d8-7819-403d-8505-3b7b9a1deb07"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("678ec6f0-f33d-4006-b4ac-9e656dccaf38"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6bb1852f-420a-4303-868e-0004b192c9c0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6cb4f341-c29b-4703-b6c5-2ae508b96f89"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("730c9a29-211b-42cc-a72c-b508c7cdd873"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("84dcdab6-cb3e-4d65-af96-c872005bdd1d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("873cac77-417d-4183-935e-ced1bf979bf8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("921d94d4-9fdc-43d8-8f71-38d1f1349d7e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("93ed5480-e4cd-4743-b431-d1772900fd05"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9ceae6a7-6041-442f-9e41-7838a728eb8e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b676dd5a-b94f-48c1-951f-eb06dce438cb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b6f0f2b5-3f1e-43a1-b1f9-0146337e5d8c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c3cb66c7-dbef-4b20-8187-a7b84b2838ef"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d7c9afa5-4936-45f4-9846-8d77e4d0a050"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ef57f52e-692a-41a7-b9be-8f9293564942"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f892c909-f996-41bf-94f5-0e7429ffc329"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a2758512-8943-422c-a4e7-b330e063b83d"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("de433980-6f0a-4016-a49c-c98c911233ac"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("113c8551-7fb3-454d-aadd-16719b82539d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("13eb6098-a63f-467c-9e6b-026f04580b73"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("265d075e-8119-4686-b6d5-47d4dd6107ed"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3e4e869e-a195-46e5-85b0-fc313a474895"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4c3f245c-e26a-435a-b096-8d4099de98a3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5d4e1d7c-0d0b-4983-95a3-1387c235000a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("708b7b5a-7878-4a8d-be79-8258a1dbdc75"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("89936aa7-5b67-4226-a43f-add7b62312dd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8bae82f2-5f7a-48a1-84cf-a1f807f6bfa2"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("91d5199a-ea15-44ae-882f-14047f06cee7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("99be9aba-343b-450e-be7a-f6722cdcf32a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("9e378bac-05f9-45af-b306-997ad0793ec5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a2dec382-34f2-457e-83d5-ab1c2a7eb872"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ac408a23-6ff2-4994-a473-c3d45bd94fa3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("aceb1a9b-3040-4704-bf84-9855e42f4940"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b426c52e-ffb1-4ecc-afad-f6b2bf596f6b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c17ded48-12c0-486c-8e44-9ed85f250293"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c98fa626-2e3f-4c41-8155-40db09f10d3e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("db07b235-05a5-4866-8a0b-b3b01c7c87ca"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("dc06614a-5299-4463-a049-dc02923d9a3c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("eca942b4-f1d3-4bac-8321-e2e87fb00327"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ff23db77-1308-478c-93b5-a5752c476f3e"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("2a517ce9-439d-4c22-a716-c4961352169a"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"));

            migrationBuilder.AlterColumn<string>(
                name: "smtpUser",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "smtpServer",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "smtpPort",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "smtpPass",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBasePassword",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBaseName",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBaseLogin",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBaseIP",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccessPort",
                table: "ClientsConfigurations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    BannerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Page = table.Column<string>(type: "varchar(200)", nullable: true),
                    Position = table.Column<string>(type: "varchar(200)", nullable: true),
                    DtStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                    table.PrimaryKey("PK_Banners", x => x.BannerId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Url = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "varchar(200)", nullable: true),
                    CategoryParentId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Code = table.Column<string>(type: "varchar(200)", nullable: true),
                    Value = table.Column<string>(type: "varchar(200)", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    DtStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Logo = table.Column<string>(type: "varchar(200)", nullable: true),
                    LogoIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    PhoneNumberIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    Site = table.Column<string>(type: "varchar(200)", nullable: true),
                    SiteIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    EmailIsVisible = table.Column<bool>(type: "boolean", nullable: false),
                    AddressIsVisible = table.Column<bool>(type: "boolean", nullable: false),
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
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersBanners",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    BannerId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_CustomersBanners", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersCoupons",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CouponId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_CustomersCoupons", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersEvents",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_CustomersEvents", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersSalePlans",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    SalePlanId = table.Column<Guid>(type: "uuid", nullable: false),
                    DtStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                    table.PrimaryKey("PK_CustomersSalePlans", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomersSocialMedias",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    SocialMediaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "varchar(500)", nullable: true),
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
                    table.PrimaryKey("PK_CustomersSocialMedias", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uuid", nullable: false),
                    Titel = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Place = table.Column<string>(type: "varchar(500)", nullable: true),
                    DtStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DtEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                    table.PrimaryKey("PK_Events", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "EventsSocialMedias",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    SocialMediaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "varchar(500)", nullable: true),
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
                    table.PrimaryKey("PK_EventsSocialMedias", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "SalePlans",
                columns: table => new
                {
                    SalePlanId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    DurationMounth = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
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
                    table.PrimaryKey("PK_SalePlans", x => x.SalePlanId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "varchar(200)", nullable: true),
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
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CustomersBanners");

            migrationBuilder.DropTable(
                name: "CustomersCoupons");

            migrationBuilder.DropTable(
                name: "CustomersEvents");

            migrationBuilder.DropTable(
                name: "CustomersSalePlans");

            migrationBuilder.DropTable(
                name: "CustomersSocialMedias");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventsSocialMedias");

            migrationBuilder.DropTable(
                name: "SalePlans");

            migrationBuilder.DropTable(
                name: "SocialMedias");

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

            migrationBuilder.AlterColumn<string>(
                name: "smtpUser",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "smtpServer",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "smtpPort",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "smtpPass",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBasePassword",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBaseName",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBaseLogin",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataBaseIP",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccessPort",
                table: "ClientsConfigurations",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, null, null, null, null, new DateTime(2021, 2, 1, 15, 53, 13, 718, DateTimeKind.Local).AddTicks(3002), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(6740), true, false, "Administradores", new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("e0d70980-c014-4f54-9676-71bccf1009ab"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4918), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("7904522d-f9ca-4735-9495-aec66a31ff7d"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4880), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("2eb562e6-c21e-4326-bbba-15196cdb4540"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4862), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("1848adbe-0e45-44fd-a4b7-1cf7cd669843"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4845), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("8fb18f8b-c07a-4399-9ced-0630644318b5"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4826), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("33404e06-3426-4c5c-8f26-bc6c93c9bfd6"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4807), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("55de40d5-958f-4e81-934a-8757a088343a"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("c3b9095e-fe10-4648-b4c5-6cf145e0e7d2"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4789), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("2f465dfe-3a6c-406e-a405-2113b2aa11a4"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4772), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("19dd981c-3c7e-47a4-9d68-db5a47f5d52f"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4754), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("064a7434-28d8-4697-a9e7-52ab22c01f16"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4737), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("6a06ba84-557a-42f0-a323-ff486966ae38"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4720), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("c3b2dd53-a49c-4772-81c0-b47fe7ba49e8"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4702), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("345670d9-088f-4438-9792-87ab3c8d5e32"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4683), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("51585175-d0e0-4246-9263-e3cdf278f766"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4661), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("9ed3c04d-5056-41da-9b35-1b2e93a29d41"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4644), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("3da018f3-d91f-49f1-af95-415be4305329"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("a5c82b2c-c369-4f87-8e58-3e1e386392d2"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4626), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("e00e9432-231b-401f-a031-745ac31cb733"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("5b88d341-a20c-4b79-9df8-6eb966cd7e3e"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4605), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("4123d725-6c83-474c-8a0f-19cb2caad5a9"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4558), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("3bc4dba6-dc6e-40a4-b9c0-d298354da918"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4540), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("f9bf76a4-3d22-4aff-bec6-4e8ea0729b2f"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4518), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("69fe413b-c40b-43df-a5c9-8313a885a736"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4314), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null },
                    { new Guid("b27ff508-2c0d-453c-9b3c-63688388759f"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(4936), new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), true, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("9cd3f2a6-7af4-451e-bc2f-c4742ed407cf"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5689), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b2df024f-08f3-4c1d-a290-913477944a28"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5604), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5349fff1-bf54-46ed-a5f4-36406f6a7ef5"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(3628), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1771), null, "", true, false, "groupusers/details", new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1735), null, "", true, false, "groupusers/list", new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1699), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1663), null, "", true, false, "systems/details", new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1625), null, "", true, false, "systems/list", new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1566), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("55de40d5-958f-4e81-934a-8757a088343a"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1528), null, "", true, false, "languages/details", new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1492), null, "", true, false, "languages/list", new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1454), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1418), null, "", true, false, "clients/details", new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1381), null, "", true, false, "clients/list", new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1282), null, "", true, false, "menus/details", new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1243), null, "", true, false, "menus/list", new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1206), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3da018f3-d91f-49f1-af95-415be4305329"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1170), null, "", true, false, "users/details", new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e00e9432-231b-401f-a031-745ac31cb733"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1130), null, "", true, false, "users/list", new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1090), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(997), null, "", true, false, "companyoperators/details", new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(930), null, "", true, false, "companyoperators/list", new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(852), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(9119), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1344), null, "", true, false, "", new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 1, 15, 53, 13, 719, DateTimeKind.Local).AddTicks(9716), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("82629ade-64e4-4c27-b24c-fc225bf30a5a"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5708), true, true, false, new Guid("9cd3f2a6-7af4-451e-bc2f-c4742ed407cf"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null },
                    { new Guid("716c7e89-b5b2-42d5-aab2-c0841ca039ba"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5409), true, true, false, new Guid("5349fff1-bf54-46ed-a5f4-36406f6a7ef5"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null },
                    { new Guid("97667267-f8e8-4cbc-acab-38aa9ceb8017"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(5668), true, true, false, new Guid("b2df024f-08f3-4c1d-a290-913477944a28"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("0dd69290-06a5-49cd-96ae-3f3a687c2c08"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1604), null, true, false, new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5c65b4d8-7819-403d-8505-3b7b9a1deb07"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1753), null, true, false, new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("84dcdab6-cb3e-4d65-af96-c872005bdd1d"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1717), null, true, false, new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("921d94d4-9fdc-43d8-8f71-38d1f1349d7e"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1681), null, true, false, new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("93ed5480-e4cd-4743-b431-d1772900fd05"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1642), null, true, false, new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("462cf482-a45b-4fd5-b296-6d41cf868855"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1546), null, true, false, new Guid("55de40d5-958f-4e81-934a-8757a088343a"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d7c9afa5-4936-45f4-9846-8d77e4d0a050"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1510), null, true, false, new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6bb1852f-420a-4303-868e-0004b192c9c0"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1472), null, true, false, new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("678ec6f0-f33d-4006-b4ac-9e656dccaf38"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1436), null, true, false, new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c3cb66c7-dbef-4b20-8187-a7b84b2838ef"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1399), null, true, false, new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b6f0f2b5-3f1e-43a1-b1f9-0146337e5d8c"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1362), null, true, false, new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24b1764f-5c54-405f-af3a-07e81a640b00"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1299), null, true, false, new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ef57f52e-692a-41a7-b9be-8f9293564942"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1262), null, true, false, new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b676dd5a-b94f-48c1-951f-eb06dce438cb"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1223), null, true, false, new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("730c9a29-211b-42cc-a72c-b508c7cdd873"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1187), null, true, false, new Guid("3da018f3-d91f-49f1-af95-415be4305329"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6cb4f341-c29b-4703-b6c5-2ae508b96f89"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1148), null, true, false, new Guid("e00e9432-231b-401f-a031-745ac31cb733"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("873cac77-417d-4183-935e-ced1bf979bf8"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1110), null, true, false, new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f892c909-f996-41bf-94f5-0e7429ffc329"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1016), null, true, false, new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9ceae6a7-6041-442f-9e41-7838a728eb8e"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(948), null, true, false, new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0e77bff5-18a0-4dbf-bd2f-0f3847f80eed"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(899), null, true, false, new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1d20d558-2c89-4932-82ce-636c902a74fd"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(394), null, true, false, new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ee387c0-c8b5-4dc1-a020-e00ab6ef9354"), null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(1789), null, true, false, new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a2758512-8943-422c-a4e7-b330e063b83d"), null, new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, null, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(7441), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("de433980-6f0a-4016-a49c-c98c911233ac"), null, null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(8938), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("a2758512-8943-422c-a4e7-b330e063b83d"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8"), new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(965), null, new Guid("bc088fd7-e4ab-4908-8038-24bb63252b31"), true, false, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), new Guid("a2758512-8943-422c-a4e7-b330e063b83d"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("13eb6098-a63f-467c-9e6b-026f04580b73"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3672), null, true, false, new Guid("201810b9-0d6f-4d68-ba57-1427fcc916fa"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("dc06614a-5299-4463-a049-dc02923d9a3c"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3654), null, true, false, new Guid("98b041df-82a2-4000-9cf5-faba53a7a4a4"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("b426c52e-ffb1-4ecc-afad-f6b2bf596f6b"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3636), null, true, false, new Guid("193398b4-a6a2-446a-bf56-a179dbcb940f"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("eca942b4-f1d3-4bac-8321-e2e87fb00327"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3618), null, true, false, new Guid("2b9e329c-701e-4f0b-8cda-cbdd93295d7d"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("8bae82f2-5f7a-48a1-84cf-a1f807f6bfa2"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3599), null, true, false, new Guid("4e1d37fe-98f7-4adc-84a2-f8d3364b9823"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("91d5199a-ea15-44ae-882f-14047f06cee7"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3582), null, true, false, new Guid("55de40d5-958f-4e81-934a-8757a088343a"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("4c3f245c-e26a-435a-b096-8d4099de98a3"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3564), null, true, false, new Guid("10236f58-6b0c-4c98-a1f2-88752f838521"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("c98fa626-2e3f-4c41-8155-40db09f10d3e"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3544), null, true, false, new Guid("a86139fd-8f06-4088-92cb-192eba775d42"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("c17ded48-12c0-486c-8e44-9ed85f250293"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3526), null, true, false, new Guid("cc7c7f72-3489-4010-a966-9748d9d091e1"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("113c8551-7fb3-454d-aadd-16719b82539d"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3508), null, true, false, new Guid("2719eae5-4ad5-4c99-af55-28198485502f"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("99be9aba-343b-450e-be7a-f6722cdcf32a"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3689), null, true, false, new Guid("dab7e315-73d9-45ec-8a98-acecd662bab8"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("a2dec382-34f2-457e-83d5-ab1c2a7eb872"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3472), null, true, false, new Guid("59455475-488a-4edb-91c2-aa2ac937c8e9"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("5d4e1d7c-0d0b-4983-95a3-1387c235000a"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3424), null, true, false, new Guid("eba6f6a7-4603-43ef-b91f-f4dbe082f37c"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("3e4e869e-a195-46e5-85b0-fc313a474895"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3406), null, true, false, new Guid("f6ae5958-7fa4-4f16-89ef-bccdd7231d4f"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("9e378bac-05f9-45af-b306-997ad0793ec5"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3388), null, true, false, new Guid("3da018f3-d91f-49f1-af95-415be4305329"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("708b7b5a-7878-4a8d-be79-8258a1dbdc75"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3365), null, true, false, new Guid("e00e9432-231b-401f-a031-745ac31cb733"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("265d075e-8119-4686-b6d5-47d4dd6107ed"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3345), null, true, false, new Guid("fec00ccf-2f86-4016-b3e5-79cb7bb496c1"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("db07b235-05a5-4866-8a0b-b3b01c7c87ca"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3326), null, true, false, new Guid("77435198-23ff-4a2d-810a-2ff68a648f0c"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("89936aa7-5b67-4226-a43f-add7b62312dd"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3308), null, true, false, new Guid("d0f63e87-221a-40ef-83bc-1a5acab4c337"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("ff23db77-1308-478c-93b5-a5752c476f3e"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3285), null, true, false, new Guid("5b31c8fe-33cd-44eb-8da8-719f0224c206"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("aceb1a9b-3040-4704-bf84-9855e42f4940"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3098), null, true, false, new Guid("fc84a50c-8e04-4b5c-b793-deac99079c87"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") },
                    { new Guid("ac408a23-6ff2-4994-a473-c3d45bd94fa3"), true, true, null, new DateTime(2021, 2, 1, 15, 53, 13, 722, DateTimeKind.Local).AddTicks(3491), null, true, false, new Guid("5a3d63e3-02cd-4c59-a71a-cbe4b3601c3a"), true, true, null, null, null, new Guid("5213a642-6b64-4ddb-bed2-e70230c30ef8") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("2a517ce9-439d-4c22-a716-c4961352169a"), "usuário administrativo", null, new DateTime(2021, 2, 1, 15, 53, 13, 721, DateTimeKind.Local).AddTicks(5975), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("79aa661f-8295-44ff-8907-5035e8a224eb"), new Guid("37a8f659-bf71-4271-85c5-cd1447d37ef5"), null, new DateTime(2021, 2, 1, 15, 53, 13, 720, DateTimeKind.Local).AddTicks(1543), null, true, false, new Guid("5326b5cd-733c-472c-8ec4-e8f845a645a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
