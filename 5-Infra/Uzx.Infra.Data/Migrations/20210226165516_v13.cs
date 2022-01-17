using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uzx.Infra.Data.Migrations
{
    public partial class v13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "amenities",
                table: "Customers",
                newName: "Amenities");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Amenities",
                table: "Customers",
                newName: "amenities");

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
    }
}
