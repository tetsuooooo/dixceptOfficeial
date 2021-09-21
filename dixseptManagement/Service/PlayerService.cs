using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using DixseptData;
using DixseptData.Entity;
using dixseptManagement.Model.Response;
using dixseptManagement.Request;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dixseptManagement.Service
{
    public interface IPlayerService : IBaseService
    {
        Task<PlayerResponse> RegistAsync(PlayerRequest request);
    }
        public class PlayerService : BaseService, IPlayerService
        {
            private IConfiguration _configration { get; set; }
            private IAwsService _awsService { get; set; }

            public PlayerService(IUnitOfWork uow, IConfiguration configuration, IAwsService awsService)
            {
                _uow = uow;
                _configration = configuration;
                _awsService = awsService;
            }

        /// <summary>
        /// 選手登録を行う
        /// </summary>
        /// <returns></returns>
        public async Task<PlayerResponse> RegistAsync(PlayerRequest request) {
            var result = new PlayerResponse() { result = false, errorMessageDetail = new List<string>() };
            // s3に画像を保存
            var imageResult = await _awsService.saveImageToS3Async(request.imageData, request.imageName);

            if (!imageResult.result) {
                result.result = false;
                result.errorMessage = "選手の登録に失敗しました。";
                result.errorMessageDetail = new List<string>() {
                "画像の登録に失敗しました。"
                };
                return result;
            }

            try 
            {
                // 登録処理
                Regist(request, imageResult.imageName);
                _uow.SaveChanges();
                result.result = true;
                result.successMessage = "選手の登録に成功しました。";
            } catch (Exception e) 
            {
                result.result = false;
                result.errorMessage = "選手の登録に失敗しました。";
                result.errorMessageDetail = new List<string>();
                return result;
            }
            
            return result;
        }

        // s3から取得したデータをbase64形式で返却する
        

        public void Regist(PlayerRequest data, string registImgName)
        {
            var player = new M_PLAYER();
            player.UNIFORM_NUMBER = data.uniformNumber;
            player.LAST_NAME = data.lastName;
            player.FIRST_NAME = data.firstName;
            player.LAST_NAME_EN = data.lastNameEn;
            player.FIRST_NAME_EN = data.firstNameEn;
            player.HEIGHT = data.height;
            player.WEIGHT = data.weight;
            player.BIRTHDAY = data.birthday;
            player.BIRTH_PLACE = data.birthdayPlace;
            player.POSITION_CD = data.positionCd;
            player.PLAYER_IMG = registImgName;
            player.COMMENT = data.comment;
            player.PLAYER_IMG_OLD = data.imageName;
            _uow.M_PLAYER.Add(player);
        }
    }
}
