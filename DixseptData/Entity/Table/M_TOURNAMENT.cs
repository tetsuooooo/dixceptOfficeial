using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class M_TOURNAMENT: EntityBase
    {
        /// <summary>
        /// 大会ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TOURNAMENT_ID { get; set; }

        /// <summary>
        /// 大会名
        /// </summary>
        [Required]
        public string TOUNAMENT_NAME { get; set; }

        /// <summary>
        /// シーズン(年)
        /// </summary>
        [Required, StringLength(4)]
        public string SEASON_YEAR { get; set; }
    }
}
