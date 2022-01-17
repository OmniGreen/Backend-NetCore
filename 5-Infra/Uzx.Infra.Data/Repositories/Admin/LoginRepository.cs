using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uzx.Infra.TransferObjects.Admin;
using Uzx.Infra.Data.Context;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.Data.Interfaces.Admin;
using Uzx.Infra.Commons;
using Uzx.Infra.Commons.Authentication;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Uzx.Infra.Data.Repositories.Admin
{
    public class LoginRepository : Repository<Users>, IDisposable, ILoginRepository
    {
        public  UzxBaseDbContext ctx;
        private readonly IMapper _mapper;

        public LoginRepository(IMapper mapper,UzxBaseDbContext context)
            : base(context)
        {
            ctx = context;
            _mapper = mapper;
            //_userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }





        /// <summary>
        /// Recupera os registros em forma de lista e preparados pela busca e para paginação
        /// </summary>
        /// <param name="searchRecord">Objeto com dados de paginação e busca</param>
        /// <returns>Retorna uma lista</returns> 
        //public LoginPortalTrans GetDataLoginCpf(Guid ColaboratorID)
        //{
        //    LoginPortalTrans singleRecord = new LoginPortalTrans();
        //    using (var dp = new DataPrimeDbContext())
        //    {
        //        //A unica permissão que haverá e verificar se ele acessa o portal
        //        var colab = (from c in dp.Colaborator
        //                     from s in dp.MapeamentoSaude
        //                            .Where(x => x.UserID == c.ColaboratorID).DefaultIfEmpty()
        //                     where c.ColaboratorID == ColaboratorID-
        //                     select new {c,s}).FirstOrDefault();
        //        if (colab == null)
        //        {
        //            singleRecord.Logado = false;
        //        }
        //        else
        //        {
        //            singleRecord.Logado = true;

        //            var nutricao = (from c in dp.MapeamentoNutricao
        //                            where c.UserID == colab.c.ColaboratorID
        //                            select c).FirstOrDefault();

        //            var voto = (from c in dp.ReceitasVoto
        //                            where c.ColaboratorID == colab.c.ColaboratorID
        //                            select c).FirstOrDefault();

        //            //var campanha = (from c in dp.MapeamentoSaude
        //            //                where c.UserID == colab.c.ColaboratorID
        //            //                select c).FirstOrDefault();


        //            using (var TTG = new UzenixDbContext())
        //            {
        //                var client = (from c in Uzx.Clients
        //                              join cc in Uzx.ClientsConfigurations on c.ClientID equals cc.ClientID
        //                              where c.ClientID == colab.c.ClientID
        //                              select new{c,cc}).FirstOrDefault();

        //                singleRecord.Client = client.c;
        //                singleRecord.Colaborator = colab.c;
        //                singleRecord.isCampaingSave = client.cc.isCampaingSave;
        //            }
        //            singleRecord.isCampanha = ((colab.s == null) ? false : true);
        //            singleRecord.isCampanhaFinalizada = ((colab.s == null) ? false : colab.s.isCampanhaFinalizada);
        //            singleRecord.isNutricao = ((nutricao == null) ? false : true);

        //            singleRecord.isVoto = ((voto == null) ? false : true);

        //            singleRecord.totNutricao = ((nutricao == null) ? 0 : nutricao.totDevolutiva);


        //        }
        //    }
        //    return singleRecord;
        //}

        /// <summary>
        /// Recupera os registros em forma de lista e preparados pela busca e para paginação
        /// </summary>
        /// <param name="searchRecord">Objeto com dados de paginação e busca</param>
        /// <returns>Retorna uma lista</returns> 
        public async Task<LoginTrans> GetDataLogin(Guid UserId)
        {
            LoginTrans searchRecord = new LoginTrans();

            Guid? upClientID = default(System.Guid);
            var users = await (from u in ctx.Users
                         join c in ctx.Clients on u.ClientId equals c.ClientId
                         where u.UserId == UserId
                         select new { u, c }).SingleOrDefaultAsync();


            var userPermission = (from up in ctx.UsersPermissions
                                  where up.UserId == users.u.UserId
                                        && up.IsActive  && !up.IsDeleted 
                                  orderby up.ClientId
                                  select up).ToList();

            List<ClientData> listClients = new List<ClientData>();
            ClientData singleClient = new ClientData();
            List<SystemsData> listSystems = new List<SystemsData>();
            SystemsData singleSystems;

            var clients = userPermission.GroupBy(u => u.ClientId).Count();

            if (userPermission.Count > 0)
            {
                UsersPermissions last = userPermission.Last();

                foreach (var item in userPermission)
                {
                    if (upClientID != item.ClientId)
                    {
                        if (upClientID != default(System.Guid))
                        {
                            singleClient.Systems = listSystems;
                            listClients.Add(singleClient);
                        }

                        singleClient = new ClientData();
                        //adiciona um cliente
                        upClientID = item.ClientId;

                        var Clients = (from c in ctx.Clients
                                       where c.ClientId == item.ClientId
                                       && c.IsActive && !c.IsDeleted
                                       select c).SingleOrDefault();

                       //singleClient.Client = Clients;
                    }
                    singleSystems = new SystemsData();
                    //adiciona os sistemas
                    var System = (from s in ctx.Systems
                                  where s.SystemId == item.SystemId
                                  && s.IsActive && !s.IsDeleted
                                  select s).SingleOrDefault();

                    //singleSystems.System = System;

                    var sysLang = (from sl in ctx.SystemsLanguages
                                  join l in ctx.Languages
                                     on sl.LanguageId  equals l.LanguageId
                                  where sl.SystemId == System.SystemId && l.IsActive && !l.IsDeleted
                                  select new { l, sl }).ToList();

                    LanguagesTrans singleLanguageTrans;
                    List<LanguagesTrans> listLanguageTrans = new List<LanguagesTrans>();

                    foreach (var language in sysLang)
                    {

                        singleLanguageTrans = new LanguagesTrans();
                        singleLanguageTrans.LanguageId = language.l.LanguageId;
                        singleLanguageTrans.Name = language.l.Name;
                        singleLanguageTrans.Country = language.l.Country;
                        singleLanguageTrans.FileName = language.l.FileName;
                        singleLanguageTrans.Alt = language.l.Alt;
                        singleLanguageTrans.Description = language.l.Description;
                        singleLanguageTrans.Image = language.l.Image;
                        singleLanguageTrans.IsDefault = language.sl.IsDefault;
                        listLanguageTrans.Add(singleLanguageTrans);

                    }
                    singleSystems.Languages = listLanguageTrans;

                    listSystems.Add(singleSystems);

                    if (item.Equals(last))
                    {
                        singleClient.Systems = listSystems;
                        listClients.Add(singleClient);
                    }
                }
            }
            searchRecord.Clients = listClients;
            searchRecord.Users = _mapper.Map<UsersTrans>(users.u);
            searchRecord.IsAdmin = users.c.IsAdmin;
            // searchRecord.Clients = Clients;
            searchRecord.Logado = true;

            return searchRecord;
        }

        public async Task<LoginTrans> GetDataLoginSite(Guid UserId)
        {
            LoginTrans searchRecord = new LoginTrans();

            var users = await (from u in ctx.UsersSite
                               where u.UserSiteId == UserId
                               select new { u}).SingleOrDefaultAsync();

            
            searchRecord.UsersSite = _mapper.Map<UsersSiteTrans>(users.u);
            searchRecord.IsAdmin = false;
            searchRecord.Logado = true;

            return searchRecord;
        }

        /// <summary>
        /// Recupera os registros em forma de lista e preparados pela busca e para paginação
        /// </summary>
        /// <param name="searchRecord">Objeto com dados de paginação e busca</param>
        /// <returns>Retorna uma lista</returns> 
        public async Task<LoginTokenTrans> LoginToken(LoginTokenTrans searchRecord)
        {
            var singleRecord = searchRecord;
            var verificationSucceeded = true; 
            dynamic password = CodeFirstCrypto.HashPassword(searchRecord.Password);
            // Recupera o usuário
           
            var userAccess = await (from ua in ctx.UsersAccess
                              where ua.Login == searchRecord.Login
                              && ua.IsActive == true
                              && ua.IsDeleted == false
                              && ua.IsVerify == true
                              select ua).FirstOrDefaultAsync();

            if (userAccess == null)
            {
                singleRecord.Token = null;
            }
            else
            {
                dynamic hashedPassword = userAccess.Password;
                verificationSucceeded = hashedPassword != null && CodeFirstCrypto.VerifyHashedPassword(hashedPassword, searchRecord.Password);

                //Se o Login e Senha deu certo
                if (verificationSucceeded)
                {
                    singleRecord.Token = TokenAccess.GenerateToken(userAccess.Login, userAccess.UserId.ToString()); 
                }

            }

            // Oculta a senha
            singleRecord.Password = "";
            
            // Retorna os dados
            return singleRecord;

            //bool verificationSucceeded = true;

            //LoginTransToken singleRecord = new LoginTransToken();
            //dynamic password = CodeFirstCrypto.HashPassword(searchRecord.Password);
            //var userAccess = (from ua in ctx.UsersAccess
            //                  where ua.Login == searchRecord.Login
            //                  && ua.IsActive == true
            //                  && ua.IsDeleted == false
            //                  && ua.IsVerify == true
            //                  select ua).FirstOrDefault();

            //if (userAccess == null)
            //{
            //    singleRecord.Logado = false;
            //}
            //else
            //{
            //    dynamic hashedPassword = userAccess.Password;
            //    verificationSucceeded = (hashedPassword != null && CodeFirstCrypto.VerifyHashedPassword(hashedPassword, searchRecord.Password));

            //    //Se o Login e Senha deu certo
            //    if (verificationSucceeded)
            //    {
            //        Guid upClientID = default(System.Guid);
            //        var users = (from u in ctx.Users
            //                     join c in ctx.Clients on u.ClientId equals c.ClientId
            //                     where u.UserId == userAccess.UserId
            //                     select new { u, c }).SingleOrDefault();


            //        var userPermission = (from up in ctx.UsersPermissions
            //                              where up.UserId == users.u.UserId
            //                                    && up.IsActive && !up.IsDeleted
            //                              orderby up.ClientId
            //                              select up).ToList();

            //        List<ClientData> listClients = new List<ClientData>();
            //        ClientData singleClient = new ClientData();
            //        List<SystemsData> listSystems = new List<SystemsData>();
            //        SystemsData singleSystems;

            //        var clients = userPermission.GroupBy(u => u.ClientId).Count();

            //        if (userPermission.Count > 0)
            //        {
            //            UsersPermissions last = userPermission.Last();

            //            foreach (var item in userPermission)
            //            {
            //                if (upClientID != item.ClientId)
            //                {
            //                    if (upClientID != default(System.Guid))
            //                    {
            //                        singleClient.Systems = listSystems;
            //                        listClients.Add(singleClient);
            //                    }

            //                    singleClient = new ClientData();
            //                    //adiciona um cliente
            //                    upClientID = (Guid)item.ClientId;

            //                    var Clients = (from c in ctx.Clients
            //                                   where c.ClientId == item.ClientId
            //                                   && c.IsActive && !c.IsDeleted
            //                                   select c).SingleOrDefault();

            //                   // singleClient.Client = Clients;
            //                }
            //                singleSystems = new SystemsData();
            //                //adiciona os sistemas
            //                var System = (from s in ctx.Systems
            //                              where s.SystemId == item.SystemId
            //                              && s.IsActive && !s.IsDeleted
            //                              select s).SingleOrDefault();

            //                //singleSystems.System = System;

            //                var dataSystemLanguages = (from sl in ctx.SystemsLanguages
            //                                           join l in ctx.Languages
            //                                              on sl.LanguageId equals l.LanguageId
            //                                           where sl.SystemId == System.SystemId && l.IsActive && !l.IsDeleted
            //                                           select new { l, sl }).ToList();

            //                LanguagesTrans singleLanguageTrans;
            //                List<LanguagesTrans> listLanguageTrans = new List<LanguagesTrans>();

            //                foreach (var language in dataSystemLanguages)
            //                {

            //                    singleLanguageTrans = new LanguagesTrans();
            //                    singleLanguageTrans.LanguageId = language.l.LanguageId;
            //                    singleLanguageTrans.Name = language.l.Name;
            //                    singleLanguageTrans.Country = language.l.Country;
            //                    singleLanguageTrans.FileName = language.l.FileName;
            //                    singleLanguageTrans.Alt = language.l.Alt;
            //                    singleLanguageTrans.Description = language.l.Description;
            //                    singleLanguageTrans.Image = language.l.Image;
            //                    singleLanguageTrans.IsDefault = language.sl.IsDefault;
            //                    listLanguageTrans.Add(singleLanguageTrans);

            //                }
            //                singleSystems.Languages = listLanguageTrans;

            //                listSystems.Add(singleSystems);

            //                if (item.Equals(last))
            //                {
            //                    singleClient.Systems = listSystems;
            //                    listClients.Add(singleClient);
            //                }
            //            }
            //        }
            //        singleRecord.UserId = users.u.UserId;
            //        singleRecord.ClientId = users.c.ClientId;
            //        singleRecord.IsAdmin = users.c.IsAdmin;
            //        // singleRecord.Clients = Clients;
            //        singleRecord.Logado = true;
            //    }
            //    else
            //    {
            //        singleRecord.Logado = false;
            //    }

            //}
            //return singleRecord;
        }


        public async Task<LoginTokenTrans> LoginTokenSite(LoginTokenTrans searchRecord)
        {
            var singleRecord = searchRecord;
            var verificationSucceeded = true;
            // Recupera o usuário
            dynamic password = CodeFirstCrypto.DecryptStringAES(searchRecord.Password);
            var userAccess = await (from ua in ctx.UsersSite
                                    where ua.Email == searchRecord.Login
                                    && ua.IsActive == true
                                    && ua.IsDeleted == false
                                    select ua).FirstOrDefaultAsync();

            if (userAccess == null)
            {
                singleRecord.Token = null;
            }
            else
            {
                dynamic hashedPassword = userAccess.Password;
                verificationSucceeded = hashedPassword != null && CodeFirstCrypto.VerifyHashedPassword(hashedPassword, password);

                //Se o Login e Senha deu certo
                if (verificationSucceeded)
                {
                    singleRecord.Token = TokenAccess.GenerateToken(userAccess.Email, userAccess.UserSiteId.ToString());
                }

            }

            // Oculta a senha
            singleRecord.Password = "";

            // Retorna os dados
            return singleRecord;
        }


        /// <summary>
        /// Recupera os registros em forma de lista e preparados pela busca e para paginação
        /// </summary>
        /// <param name="searchRecord">Objeto com dados de paginação e busca</param>
        /// <returns>Retorna uma lista</returns> 
        //public async Task<LoginTransToken> LoginTokenCpf(LoginTransToken searchRecord)
        //{
        //    bool verificationSucceeded = true;

        //    LoginTransToken singleRecord = new LoginTransToken();
        //    try
        //    {
        //        using (var dp = new DataPrimeDbContext())
        //        {
        //            //A unica permissão que haverá e verificar se ele acessa o portal
        //            var colab = (from c in dp.Colaborator
        //                         where c.NumCpf.Replace(".", "").Replace("-", "") == searchRecord.Cpf.Replace(".", "").Replace("-", "")
        //                         select c).FirstOrDefault();
        //            if (colab == null)
        //            {
        //                singleRecord.Logado = false;
        //            }
        //            else
        //            {
        //                singleRecord.Logado = true;

        //                //var nutricao = (from c in dp.MapeamentoNutricao
        //                //                where c.UserID == colab.ColaboratorID
        //                //                select c).FirstOrDefault();

        //                //var campanha = (from c in dp.MapeamentoSaude
        //                //                where c.UserID == colab.ColaboratorID
        //                //                select c).FirstOrDefault();


        //                //using (var TTG = new UzenixDbContext())
        //                //{
        //                //    var client = (from c in Uzx.Clients
        //                //                  where c.ClientID == colab.ClientID
        //                //                  select c).FirstOrDefault();

        //                    singleRecord.ClientId = colab.ClientId;
        //                   singleRecord.ColaboratorId = colab.ColaboratorId;
        //                //}
        //                //singleRecord.isCampanha = ((campanha == null) ? false : true);
        //                //singleRecord.isNutricao = ((nutricao == null) ? false : true);
        //                //singleRecord.totNutricao = ((nutricao == null) ? 0 : nutricao.totDevolutiva);

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //    return singleRecord;
        //}

        /// <summary>
        /// Recupera os registros em forma de lista e preparados pela busca e para paginação
        /// </summary>
        /// <param name="searchRecord">Objeto com dados de paginação e busca</param>
        /// <returns>Retorna uma lista</returns> 
        public async Task<LoginTrans> Login(LoginReceiveTrans loginRecord)
        {
            //ClientData singleClientData;
            bool verificationSucceeded = true;
            LoginTrans searchRecord = new LoginTrans();
            searchRecord.Login = loginRecord.Login;
            searchRecord.Password = loginRecord.Password;
            dynamic password = CodeFirstCrypto.HashPassword(searchRecord.Password);

            var userAccess = await (from ua in ctx.UsersAccess
                              where ua.Login == searchRecord.Login
                              && ua.IsActive == true 
                              && ua.IsDeleted == false
                              && ua.IsVerify == true
                              select ua).FirstOrDefaultAsync();

            if (userAccess == null)
            {
                searchRecord.Logado = false;
            }
            else
            {
                string hashedPassword = userAccess.Password;
                verificationSucceeded = (hashedPassword != null && CodeFirstCrypto.VerifyHashedPassword(hashedPassword, searchRecord.Password));

                //Se o Login e Senha deu certo
                if (verificationSucceeded)
                {
                    Guid? upClientID = default(System.Guid);
                    var users = (from u in ctx.Users
                                 join c in ctx.Clients on u.ClientId equals c.ClientId
                                 where u.UserId == userAccess.UserId
                                 select new { u, c }).SingleOrDefault();


                    var userPermission = (from up in ctx.UsersPermissions
                                          where up.UserId == users.u.UserId
                                                && up.IsActive && !up.IsDeleted
                                          orderby up.ClientId
                                          select up).ToList();

                    List<ClientData> listClients = new List<ClientData>();
                    ClientData singleClient = new ClientData();
                    List<SystemsData> listSystems = new List<SystemsData>();
                    SystemsData singleSystems;

                    var clients = userPermission.GroupBy(u => u.ClientId).Count();

                    if (userPermission.Count > 0)
                    {
                        UsersPermissions last = userPermission.Last();

                        foreach (var item in userPermission)
                        {
                            if (upClientID != item.ClientId)
                            {
                                if (upClientID != default(System.Guid))
                                {
                                    singleClient.Systems = listSystems;
                                    listClients.Add(singleClient);
                                }

                                singleClient = new ClientData();
                                //adiciona um cliente
                                upClientID = item.ClientId;

                                var Clients = (from c in ctx.Clients
                                               where c.ClientId == item.ClientId
                                               && c.IsActive && !c.IsDeleted
                                               select c).SingleOrDefault();

                                //singleClient.Client = Clients;
                            }
                            singleSystems = new SystemsData();
                            //adiciona os sistemas
                            var System = (from s in ctx.Systems
                                          where s.SystemId == item.SystemId
                                          && s.IsActive && !s.IsDeleted
                                          select s).SingleOrDefault();

                            //singleSystems.System = System;

                            var systemsLanguages = (from sl in ctx.SystemsLanguages
                                                    join l in ctx.Languages
                                                       on sl.LanguageId equals l.LanguageId
                                                    where sl.SystemId == System.SystemId && l.IsActive && !l.IsDeleted
                                                    select new { l, sl }).ToList();

                            LanguagesTrans singleLanguageTrans;
                            List<LanguagesTrans> listLanguageTrans = new List<LanguagesTrans>();

                            foreach (var language in systemsLanguages)
                            {

                                singleLanguageTrans = new LanguagesTrans();
                                singleLanguageTrans.LanguageId = language.l.LanguageId;
                                singleLanguageTrans.Name = language.l.Name;
                                singleLanguageTrans.Country = language.l.Country;
                                singleLanguageTrans.FileName = language.l.FileName;
                                singleLanguageTrans.Alt = language.l.Alt;
                                singleLanguageTrans.Description = language.l.Description;
                                singleLanguageTrans.Image = language.l.Image;
                                singleLanguageTrans.IsDefault = language.sl.IsDefault;
                                listLanguageTrans.Add(singleLanguageTrans);

                            }
                            singleSystems.Languages = listLanguageTrans;

                            listSystems.Add(singleSystems);

                            if (item.Equals(last))
                            {
                                singleClient.Systems = listSystems;
                                listClients.Add(singleClient);
                            }
                        }
                    }
                    searchRecord.Clients = listClients;

                    searchRecord.Users = _mapper.Map<UsersTrans>(users.u);
                    searchRecord.IsAdmin = users.c.IsAdmin;
                   // searchRecord.Clients = Clients;
                    searchRecord.Logado = true;
                }
                else
                {
                    searchRecord.Logado = false;
                }
            }
            return searchRecord;
        }

        /// <summary>
        /// O método de recuperação de senha, após validar o e-mail na View, irá verificar a existência deste na base de dados.
        /// Caso não exista, informa ao usuário.
        /// Caso exista, envia o link para recuperação de senha para o e-mail do usuário.
        public bool recoverPassword(LoginTrans searchRecord)
        {
            //Password password;  
            //Email email;
            //string key, key2;

            // Instancia o banco de dados
            //using (UzenixDbContext ctx = new UzenixDbContext())
            //{
            //    var usersAccess = ctx.UsersAccess.Where(x => x.Login == searchRecord.Login).SingleOrDefault();
            //    if (usersAccess == null)
            //    {
            //        return false;
            //    }

            //    password = new Password();
            //    key = password.geraSenha();
            //    key2 = key;

            //    usersAccess.Password = CodeFirstCrypto.HashPassword(key);
            //    ctx.Entry(usersAccess).State = EntityState.Modified;
            //    ctx.SaveChanges();

            //    email = new Email();
            //    email.sendEmail(usersAccess.Login, "Recuperação de Senha", "Recuperação de Senha", "Nova senha de acesso: " + key2, "");
                return true;
            //}
        }

        /// <summary>
        /// O método de ativação de acesso verifica se existe um UsersAccess com o ID especificado por parâmetro.
        /// Caso não exista, informa ao usuário o erro e solicita contato com o Administrador.
        /// Caso exista, ativa o acesso do usuário e exibe mensagem de confirmação.
        public bool activateAccess(string key)
        {
            //UsersAccess singleRecord = null;

            // Instancia o banco de dados
            //using (UzenixDbContext ctx = new UzenixDbContext())
            //{
            //    foreach (var item in ctx.UsersAccess)
            //    {
            //        if (CodeFirstCrypto.VerifyHashedPassword(key.Replace('!', '/'), item.UserAccessID.ToString()))
            //        {
            //            singleRecord = new UsersAccess();
            //            singleRecord = item;
            //            break;
            //        }
            //    }

            //    if (singleRecord == null)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        singleRecord.IsVerify = true;
            //        ctx.Entry(singleRecord).State = EntityState.Modified;
                    return true;
            //    }
            //}
        }


     }
}
