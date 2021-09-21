using System;
using System.Collections.Generic;
using System.Text;

namespace DixseptData.Entity.Common
{
    /// <summary>
    /// 同時実行トークン
    /// </summary>
    public interface IConcurrencyEntity
    {
        public byte[] Timestamp { get; set; }
    }
}
