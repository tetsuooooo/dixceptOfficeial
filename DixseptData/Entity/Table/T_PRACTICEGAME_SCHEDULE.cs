using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DixseptData.Entity.Table
{
    public class T_PRACTICEGAME_SCHEDULE
    {
        /// <summary>
        /// T_練習試合_ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PRACTICEGAME_ID { get; set; }

        /// <summary>
        /// 日付
        /// </summary>
        [Column(TypeName = "Date")]
        public DateTime DATE { get; set; }

        /// <summary>
        /// 場所
        /// </summary>
        public string PLACE { get; set; }

        /// <summary>
        /// 対戦相手名
        /// </summary>
        public string OPPONENT_NAME { get; set; }

        /// <summary>
        /// カテゴリー
        /// </summary>
        public int CATEGORY { get; set; }

    }
}
