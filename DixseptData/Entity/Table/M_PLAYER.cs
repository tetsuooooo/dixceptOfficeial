using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity
{
    public class M_PLAYER: EntityBase
    {
        /// <summary>
        /// 選手ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PLAYER_ID { get; set; }

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
        /// 身長
        /// </summary>
        public int HEIGHT { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public int WEIGHT { get; set; }

        /// <summary>
        /// 生年月日
        /// </summary>
        [Column(TypeName="Date")]
        public DateTime BIRTHDAY { get; set; }

        /// <summary>
        /// 出身地
        /// </summary>
        [Required]
        public string BIRTH_PLACE { get; set; }

        /// <summary>
        /// ポジションCD
        /// </summary>
        [Required, StringLength(1)]
        public string POSITION_CD { get; set; }

        /// <summary>
        /// 選手画像(s3上のファイル名)
        /// </summary>
        public string PLAYER_IMG { get; set; }

        /// <summary>
        /// 選手画像(返還前のファイル名)
        /// </summary>
        public string PLAYER_IMG_OLD { get; set; }

        /// <summary>
        /// コメント
        /// </summary>
        [Required]
        public string COMMENT { get; set; }
        
    }
}
