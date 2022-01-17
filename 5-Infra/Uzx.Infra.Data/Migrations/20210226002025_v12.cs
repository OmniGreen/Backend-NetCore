using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethods",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber2",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberIsVisible2",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Specialties",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoLink",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Whats",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WhatsIsVisible",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "amenities",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "AgentId", "Document1", "Document2", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "IsActive", "IsAdmin", "IsDeleted", "Name1", "Name2", "ParentId", "Person", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("caf06b02-f3cc-45d8-8617-617bd7427b4c"), null, null, null, null, null, new DateTime(2021, 2, 25, 21, 20, 24, 72, DateTimeKind.Local).AddTicks(413), null, null, true, true, false, "Administrador Uzenix", "Admin", new Guid("00000000-0000-0000-0000-000000000000"), "1", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "GroupUserId", "DtDeleted", "DtInsert", "IsActive", "IsDeleted", "Name", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[] { new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), null, new DateTime(2021, 2, 25, 21, 20, 24, 77, DateTimeKind.Local).AddTicks(7888), true, false, "Administradores", new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, null });

            migrationBuilder.InsertData(
                table: "GroupUsersMenus",
                columns: new[] { "GroupUserMenuId", "C", "D", "DtDeleted", "DtInsert", "GroupUserId", "IsActive", "IsDeleted", "MenuId", "R", "SystemId", "U", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("78938957-6a30-4501-b8ca-cd2144df2a30"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6658), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("d954c734-4698-4b60-a124-9c793f7d1844"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("7b47fd8c-6211-47a9-be3c-c7db7750c9c8"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6559), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("33e5cd0f-0f12-41af-a9c9-19384d0e187c"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("571c4c3d-05e7-4d3c-83f0-3f20390e4198"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6521), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("c7978496-90b1-4156-804f-dcc614d2ef41"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("6a264290-0f9a-4876-b547-cb2f75395aaf"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6485), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("68988722-b166-4557-8703-3ecd40b541ef"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("986c21d3-c1b5-4a17-9f4b-3892e1b5c981"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6447), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("2bb7caa7-090a-43a7-bf7b-63698ca451ce"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("3ff89d06-3ee9-47a6-b96a-67aa8b797598"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6412), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("bfce1171-184c-4be0-a6b8-380bdacb1c53"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("ec81b2cf-9cf6-4497-98ab-6a66f76c0e6f"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6378), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("0ec52e08-5673-44bc-9e86-760f90ab545c"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("e7e77f4a-c0d7-4993-9e6d-172aa448f233"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6345), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("a7774782-f273-45f9-b7cc-57db0ca9c137"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("39a45809-c7bf-4a62-a509-82807aaf091d"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6312), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("3ed13203-b426-4546-ac19-4056a0a8d09b"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("9705a92a-7b3b-4bfe-b7d5-1635ef598136"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6278), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("c1ab8b0e-5924-4eea-b00c-04f8be296f14"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("d381ff97-2095-4693-a421-7afe9b886ca4"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6238), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("6c4e8777-fa3f-4426-918d-deddd7137283"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("68a43cb2-1fe3-4889-b755-f628812970ce"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6203), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("1c36321b-9a0d-4ea3-8b3f-4eebe592e47f"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("c805bc23-d65e-4f3f-9ff2-979c1c942539"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6164), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("44229aa4-5829-401b-a5a5-5bce6a80213c"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("aafa1454-9070-454e-b07b-6245fab6fb57"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6128), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("90dedb31-edeb-4586-bef1-0fa0adc29579"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("05ac37f2-ac5f-42ff-a13f-9e3afc17e30e"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6093), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("c3fa2829-841f-4b24-a5f3-198a5ce6ba89"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("c7c392a4-9367-4ce7-b0f0-09e473969517"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6056), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("f5468620-bf4b-42ce-9172-9d831a843053"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("500bb59c-c2ec-4477-9104-0f8474ae7543"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(5993), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("d5f8eab7-deed-4f97-bc54-74452c6b526e"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("35813609-170c-4a32-816d-c7b21ecd275b"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(5812), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("a967e47e-dac3-42f5-8acd-b72487c01164"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("20b8ebc3-a231-4cf3-bcd9-03bb38d51e18"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(5763), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("1e962bb1-adeb-4b14-8f74-f3028302af66"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("13b0e5c4-ee76-4001-bba6-72ac7c7cbc33"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(5670), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("382137f8-6b86-4dc5-afef-0b5b5d8da9e8"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("f3c4a049-9fb1-49eb-8eaf-2cd68ef34692"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(4939), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null },
                    { new Guid("f3382336-a899-49f4-80a6-794c4dbcff70"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(6703), new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("9d938b84-4305-49db-abd6-90537d2e5935"), true, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "Alt", "Country", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "FileName", "Image", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("86d31897-dccd-466a-8556-26339bd950bd"), "Idioma do país Espanha.", "Espanha", "Idioma em Espanhol da Espanha.", null, new DateTime(2021, 2, 25, 21, 20, 24, 77, DateTimeKind.Local).AddTicks(5850), null, "es.js", "png", true, false, "Espanhol", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c49c735d-01c6-4638-96f4-ad24384c6e37"), "Idioma do país EUA", "EUA", "Idioma em Inglês Norte Americano", null, new DateTime(2021, 2, 25, 21, 20, 24, 77, DateTimeKind.Local).AddTicks(5660), null, "us.js", "png", true, false, "Inglês", null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2befa0f0-8d50-43e2-8205-e7b48fea30e5"), "Idioma do país Brasil", "Brasil", "Idioma em Portugues Brasileiro", null, new DateTime(2021, 2, 25, 21, 20, 24, 76, DateTimeKind.Local).AddTicks(9716), null, "ptbr.js", "png", true, false, "Portugues", null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Alt", "ClientId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Icone", "IsActive", "IsDeleted", "Link", "MenuIdPai", "MenusTypeId", "Name", "Target", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("9d938b84-4305-49db-abd6-90537d2e5935"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(9099), null, "", true, false, "groupusers/details", new Guid("33e5cd0f-0f12-41af-a9c9-19384d0e187c"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d954c734-4698-4b60-a124-9c793f7d1844"), "Listagem de Grupo de Usuarios", null, "Realiza a busca de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(9022), null, "", true, false, "groupusers/list", new Guid("33e5cd0f-0f12-41af-a9c9-19384d0e187c"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("33e5cd0f-0f12-41af-a9c9-19384d0e187c"), "Cadastro de Grupo de Usuarios", null, "Realiza o cadastro de Grupo de Usuarios", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8943), null, "", true, false, "", new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("00000000-0000-0000-0000-000000000000"), "Grupo de Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c7978496-90b1-4156-804f-dcc614d2ef41"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8872), null, "", true, false, "systems/details", new Guid("2bb7caa7-090a-43a7-bf7b-63698ca451ce"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("68988722-b166-4557-8703-3ecd40b541ef"), "Listagem de Sistemas", null, "Realiza a busca de Sistemas", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8794), null, "", true, false, "systems/list", new Guid("2bb7caa7-090a-43a7-bf7b-63698ca451ce"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2bb7caa7-090a-43a7-bf7b-63698ca451ce"), "Cadastro de Sistemas", null, "Realiza o cadastro de Sistemas", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8642), null, "", true, false, "", new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("00000000-0000-0000-0000-000000000000"), "Sistemas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bfce1171-184c-4be0-a6b8-380bdacb1c53"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8561), null, "", true, false, "languages/details", new Guid("a7774782-f273-45f9-b7cc-57db0ca9c137"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0ec52e08-5673-44bc-9e86-760f90ab545c"), "Listagem de Idiomas", null, "Realiza a busca de Idiomas", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8488), null, "", true, false, "languages/list", new Guid("a7774782-f273-45f9-b7cc-57db0ca9c137"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a7774782-f273-45f9-b7cc-57db0ca9c137"), "Cadastro de Idiomas", null, "Realiza o cadastro de Idiomas", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8410), null, "", true, false, "", new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("00000000-0000-0000-0000-000000000000"), "Idiomas", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3ed13203-b426-4546-ac19-4056a0a8d09b"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8332), null, "", true, false, "clients/details", new Guid("6c4e8777-fa3f-4426-918d-deddd7137283"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c1ab8b0e-5924-4eea-b00c-04f8be296f14"), "Listagem de Clientes", null, "Realiza a busca de Clientes", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8249), null, "", true, false, "clients/list", new Guid("6c4e8777-fa3f-4426-918d-deddd7137283"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1c36321b-9a0d-4ea3-8b3f-4eebe592e47f"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8008), null, "", true, false, "menus/details", new Guid("90dedb31-edeb-4586-bef1-0fa0adc29579"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("44229aa4-5829-401b-a5a5-5bce6a80213c"), "Listagem de Menus", null, "Realiza a busca de Menus", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7926), null, "", true, false, "menus/list", new Guid("90dedb31-edeb-4586-bef1-0fa0adc29579"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("90dedb31-edeb-4586-bef1-0fa0adc29579"), "Cadastro de Menus", null, "Realiza o cadastro de Menus", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7847), null, "", true, false, "", new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("00000000-0000-0000-0000-000000000000"), "Menus", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c3fa2829-841f-4b24-a5f3-198a5ce6ba89"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7772), null, "", true, false, "users/details", new Guid("d5f8eab7-deed-4f97-bc54-74452c6b526e"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f5468620-bf4b-42ce-9172-9d831a843053"), "Listagem de Usuarios", null, "Realiza a busca de Usuarios", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7692), null, "", true, false, "users/list", new Guid("d5f8eab7-deed-4f97-bc54-74452c6b526e"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d5f8eab7-deed-4f97-bc54-74452c6b526e"), "Cadastro de Usuarios", null, "Realiza o cadastro de Usuarios", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7598), null, "", true, false, "", new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("00000000-0000-0000-0000-000000000000"), "Usuarios", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a967e47e-dac3-42f5-8acd-b72487c01164"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7197), null, "", true, false, "companyoperators/details", new Guid("382137f8-6b86-4dc5-afef-0b5b5d8da9e8"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastrar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("1e962bb1-adeb-4b14-8f74-f3028302af66"), "Listagem de Operadoras", null, "Realiza a busca de Operadoras", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7122), null, "", true, false, "companyoperators/list", new Guid("382137f8-6b86-4dc5-afef-0b5b5d8da9e8"), new Guid("00000000-0000-0000-0000-000000000000"), "Listar", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("382137f8-6b86-4dc5-afef-0b5b5d8da9e8"), "Cadastro de Operadoras", null, "Realiza o cadastro de Operadoras", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(6952), null, "", true, false, "", new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("00000000-0000-0000-0000-000000000000"), "Operadoras", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), "Menu de Cadastros", null, "Menu para realizar diversos cadastros", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(3244), null, "", true, false, "", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), "Cadastros", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6c4e8777-fa3f-4426-918d-deddd7137283"), "Cadastro de Clientes", null, "Realiza o cadastro de Clientes", null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8168), null, "", true, false, "", new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("00000000-0000-0000-0000-000000000000"), "Clientes", null, null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Systems",
                columns: new[] { "SystemId", "Alt", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "Image", "IsActive", "IsAdmin", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), "Sistema Administrativo", "Sistema Administrativo", null, new DateTime(2021, 2, 25, 21, 20, 24, 75, DateTimeKind.Local).AddTicks(8981), null, "", true, false, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "SystemsLanguages",
                columns: new[] { "SystemLanguageId", "DtDeleted", "DtInsert", "IsActive", "IsDefault", "IsDeleted", "LanguageId", "SystemId", "UserIdDeleted", "UserIdInsert" },
                values: new object[,]
                {
                    { new Guid("38382b3a-1429-4a39-bcc7-fb87cbd9013a"), null, new DateTime(2021, 2, 25, 21, 20, 24, 77, DateTimeKind.Local).AddTicks(5888), true, true, false, new Guid("86d31897-dccd-466a-8556-26339bd950bd"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, null },
                    { new Guid("c55d0b97-aa53-4563-8130-b91a986f8e44"), null, new DateTime(2021, 2, 25, 21, 20, 24, 77, DateTimeKind.Local).AddTicks(5118), true, true, false, new Guid("2befa0f0-8d50-43e2-8205-e7b48fea30e5"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, null },
                    { new Guid("81ccc119-bfd8-46c9-8458-211ce8ea43e2"), null, new DateTime(2021, 2, 25, 21, 20, 24, 77, DateTimeKind.Local).AddTicks(5803), true, true, false, new Guid("c49c735d-01c6-4638-96f4-ad24384c6e37"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, null }
                });

            migrationBuilder.InsertData(
                table: "SystemsMenus",
                columns: new[] { "SystemMenuId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[,]
                {
                    { new Guid("99591ecb-9230-453c-8410-1d306b14bc36"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8682), null, true, false, new Guid("2bb7caa7-090a-43a7-bf7b-63698ca451ce"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b226fe02-feb8-4214-8419-b1c6df264ce2"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(9060), null, true, false, new Guid("d954c734-4698-4b60-a124-9c793f7d1844"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("017db78c-3692-4805-a93e-43566e830d49"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8978), null, true, false, new Guid("33e5cd0f-0f12-41af-a9c9-19384d0e187c"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c4772638-3713-420e-8f3b-c4c3a8e4edf9"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8906), null, true, false, new Guid("c7978496-90b1-4156-804f-dcc614d2ef41"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("36f0f258-ce84-46c1-ad5b-3d3ee1e938a2"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8833), null, true, false, new Guid("68988722-b166-4557-8703-3ecd40b541ef"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2283c782-aec2-426b-b70c-08075588c0bc"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8595), null, true, false, new Guid("bfce1171-184c-4be0-a6b8-380bdacb1c53"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0befa13f-4547-4f2a-8b92-301a34083ae8"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8521), null, true, false, new Guid("0ec52e08-5673-44bc-9e86-760f90ab545c"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b97556f6-82c6-4511-a7c6-4903fcf02c73"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8447), null, true, false, new Guid("a7774782-f273-45f9-b7cc-57db0ca9c137"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ba359478-9cec-4794-813b-c259f7aca43e"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8368), null, true, false, new Guid("3ed13203-b426-4546-ac19-4056a0a8d09b"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("69b84756-1f1e-40cb-9ea2-81c4c3334dba"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8285), null, true, false, new Guid("c1ab8b0e-5924-4eea-b00c-04f8be296f14"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("69bc1167-0bbb-4b1f-bf4f-632cef2b53a3"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8210), null, true, false, new Guid("6c4e8777-fa3f-4426-918d-deddd7137283"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("71b3fcbe-28e1-4286-8d1c-7e6a8ab2df78"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(8044), null, true, false, new Guid("1c36321b-9a0d-4ea3-8b3f-4eebe592e47f"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f9565876-d104-4b98-905e-86e790d60da3"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7965), null, true, false, new Guid("44229aa4-5829-401b-a5a5-5bce6a80213c"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("3a1c9abb-d1cc-4111-9f4c-5c02095ce2c2"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7880), null, true, false, new Guid("90dedb31-edeb-4586-bef1-0fa0adc29579"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("87ece385-c880-46ab-91eb-5e76e90be86e"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7808), null, true, false, new Guid("c3fa2829-841f-4b24-a5f3-198a5ce6ba89"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c0f11ef2-2bac-44d5-bcdb-f7ee20671899"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7728), null, true, false, new Guid("f5468620-bf4b-42ce-9172-9d831a843053"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("a350dd5a-5017-4174-b0dd-ad84b19529b0"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7646), null, true, false, new Guid("d5f8eab7-deed-4f97-bc54-74452c6b526e"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("6d68c490-5094-4e4f-a071-5da83dfef03e"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7397), null, true, false, new Guid("a967e47e-dac3-42f5-8acd-b72487c01164"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("b43bebf4-4f32-4f7d-a0c8-e626c9942498"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7158), null, true, false, new Guid("1e962bb1-adeb-4b14-8f74-f3028302af66"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("38e2344f-abab-4e9d-a1fe-a1eb5fa38202"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(7062), null, true, false, new Guid("382137f8-6b86-4dc5-afef-0b5b5d8da9e8"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("d33899aa-8717-4263-af00-08436a988119"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(5998), null, true, false, new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("83ca2637-0956-426c-a575-b69cad8c024a"), null, new DateTime(2021, 2, 25, 21, 20, 24, 78, DateTimeKind.Local).AddTicks(9135), null, true, false, new Guid("9d938b84-4305-49db-abd6-90537d2e5935"), new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CellPhone", "ClientId", "Cpf", "DtBirth", "DtDeleted", "DtInsert", "DtLastUpdate", "Gender", "Icone", "IsActive", "IsDeleted", "Name", "Nationality", "Phone", "Rg", "Surname", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("0c795b55-d7ad-480e-9a44-4e0e1979f777"), null, new Guid("caf06b02-f3cc-45d8-8617-617bd7427b4c"), null, null, null, new DateTime(2021, 2, 25, 21, 20, 24, 80, DateTimeKind.Local).AddTicks(2442), null, null, null, true, false, "Administrador", null, null, null, "Master", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "UsersAccess",
                columns: new[] { "UserAccessId", "DTVerify", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "IsVerify", "Login", "Password", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("a8428819-53bc-4e94-abbf-96c393182940"), null, null, new DateTime(2021, 2, 25, 21, 20, 24, 80, DateTimeKind.Local).AddTicks(6508), null, true, false, true, "user@uzenix.com", "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==", new Guid("0c795b55-d7ad-480e-9a44-4e0e1979f777"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissions",
                columns: new[] { "UserPermissionId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "GroupUserId", "IsActive", "IsDeleted", "SystemId", "UserId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36"), new Guid("caf06b02-f3cc-45d8-8617-617bd7427b4c"), null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(1848), null, new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"), true, false, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), new Guid("0c795b55-d7ad-480e-9a44-4e0e1979f777"), null, null, null });

            migrationBuilder.InsertData(
                table: "UsersPermissionsMenus",
                columns: new[] { "UserPermissionMenuId", "C", "D", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "MenuId", "R", "U", "UserIdDeleted", "UserIdInsert", "UserIdUpdate", "UserPermissionId" },
                values: new object[,]
                {
                    { new Guid("895e4661-965b-496f-8dcb-188b85a76922"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7272), null, true, false, new Guid("d954c734-4698-4b60-a124-9c793f7d1844"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("005cdb2a-fc84-4e1e-ae9b-83040fa1adcf"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7249), null, true, false, new Guid("33e5cd0f-0f12-41af-a9c9-19384d0e187c"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("57264c1c-b65e-4d02-bd15-3b3e8fab534b"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7227), null, true, false, new Guid("c7978496-90b1-4156-804f-dcc614d2ef41"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("bd7a63e0-b7bd-4a50-840a-a41394422305"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7204), null, true, false, new Guid("68988722-b166-4557-8703-3ecd40b541ef"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("7aaa450c-a022-418b-8180-de839d5b0604"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7179), null, true, false, new Guid("2bb7caa7-090a-43a7-bf7b-63698ca451ce"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("643d5d9e-c7bd-432c-a367-40f8dc6822b6"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7157), null, true, false, new Guid("bfce1171-184c-4be0-a6b8-380bdacb1c53"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("17d6dcf6-fcb0-4bb9-9f27-850cdc6ab90a"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7134), null, true, false, new Guid("0ec52e08-5673-44bc-9e86-760f90ab545c"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("724ec283-0dc3-42bc-892f-bac35072e64d"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7108), null, true, false, new Guid("a7774782-f273-45f9-b7cc-57db0ca9c137"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("bef42e3c-64a5-41e6-9bd6-fbddae68f46e"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7086), null, true, false, new Guid("3ed13203-b426-4546-ac19-4056a0a8d09b"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("d5438166-1f6c-4647-9256-bf892aec8980"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7063), null, true, false, new Guid("c1ab8b0e-5924-4eea-b00c-04f8be296f14"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("3abde493-3f12-4805-b75f-2417613e874e"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7294), null, true, false, new Guid("9d938b84-4305-49db-abd6-90537d2e5935"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("407d5abd-1bed-4220-ac49-54e5e10e23bb"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7006), null, true, false, new Guid("1c36321b-9a0d-4ea3-8b3f-4eebe592e47f"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("dc2155fd-f6a9-4eba-b4f7-12257f38b1f7"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6804), null, true, false, new Guid("44229aa4-5829-401b-a5a5-5bce6a80213c"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("b9fb95af-0679-43f3-ac63-88c75163d357"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6782), null, true, false, new Guid("90dedb31-edeb-4586-bef1-0fa0adc29579"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("a5ee48ff-35fd-44e7-a6d1-6785735910d3"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6759), null, true, false, new Guid("c3fa2829-841f-4b24-a5f3-198a5ce6ba89"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("3f8b0de3-2bc5-43b4-beab-d3733eb4d505"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6729), null, true, false, new Guid("f5468620-bf4b-42ce-9172-9d831a843053"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("f06daf42-8a5a-4043-bcbc-512b669a8851"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6701), null, true, false, new Guid("d5f8eab7-deed-4f97-bc54-74452c6b526e"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("b90fe7ca-5c90-4d33-beb4-2c0ff96b6f37"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6678), null, true, false, new Guid("a967e47e-dac3-42f5-8acd-b72487c01164"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("1a0a0ea4-83f1-460e-8519-d85db59b0d8c"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6653), null, true, false, new Guid("1e962bb1-adeb-4b14-8f74-f3028302af66"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("ddea1d9c-243c-4afd-86a9-a71bbec653bc"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6614), null, true, false, new Guid("382137f8-6b86-4dc5-afef-0b5b5d8da9e8"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("d45c4ea1-f326-4144-86a4-06298e98d535"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(6329), null, true, false, new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") },
                    { new Guid("474b7932-1e28-4777-8bf7-1d1b4ee3e7c5"), true, true, null, new DateTime(2021, 2, 25, 21, 20, 24, 81, DateTimeKind.Local).AddTicks(7040), null, true, false, new Guid("6c4e8777-fa3f-4426-918d-deddd7137283"), true, true, null, null, null, new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36") }
                });

            migrationBuilder.InsertData(
                table: "UsersTypes",
                columns: new[] { "UserTypeId", "Description", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "Name", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("42ab4ce7-3982-449f-aa5f-6c14a6067789"), "usuário administrativo", null, new DateTime(2021, 2, 25, 21, 20, 24, 79, DateTimeKind.Local).AddTicks(9418), null, true, false, "Administrativo", null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.InsertData(
                table: "ClientsSystems",
                columns: new[] { "ClientSystemId", "ClientId", "DtDeleted", "DtInsert", "DtLastUpdate", "IsActive", "IsDeleted", "SystemId", "UserIdDeleted", "UserIdInsert", "UserIdUpdate" },
                values: new object[] { new Guid("b4e19551-5a4c-443c-b425-852237ec1a6e"), new Guid("caf06b02-f3cc-45d8-8617-617bd7427b4c"), null, new DateTime(2021, 2, 25, 21, 20, 24, 76, DateTimeKind.Local).AddTicks(3285), null, true, false, new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"), null, new Guid("00000000-0000-0000-0000-000000000000"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: new Guid("caf06b02-f3cc-45d8-8617-617bd7427b4c"));

            migrationBuilder.DeleteData(
                table: "ClientsSystems",
                keyColumn: "ClientSystemId",
                keyValue: new Guid("b4e19551-5a4c-443c-b425-852237ec1a6e"));

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "GroupUserId",
                keyValue: new Guid("d24332bd-49ec-4330-8de7-b81b2ac0d2fa"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("05ac37f2-ac5f-42ff-a13f-9e3afc17e30e"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("13b0e5c4-ee76-4001-bba6-72ac7c7cbc33"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("20b8ebc3-a231-4cf3-bcd9-03bb38d51e18"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("35813609-170c-4a32-816d-c7b21ecd275b"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("39a45809-c7bf-4a62-a509-82807aaf091d"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("3ff89d06-3ee9-47a6-b96a-67aa8b797598"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("500bb59c-c2ec-4477-9104-0f8474ae7543"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("571c4c3d-05e7-4d3c-83f0-3f20390e4198"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("68a43cb2-1fe3-4889-b755-f628812970ce"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("6a264290-0f9a-4876-b547-cb2f75395aaf"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("78938957-6a30-4501-b8ca-cd2144df2a30"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("7b47fd8c-6211-47a9-be3c-c7db7750c9c8"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("9705a92a-7b3b-4bfe-b7d5-1635ef598136"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("986c21d3-c1b5-4a17-9f4b-3892e1b5c981"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("aafa1454-9070-454e-b07b-6245fab6fb57"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c7c392a4-9367-4ce7-b0f0-09e473969517"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("c805bc23-d65e-4f3f-9ff2-979c1c942539"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("d381ff97-2095-4693-a421-7afe9b886ca4"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("e7e77f4a-c0d7-4993-9e6d-172aa448f233"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("ec81b2cf-9cf6-4497-98ab-6a66f76c0e6f"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f3382336-a899-49f4-80a6-794c4dbcff70"));

            migrationBuilder.DeleteData(
                table: "GroupUsersMenus",
                keyColumn: "GroupUserMenuId",
                keyValue: new Guid("f3c4a049-9fb1-49eb-8eaf-2cd68ef34692"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2befa0f0-8d50-43e2-8205-e7b48fea30e5"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("86d31897-dccd-466a-8556-26339bd950bd"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c49c735d-01c6-4638-96f4-ad24384c6e37"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("0ec52e08-5673-44bc-9e86-760f90ab545c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1c36321b-9a0d-4ea3-8b3f-4eebe592e47f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("1e962bb1-adeb-4b14-8f74-f3028302af66"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("2bb7caa7-090a-43a7-bf7b-63698ca451ce"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("33e5cd0f-0f12-41af-a9c9-19384d0e187c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("382137f8-6b86-4dc5-afef-0b5b5d8da9e8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("3ed13203-b426-4546-ac19-4056a0a8d09b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("44229aa4-5829-401b-a5a5-5bce6a80213c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("68988722-b166-4557-8703-3ecd40b541ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("6c4e8777-fa3f-4426-918d-deddd7137283"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("7bf468ed-2890-4482-8d62-61c80a30874a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("90dedb31-edeb-4586-bef1-0fa0adc29579"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("9d938b84-4305-49db-abd6-90537d2e5935"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a7774782-f273-45f9-b7cc-57db0ca9c137"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("a967e47e-dac3-42f5-8acd-b72487c01164"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("bfce1171-184c-4be0-a6b8-380bdacb1c53"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c1ab8b0e-5924-4eea-b00c-04f8be296f14"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c3fa2829-841f-4b24-a5f3-198a5ce6ba89"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("c7978496-90b1-4156-804f-dcc614d2ef41"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d5f8eab7-deed-4f97-bc54-74452c6b526e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("d954c734-4698-4b60-a124-9c793f7d1844"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "MenuId",
                keyValue: new Guid("f5468620-bf4b-42ce-9172-9d831a843053"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("38382b3a-1429-4a39-bcc7-fb87cbd9013a"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("81ccc119-bfd8-46c9-8458-211ce8ea43e2"));

            migrationBuilder.DeleteData(
                table: "SystemsLanguages",
                keyColumn: "SystemLanguageId",
                keyValue: new Guid("c55d0b97-aa53-4563-8130-b91a986f8e44"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("017db78c-3692-4805-a93e-43566e830d49"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("0befa13f-4547-4f2a-8b92-301a34083ae8"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("2283c782-aec2-426b-b70c-08075588c0bc"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("36f0f258-ce84-46c1-ad5b-3d3ee1e938a2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("38e2344f-abab-4e9d-a1fe-a1eb5fa38202"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("3a1c9abb-d1cc-4111-9f4c-5c02095ce2c2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("69b84756-1f1e-40cb-9ea2-81c4c3334dba"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("69bc1167-0bbb-4b1f-bf4f-632cef2b53a3"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("6d68c490-5094-4e4f-a071-5da83dfef03e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("71b3fcbe-28e1-4286-8d1c-7e6a8ab2df78"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("83ca2637-0956-426c-a575-b69cad8c024a"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("87ece385-c880-46ab-91eb-5e76e90be86e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("99591ecb-9230-453c-8410-1d306b14bc36"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("a350dd5a-5017-4174-b0dd-ad84b19529b0"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b226fe02-feb8-4214-8419-b1c6df264ce2"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b43bebf4-4f32-4f7d-a0c8-e626c9942498"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("b97556f6-82c6-4511-a7c6-4903fcf02c73"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("ba359478-9cec-4794-813b-c259f7aca43e"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c0f11ef2-2bac-44d5-bcdb-f7ee20671899"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("c4772638-3713-420e-8f3b-c4c3a8e4edf9"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("d33899aa-8717-4263-af00-08436a988119"));

            migrationBuilder.DeleteData(
                table: "SystemsMenus",
                keyColumn: "SystemMenuId",
                keyValue: new Guid("f9565876-d104-4b98-905e-86e790d60da3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("0c795b55-d7ad-480e-9a44-4e0e1979f777"));

            migrationBuilder.DeleteData(
                table: "UsersAccess",
                keyColumn: "UserAccessId",
                keyValue: new Guid("a8428819-53bc-4e94-abbf-96c393182940"));

            migrationBuilder.DeleteData(
                table: "UsersPermissions",
                keyColumn: "UserPermissionId",
                keyValue: new Guid("eed50e92-6855-4f16-bd7a-74914fd82e36"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("005cdb2a-fc84-4e1e-ae9b-83040fa1adcf"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("17d6dcf6-fcb0-4bb9-9f27-850cdc6ab90a"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("1a0a0ea4-83f1-460e-8519-d85db59b0d8c"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3abde493-3f12-4805-b75f-2417613e874e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("3f8b0de3-2bc5-43b4-beab-d3733eb4d505"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("407d5abd-1bed-4220-ac49-54e5e10e23bb"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("474b7932-1e28-4777-8bf7-1d1b4ee3e7c5"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("57264c1c-b65e-4d02-bd15-3b3e8fab534b"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("643d5d9e-c7bd-432c-a367-40f8dc6822b6"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("724ec283-0dc3-42bc-892f-bac35072e64d"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("7aaa450c-a022-418b-8180-de839d5b0604"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("895e4661-965b-496f-8dcb-188b85a76922"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("a5ee48ff-35fd-44e7-a6d1-6785735910d3"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b90fe7ca-5c90-4d33-beb4-2c0ff96b6f37"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("b9fb95af-0679-43f3-ac63-88c75163d357"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bd7a63e0-b7bd-4a50-840a-a41394422305"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("bef42e3c-64a5-41e6-9bd6-fbddae68f46e"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d45c4ea1-f326-4144-86a4-06298e98d535"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("d5438166-1f6c-4647-9256-bf892aec8980"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("dc2155fd-f6a9-4eba-b4f7-12257f38b1f7"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("ddea1d9c-243c-4afd-86a9-a71bbec653bc"));

            migrationBuilder.DeleteData(
                table: "UsersPermissionsMenus",
                keyColumn: "UserPermissionMenuId",
                keyValue: new Guid("f06daf42-8a5a-4043-bcbc-512b669a8851"));

            migrationBuilder.DeleteData(
                table: "UsersTypes",
                keyColumn: "UserTypeId",
                keyValue: new Guid("42ab4ce7-3982-449f-aa5f-6c14a6067789"));

            migrationBuilder.DeleteData(
                table: "Systems",
                keyColumn: "SystemId",
                keyValue: new Guid("692d0e8f-5293-4fad-bd93-79b1508f1f5d"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PaymentMethods",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberIsVisible2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Specialties",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "VideoLink",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Whats",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "WhatsIsVisible",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "amenities",
                table: "Customers");

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
    }
}
