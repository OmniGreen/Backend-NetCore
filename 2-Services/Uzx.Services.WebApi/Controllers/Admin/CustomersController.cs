using Uzx.Services.WebApi.Controllers._Base;
using Uzx.Domain.Entities.Admin;
using Uzx.Infra.TransferObjects.Admin;
using Microsoft.AspNetCore.Mvc;
using Uzx.Services.WebApi.Interfaces.Admin;
using Uzx.Application.Interfaces.Admin;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using Uzx.Application.Interfaces._Base;
using System;
using Amazon.S3;
using Amazon;
using Amazon.S3.Model;
using System.Linq;
using System.Text.Json;
using System.Reflection.Metadata.Ecma335;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : BaseController<Customers, CustomersTrans>, ICustomersController
    {
        public readonly ICustomersApp _serviceApp;
        //
        public CustomersController(IMapper mapper,  ICustomersApp serviceApp)
            : base(mapper, serviceApp)
        {
            _serviceApp = serviceApp;
        }

        [HttpPost("GetByApp")]
        public async Task<List<CustomersTrans>> GetByApp(CustomersTrans searchRecord)
        {
            return await _serviceApp.GetByApp(searchRecord);
        }

        [HttpGet("GetByIdDetalhe/{id:guid}")]
        public async Task<CustomersTrans> GetByIdDetalhe(Guid id)
        {
            return await _serviceApp.GetById2(id);
        }

        [HttpPost("DeleteFromS3")]
        public async Task DeleteFromS3([FromBody] UploadTrans upload)
        {
            var client = new AmazonS3Client("AKIAIH7IULO3DLMFPJ5A", "XPDnVidYbdx5zK7M8iJC1EhXvj4J2xoujjzwLkQG", RegionEndpoint.USEast2);
            var id = new Guid(upload.Id);

            try
            {

                DeleteObjectRequest request = new DeleteObjectRequest
                {
                    BucketName = "clickmoocas3",
                    Key = upload.Name,
                };
                var response = await GetById(id);

                await client.DeleteObjectAsync(request);

                var imgArray = response.Images.Replace("[", "{").Replace("]", "}").Replace("\"", "");

                var deserializedArray = JsonSerializer.Serialize(imgArray);
           

                response.Images = response.Images;

                await Update(response);

            } catch (Exception ex)
            {
                throw ex;
            }

            
        }

    }
}
