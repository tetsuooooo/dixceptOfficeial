using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using DixseptData;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static dixseptManagement.Service.AwsService;

namespace dixseptManagement.Service
{
    public interface IAwsService : IBaseService {
        Task<S3Response> saveImageToS3Async(string data, string imageName);
        Task<string> ImageAsync();
        string GetImamgeUrl();
    }

    public class AwsService : BaseService, IAwsService
    {
        const string FOLDER = "player/";

        private IConfiguration _configration { get; set; }
        public AwsService(IUnitOfWork uow, IConfiguration configuration)
        {
            _uow = uow;
            _configration = configuration;
        }


        /// <summary>
        /// 画像をS3に保存
        /// </summary>
        /// <returns></returns>
        public async Task<S3Response> saveImageToS3Async(string data, string imageName)
        {
            var result = new S3Response();
            using (var client = new AmazonS3Client(_configration.GetSection("Aws:accessKey").Value, _configration.GetSection("Aws:secretKey").Value, RegionEndpoint.APNortheast1))
            {
                byte[] bytes = Convert.FromBase64String(data);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    var fileName = Guid.NewGuid();
                    // Guid値 + ファイル名でファイル名作成
                    var registFileName = FOLDER + fileName + imageName;
                    var putRequest = new PutObjectRequest();
                    putRequest.BucketName = _configration.GetSection("Aws:bucketName").Value;
                    putRequest.Key = registFileName;
                    putRequest.InputStream = ms;
                    try
                    {
                        await client.PutObjectAsync(putRequest);
                        result.result = true;
                        result.imageName = registFileName;
                        return result;
                    }
                    catch (Exception e)
                    {
                        return result;
                    }
                }
            }
        }

        /// <summary>
        /// s3から指定した画像の署名付きURL取得
        /// </summary>
        /// <returns></returns>
        public string GetImamgeUrl()
        {
            using (var client = new AmazonS3Client(_configration.GetSection("Aws:accessKey").Value, _configration.GetSection("Aws:secretKey").Value, RegionEndpoint.APNortheast1))
            {
                var request = new GetPreSignedUrlRequest
                {
                    BucketName = _configration.GetSection("Aws:bucketName").Value,
                    Key = "sampleChange4.png",
                    Expires = DateTime.UtcNow.AddDays(1)
                };
                var url = client.GetPreSignedURL(request);
                return url;
            }

        }

        public async Task<string> ImageAsync()
        {
            using (var client = new AmazonS3Client(_configration.GetSection("Aws:accessKey").Value, _configration.GetSection("Aws:secretKey").Value, RegionEndpoint.APNortheast1))
            {
                try
                {
                    var request = new GetObjectRequest { BucketName = _configration.GetSection("Aws:bucketName").Value, Key = "sample4.png" };
                    using (var response = await client.GetObjectAsync(request))
                    using (var responseStream = response.ResponseStream)
                    using (var ms = new MemoryStream())
                    {
                        responseStream.CopyTo(ms);

                        var putRequest = new PutObjectRequest();
                        putRequest.BucketName = _configration.GetSection("Aws:bucketName").Value;
                        putRequest.Key = "sampleChange4.png";
                        putRequest.InputStream = ms;
                        await client.PutObjectAsync(putRequest);
                        // byte配列をbase64に変換
                        var data = Convert.ToBase64String(ms.ToArray());
                    }

                }
                catch (Exception e)
                {
                }
            }
            return "";
        }

        public class S3Response {
            public string imageName {get;set;}
            public bool result { get; set; }
        }
    }
}
