using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class T_PRACTICEGAME_POINT : EntityBase
    {
        /// <summary>
        /// 練習得点ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PRACTICE_POINT_ID { get; set; }

        /// <summary>
        /// 練習試合詳細結果ID
        /// </summary>
        public int PRACTICEGAME_DETAIL_ID { get; set; }

        /// <summary>
        /// 選手ID
        /// </summary>
        public int PLAYER_ID { get; set; }

        /// <summary>
        /// 得点区分
        /// </summary>
        [Required, StringLength(1)]
        public string POINT_CD { get; set; }
    }
}
