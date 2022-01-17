using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("eb962159-509d-44e9-8640-374db3f38265"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("b39ed824-d706-4d97-b9f8-bb18c4097bdf"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("0f969598-11ae-4c5a-8a1c-8113a833a30b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("107c7cf8-bfae-4864-b3d2-7c40d5787bfb"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("2403d1ca-7d87-4a8a-b691-c4ca95f7ba5f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("29492ce3-d629-4316-9f32-afb024f320d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("37214869-9fee-41f6-9cb5-13b122a2cdc4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("4b8b1ac3-499a-4d20-bc90-23a34a21ea1d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("5ccb9077-944d-4341-96e6-df441b3bc66f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("687ce6e1-71c5-421d-940b-2aa1bb9046d0"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("752e8583-b8ab-4827-a000-ef6db96823bc"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8402416e-e7c2-4eaa-a155-61e95d9fe95b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("8671f903-86ad-4876-a9db-42c51d05f4d5"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("90db599d-6391-4cc2-b1d8-44346e0d3cc4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a17e607e-3e46-4a51-a4e3-3370ae6d3ff6"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a4daf52b-1a94-42da-84f9-754be533640c"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("a5dd00fd-a18d-4b96-b030-12304873a534"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b245027d-43a4-4677-882a-c3f787521487"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("b9a845b3-0c72-44b4-8f2c-cf50146824fa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c633af71-f3be-4d9a-91f9-8bd7d2c79952"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c65d933c-d2d8-4edf-85a6-3261189b9161"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c931b032-7b8d-4284-8888-402f5ba020c7"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ca67aa44-7a0b-4cd8-a9a0-1b60f465ded2"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("df720e53-aa99-4d85-ad99-03b0452b719b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("269b7fcf-0ef6-49d8-a937-dbc7a78848d2"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("88f210d7-73a5-4e30-80a4-5a3ab5c0be7b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e867c9c5-4138-45fc-b4ef-b6e9e5cbe003"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("514a9596-1dfa-478f-926e-285aa83cad05"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a378e273-0244-44b8-879c-fb93c871db6e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dc076851-5994-484a-9283-80429002a85d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("08eb732c-34d9-49aa-a6f6-181ef09a3bd7"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("324e883a-7016-4637-a5d8-853e6910684a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("9d2a6009-075b-48ab-a5f8-ead6295e3c33"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("02fe5ac5-5929-4140-a9a0-de8b2b166a1f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1ed20729-e6f7-4065-8a98-c4d10d60c726"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("1f30583e-b55e-4464-b020-236f1543f5ec"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("229df281-75e2-4d02-907a-4b2dc69c297c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("28195b16-b5d7-4c3b-a1a9-4d9bc71b1f35"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2eab63eb-876f-46d5-876e-8e7c444b4938"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4ba0e271-1819-490a-8871-800da462c329"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("4f5c8215-05e6-4dc2-8698-5f6af505283b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("502d7ac3-7f7c-4111-8f9f-573f402d918c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("51efc264-3765-483c-b54d-1aefd4d59758"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5ef001ed-3ff6-4ce5-9500-6a16087b15d0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("5fd4321e-9b2d-4721-9b04-1e40731a1626"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6c5c97e1-794a-4f44-8c8a-2de7a1667e5d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("7e5378e5-d077-4a33-9466-65cc0a574a4c"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("8082a6fe-4dcf-4929-902a-79630cb68ca6"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("84dca31a-32da-4f4d-89ed-c73ce3c1d9cf"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("9a74cd1c-4fd0-4c4b-90a8-a0c47e8e263f"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a1400012-7aa6-4666-8bdd-d1dfd831603d"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a75cbd49-3eea-4e2b-8ea3-84839c9861e3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ade80d2b-9cda-4fe3-8e24-fa173d1a5352"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba4fe512-8499-456a-8548-3b94e261ba6b"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ce12dad6-aae8-4810-b330-7f856a3b9b1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("125621c4-2582-472b-8605-e3c9312ff10a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("117467e3-2eb8-4a0d-945d-12e015ec0753"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("158ae004-525e-483c-a8fe-b916f9c8128d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("2ab991f2-be6b-476f-b0b2-855862e51d82"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("48753d45-c486-4994-a3b7-9b63a655c98d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5b10d85d-cae7-4986-b27f-33827b10774c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("5dfba400-bd80-4ad2-82d7-28dd8d1d08e8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7decc1c9-2e28-47e8-a21b-2d6d742a0050"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("8851b25c-02f6-4871-b1e7-beee95ab68d6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("91f5db60-9213-4435-8c50-f7964c9305a5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("94710b33-935d-4d66-845c-817e0dbba4f7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a4c97367-4e24-44c1-a566-5aa90ef0c496"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c2191e5c-632a-498b-af92-3c995b697db8"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c2e21782-2b5c-4a56-8b57-e29bfc66c1f9"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c5a2659a-4096-48a4-9f94-728d4dc32d30"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c5eaa390-f0b8-4b92-8cc8-b9581c6a1d5a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("c6cfe0eb-a740-406e-af43-e7232372e159"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("cda225c3-58a0-419e-b8c2-2baae4145805"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f3b1996b-90cb-4ff4-aa5a-f49606996721"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f5b02938-a252-49af-a4eb-cf9cdc0f7e23"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f5fd0d86-3f15-492a-8499-adea6ab09f51"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f77eaaea-9250-426d-b124-3d1097549c0e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("fe38001b-9b70-45ec-b6b7-d3919c708bf8"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("230bcb5c-cb6d-45b1-a230-0cf21a7a04bd"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"));

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsGhost",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UserSiteId",
                table: "Customers",
                type: "uuid",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsGhost",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserSiteId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, null, null, null, null, new DateTime(2021, 3, 22, 13, 6, 3, 215, DateTimeKind.Local).AddTicks(285), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(1891), true, false, "Administradores", new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("4b8b1ac3-499a-4d20-bc90-23a34a21ea1d"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8674), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("c633af71-f3be-4d9a-91f9-8bd7d2c79952"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8650), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("90db599d-6391-4cc2-b1d8-44346e0d3cc4"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8628), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("752e8583-b8ab-4827-a000-ef6db96823bc"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8606), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("b245027d-43a4-4677-882a-c3f787521487"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8582), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("29492ce3-d629-4316-9f32-afb024f320d5"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8559), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("8671f903-86ad-4876-a9db-42c51d05f4d5"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8532), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("c65d933c-d2d8-4edf-85a6-3261189b9161"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8455), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("8402416e-e7c2-4eaa-a155-61e95d9fe95b"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8433), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("0f969598-11ae-4c5a-8a1c-8113a833a30b"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8409), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("5ccb9077-944d-4341-96e6-df441b3bc66f"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8387), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("687ce6e1-71c5-421d-940b-2aa1bb9046d0"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8365), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("b9a845b3-0c72-44b4-8f2c-cf50146824fa"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8342), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("c931b032-7b8d-4284-8888-402f5ba020c7"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8321), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("a5dd00fd-a18d-4b96-b030-12304873a534"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8299), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("a4daf52b-1a94-42da-84f9-754be533640c"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8276), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("dc076851-5994-484a-9283-80429002a85d"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("a17e607e-3e46-4a51-a4e3-3370ae6d3ff6"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8250), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("ca67aa44-7a0b-4cd8-a9a0-1b60f465ded2"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8222), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("37214869-9fee-41f6-9cb5-13b122a2cdc4"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8198), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("107c7cf8-bfae-4864-b3d2-7c40d5787bfb"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8162), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("2403d1ca-7d87-4a8a-b691-c4ca95f7ba5f"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(7811), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null },
                    { new Guid("df720e53-aa99-4d85-ad99-03b0452b719b"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(8696), new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), true, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("269b7fcf-0ef6-49d8-a937-dbc7a78848d2"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(340), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("88f210d7-73a5-4e30-80a4-5a3ab5c0be7b"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(201), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e867c9c5-4138-45fc-b4ef-b6e9e5cbe003"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 3, 22, 13, 6, 3, 218, DateTimeKind.Local).AddTicks(6544), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(3015), null, "", true, false, "groupusers/details", new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2912), null, "", true, false, "groupusers/list", new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2866), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2820), null, "", true, false, "systems/details", new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2775), null, "", true, false, "systems/list", new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2727), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2675), null, "", true, false, "languages/details", new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2580), null, "", true, false, "languages/list", new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2535), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2487), null, "", true, false, "clients/details", new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2436), null, "", true, false, "clients/list", new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2340), null, "", true, false, "menus/details", new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2288), null, "", true, false, "menus/list", new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2161), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2106), null, "", true, false, "users/details", new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("dc076851-5994-484a-9283-80429002a85d"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2022), null, "", true, false, "users/list", new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1928), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1636), null, "", true, false, "companyoperators/details", new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1540), null, "", true, false, "companyoperators/list", new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1340), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 3, 22, 13, 6, 3, 220, DateTimeKind.Local).AddTicks(5970), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2389), null, "", true, false, "", new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 3, 22, 13, 6, 3, 217, DateTimeKind.Local).AddTicks(8151), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("324e883a-7016-4637-a5d8-853e6910684a"), null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(367), true, true, false, new Guid("269b7fcf-0ef6-49d8-a937-dbc7a78848d2"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null },
                    { new Guid("08eb732c-34d9-49aa-a6f6-181ef09a3bd7"), null, new DateTime(2021, 3, 22, 13, 6, 3, 218, DateTimeKind.Local).AddTicks(9858), true, true, false, new Guid("e867c9c5-4138-45fc-b4ef-b6e9e5cbe003"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null },
                    { new Guid("9d2a6009-075b-48ab-a5f8-ead6295e3c33"), null, new DateTime(2021, 3, 22, 13, 6, 3, 219, DateTimeKind.Local).AddTicks(309), true, true, false, new Guid("88f210d7-73a5-4e30-80a4-5a3ab5c0be7b"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("51efc264-3765-483c-b54d-1aefd4d59758"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2750), null, true, false, new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("9a74cd1c-4fd0-4c4b-90a8-a0c47e8e263f"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2933), null, true, false, new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ba4fe512-8499-456a-8548-3b94e261ba6b"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2886), null, true, false, new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("28195b16-b5d7-4c3b-a1a9-4d9bc71b1f35"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2841), null, true, false, new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5fd4321e-9b2d-4721-9b04-1e40731a1626"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2797), null, true, false, new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1ed20729-e6f7-4065-8a98-c4d10d60c726"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2699), null, true, false, new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("229df281-75e2-4d02-907a-4b2dc69c297c"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2647), null, true, false, new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ade80d2b-9cda-4fe3-8e24-fa173d1a5352"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2556), null, true, false, new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("5ef001ed-3ff6-4ce5-9500-6a16087b15d0"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2510), null, true, false, new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a1400012-7aa6-4666-8bdd-d1dfd831603d"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2459), null, true, false, new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("84dca31a-32da-4f4d-89ed-c73ce3c1d9cf"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2411), null, true, false, new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ce12dad6-aae8-4810-b330-7f856a3b9b1b"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2365), null, true, false, new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7e5378e5-d077-4a33-9466-65cc0a574a4c"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2312), null, true, false, new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("502d7ac3-7f7c-4111-8f9f-573f402d918c"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2250), null, true, false, new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("02fe5ac5-5929-4140-a9a0-de8b2b166a1f"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2135), null, true, false, new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8082a6fe-4dcf-4929-902a-79630cb68ca6"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(2061), null, true, false, new Guid("dc076851-5994-484a-9283-80429002a85d"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a75cbd49-3eea-4e2b-8ea3-84839c9861e3"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1977), null, true, false, new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6c5c97e1-794a-4f44-8c8a-2de7a1667e5d"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1679), null, true, false, new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4f5c8215-05e6-4dc2-8698-5f6af505283b"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1588), null, true, false, new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1f30583e-b55e-4464-b020-236f1543f5ec"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(1467), null, true, false, new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("4ba0e271-1819-490a-8871-800da462c329"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(39), null, true, false, new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2eab63eb-876f-46d5-876e-8e7c444b4938"), null, new DateTime(2021, 3, 22, 13, 6, 3, 221, DateTimeKind.Local).AddTicks(3040), null, true, false, new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"), null, new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, null, null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(2355), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("125621c4-2582-472b-8605-e3c9312ff10a"), null, null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(4899), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7"), new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(8292), null, new Guid("ea5c3807-ce9d-4198-9e07-71d3288833ea"), true, false, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), new Guid("1a59a40c-340e-4a93-9b6a-d54ab8a3a652"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("fe38001b-9b70-45ec-b6b7-d3919c708bf8"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2864), null, true, false, new Guid("5160c2cf-587a-4fdf-bc94-8f913534e549"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("cda225c3-58a0-419e-b8c2-2baae4145805"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2843), null, true, false, new Guid("dc66b52b-593f-4cfe-9ea6-c9aa4d127ec6"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f5fd0d86-3f15-492a-8499-adea6ab09f51"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2818), null, true, false, new Guid("c5feccbb-146e-4b98-b9dd-b7f2fefb5756"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("5b10d85d-cae7-4986-b27f-33827b10774c"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2749), null, true, false, new Guid("d77f04fa-bd80-4760-9f26-fb8821f90866"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c5eaa390-f0b8-4b92-8cc8-b9581c6a1d5a"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2727), null, true, false, new Guid("a378e273-0244-44b8-879c-fb93c871db6e"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c2e21782-2b5c-4a56-8b57-e29bfc66c1f9"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2706), null, true, false, new Guid("e7ba096f-3e05-4ced-a668-75dfa32662f7"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("5dfba400-bd80-4ad2-82d7-28dd8d1d08e8"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2686), null, true, false, new Guid("01158e7a-5c4d-46dd-a37f-2bbd18ef06c4"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f5b02938-a252-49af-a4eb-cf9cdc0f7e23"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2665), null, true, false, new Guid("95864da0-c4a6-4bfa-924f-d9b3ef1f2d1c"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c5a2659a-4096-48a4-9f94-728d4dc32d30"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2643), null, true, false, new Guid("9d2f432b-a3fe-49c9-9baa-f76a30a18416"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("91f5db60-9213-4435-8c50-f7964c9305a5"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2623), null, true, false, new Guid("e6f105e8-e005-4457-88d2-b6b84bc161c0"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("2ab991f2-be6b-476f-b0b2-855862e51d82"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2885), null, true, false, new Guid("f6b485f9-4a93-4d3a-b619-04b87eeeff6a"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f77eaaea-9250-426d-b124-3d1097549c0e"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2578), null, true, false, new Guid("191f2c4a-947b-45dd-a559-32225a6d2a0e"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c6cfe0eb-a740-406e-af43-e7232372e159"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2555), null, true, false, new Guid("7270c6bd-c039-4e5e-9d42-30a41b673bd3"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("117467e3-2eb8-4a0d-945d-12e015ec0753"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2535), null, true, false, new Guid("5c07a773-592d-4343-9c21-dd72e8c7d7af"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("48753d45-c486-4994-a3b7-9b63a655c98d"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2513), null, true, false, new Guid("6c8fdfbf-e878-4552-95b7-87ff51cf089e"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("8851b25c-02f6-4871-b1e7-beee95ab68d6"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2492), null, true, false, new Guid("dc076851-5994-484a-9283-80429002a85d"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("94710b33-935d-4d66-845c-817e0dbba4f7"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2467), null, true, false, new Guid("282e44a1-7dbd-4c12-8a1a-9a01629a64e1"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("f3b1996b-90cb-4ff4-aa5a-f49606996721"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2438), null, true, false, new Guid("9c9bc960-9e38-4541-8e02-ee1b27ca2280"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("7decc1c9-2e28-47e8-a21b-2d6d742a0050"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2335), null, true, false, new Guid("f33ec5ce-34c7-4815-91f7-36d49936bfc7"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("c2191e5c-632a-498b-af92-3c995b697db8"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2296), null, true, false, new Guid("514a9596-1dfa-478f-926e-285aa83cad05"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("158ae004-525e-483c-a8fe-b916f9c8128d"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2035), null, true, false, new Guid("03f22a2a-a842-43f7-ba55-ab94dcb61dfb"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") },
                    { new Guid("a4c97367-4e24-44c1-a566-5aa90ef0c496"), true, true, null, new DateTime(2021, 3, 22, 13, 6, 3, 223, DateTimeKind.Local).AddTicks(2602), null, true, false, new Guid("3870978d-9a32-4485-be9e-08a2960c6faa"), true, true, null, null, null, new Guid("2927cfa4-e211-4a51-bd80-fa00424d17a7") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("230bcb5c-cb6d-45b1-a230-0cf21a7a04bd"), "usuário administrativo", null, new DateTime(2021, 3, 22, 13, 6, 3, 222, DateTimeKind.Local).AddTicks(276), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b39ed824-d706-4d97-b9f8-bb18c4097bdf"), new Guid("eb962159-509d-44e9-8640-374db3f38265"), null, new DateTime(2021, 3, 22, 13, 6, 3, 218, DateTimeKind.Local).AddTicks(1787), null, true, false, new Guid("1c9b2dca-8583-4c86-8488-d0eff665d390"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }
    }
}
