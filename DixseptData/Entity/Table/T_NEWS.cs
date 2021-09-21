using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class T_NEWS : EntityBase
    {
        /// <summary>
        /// ニュースID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NEWS_ID { get; set; } 

        /// <summary>
        /// ニュース区分
        /// </summary>
        [StringLength(1), Required]
        public string NEWS_CD { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        [Required]
        public string TITLE { get; set; }

        /// <summary>
        /// コメント
        /// </summary>
        [Required]
        public string COMMENT { get; set; }
        
        /// <summary>
        /// 画像名
        /// </summary>
        [Required]
        public string NEWS_IMG { get; set; }

        /// <summary>
        /// 公式戦結果ID
        /// </summary>
        public int? OFFICIAL_SCHEDULE_ID { get; set; }

        /// <summary>
        /// 練習試合結果ID
        /// </summary>
        public int? PRACTICE_SCHEDULE_ID { get; set; }

        /// <summary>
        /// 練習ID
        /// </summary>
        public int? PRACTICE_ID { get; set; }

    }
}
