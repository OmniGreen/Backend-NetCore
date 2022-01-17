using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("fc7427af-6f1a-4e0f-942e-f7181b6215e8"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("d27912af-92f0-44a6-b2dd-576c26237a2c"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("022a315c-f94f-44c7-a977-fdf33700967e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("09d1eda1-9b85-46c9-a517-896fe695d7d7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("21ac9a49-011f-4450-955e-847af4d615ae"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("43d18d99-0827-4242-8639-8ef6bbcdc4f4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("46db677c-d76b-4ef7-9484-387d5c64fdf9"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("47d9b37d-032d-4edd-9b90-97e8300ee7cd"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("50e2aa7a-ca1b-463f-accd-4dceddadc16b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6a09acec-cb08-4d3a-b5a1-61483d62e36e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("73e6c888-cf37-4ef3-ac95-bad46ec19c56"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7c869502-c858-4b90-8afa-334b0464d105"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("86bc47c4-073c-4a84-ace4-8fd252405e98"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8e24490a-5bb9-49ca-ba10-660b9db901a5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a0b367ba-ca11-4975-8181-0cfe2b428e0a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a591ecc9-8955-40e3-8649-a900860da367"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ac74dc6e-b520-40ea-bb13-58bd48f85157"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b46cbdfa-536c-41a8-a5f9-f593bc366b20"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c6cfb60b-04f9-45c4-877d-ca1e93249f32"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ca8492b8-eb1a-40a7-b14f-e5018e1c413a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("cc5f6171-60f5-4416-86fb-3d2e03ad09ff"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d61ea238-0468-41ae-ae7d-dc8e762ea73e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("dfa41bfd-ac69-414c-83f7-3ed796add2f1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e313b0fb-e334-44e0-923f-d47287074305"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2552bd03-122f-4c88-9af9-a0d566d11189"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4813be3e-9b80-4a91-af91-b42b419b200c"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ee28dbfe-258e-469c-979c-761c23a6dc83"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("275c6428-2f3d-4b3f-b130-212418eb291f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3b9d691f-85eb-49a7-b830-027c2bf67f3d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("44513a65-7ddc-4218-9e10-c989ecd401da"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("586a4afa-1b6e-466b-b28c-e847e2b0d192"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5978ef39-8c64-4c29-b9ad-c95b495ed31a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6d289362-8c5d-48cd-9965-a6fd45695c2d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6f27c060-6587-432a-98d3-f6bd75847900"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6f34d037-c384-40bd-aec1-b3489a7d6163"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("80c2f0a6-b71e-4554-883f-2b3a0dc46171"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("86abf1bf-83c6-4545-b4bd-120a0d0affbf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("879b48f2-992c-4f90-a8e8-322d303f8fa7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("897f2807-4b1f-4835-9036-5f4476ac9b60"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("8d3a8938-c892-4d24-a411-76a288b24f41"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ac57cf5f-30ba-474a-8bf7-707b65965c10"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("b34fc7cf-6317-4c03-b30c-d21d6e95c46b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d5fcc7fd-f6a4-4f84-b1b5-33503b824f50"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d7ba2129-e3b4-4d2b-a11e-63be859d7515"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d87d87ed-7500-4197-a153-f68804a8737e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d93bd64b-1d2c-4e05-9118-efb6aaa24c47"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("edc03da9-57db-494c-a47c-3fcc667f6798"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f8ecf0d5-90dd-4f47-866e-aac9314f9066"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("02fb80f4-0221-425c-a3b0-7992ab5e7f46"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("44f02a89-b54d-46b6-b5d6-2117a475f5cf"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("454c18ce-2e11-4355-8cad-4410732b0b19"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("07bb8f1f-1594-4f96-bc08-e3ae067b0043"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("09eddf66-75d4-4738-b1ef-d088044e232c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1af3786f-69ce-4a7d-91e2-1c5464031005"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("23431be8-0c43-4184-8de4-0926ff3119da"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("33a9698b-6035-4d90-9981-4a060820451b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3883f293-add4-48c1-a500-3f782c2453e3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3a1acfcd-b09d-44bc-ac10-1c65ed83e978"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5da1e63d-eef2-45ec-9c41-aabfeb2fe143"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6b85446b-f39c-4667-89ed-74d0332e9ad8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("832b23fc-87fd-44f4-a9d7-592fb200fe27"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8fc0dac8-9647-4fcb-a0b0-872c382f38b1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9f3f4aa7-ad2c-4b0c-afff-09a55b5ce68b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a292bf64-a919-4827-bca7-9d1c2a623529"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a943df7f-62fa-411f-b77f-808b026d9c48"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b83de1d3-aaff-47ab-8e70-c01e42c8316f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c364731d-7085-4794-8d88-e139c77d3c62"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d75298d4-bd1c-40ef-b243-b064e1cf4f7a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d78a655d-4ba7-4624-9786-5a9e00d87fd3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e64f5d0b-0f13-4d2d-9fe3-812842b162b5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("eb58dfc7-4e88-486c-b419-600d6b56fcbb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f9f87898-18e6-410d-8c10-0fa92b9b772f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("feb6655a-44a7-4372-8700-d9d22cc18f0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("42b104c5-4572-46b9-b332-1dc3560bcf8c"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("058af92d-7a17-4d6f-953e-4bfd72d2bec6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("26fe6ca8-baa8-4017-a267-68b70809eebe"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5589d003-d9fa-47ce-8ea7-db7aeb1343b0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5816c278-4877-404b-a14a-6d24ad26c2db"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5a6d87f6-c79a-4a04-9509-c968a15706ab"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5d5e539c-c8ce-4d50-982a-984448f9bfcb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7b6613ed-1e5d-4c1c-a3d6-a3a1b505657d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("892af626-3323-4f74-bf5d-b78d261450e5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("906c673d-5d52-43dd-83e0-f30bc7a8e25d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("90ebe343-4a0e-4712-ad7f-b439c144489b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("90fba701-de20-4b75-b07b-009200ad0433"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a4ea4076-cd67-4bfc-851b-66ea84aa8ac3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b949328d-d6ee-4cfd-936b-3b4f6de45556"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bdc73549-31de-414c-9869-4c83b4acce37"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cf9c7743-6800-441d-906c-98576e746b85"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("df07824e-02a8-4a4a-8a5d-53b92ec61b1c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e32711d1-31e8-41ce-9714-54fba748dc10"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e764e988-256d-4ec3-86c1-cea549ea5077"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e7e3347b-e435-43fb-813a-2445baa49095"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ed963397-57c7-47fb-81d1-314091fd7f36"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f0954b4f-8b0b-447c-adef-a536ce8d3dde"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f296cca8-ced7-4269-8caa-f57e767f2ba1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fc7ea080-56ed-49d7-9a6c-448409587596"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("763d0f15-eb25-4bcc-8b7a-f78b58ec4944"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"));

            migrationBuilder.AlterColumn<string>(
                name: "PaymentLink",
                table: "SalePlans",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("0208be56-5b6b-4e88-a7a8-97da7aafc76e"), null, null, null, null, null, new DateTime(2021, 5, 27, 10, 32, 28, 794, DateTimeKind.Local).AddTicks(6648), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), null, new DateTime(2021, 5, 27, 10, 32, 28, 798, DateTimeKind.Local).AddTicks(4065), true, false, "Administradores", new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("b71d2b8a-7d20-48a7-ac09-3a3a50f4af27"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(7099), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("93b75efb-7a88-4789-8710-7eeafd8a912a"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("d460af34-2787-4c26-939c-13ec557320e8"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(7042), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("6a03a186-495e-4cf2-9299-9b68eba6a60a"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("af3f18a0-572f-4bc7-91d4-fe1cfe5df72d"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(7021), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("4bd87bbd-b33d-4d6e-bc4a-e75c0ba78671"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("47bba3eb-1bf9-4cb2-b1df-812db8ffb89b"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(7000), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("1a09e7e2-65d7-4b53-83d0-c4a5ecff2314"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("fdbdba12-75cf-4ca4-8b67-b4f6b0b9e89b"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6978), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("e648fdd8-8040-4bb6-b821-09d5ae5e8ce0"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("5e91283f-c1d8-40db-89d1-60ee1e94024a"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6955), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("2c1c1669-fb35-422b-ae19-2f54917bcc21"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("847bbabe-8682-4827-94c3-d84d6c6c662f"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6935), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("204cb588-ea6f-4dd6-b36e-3c5cee2fdf47"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("75df804f-4d11-4087-9232-cbce3606680f"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6915), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("461c012f-9b60-44d0-9115-ec9a85bba909"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("f038132b-1807-4508-ac94-17aca093cecf"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6895), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("08b953f5-3028-4ca0-bedb-30a6dea7e2ab"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("43a0041c-58fb-4d8a-8ec1-990bb69334c3"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6874), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("4130943c-c45d-4e48-8235-bb85764a8f9b"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("ecd7c511-d3c7-4e8d-9d53-bba75c2effcb"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6854), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("5a2a7805-4696-490d-b2a9-df08131ccfc1"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("ced2c32b-942c-4f27-9985-14b680bddb73"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6833), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("6830fd96-6976-46e8-b1b1-e3dcd64b913b"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("2f8c49d3-b516-4bce-bcba-c43f45b32261"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6811), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("99e90691-50d3-442b-814a-0215a6501aee"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("1d1c18a1-6c1c-4bbc-960e-6a762a2f4514"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6785), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("91544a10-de10-4c72-81a2-a502a903ca8b"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("81ce6a4e-74fe-4555-a5f0-ee5bf94f4319"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6764), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("91061f19-dc61-45c4-aef2-4b6efdb40fca"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("49e85171-035a-4fda-bad4-03a2fb941082"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6743), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("6c594754-822a-4e5c-b1c8-f9d65b7cf8f6"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("82f8d7eb-440e-4293-9959-ecf06194e9ef"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6716), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("c89fe405-0ebd-495f-8e5e-816506e63f26"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("a4576414-771f-4b5b-9350-74606833bdf1"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6651), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("ece99b78-c53f-4bf8-97f2-2f810cbdaeb5"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("3c6edc20-cfad-49ec-885f-baec7a6a3d12"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6628), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("1f225379-968c-4812-97eb-0a4c98eea6f9"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("5ac2f310-cb97-4baf-9c18-87f16770feda"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6592), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("4fd73fed-b994-4236-b8e5-cb5a64f733c5"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("fbc8c6d2-5dfd-4bd8-ad23-f2b51a69047a"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(6261), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null },
                    { new Guid("8dec18b0-32a4-4043-a376-92b52e63a22e"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(7123), new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("96a11dbe-a48e-49fd-8f04-eac4bb15c221"), true, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("dee68e5b-73f7-458b-b4ce-2c7c2dfa1bb4"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 5, 27, 10, 32, 28, 798, DateTimeKind.Local).AddTicks(2552), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a521b6fd-0beb-4e27-86fe-c1ea0762d88e"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 5, 27, 10, 32, 28, 798, DateTimeKind.Local).AddTicks(2414), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6159131b-ea6a-4d87-9fe5-994b485904ce"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 5, 27, 10, 32, 28, 797, DateTimeKind.Local).AddTicks(9206), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("96a11dbe-a48e-49fd-8f04-eac4bb15c221"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1943), null, "", true, false, "groupusers/details", new Guid("6a03a186-495e-4cf2-9299-9b68eba6a60a"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("93b75efb-7a88-4789-8710-7eeafd8a912a"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1901), null, "", true, false, "groupusers/list", new Guid("6a03a186-495e-4cf2-9299-9b68eba6a60a"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6a03a186-495e-4cf2-9299-9b68eba6a60a"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1858), null, "", true, false, "", new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4bd87bbd-b33d-4d6e-bc4a-e75c0ba78671"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1815), null, "", true, false, "systems/details", new Guid("e648fdd8-8040-4bb6-b821-09d5ae5e8ce0"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1a09e7e2-65d7-4b53-83d0-c4a5ecff2314"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1768), null, "", true, false, "systems/list", new Guid("e648fdd8-8040-4bb6-b821-09d5ae5e8ce0"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e648fdd8-8040-4bb6-b821-09d5ae5e8ce0"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1680), null, "", true, false, "", new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2c1c1669-fb35-422b-ae19-2f54917bcc21"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1635), null, "", true, false, "languages/details", new Guid("461c012f-9b60-44d0-9115-ec9a85bba909"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("204cb588-ea6f-4dd6-b36e-3c5cee2fdf47"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1592), null, "", true, false, "languages/list", new Guid("461c012f-9b60-44d0-9115-ec9a85bba909"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("461c012f-9b60-44d0-9115-ec9a85bba909"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1546), null, "", true, false, "", new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("08b953f5-3028-4ca0-bedb-30a6dea7e2ab"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1503), null, "", true, false, "clients/details", new Guid("5a2a7805-4696-490d-b2a9-df08131ccfc1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4130943c-c45d-4e48-8235-bb85764a8f9b"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1458), null, "", true, false, "clients/list", new Guid("5a2a7805-4696-490d-b2a9-df08131ccfc1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6830fd96-6976-46e8-b1b1-e3dcd64b913b"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1326), null, "", true, false, "menus/details", new Guid("91544a10-de10-4c72-81a2-a502a903ca8b"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("99e90691-50d3-442b-814a-0215a6501aee"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1281), null, "", true, false, "menus/list", new Guid("91544a10-de10-4c72-81a2-a502a903ca8b"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("91544a10-de10-4c72-81a2-a502a903ca8b"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1237), null, "", true, false, "", new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("91061f19-dc61-45c4-aef2-4b6efdb40fca"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1194), null, "", true, false, "users/details", new Guid("c89fe405-0ebd-495f-8e5e-816506e63f26"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6c594754-822a-4e5c-b1c8-f9d65b7cf8f6"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1147), null, "", true, false, "users/list", new Guid("c89fe405-0ebd-495f-8e5e-816506e63f26"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c89fe405-0ebd-495f-8e5e-816506e63f26"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1097), null, "", true, false, "", new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ece99b78-c53f-4bf8-97f2-2f810cbdaeb5"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(916), null, "", true, false, "companyoperators/details", new Guid("4fd73fed-b994-4236-b8e5-cb5a64f733c5"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f225379-968c-4812-97eb-0a4c98eea6f9"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(872), null, "", true, false, "companyoperators/list", new Guid("4fd73fed-b994-4236-b8e5-cb5a64f733c5"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4fd73fed-b994-4236-b8e5-cb5a64f733c5"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(760), null, "", true, false, "", new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 5, 27, 10, 32, 28, 798, DateTimeKind.Local).AddTicks(8041), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5a2a7805-4696-490d-b2a9-df08131ccfc1"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1412), null, "", true, false, "", new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 5, 27, 10, 32, 28, 797, DateTimeKind.Local).AddTicks(2215), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("9811ca79-6c84-4787-a7a4-88fba9467603"), null, new DateTime(2021, 5, 27, 10, 32, 28, 798, DateTimeKind.Local).AddTicks(2576), true, true, false, new Guid("dee68e5b-73f7-458b-b4ce-2c7c2dfa1bb4"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, null },
                    { new Guid("90c17b35-c38e-40ed-a197-660fec3149c8"), null, new DateTime(2021, 5, 27, 10, 32, 28, 798, DateTimeKind.Local).AddTicks(2168), true, true, false, new Guid("6159131b-ea6a-4d87-9fe5-994b485904ce"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, null },
                    { new Guid("9a0b73e8-8e9d-44a9-89ab-86c4e3b7815f"), null, new DateTime(2021, 5, 27, 10, 32, 28, 798, DateTimeKind.Local).AddTicks(2523), true, true, false, new Guid("a521b6fd-0beb-4e27-86fe-c1ea0762d88e"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("24d0b784-5b7b-4b73-aaa3-824c8d8147e1"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1704), null, true, false, new Guid("e648fdd8-8040-4bb6-b821-09d5ae5e8ce0"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("cdfc2b46-9edd-4433-8ed1-f513993782bf"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1921), null, true, false, new Guid("93b75efb-7a88-4789-8710-7eeafd8a912a"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b9b872c9-d86a-48b5-98c5-96a4d6c78000"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1879), null, true, false, new Guid("6a03a186-495e-4cf2-9299-9b68eba6a60a"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6a912c08-e91a-4676-84cd-6b221866bfb2"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1835), null, true, false, new Guid("4bd87bbd-b33d-4d6e-bc4a-e75c0ba78671"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c1d83c3b-8878-4dac-8cae-bcd7c402215f"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1790), null, true, false, new Guid("1a09e7e2-65d7-4b53-83d0-c4a5ecff2314"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5b29e42e-8e7e-46c0-9a43-5951a9582b44"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1655), null, true, false, new Guid("2c1c1669-fb35-422b-ae19-2f54917bcc21"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("617f2355-2351-4b18-ac08-b1ae15c7a8a5"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1612), null, true, false, new Guid("204cb588-ea6f-4dd6-b36e-3c5cee2fdf47"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9d7a8034-a013-42c0-8e23-2ae0f051d896"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1567), null, true, false, new Guid("461c012f-9b60-44d0-9115-ec9a85bba909"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("803ded9d-29ca-46ea-abfa-a962df439a02"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1523), null, true, false, new Guid("08b953f5-3028-4ca0-bedb-30a6dea7e2ab"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2564408a-f87d-4ffe-b744-baf507029994"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1479), null, true, false, new Guid("4130943c-c45d-4e48-8235-bb85764a8f9b"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3af8f261-ba3e-4439-b1e4-baba9673b5d4"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1436), null, true, false, new Guid("5a2a7805-4696-490d-b2a9-df08131ccfc1"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5c14fba3-f75a-4c34-8a8a-465e584fd983"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1347), null, true, false, new Guid("6830fd96-6976-46e8-b1b1-e3dcd64b913b"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("993c7121-69fa-4a26-b396-81a6ce0ed15c"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1303), null, true, false, new Guid("99e90691-50d3-442b-814a-0215a6501aee"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("857b78ad-a558-4f7b-badc-67fd86859dc6"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1257), null, true, false, new Guid("91544a10-de10-4c72-81a2-a502a903ca8b"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bc2b33d6-fd60-4c22-96cf-fcb5aa558196"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1215), null, true, false, new Guid("91061f19-dc61-45c4-aef2-4b6efdb40fca"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9fd02706-0ab7-4a01-b680-af68d0e337cb"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1168), null, true, false, new Guid("6c594754-822a-4e5c-b1c8-f9d65b7cf8f6"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1995580e-9cbd-49e0-86ea-1612920fd123"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1122), null, true, false, new Guid("c89fe405-0ebd-495f-8e5e-816506e63f26"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("48e768f2-66e6-4c09-9c05-a6f0a0922f8c"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(989), null, true, false, new Guid("ece99b78-c53f-4bf8-97f2-2f810cbdaeb5"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("80530f47-17ed-46ed-83f8-472a03cc7fc2"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(894), null, true, false, new Guid("1f225379-968c-4812-97eb-0a4c98eea6f9"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e19057ee-56f4-4ff8-a769-5d1beb641731"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(828), null, true, false, new Guid("4fd73fed-b994-4236-b8e5-cb5a64f733c5"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("81376a9f-6a9f-4b81-8ddd-8510be11f902"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(67), null, true, false, new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5775bbce-7440-498b-9f5c-887e144f56d7"), null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(1963), null, true, false, new Guid("96a11dbe-a48e-49fd-8f04-eac4bb15c221"), new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("7200896c-391e-48d5-a7a2-f53a003a99c5"), null, new Guid("0208be56-5b6b-4e88-a7a8-97da7aafc76e"), null, null, null, new DateTime(2021, 5, 27, 10, 32, 28, 800, DateTimeKind.Local).AddTicks(714), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("abeb9339-f056-45c5-9257-c902212fa2dd"), null, null, new DateTime(2021, 5, 27, 10, 32, 28, 800, DateTimeKind.Local).AddTicks(3174), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("7200896c-391e-48d5-a7a2-f53a003a99c5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40"), new Guid("0208be56-5b6b-4e88-a7a8-97da7aafc76e"), null, new DateTime(2021, 5, 27, 10, 32, 28, 801, DateTimeKind.Local).AddTicks(6627), null, new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"), true, false, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), new Guid("7200896c-391e-48d5-a7a2-f53a003a99c5"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("0df3d495-cf7a-4a7b-8c3d-caf237e936a3"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(6133), null, true, false, new Guid("93b75efb-7a88-4789-8710-7eeafd8a912a"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("b96d9613-a473-4448-be61-e5c1790de541"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(6108), null, true, false, new Guid("6a03a186-495e-4cf2-9299-9b68eba6a60a"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("a31ca642-2d02-4732-beb8-087adcb2c62c"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(6080), null, true, false, new Guid("4bd87bbd-b33d-4d6e-bc4a-e75c0ba78671"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("639cc9c8-2845-4d06-83e3-6443ef87c806"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(6013), null, true, false, new Guid("1a09e7e2-65d7-4b53-83d0-c4a5ecff2314"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("d57b29d0-067f-46e1-b001-0ee3eba7481a"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5926), null, true, false, new Guid("e648fdd8-8040-4bb6-b821-09d5ae5e8ce0"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("784cd245-99fa-4f6f-ae8f-13ffde666831"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5884), null, true, false, new Guid("2c1c1669-fb35-422b-ae19-2f54917bcc21"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("74c531f3-bc72-4c17-a527-5ae5a13d0025"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5826), null, true, false, new Guid("204cb588-ea6f-4dd6-b36e-3c5cee2fdf47"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("1326ee1e-5f59-4b3d-9f1f-173f860cb379"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5728), null, true, false, new Guid("461c012f-9b60-44d0-9115-ec9a85bba909"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("fabb023d-5366-41f0-a93a-2a6227490b4a"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5659), null, true, false, new Guid("08b953f5-3028-4ca0-bedb-30a6dea7e2ab"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("ab1b3bf6-093f-4069-b8c7-7969c08952d9"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5619), null, true, false, new Guid("4130943c-c45d-4e48-8235-bb85764a8f9b"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("f33a1e5a-8255-4d2c-95df-165caee55236"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(6163), null, true, false, new Guid("96a11dbe-a48e-49fd-8f04-eac4bb15c221"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("4b59036b-4da8-4251-affa-44a9a7d28a48"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5513), null, true, false, new Guid("6830fd96-6976-46e8-b1b1-e3dcd64b913b"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("0b81e257-ce03-48a9-ad5d-c59222078600"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5361), null, true, false, new Guid("99e90691-50d3-442b-814a-0215a6501aee"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("e99095da-2d06-4b10-802b-768d64d32e73"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5329), null, true, false, new Guid("91544a10-de10-4c72-81a2-a502a903ca8b"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("df5c9659-2976-48f5-9e81-5829697b86a0"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5294), null, true, false, new Guid("91061f19-dc61-45c4-aef2-4b6efdb40fca"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("81aec9f4-e19a-4a88-ac60-1e8af1e8ae12"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5208), null, true, false, new Guid("6c594754-822a-4e5c-b1c8-f9d65b7cf8f6"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("cc322801-b7c4-413b-a4aa-6a262cb522aa"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5114), null, true, false, new Guid("c89fe405-0ebd-495f-8e5e-816506e63f26"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("f2054876-0c1e-44ff-922b-c4d82f5293a0"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5041), null, true, false, new Guid("ece99b78-c53f-4bf8-97f2-2f810cbdaeb5"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("532ceca1-fb14-4c13-bc8c-9ac27ad43c6b"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(4989), null, true, false, new Guid("1f225379-968c-4812-97eb-0a4c98eea6f9"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("458bb579-7ddb-4dd6-9e71-330c6fa333f1"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(4866), null, true, false, new Guid("4fd73fed-b994-4236-b8e5-cb5a64f733c5"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("35c59b4a-abcd-4cf0-8f2e-6e3c61508a28"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(4264), null, true, false, new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") },
                    { new Guid("56b60365-04da-4eae-b94e-c76b49e02605"), true, true, null, new DateTime(2021, 5, 27, 10, 32, 28, 802, DateTimeKind.Local).AddTicks(5574), null, true, false, new Guid("5a2a7805-4696-490d-b2a9-df08131ccfc1"), true, true, null, null, null, new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("9c53af9e-0c18-4d3d-9c42-95efdc99182d"), "usuário administrativo", null, new DateTime(2021, 5, 27, 10, 32, 28, 799, DateTimeKind.Local).AddTicks(8633), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("43530bd9-ffb5-4e6e-9dff-3c6f321a0935"), new Guid("0208be56-5b6b-4e88-a7a8-97da7aafc76e"), null, new DateTime(2021, 5, 27, 10, 32, 28, 797, DateTimeKind.Local).AddTicks(5516), null, true, false, new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("0208be56-5b6b-4e88-a7a8-97da7aafc76e"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("43530bd9-ffb5-4e6e-9dff-3c6f321a0935"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("c316cecb-8e21-4700-9ff6-b98e30551efb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("1d1c18a1-6c1c-4bbc-960e-6a762a2f4514"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2f8c49d3-b516-4bce-bcba-c43f45b32261"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3c6edc20-cfad-49ec-885f-baec7a6a3d12"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("43a0041c-58fb-4d8a-8ec1-990bb69334c3"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("47bba3eb-1bf9-4cb2-b1df-812db8ffb89b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("49e85171-035a-4fda-bad4-03a2fb941082"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ac2f310-cb97-4baf-9c18-87f16770feda"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5e91283f-c1d8-40db-89d1-60ee1e94024a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("75df804f-4d11-4087-9232-cbce3606680f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("81ce6a4e-74fe-4555-a5f0-ee5bf94f4319"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("82f8d7eb-440e-4293-9959-ecf06194e9ef"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("847bbabe-8682-4827-94c3-d84d6c6c662f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8dec18b0-32a4-4043-a376-92b52e63a22e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a4576414-771f-4b5b-9350-74606833bdf1"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("af3f18a0-572f-4bc7-91d4-fe1cfe5df72d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b71d2b8a-7d20-48a7-ac09-3a3a50f4af27"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ced2c32b-942c-4f27-9985-14b680bddb73"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d460af34-2787-4c26-939c-13ec557320e8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ecd7c511-d3c7-4e8d-9d53-bba75c2effcb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f038132b-1807-4508-ac94-17aca093cecf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fbc8c6d2-5dfd-4bd8-ad23-f2b51a69047a"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("fdbdba12-75cf-4ca4-8b67-b4f6b0b9e89b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("6159131b-ea6a-4d87-9fe5-994b485904ce"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("a521b6fd-0beb-4e27-86fe-c1ea0762d88e"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("dee68e5b-73f7-458b-b4ce-2c7c2dfa1bb4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("08b953f5-3028-4ca0-bedb-30a6dea7e2ab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1a09e7e2-65d7-4b53-83d0-c4a5ecff2314"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1f225379-968c-4812-97eb-0a4c98eea6f9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("204cb588-ea6f-4dd6-b36e-3c5cee2fdf47"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2c1c1669-fb35-422b-ae19-2f54917bcc21"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4130943c-c45d-4e48-8235-bb85764a8f9b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("461c012f-9b60-44d0-9115-ec9a85bba909"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("48b0fd1b-0bf8-4196-8b4f-479b35add8d0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4bd87bbd-b33d-4d6e-bc4a-e75c0ba78671"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("4fd73fed-b994-4236-b8e5-cb5a64f733c5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5a2a7805-4696-490d-b2a9-df08131ccfc1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6830fd96-6976-46e8-b1b1-e3dcd64b913b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6a03a186-495e-4cf2-9299-9b68eba6a60a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6c594754-822a-4e5c-b1c8-f9d65b7cf8f6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("91061f19-dc61-45c4-aef2-4b6efdb40fca"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("91544a10-de10-4c72-81a2-a502a903ca8b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("93b75efb-7a88-4789-8710-7eeafd8a912a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("96a11dbe-a48e-49fd-8f04-eac4bb15c221"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("99e90691-50d3-442b-814a-0215a6501aee"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c89fe405-0ebd-495f-8e5e-816506e63f26"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e648fdd8-8040-4bb6-b821-09d5ae5e8ce0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("ece99b78-c53f-4bf8-97f2-2f810cbdaeb5"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("90c17b35-c38e-40ed-a197-660fec3149c8"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("9811ca79-6c84-4787-a7a4-88fba9467603"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("9a0b73e8-8e9d-44a9-89ab-86c4e3b7815f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1995580e-9cbd-49e0-86ea-1612920fd123"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("24d0b784-5b7b-4b73-aaa3-824c8d8147e1"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2564408a-f87d-4ffe-b744-baf507029994"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3af8f261-ba3e-4439-b1e4-baba9673b5d4"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("48e768f2-66e6-4c09-9c05-a6f0a0922f8c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5775bbce-7440-498b-9f5c-887e144f56d7"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5b29e42e-8e7e-46c0-9a43-5951a9582b44"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5c14fba3-f75a-4c34-8a8a-465e584fd983"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("617f2355-2351-4b18-ac08-b1ae15c7a8a5"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6a912c08-e91a-4676-84cd-6b221866bfb2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("803ded9d-29ca-46ea-abfa-a962df439a02"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("80530f47-17ed-46ed-83f8-472a03cc7fc2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("81376a9f-6a9f-4b81-8ddd-8510be11f902"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("857b78ad-a558-4f7b-badc-67fd86859dc6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("993c7121-69fa-4a26-b396-81a6ce0ed15c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9d7a8034-a013-42c0-8e23-2ae0f051d896"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9fd02706-0ab7-4a01-b680-af68d0e337cb"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b9b872c9-d86a-48b5-98c5-96a4d6c78000"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("bc2b33d6-fd60-4c22-96cf-fcb5aa558196"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c1d83c3b-8878-4dac-8cae-bcd7c402215f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("cdfc2b46-9edd-4433-8ed1-f513993782bf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("e19057ee-56f4-4ff8-a769-5d1beb641731"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7200896c-391e-48d5-a7a2-f53a003a99c5"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("abeb9339-f056-45c5-9257-c902212fa2dd"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("e77bfc62-b5bd-449e-b212-4b1c00b69f40"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0b81e257-ce03-48a9-ad5d-c59222078600"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("0df3d495-cf7a-4a7b-8c3d-caf237e936a3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1326ee1e-5f59-4b3d-9f1f-173f860cb379"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("35c59b4a-abcd-4cf0-8f2e-6e3c61508a28"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("458bb579-7ddb-4dd6-9e71-330c6fa333f1"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("4b59036b-4da8-4251-affa-44a9a7d28a48"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("532ceca1-fb14-4c13-bc8c-9ac27ad43c6b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("56b60365-04da-4eae-b94e-c76b49e02605"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("639cc9c8-2845-4d06-83e3-6443ef87c806"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("74c531f3-bc72-4c17-a527-5ae5a13d0025"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("784cd245-99fa-4f6f-ae8f-13ffde666831"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("81aec9f4-e19a-4a88-ac60-1e8af1e8ae12"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a31ca642-2d02-4732-beb8-087adcb2c62c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ab1b3bf6-093f-4069-b8c7-7969c08952d9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b96d9613-a473-4448-be61-e5c1790de541"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cc322801-b7c4-413b-a4aa-6a262cb522aa"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d57b29d0-067f-46e1-b001-0ee3eba7481a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("df5c9659-2976-48f5-9e81-5829697b86a0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("e99095da-2d06-4b10-802b-768d64d32e73"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f2054876-0c1e-44ff-922b-c4d82f5293a0"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f33a1e5a-8255-4d2c-95df-165caee55236"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fabb023d-5366-41f0-a93a-2a6227490b4a"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("9c53af9e-0c18-4d3d-9c42-95efdc99182d"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("9bc46e8d-4b16-49a1-a184-b24b1e4c4360"));

            migrationBuilder.AlterColumn<string>(
                name: "PaymentLink",
                table: "SalePlans",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("fc7427af-6f1a-4e0f-942e-f7181b6215e8"), null, null, null, null, null, new DateTime(2021, 5, 27, 10, 25, 38, 395, DateTimeKind.Local).AddTicks(2394), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), null, new DateTime(2021, 5, 27, 10, 25, 38, 405, DateTimeKind.Local).AddTicks(3340), true, false, "Administradores", new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("47d9b37d-032d-4edd-9b90-97e8300ee7cd"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4577), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("6f27c060-6587-432a-98d3-f6bd75847900"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("cc5f6171-60f5-4416-86fb-3d2e03ad09ff"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4534), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("275c6428-2f3d-4b3f-b130-212418eb291f"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("46db677c-d76b-4ef7-9484-387d5c64fdf9"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4453), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("5978ef39-8c64-4c29-b9ad-c95b495ed31a"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("dfa41bfd-ac69-414c-83f7-3ed796add2f1"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4365), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("586a4afa-1b6e-466b-b28c-e847e2b0d192"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("e313b0fb-e334-44e0-923f-d47287074305"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4282), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("ac57cf5f-30ba-474a-8bf7-707b65965c10"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("a0b367ba-ca11-4975-8181-0cfe2b428e0a"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4107), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("edc03da9-57db-494c-a47c-3fcc667f6798"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("022a315c-f94f-44c7-a977-fdf33700967e"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4063), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("d7ba2129-e3b4-4d2b-a11e-63be859d7515"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("a591ecc9-8955-40e3-8649-a900860da367"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(3963), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("80c2f0a6-b71e-4554-883f-2b3a0dc46171"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("d61ea238-0468-41ae-ae7d-dc8e762ea73e"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(3094), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("897f2807-4b1f-4835-9036-5f4476ac9b60"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("c6cfb60b-04f9-45c4-877d-ca1e93249f32"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(2584), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("b34fc7cf-6317-4c03-b30c-d21d6e95c46b"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("50e2aa7a-ca1b-463f-accd-4dceddadc16b"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(1732), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("44513a65-7ddc-4218-9e10-c989ecd401da"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("6a09acec-cb08-4d3a-b5a1-61483d62e36e"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(1097), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("8d3a8938-c892-4d24-a411-76a288b24f41"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("7c869502-c858-4b90-8afa-334b0464d105"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(985), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("d93bd64b-1d2c-4e05-9118-efb6aaa24c47"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("8e24490a-5bb9-49ca-ba10-660b9db901a5"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(731), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("3b9d691f-85eb-49a7-b830-027c2bf67f3d"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("86bc47c4-073c-4a84-ace4-8fd252405e98"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(446), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("86abf1bf-83c6-4545-b4bd-120a0d0affbf"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("73e6c888-cf37-4ef3-ac95-bad46ec19c56"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(74), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("d5fcc7fd-f6a4-4f84-b1b5-33503b824f50"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("ca8492b8-eb1a-40a7-b14f-e5018e1c413a"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 411, DateTimeKind.Local).AddTicks(9579), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("6d289362-8c5d-48cd-9965-a6fd45695c2d"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("43d18d99-0827-4242-8639-8ef6bbcdc4f4"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 411, DateTimeKind.Local).AddTicks(9102), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("6f34d037-c384-40bd-aec1-b3489a7d6163"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("09d1eda1-9b85-46c9-a517-896fe695d7d7"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 411, DateTimeKind.Local).AddTicks(8614), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("d87d87ed-7500-4197-a153-f68804a8737e"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("b46cbdfa-536c-41a8-a5f9-f593bc366b20"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 411, DateTimeKind.Local).AddTicks(8113), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("879b48f2-992c-4f90-a8e8-322d303f8fa7"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("ac74dc6e-b520-40ea-bb13-58bd48f85157"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 411, DateTimeKind.Local).AddTicks(5770), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null },
                    { new Guid("21ac9a49-011f-4450-955e-847af4d615ae"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 412, DateTimeKind.Local).AddTicks(4606), new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("f8ecf0d5-90dd-4f47-866e-aac9314f9066"), true, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("4813be3e-9b80-4a91-af91-b42b419b200c"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 5, 27, 10, 25, 38, 404, DateTimeKind.Local).AddTicks(7870), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2552bd03-122f-4c88-9af9-a0d566d11189"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 5, 27, 10, 25, 38, 404, DateTimeKind.Local).AddTicks(7453), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ee28dbfe-258e-469c-979c-761c23a6dc83"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 5, 27, 10, 25, 38, 401, DateTimeKind.Local).AddTicks(1011), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f8ecf0d5-90dd-4f47-866e-aac9314f9066"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5841), null, "", true, false, "groupusers/details", new Guid("275c6428-2f3d-4b3f-b130-212418eb291f"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6f27c060-6587-432a-98d3-f6bd75847900"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5689), null, "", true, false, "groupusers/list", new Guid("275c6428-2f3d-4b3f-b130-212418eb291f"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("275c6428-2f3d-4b3f-b130-212418eb291f"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5553), null, "", true, false, "", new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5978ef39-8c64-4c29-b9ad-c95b495ed31a"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5402), null, "", true, false, "systems/details", new Guid("ac57cf5f-30ba-474a-8bf7-707b65965c10"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("586a4afa-1b6e-466b-b28c-e847e2b0d192"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5251), null, "", true, false, "systems/list", new Guid("ac57cf5f-30ba-474a-8bf7-707b65965c10"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ac57cf5f-30ba-474a-8bf7-707b65965c10"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5104), null, "", true, false, "", new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("edc03da9-57db-494c-a47c-3fcc667f6798"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4935), null, "", true, false, "languages/details", new Guid("80c2f0a6-b71e-4554-883f-2b3a0dc46171"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d7ba2129-e3b4-4d2b-a11e-63be859d7515"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4685), null, "", true, false, "languages/list", new Guid("80c2f0a6-b71e-4554-883f-2b3a0dc46171"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("80c2f0a6-b71e-4554-883f-2b3a0dc46171"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4523), null, "", true, false, "", new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("897f2807-4b1f-4835-9036-5f4476ac9b60"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4365), null, "", true, false, "clients/details", new Guid("44513a65-7ddc-4218-9e10-c989ecd401da"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b34fc7cf-6317-4c03-b30c-d21d6e95c46b"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4218), null, "", true, false, "clients/list", new Guid("44513a65-7ddc-4218-9e10-c989ecd401da"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8d3a8938-c892-4d24-a411-76a288b24f41"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3909), null, "", true, false, "menus/details", new Guid("3b9d691f-85eb-49a7-b830-027c2bf67f3d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d93bd64b-1d2c-4e05-9118-efb6aaa24c47"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3753), null, "", true, false, "menus/list", new Guid("3b9d691f-85eb-49a7-b830-027c2bf67f3d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3b9d691f-85eb-49a7-b830-027c2bf67f3d"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3526), null, "", true, false, "", new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("86abf1bf-83c6-4545-b4bd-120a0d0affbf"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3386), null, "", true, false, "users/details", new Guid("6d289362-8c5d-48cd-9965-a6fd45695c2d"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d5fcc7fd-f6a4-4f84-b1b5-33503b824f50"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3234), null, "", true, false, "users/list", new Guid("6d289362-8c5d-48cd-9965-a6fd45695c2d"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6d289362-8c5d-48cd-9965-a6fd45695c2d"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3063), null, "", true, false, "", new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6f34d037-c384-40bd-aec1-b3489a7d6163"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(2725), null, "", true, false, "companyoperators/details", new Guid("879b48f2-992c-4f90-a8e8-322d303f8fa7"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d87d87ed-7500-4197-a153-f68804a8737e"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(2575), null, "", true, false, "companyoperators/list", new Guid("879b48f2-992c-4f90-a8e8-322d303f8fa7"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("879b48f2-992c-4f90-a8e8-322d303f8fa7"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(2277), null, "", true, false, "", new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 5, 27, 10, 25, 38, 406, DateTimeKind.Local).AddTicks(7458), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("44513a65-7ddc-4218-9e10-c989ecd401da"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4070), null, "", true, false, "", new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 5, 27, 10, 25, 38, 398, DateTimeKind.Local).AddTicks(1417), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("02fb80f4-0221-425c-a3b0-7992ab5e7f46"), null, new DateTime(2021, 5, 27, 10, 25, 38, 404, DateTimeKind.Local).AddTicks(7957), true, true, false, new Guid("4813be3e-9b80-4a91-af91-b42b419b200c"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, null },
                    { new Guid("454c18ce-2e11-4355-8cad-4410732b0b19"), null, new DateTime(2021, 5, 27, 10, 25, 38, 404, DateTimeKind.Local).AddTicks(4844), true, true, false, new Guid("ee28dbfe-258e-469c-979c-761c23a6dc83"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, null },
                    { new Guid("44f02a89-b54d-46b6-b5d6-2117a475f5cf"), null, new DateTime(2021, 5, 27, 10, 25, 38, 404, DateTimeKind.Local).AddTicks(7765), true, true, false, new Guid("2552bd03-122f-4c88-9af9-a0d566d11189"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("3a1acfcd-b09d-44bc-ac10-1c65ed83e978"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5164), null, true, false, new Guid("ac57cf5f-30ba-474a-8bf7-707b65965c10"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f9f87898-18e6-410d-8c10-0fa92b9b772f"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5763), null, true, false, new Guid("6f27c060-6587-432a-98d3-f6bd75847900"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33a9698b-6035-4d90-9981-4a060820451b"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5619), null, true, false, new Guid("275c6428-2f3d-4b3f-b130-212418eb291f"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9f3f4aa7-ad2c-4b0c-afff-09a55b5ce68b"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5473), null, true, false, new Guid("5978ef39-8c64-4c29-b9ad-c95b495ed31a"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1af3786f-69ce-4a7d-91e2-1c5464031005"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5323), null, true, false, new Guid("586a4afa-1b6e-466b-b28c-e847e2b0d192"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("07bb8f1f-1594-4f96-bc08-e3ae067b0043"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5018), null, true, false, new Guid("edc03da9-57db-494c-a47c-3fcc667f6798"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6b85446b-f39c-4667-89ed-74d0332e9ad8"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4740), null, true, false, new Guid("d7ba2129-e3b4-4d2b-a11e-63be859d7515"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("eb58dfc7-4e88-486c-b419-600d6b56fcbb"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4596), null, true, false, new Guid("80c2f0a6-b71e-4554-883f-2b3a0dc46171"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e64f5d0b-0f13-4d2d-9fe3-812842b162b5"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4443), null, true, false, new Guid("897f2807-4b1f-4835-9036-5f4476ac9b60"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8fc0dac8-9647-4fcb-a0b0-872c382f38b1"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4292), null, true, false, new Guid("b34fc7cf-6317-4c03-b30c-d21d6e95c46b"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d75298d4-bd1c-40ef-b243-b064e1cf4f7a"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(4140), null, true, false, new Guid("44513a65-7ddc-4218-9e10-c989ecd401da"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d78a655d-4ba7-4624-9786-5a9e00d87fd3"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3983), null, true, false, new Guid("8d3a8938-c892-4d24-a411-76a288b24f41"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("832b23fc-87fd-44f4-a9d7-592fb200fe27"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3833), null, true, false, new Guid("d93bd64b-1d2c-4e05-9118-efb6aaa24c47"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("23431be8-0c43-4184-8de4-0926ff3119da"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3603), null, true, false, new Guid("3b9d691f-85eb-49a7-b830-027c2bf67f3d"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5da1e63d-eef2-45ec-9c41-aabfeb2fe143"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3459), null, true, false, new Guid("86abf1bf-83c6-4545-b4bd-120a0d0affbf"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a943df7f-62fa-411f-b77f-808b026d9c48"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3301), null, true, false, new Guid("d5fcc7fd-f6a4-4f84-b1b5-33503b824f50"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a292bf64-a919-4827-bca7-9d1c2a623529"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(3149), null, true, false, new Guid("6d289362-8c5d-48cd-9965-a6fd45695c2d"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c364731d-7085-4794-8d88-e139c77d3c62"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(2800), null, true, false, new Guid("6f34d037-c384-40bd-aec1-b3489a7d6163"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b83de1d3-aaff-47ab-8e70-c01e42c8316f"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(2641), null, true, false, new Guid("d87d87ed-7500-4197-a153-f68804a8737e"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("feb6655a-44a7-4372-8700-d9d22cc18f0f"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(2447), null, true, false, new Guid("879b48f2-992c-4f90-a8e8-322d303f8fa7"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("09eddf66-75d4-4738-b1ef-d088044e232c"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(956), null, true, false, new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3883f293-add4-48c1-a500-3f782c2453e3"), null, new DateTime(2021, 5, 27, 10, 25, 38, 407, DateTimeKind.Local).AddTicks(5971), null, true, false, new Guid("f8ecf0d5-90dd-4f47-866e-aac9314f9066"), new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("42b104c5-4572-46b9-b332-1dc3560bcf8c"), null, new Guid("fc7427af-6f1a-4e0f-942e-f7181b6215e8"), null, null, null, new DateTime(2021, 5, 27, 10, 25, 38, 414, DateTimeKind.Local).AddTicks(9153), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("058af92d-7a17-4d6f-953e-4bfd72d2bec6"), null, null, new DateTime(2021, 5, 27, 10, 25, 38, 415, DateTimeKind.Local).AddTicks(3967), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("42b104c5-4572-46b9-b332-1dc3560bcf8c"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9"), new Guid("fc7427af-6f1a-4e0f-942e-f7181b6215e8"), null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(418), null, new Guid("f9c7e60b-50ab-42a5-827f-8031f4ba0262"), true, false, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), new Guid("42b104c5-4572-46b9-b332-1dc3560bcf8c"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("ed963397-57c7-47fb-81d1-314091fd7f36"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8786), null, true, false, new Guid("6f27c060-6587-432a-98d3-f6bd75847900"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("fc7ea080-56ed-49d7-9a6c-448409587596"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8648), null, true, false, new Guid("275c6428-2f3d-4b3f-b130-212418eb291f"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("906c673d-5d52-43dd-83e0-f30bc7a8e25d"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8559), null, true, false, new Guid("5978ef39-8c64-4c29-b9ad-c95b495ed31a"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("e32711d1-31e8-41ce-9714-54fba748dc10"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8484), null, true, false, new Guid("586a4afa-1b6e-466b-b28c-e847e2b0d192"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("90ebe343-4a0e-4712-ad7f-b439c144489b"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8393), null, true, false, new Guid("ac57cf5f-30ba-474a-8bf7-707b65965c10"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("5a6d87f6-c79a-4a04-9509-c968a15706ab"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8311), null, true, false, new Guid("edc03da9-57db-494c-a47c-3fcc667f6798"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("7b6613ed-1e5d-4c1c-a3d6-a3a1b505657d"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8225), null, true, false, new Guid("d7ba2129-e3b4-4d2b-a11e-63be859d7515"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("a4ea4076-cd67-4bfc-851b-66ea84aa8ac3"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8137), null, true, false, new Guid("80c2f0a6-b71e-4554-883f-2b3a0dc46171"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("e764e988-256d-4ec3-86c1-cea549ea5077"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8058), null, true, false, new Guid("897f2807-4b1f-4835-9036-5f4476ac9b60"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("e7e3347b-e435-43fb-813a-2445baa49095"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7972), null, true, false, new Guid("b34fc7cf-6317-4c03-b30c-d21d6e95c46b"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("5816c278-4877-404b-a14a-6d24ad26c2db"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(8969), null, true, false, new Guid("f8ecf0d5-90dd-4f47-866e-aac9314f9066"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("cf9c7743-6800-441d-906c-98576e746b85"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7813), null, true, false, new Guid("8d3a8938-c892-4d24-a411-76a288b24f41"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("b949328d-d6ee-4cfd-936b-3b4f6de45556"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7723), null, true, false, new Guid("d93bd64b-1d2c-4e05-9118-efb6aaa24c47"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("5d5e539c-c8ce-4d50-982a-984448f9bfcb"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7644), null, true, false, new Guid("3b9d691f-85eb-49a7-b830-027c2bf67f3d"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("5589d003-d9fa-47ce-8ea7-db7aeb1343b0"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7569), null, true, false, new Guid("86abf1bf-83c6-4545-b4bd-120a0d0affbf"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("90fba701-de20-4b75-b07b-009200ad0433"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7480), null, true, false, new Guid("d5fcc7fd-f6a4-4f84-b1b5-33503b824f50"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("df07824e-02a8-4a4a-8a5d-53b92ec61b1c"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7363), null, true, false, new Guid("6d289362-8c5d-48cd-9965-a6fd45695c2d"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("bdc73549-31de-414c-9869-4c83b4acce37"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7189), null, true, false, new Guid("6f34d037-c384-40bd-aec1-b3489a7d6163"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("26fe6ca8-baa8-4017-a267-68b70809eebe"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7113), null, true, false, new Guid("d87d87ed-7500-4197-a153-f68804a8737e"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("892af626-3323-4f74-bf5d-b78d261450e5"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(6998), null, true, false, new Guid("879b48f2-992c-4f90-a8e8-322d303f8fa7"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("f0954b4f-8b0b-447c-adef-a536ce8d3dde"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(6506), null, true, false, new Guid("98a483ce-e0ee-4178-ba1f-87e3f73c0988"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") },
                    { new Guid("f296cca8-ced7-4269-8caa-f57e767f2ba1"), true, true, null, new DateTime(2021, 5, 27, 10, 25, 38, 416, DateTimeKind.Local).AddTicks(7892), null, true, false, new Guid("44513a65-7ddc-4218-9e10-c989ecd401da"), true, true, null, null, null, new Guid("1be9e522-00a4-4338-b7e8-4e5fad62a1a9") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("763d0f15-eb25-4bcc-8b7a-f78b58ec4944"), "usuário administrativo", null, new DateTime(2021, 5, 27, 10, 25, 38, 413, DateTimeKind.Local).AddTicks(3175), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("d27912af-92f0-44a6-b2dd-576c26237a2c"), new Guid("fc7427af-6f1a-4e0f-942e-f7181b6215e8"), null, new DateTime(2021, 5, 27, 10, 25, 38, 399, DateTimeKind.Local).AddTicks(744), null, true, false, new Guid("399ea16a-ed74-4c5f-95e5-bf65c7b3d279"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
