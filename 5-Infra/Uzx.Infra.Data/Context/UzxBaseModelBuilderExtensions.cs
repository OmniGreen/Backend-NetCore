using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.EntityConfig.Admin;
public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var ClientId = Guid.NewGuid();
        var SystemId = Guid.NewGuid();
        var LanguageId = Guid.NewGuid();
        var lstMenus = new List<Guid>();

        //Adicionando o Cliente Master
        modelBuilder.Entity<Clients>().HasData(
           new Clients
           {
               Name1 = "Administrador Uzenix",
               Name2 = "Admin",
               IdParent = default(System.Guid),
               Person = "1",
               IsAdmin = true,
               IsActive = true,
               IsDeleted = false,
               DtInsert = DateTime.Now,
               UserIdInsert = default(System.Guid),
               IdClient = ClientId
           }
        );

        //modelBuilder.Entity<Systems>().HasData(
        //   new Systems
        //   {
        //       Name = "Administrativo",
        //       Description = "Sistema Administrativo",
        //       Alt = "Sistema Administrativo",
        //       Image = "",
        //       IsActive = true,
        //       IsDeleted = false,
        //       DtInsert = DateTime.Now,
        //       UserIdInsert = default(System.Guid),
        //       SystemId = SystemId
        //   }
        //);


        //modelBuilder.Entity<ClientsSystems>().HasData(
        //   new ClientsSystems
        //   {
        //       SystemId = SystemId,
        //       ClientId = ClientId,
        //       IsActive = true,
        //       IsDeleted = false,
        //       DtInsert = DateTime.Now,
        //       UserIdInsert = default(System.Guid),
        //       ClientSystemId = Guid.NewGuid()
        //   }
        //);
//        modelBuilder.Entity<Languages>().HasData(
//           new Languages
//           {
//               Name = "Portugues",
//               Description = "Idioma em Portugues Brasileiro",
//               Alt = "Idioma do país Brasil",
//               Country = "Brasil",
//               FileName = "ptbr.js",
//               Image = "png",
//               IsActive = true,
//               IsDeleted = false,
//               DtInsert = DateTime.Now,
//               UserIdInsert = default(System.Guid),
//               LanguageId = LanguageId
//           }
//        );

//        modelBuilder.Entity<SystemsLanguages>().HasData(
//           new SystemsLanguages
//           {
//               SystemLanguageId = Guid.NewGuid(),
//               SystemId = SystemId,
//               LanguageId = LanguageId,
//               IsDefault = true,
//               IsActive = true,
//               IsDeleted = false,
//               DtInsert = DateTime.Now
//           }
//        );


//        LanguageId = Guid.NewGuid();

//        modelBuilder.Entity<Languages>().HasData(
//           new Languages
//           {
//               Name = "Inglês",
//               Description = "Idioma em Inglês Norte Americano",
//               Alt = "Idioma do país EUA",
//               Country = "EUA",
//               FileName = "us.js",
//               Image = "png",
//               IsActive = true,
//               IsDeleted = false,
//               DtInsert = DateTime.Now,
//               UserIdInsert = default(System.Guid),
//               LanguageId = LanguageId
//           }
//        );

//        modelBuilder.Entity<SystemsLanguages>().HasData(
//           new SystemsLanguages
//           {
//               SystemLanguageId = Guid.NewGuid(),
//               SystemId = SystemId,
//               LanguageId = LanguageId,
//               IsDefault = true,
//               IsActive = true,
//               IsDeleted = false,
//               DtInsert = DateTime.Now
//           }
//        );


//        LanguageId = Guid.NewGuid();

//        modelBuilder.Entity<Languages>().HasData(
//           new Languages
//           {
//               Name = "Espanhol",
//               Description = "Idioma em Espanhol da Espanha.",
//               Alt = "Idioma do país Espanha.",
//               Country = "Espanha",
//               FileName = "es.js",
//               Image = "png",
//               IsActive = true,
//               IsDeleted = false,
//               DtInsert = DateTime.Now,
//               UserIdInsert = default(System.Guid),
//               LanguageId = LanguageId
//           }
//        );

//        modelBuilder.Entity<SystemsLanguages>().HasData(
//           new SystemsLanguages
//           {
//               SystemLanguageId = Guid.NewGuid(),
//               SystemId = SystemId,
//               LanguageId = LanguageId,
//               IsDefault = true,
//               IsActive = true,
//               IsDeleted = false,
//               DtInsert = DateTime.Now
//           }
//        );

//        var GroupUserId = Guid.NewGuid();

//        modelBuilder.Entity<GroupUsers>().HasData(
//          new GroupUsers
//          {
//              SystemId = SystemId,
//              Name = "Administradores",
//              IsActive = true,
//              IsDeleted = false,
//              DtInsert = DateTime.Now,
//              GroupUserId = GroupUserId
//          }
//       );


//        var MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        var MenuIDPai = MenuId;

//        modelBuilder.Entity<Menus>().HasData(
//         new Menus
//         {
//             Name = "Cadastros",
//             Alt = "Menu de Cadastros",
//             Description = "Menu para realizar diversos cadastros",
//             Link = "",
//             Icone = "",
//             MenuIdPai = default(System.Guid),
//             IsActive = true,
//             IsDeleted = false,
//             DtInsert = DateTime.Now,
//             UserIdInsert = default(System.Guid),
//             MenuId = MenuId
//         }
//      );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        var MenuSubItemPai = MenuId;
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Operadoras",
//            Alt = "Cadastro de Operadoras",
//            Description = "Realiza o cadastro de Operadoras",
//            Link = "",
//            Icone = "",
//            MenuIdPai = MenuIDPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );


//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Listar",
//            Alt = "Listagem de Operadoras",
//            Description = "Realiza a busca de Operadoras",
//            Link = "companyoperators/list",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Cadastrar",
//            Alt = "Cadastro de Operadoras",
//            Description = "Realiza o cadastro de Operadoras",
//            Link = "companyoperators/details",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );


//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        MenuSubItemPai = MenuId;
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Usuarios",
//            Alt = "Cadastro de Usuarios",
//            Description = "Realiza o cadastro de Usuarios",
//            Link = "",
//            Icone = "",
//            MenuIdPai = MenuIDPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Listar",
//            Alt = "Listagem de Usuarios",
//            Description = "Realiza a busca de Usuarios",
//            Link = "users/list",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Cadastrar",
//            Alt = "Cadastro de Usuarios",
//            Description = "Realiza o cadastro de Usuarios",
//            Link = "users/details",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );






//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        MenuSubItemPai = MenuId;
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Menus",
//            Alt = "Cadastro de Menus",
//            Description = "Realiza o cadastro de Menus",
//            Link = "",
//            Icone = "",
//            MenuIdPai = MenuIDPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Listar",
//            Alt = "Listagem de Menus",
//            Description = "Realiza a busca de Menus",
//            Link = "menus/list",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Cadastrar",
//            Alt = "Cadastro de Menus",
//            Description = "Realiza o cadastro de Menus",
//            Link = "menus/details",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );






//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        MenuSubItemPai = MenuId;
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Clientes",
//            Alt = "Cadastro de Clientes",
//            Description = "Realiza o cadastro de Clientes",
//            Link = "",
//            Icone = "",
//            MenuIdPai = MenuIDPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Listar",
//            Alt = "Listagem de Clientes",
//            Description = "Realiza a busca de Clientes",
//            Link = "clients/list",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Cadastrar",
//            Alt = "Cadastro de Clientes",
//            Description = "Realiza o cadastro de Clientes",
//            Link = "clients/details",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );





//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        MenuSubItemPai = MenuId;
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Idiomas",
//            Alt = "Cadastro de Idiomas",
//            Description = "Realiza o cadastro de Idiomas",
//            Link = "",
//            Icone = "",
//            MenuIdPai = MenuIDPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Listar",
//            Alt = "Listagem de Idiomas",
//            Description = "Realiza a busca de Idiomas",
//            Link = "languages/list",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Cadastrar",
//            Alt = "Cadastro de Idiomas",
//            Description = "Realiza o cadastro de Idiomas",
//            Link = "languages/details",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );










//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        MenuSubItemPai = MenuId;
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Sistemas",
//            Alt = "Cadastro de Sistemas",
//            Description = "Realiza o cadastro de Sistemas",
//            Link = "",
//            Icone = "",
//            MenuIdPai = MenuIDPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Listar",
//            Alt = "Listagem de Sistemas",
//            Description = "Realiza a busca de Sistemas",
//            Link = "systems/list",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Cadastrar",
//            Alt = "Cadastro de Sistemas",
//            Description = "Realiza o cadastro de Sistemas",
//            Link = "systems/details",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );







//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        MenuSubItemPai = MenuId;
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Grupo de Usuarios",
//            Alt = "Cadastro de Grupo de Usuarios",
//            Description = "Realiza o cadastro de Grupo de Usuarios",
//            Link = "",
//            Icone = "",
//            MenuIdPai = MenuIDPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Listar",
//            Alt = "Listagem de Grupo de Usuarios",
//            Description = "Realiza a busca de Grupo de Usuarios",
//            Link = "groupusers/list",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );

//        MenuId = Guid.NewGuid();
//        lstMenus.Add(MenuId);
//        modelBuilder.Entity<Menus>().HasData(
//        new Menus
//        {
//            Name = "Cadastrar",
//            Alt = "Cadastro de Grupo de Usuarios",
//            Description = "Realiza o cadastro de Grupo de Usuarios",
//            Link = "groupusers/details",
//            Icone = "",
//            MenuIdPai = MenuSubItemPai,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            MenuId = MenuId
//        }
//     );

//        modelBuilder.Entity<SystemsMenus>().HasData(
//        new SystemsMenus
//        {
//            SystemId = SystemId,
//            MenuId = MenuId,
//            IsActive = true,
//            IsDeleted = false,
//            DtInsert = DateTime.Now,
//            UserIdInsert = default(System.Guid),
//            SystemMenuId = Guid.NewGuid()
//        }
//     );



//        ////ADICIONANDO OS MENUS DO SISTEMA ADMINISTRATIVO AO GRUPO DE USUARIO
//        //var listSystemsMenus = (from sm in context.SystemsMenus
//        //                        where sm.SystemID == oSystems.SystemID
//        //                        select sm
//        //                         ).ToList();


//        foreach (var item in lstMenus)
//        {
//            //Adicionamento menu ao grupo de usuario
//            modelBuilder.Entity<GroupUsersMenus>().HasData(
//               new GroupUsersMenus
//               {
//                   GroupUserMenuId = Guid.NewGuid(),
//                   GroupUserId = GroupUserId,
//                   SystemId = SystemId,
//                   MenuId = item,
//                   //ClientId = ClientId,
//                   C = true,
//                   R = true,
//                   U = true,
//                   D = true,
//                   IsActive = true,
//                   IsDeleted = false,
//                   DtInsert = DateTime.Now
//               }
//            );
//        }


//        modelBuilder.Entity<UsersTypes>().HasData(
//      new UsersTypes
//      {
//          Name = "Administrativo",
//          Description = "usuário administrativo",
//          IsActive = true,
//          IsDeleted = false,
//          DtInsert = DateTime.Now,
//          UserIdInsert = default(System.Guid),
//          UserTypeId = Guid.NewGuid()
//      }
//   );
//        var UserId = Guid.NewGuid();
//        modelBuilder.Entity<Users>().HasData(
//      new Users
//      {
//          Name = "Administrador",
//          Surname = "Master",
//          ClientId = ClientId,
//          IsActive = true,
//          IsDeleted = false,
//          DtInsert = DateTime.Now,
//          UserIdInsert = default(System.Guid),
//          //UserTypeID = usType.UserTypeID,
//              UserId = UserId
//      }
//   );

//        modelBuilder.Entity<UsersProfile>().HasData(
//     new UsersProfile
//     {
//         Login = "user@uzenix.com",
//         UserId = UserId,
//         Password = "AO5+45YXX6IBTW3FF/sVqz7BxjClYY3xE0qkWef8lLgJOnM7Rk6cUiF3t8v5huFcWw==",
//         DtInsert = DateTime.Now,
//         IsActive = true,
//         IsDeleted = false,
//         IsVerify = true,
//         UserAccessId = Guid.NewGuid()
//     }
//  );
//        var UserPermissionId = Guid.NewGuid();
//        modelBuilder.Entity<UsersPermissions>().HasData(
//     new UsersPermissions
//     {
//         UserPermissionId = UserPermissionId,
//         ClientId = ClientId,
//         UserId = UserId,
//         SystemId = SystemId,
//         GroupUserId = GroupUserId,
//         IsActive = true,
//         IsDeleted = false,
//         DtInsert = DateTime.Now
//     }
//  );





//        ////ADICIONANDO OS MENUS DO SGRUPO DE USUARIO AO USUARIO
//        //var listGroupUserMenus = (from gum in context.GroupUsersMenus
//        //                          where gum.GroupUserID == oGroupUsers.GroupUserID
//        //                          select gum
//        //                         ).ToList();


//        foreach (var item in lstMenus)
//        {
//            modelBuilder.Entity<UsersPermissionsMenus>().HasData(
//     new UsersPermissionsMenus
//     {
//         UserPermissionMenuId = Guid.NewGuid(),
//         UserPermissionId = UserPermissionId,
//         MenuId = item,
//         C = true,
//         R = true,
//         U = true,
//         D = true,
//         IsActive = true,
//         IsDeleted = false,
//         DtInsert = DateTime.Now
//     }
//  );


           
//        }






   }
}