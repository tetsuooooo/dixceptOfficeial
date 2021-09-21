using dixseptManagement.Model.Player;
using dixseptManagement.Model.Response;
using dixseptManagement.Request;
using dixseptManagement.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace dixseptManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private IPlayerService _playerService;

        public PlayerController(IPlayerService playerService) {
            _playerService = playerService;
        }

        /// <summary>
        /// 選手登録
        /// </summary>
        /// <returns></returns>
        [HttpPost, ActionName("regist")]
        public async Task<ActionResult<PlayerResponse>> RegistAsync([FromBody] PlayerRequest request) 
        {
            // TODO: バリデーション
            var result = await _playerService.RegistAsync(request);

            return result;
        }

     //   [HttpGet, ActionName("sample")]
     //   public async Task<ActionResult<string>> SampleAsync() {
            
     //await _playerService.saveFileAsync();
     //       return "成功しました";
     //   }

     //   [HttpGet]
     //   public async Task<ActionResult<string>> Index()
     //   {
     //       return "成功";
     //       //await _playerService.saveFileAsync();
     //       //return _playerService.Sample();
     //   }

     //   [HttpGet, ActionName("Image")]
     //   public async Task<ActionResult<string>> ImageAsync() {
     //       await _playerService.ImageAsync();
     //       return "";
     //   }

     //   [HttpGet, ActionName("url")]
     //   public ActionResult<string> getUrl()
     //   {
     //       var url = _playerService.GetImamgeUrl();
     //       return url;
     //   }
    }
}
