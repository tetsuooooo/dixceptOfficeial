using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class T_OFFICIAL_RESULT : EntityBase
    {
        /// <summary>
        /// 公式結果ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OFFICIAL_RESULT_ID {get;set;}

        /// <summary>
        /// ホーム前半
        /// </summary>
        public int H_FIRST_TIME { get; set; }

        /// <summary>
        /// アウェイ前半
        /// </summary>
        public int A_FIRST_TIME { get; set; }

        /// <summary>
        /// ホーム後半
        /// </summary>
        public int H_SECOND_TIME { get; set; }

        /// <summary>
        /// アウェイ後半
        /// </summary>
        public int A_SECOND_TIME { get; set; }

        /// <summary>
        /// ホーム延長前半
        /// </summary>
        public int? H_EX_FIRST_TIME { get; set; }

        /// <summary>
        /// アウェイ延長前半
        /// </summary>
        public int? A_EX_FIRST_TIME { get; set; }

        /// <summary>
        /// ホーム延長後半
        /// </summary>
        public int? H_EX_LAST_TIME { get; set; }

        /// <summary>
        /// アウェイ延長後半
        /// </summary>
        public int? A_EX_LAST_TIME { get; set; }

        /// <summary>
        /// ホームPK
        /// </summary>
        public int? H_PK { get; set; }

        /// <summary>
        /// アウェイPK
        /// </summary>
        public int? A_PK { get; set; }

    }
}
