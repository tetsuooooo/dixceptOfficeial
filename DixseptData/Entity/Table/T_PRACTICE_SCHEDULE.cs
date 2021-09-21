using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class T_PRACTICE_SCHEDULE : EntityBase
    {
        /// <summary>
        /// 練習スケジュールID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PRACTICE_SCHEDULE_ID { get; set; }

        /// <summary>
        /// 日付
        /// </summary>
        [Column(TypeName = "Date")]
        public DateTime DATE { get; set; }

        /// <summary>
        /// 時間
        /// </summary>
        [Required, StringLength(5)]
        public string TIME { get; set; }

        /// <summary>
        /// カテゴリー
        /// </summary>
        public int CATEGORY { get; set; }
    }
}
