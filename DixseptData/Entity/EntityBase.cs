using DixseptData.Entity.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DixseptData.Entity
{
    /// <summary>
    ///  EntityModel 基底クラス
    /// </summary>
    public class EntityBase: ITimeStumpEntity, IConcurrencyEntity
    {
        /// <summary>
        /// 登録日
        /// </summary>
        public DateTime? CREATE_AT { get; set; }

        /// <summary>
        /// 更新日付
        /// </summary>
        public DateTime? UPDATE_AT { get; set; }

        /// <summary>
        /// 登録者
        /// </summary>
        public string CREATE_BY { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        public string UPDATE_BY { get; set; }

        public byte[] Timestamp { get; set; }
    }
}
