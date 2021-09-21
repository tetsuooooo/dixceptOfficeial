using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class T_OFFICIAL_POINT :EntityBase
    {
        /// <summary>
        /// 得点ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OFFICIAL_POINT_ID { get; set; }

        /// <summary>
        /// 公式戦結果ID
        /// </summary>
        public int OFFICIAL_RESULT_ID { get; set; }

        /// <summary>
        /// 選手ID
        /// </summary>
        public int PLAYER_ID { get; set; }

        /// <summary>
        /// 得点区分
        /// </summary>
        /// 0:得点 1: 失点
        public bool POINT_CD { get; set; }
    }
}
