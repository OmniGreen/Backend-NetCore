using System;
using System.Collections.Generic;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Infra.Data.Interfaces.Admin;
using System.Linq;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class ClientsRepository : BaseRepository<Clients>, IClientsRepository
    {
        public ClientsRepository(UzxBaseDbContext TTGContext)
            :base(TTGContext)
        {
        }

        public ClientsFind List(ClientsFind searchRecord)
        {
            // Declaração de variaveis
            List<ClientsTrans> listRecord = new List<ClientsTrans>();
            ClientsTrans singleRecord;

            // Variaveis para a paginação
            int iniRegistros = (searchRecord.Page - 1) * searchRecord.QtdRegistros;
            bool Ativo = Convert.ToBoolean(((searchRecord.Active == "2") ? 0 : Convert.ToInt32(searchRecord.Active)));


                List<Clients> listClientsRecords = new List<Clients>();

                if (Convert.ToBoolean(searchRecord.IsAdmin))
                {
                    // Realiza o comando Linq de consulta
                    listClientsRecords = (from r in Db.Clients
                                          where (searchRecord.Name.Equals(null) || r.Name1.Contains(searchRecord.Name))
                                             && (searchRecord.Active == "2" || r.IsActive == Ativo)
                                             && r.IsDeleted == false
                                             && r.ParentId == default(System.Guid)
                                          select r).ToList();
                }
                else
                {
                    // Realiza o comando Linq de consulta
                    listClientsRecords = (from r in Db.Clients
                                          where (searchRecord.Name.Equals(null) || r.Name1.Contains(searchRecord.Name))
                                             && (searchRecord.Active == "2" || r.IsActive == Ativo)
                                             && r.IsDeleted == false
                                             && (r.ParentId == searchRecord.MatrizClientId || r.ClientId == searchRecord.MatrizClientId)
                                          select r).ToList();
                }


                // Filtra apenas a pagina com a quantidade de registros a ser exibidos
                var resultado = listClientsRecords.Skip(iniRegistros).Take(searchRecord.QtdRegistros).ToList();

                // Loop para adicionar o registro a lista
                foreach (var iten in resultado)
                {
                    singleRecord = new ClientsTrans();
                    singleRecord.ClientId = iten.ClientId;
                    singleRecord.Person = iten.Person;
                    singleRecord.Name1 = iten.Name1;
                    singleRecord.Name2 = iten.Name2;
                    singleRecord.Document1 = iten.Document1;
                    singleRecord.Document2 = iten.Document2;
                    singleRecord.Gender = iten.Gender;
                    singleRecord.DtBirth = iten.DtBirth;
                    singleRecord.IsActive = iten.IsActive;
                    listRecord.Add(singleRecord);
                }

                searchRecord.List = listRecord;
                searchRecord.QtdTotalRegistros = listClientsRecords.Count();

                // Retorna a lista
                return searchRecord;
            
        }


    }
}
