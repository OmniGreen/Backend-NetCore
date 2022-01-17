using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uzx.Domain.Entities._Base;
using Uzx.Infra.TransferObjects._Base;

namespace Uzx.Services.WebApi.Interfaces._Base
{
    public interface IBaseController<T, TO>
        where T : BaseEntity
        where TO : BaseTrans
    {

        Task<IActionResult> Register([FromBody] TO jsonObject);
        Task<IActionResult> Update([FromBody] TO jsonObject);
        Task<IEnumerable<TO>> Get();
        Task<TO> GetById(Guid id);
        Task<IActionResult> Delete(Guid id);
        Task<List<T>> GetByFilter(TO searchRecord);

    }
}
