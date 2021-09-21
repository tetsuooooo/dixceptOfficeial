using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dixseptManagement.Controllers
{
    /// <summary>
    /// コントローラー基底クラス
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// ModelStateエラーメッセージ
        /// </summary>
        protected List<string> ModelStateErrorMessages => ModelState.SelectMany(x => x.Value.Errors.Select(e => e.ErrorMessage)).ToList();
    }
}
