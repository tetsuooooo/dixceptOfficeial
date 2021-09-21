using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dixseptManagement.Model
{
    public class PlayerCommonModel : IValidatableObject
    {
        /// <summary>
        /// 背番号
        /// </summary>
        public int UNIFORM_NUMBER { get; set; }

        /// <summary>
        /// 氏
        /// </summary>
        [Required]
        public string LAST_NAME { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [Required]
        public string FIRST_NAME { get; set; }

        /// <summary>
        /// 氏(ローマ字)
        /// </summary>
        [Required]
        public string LAST_NAME_EN { get; set; }

        /// <summary>
        /// 名(ローマ字)
        /// </summary>
        [Required]
        public string FIRST_NAME_EN { get; set; }

        /// <summary>
        /// 出身地
        /// </summary>
        [Required]
        public string BIRTH_PLACE { get; set; }

        /// <summary>
        /// 生年月日
        /// </summary>
        [DataType("Date")]
        public DateTime BIRTHDAY { get; set; }

        /// <summary>
        /// ポジション
        /// </summary>
        [Required]
        public string POSITION_CD { get; set; }

        /// <summary>
        /// 身長
        /// </summary>
        public int HEIGHT { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public int WEIGHT { get; set; }

        /// <summary>
        /// コメント
        /// </summary>
        [Required]
        public string COMMENT { get; set; }

        /// <summary>
        /// 画像データ(base64)
        /// </summary>
        [Required]
        public string IMAGE { get; set; }

        /// <summary>
        /// ファイル名
        /// </summary>
        [Required]
        public string IMAGE_NAME { get; set; }

        /// バリデーション
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) 
        {
            var results = new List<ValidationResult>();

            return results;
        
        }
    }
}
