using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DixseptData.Entity.Table
{
    public class M_TEAM: EntityBase
    {
        /// <summary>
        /// チームID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TEAM_ID { get; set; }

        /// <summary>
        /// チーム名
        /// </summary>
        public string TEAM_NAME { get; set; }

        /// <summary>
        /// エンブレム
        /// </summary>
        public string EMBLEM { get; set; }

    }
}
