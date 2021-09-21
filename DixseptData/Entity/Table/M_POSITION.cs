using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class M_POSITION : EntityBase
    {
        /// <summary>
        /// ポジションCD
        /// </summary>
        [Key]
        [Required, StringLength(1)]
        public string POSITION_CD { get; set; }

        /// <summary>
        /// ポジション名
        /// </summary>
        [Required]
        public string POSITION_NAME { get; set; }
    }
}
