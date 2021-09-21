using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dixseptManagement.Model.Response
{
    public class ResponseBase<T>
    {
        /// <summary>
        /// レスポンス結果
        /// </summary>
        public bool result { get; set; }

        /// <summary>
        /// 成功メッセージ
        /// </summary>
        public string successMessage { get; set; }

        /// <summary>
        /// エラーメッセージ
        /// </summary> 
        public string errorMessage { get; set; }

        /// <summary>
        /// エラーメッセージ詳細
        /// </summary>
        public List<string> errorMessageDetail { get; set; }

        /// <summary>
        /// データ
        /// </summary>
        public T Data { get; set; }
    }
}
