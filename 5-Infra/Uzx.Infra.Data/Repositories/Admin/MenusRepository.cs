using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects.Admin;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class MenusRepository : BaseRepository<Menus>, IMenusRepository
    {
        public MenusRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {

        }

        //public async Task<List<MenusTrans>> GetAllByUser(UsersPermissionsTrans searchRecord)
        //{
        //    // Declaração de variaveis
        //    List<MenusTrans> listRecord = new List<MenusTrans>();
        //    MenusTrans singleRecord = new MenusTrans();
        //        // Realiza o comando Linq de consulta
        //        var data = await (from up in Db.UsersPermissions
        //                    join upm in Db.UsersPermissionsMenus
        //                        on up.UserPermissionId equals upm.UserPermissionId
        //                    join r in Db.Menus
        //                        on upm.MenuId equals r.MenuId
        //                    where up.UserId == Guid.Parse(searchRecord.UserId)
        //                            && up.ClientId   == Guid.Parse(searchRecord.ClientId)
        //                            && up.SystemId == Guid.Parse(searchRecord.SystemId)
        //                            && r.IsDeleted == false
        //                            && r.IsActive == true
        //                            && up.IsActive == true
        //                            && up.IsDeleted == false
        //                            && upm.IsActive == true
        //                            && upm.IsDeleted == false
        //                    orderby r.Name
        //                    select r).ToListAsync();

        //        listRecord = FillRecursive(data, default(System.Guid), 3).ToList();

        //    // Retorna a lista
        //    return listRecord;
        //}


        //private static List<MenusTrans> FillRecursive(List<Menus> flatObjects, Guid parentId, int espaco)
        //{
        //    List<MenusTrans> recursiveObjects = new List<MenusTrans>();
        //    List<MenusTrans> listContador = new List<MenusTrans>();
        //    bool hasChildren = false;
        //    foreach (var item in flatObjects.Where(x => x.MenuIdPai.Equals(parentId)))
        //    {
        //        listContador = FillRecursive(flatObjects, item.MenuId, espaco + 3);
        //        hasChildren = listContador.Count() > 0;
        //        string teste = item.Name;
        //        recursiveObjects.Add(new MenusTrans
        //        {
        //            Children = listContador,
        //            MenuId = item.MenuId,
        //            Name = item.Name,
        //            NameLink = teste.Replace(" ", ""),
        //            Description = item.Description,
        //            Link = item.Link,
        //            TaRget = item.Target,
        //            Icone = item.Icone,
        //            Alt = item.Alt,
        //            IsActive = item.IsActive,
        //            MenusTypeId = item.MenusTypeId,
        //            MenuIdPai = item.MenuIdPai,
        //            Space = espaco,
        //            HasChildren = hasChildren

        //        });
        //    }

        //    return recursiveObjects;
        //}

    }
}
