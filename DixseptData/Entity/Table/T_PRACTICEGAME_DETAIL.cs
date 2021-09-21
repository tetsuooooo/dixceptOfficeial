using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class T_PRACTICEGAME_DETAIL : EntityBase
    {
        /// <summary>
        /// 練習詳細ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PRACTICE_DETAIL_RESULT_ID { get; set; }

        /// <summary>
        /// 練習試合スケジュールID
        /// </summary>
        public int PRACTICEGAME_ID { get; set; }

        /// <summary>
        /// 試合時間
        /// </summary>
        public int GAME_TIME { get; set; }

        /// <summary>
        /// 本数
        /// </summary>
        public int GAME_COUNT { get; set; }

    }
}
