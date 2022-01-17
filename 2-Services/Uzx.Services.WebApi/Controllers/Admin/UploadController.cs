using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Services.WebApi.Controllers.Admin
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {

        public UploadController()
        {
        }

        [HttpPost("ToS3")]
        public async Task UploadFileToS3()
        {

            var file = this.Request.Form.Files[0];
            var extension = Path.GetExtension(file.FileName);
            var guid = this.Request.Form.Keys.ToList()[0].ToString();

            using (var client = new AmazonS3Client("AKIAIH7IULO3DLMFPJ5A", "XPDnVidYbdx5zK7M8iJC1EhXvj4J2xoujjzwLkQG", RegionEndpoint.USEast1))
            {
                
                using (var newMemoryStream = new MemoryStream())
                {
                    file.CopyTo(newMemoryStream);

                    var uploadRequest = new TransferUtilityUploadRequest
                    {
                        InputStream = newMemoryStream,
                        Key = guid + extension,
                        BucketName = "clickmoocas3",
                        CannedACL = S3CannedACL.PublicRead
                    };

                    var fileTransferUtility = new TransferUtility(client);
                    await fileTransferUtility.UploadAsync(uploadRequest);
                }
            }
        }

        [HttpPost("ToS3All")]
        public async Task UploadFileToS3All()
        {

            var file = this.Request.Form.Files[0];

            using (var client = new AmazonS3Client("AKIAIH7IULO3DLMFPJ5A", "XPDnVidYbdx5zK7M8iJC1EhXvj4J2xoujjzwLkQG", RegionEndpoint.USEast1))
            {
                using (var newMemoryStream = new MemoryStream())
                {
                    file.CopyTo(newMemoryStream);

                    var uploadRequest = new TransferUtilityUploadRequest
                    {
                        InputStream = newMemoryStream,
                        Key = file.FileName,
                        BucketName = "clickmoocas3",
                        CannedACL = S3CannedACL.PublicRead
                    };

                    var fileTransferUtility = new TransferUtility(client);
                    await fileTransferUtility.UploadAsync(uploadRequest);
                }
            }
        }





    }
}
