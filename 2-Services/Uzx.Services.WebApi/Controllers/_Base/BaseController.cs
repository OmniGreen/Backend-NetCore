using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces._Base;
using Uzx.Infra.TransferObjects._Base;
using Uzx.Domain.Entities._Base;
using Uzx.Application.Interfaces._Base;
using System.Linq;
using AutoMapper;

namespace Uzx.Services.WebApi.Controllers._Base
{
    [Route("api/[controller]")]
    public class BaseController<T, TO> : ApiController, IBaseController<T, TO>
        where T : BaseEntity
        where TO : BaseTrans

    {
        public readonly IBaseApp<T, TO> _serviceApp;
        private readonly IMapper _mapper;
        public BaseController(IMapper mapper, IBaseApp<T, TO> serviceApp)
        {
            _mapper = mapper;
            _serviceApp = serviceApp;
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] TO jsonObject)
        {
            var obj = _mapper.Map<T>(jsonObject);
            return CustomResponse(await _serviceApp.Update(obj));
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] TO jsonObject)
        {
            var obj = _mapper.Map<T>(jsonObject);
            return CustomResponse(await _serviceApp.Register(obj));
        }

        [HttpPost("Delete/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return CustomResponse(await _serviceApp.Remove(id));
        }

        [HttpGet("Get")]
        public Task<IEnumerable<TO>> Get()
        {
            throw new NotImplementedException();
        }

        //[HttpGet("GetById")]
        [HttpGet("GetById/{id:guid}")]
        public async Task<TO> GetById(Guid id)
        {
            return await _serviceApp.GetById(id);
        }
        [HttpPost("GetByFilter")]
        public async Task<List<T>> GetByFilter(TO searchRecord)
        {

            string strCondicao = "isdeleted=false ";
            foreach (var p in searchRecord.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any()))
            {
                var value = p.GetValue(searchRecord, null);
                bool addParam = false;
                if (value != null)
                {

                    switch (GetPropertyName(p.PropertyType))
                    {
                        case "Guid":
                            //Verifica se o guid e empty
                            var guidOutput = Guid.Empty;
                            bool isValid = Guid.TryParse(value.ToString(), out guidOutput);
                            if (isValid && guidOutput != Guid.Empty)//verifica se o guid e valido
                            {
                                addParam = true;
                                value = "==Guid(\"" + value + "\")";
                            }
                            break;
                        case "Boolean":
                            addParam = true;
                            value = "==" + Convert.ToBoolean(value);
                            break;
                        case "String":
                            addParam = true;
                            value = ".ToLower().Contains(\"" + value.ToString().ToLower() + "\")";
                            break;
                        case "Int32":
                            addParam = true;
                            value = "==" + Convert.ToInt32(value);
                            break;
                        case "Double":
                            addParam = true;
                            value = "==" + Convert.ToDouble(value);
                            break;
                        case "DateTime":
                            DateTime temp;
                            if (DateTime.TryParse(value.ToString(), out temp))
                            {
                                if (temp != DateTime.MinValue)
                                {
                                    addParam = true;
                                    value = "==" + Convert.ToDateTime(value);
                                }
                            }                            
                            break;
                        default:
                            break;
                    }



                    if (addParam)
                    {
                        if (strCondicao != string.Empty)
                        {
                            strCondicao += " AND ";
                        }
                        strCondicao += p.Name + value;
                    }
                }
            }
            return await _serviceApp.GetByFilter(strCondicao);
        }


        private string GetPropertyName(Type param)
        {
            if (param == typeof(Nullable<Guid>))
                return "Guid";
            else if (param == typeof(Nullable<bool>))
                return "Boolean";
            else if (param == typeof(string))
                return "String";
            else if (param == typeof(Nullable<Int32>))
                return "Int32";
            else if (param == typeof(Nullable<Double>))
                return "Double";
            else if (param == typeof(Nullable<DateTime>))
                return "DateTime";
            else
                return string.Empty;
        }
    }
}