using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dixseptManagement.Controllers
{

    /// <summary>
    /// コントローラーAPI基底クラス
    /// </summary>
    [Authorize]
    //[ExceptionFilter]
    public class BaseApiController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
