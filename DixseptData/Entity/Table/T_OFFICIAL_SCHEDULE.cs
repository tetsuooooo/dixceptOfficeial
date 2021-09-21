using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class T_OFFICIAL_SCHEDULE
    {
        /// <summary>
        /// 公式戦結果スケジュールID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OFFICIAL_SCHEDULE_ID { get; set; }

        /// <summary>
        /// 大会ID
        /// </summary>
        public int TOURNAMENT_ID { get; set; }

        /// <summary>
        /// 対戦相手_ID
        /// </summary>
        public int OPPONENT_ID { get; set; }

        /// <summary>
        /// 日付
        /// </summary>
        [Column(TypeName = "Date")]
        public DateTime DATE { get; set; }

        /// <summary>
        /// 時間
        /// </summary>
        public string TIME { get; set; }

        /// <summary>
        /// 会場
        /// </summary>
        public string PLACE { get; set; }

        /// <summary>
        /// カテゴリー
        /// </summary>
        public int CATEGORY { get; set; }

        /// <summary>
        /// 節
        /// </summary>
        public int SECTION {get;set;}
    }
}
