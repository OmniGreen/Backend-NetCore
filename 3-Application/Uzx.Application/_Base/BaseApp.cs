using AutoMapper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Uzx.Application.Interfaces._Base; using Uzx.Infra.TransferObjects._Base;
using Uzx.Domain.Entities._Base;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;

namespace Uzx.Application._Base
{
    public class BaseApp<T, TO> :  IBaseApp<T, TO> 
        where T :BaseEntity
        where TO : BaseTrans

    {
        private readonly IMapper _mapper;
        public readonly IBaseRepository<T> _baseRepository;

        public BaseApp(IMapper mapper,
                    IBaseRepository<T> baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<TO> GetById(Guid id)
        {
            return _mapper.Map<TO> (await _baseRepository.GetById(id));
        }

        public async Task<T> Register(T single)
        {
            return await _baseRepository.Add(single);
        }

        public async Task<List<T>> Remove(Guid id)
        {

            return await _baseRepository.Remove(id);
        }

        public Task<T> Update(T single)
        {
            return  _baseRepository.Update(single);
        }


        public async Task<List<T>> GetByFilter(string condition)
        {
            return await _baseRepository.GetByFilter(condition);
        }
    }
}
