using DixseptData.Entity;
using DixseptData.Entity.Common;
using DixseptData.Entity.Table;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DixseptData
{
    public partial class DixseptContext : DbContext, IDataProtectionKeyContext
    {
        public DixseptContext(DbContextOptions<DixseptContext> options) : base(options)
        {
        }

        // データ保護キー格納用テーブル
        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }

        #region table

        public DbSet<M_PLAYER> M_PLAYER { get; set; }

        public DbSet<M_POSITION> M_POSITION { get; set; }

        public DbSet<M_TEAM> M_TEAM { get; set; }

        public DbSet<M_TOURNAMENT> M_TOURNAMENT { get; set; }

        public DbSet<T_NEWS> T_NEWS { get; set; }

        public DbSet<T_OFFICIAL_SCHEDULE> T_OFFICIAL_SCHEDULE { get; set; }

        public DbSet<T_OFFICIAL_POINT> T_OFFICIAL_POINT {get;set;}

        public DbSet<T_OFFICIAL_RESULT> T_OFFICIAL_RESULT { get; set; }

        public DbSet<T_PRACTICE_SCHEDULE> T_PRACTICE_SCHEDULE { get; set; }

        public DbSet<T_PRACTICEGAME_SCHEDULE> T_PRACTICEGAME_SCHEDULE { get; set; }

        public DbSet<T_PRACTICEGAME_DETAIL> T_PRACTICEGAME_DETAIL { get; set; }

        public DbSet<T_PRACTICEGAME_POINT> T_PRACTICEGAME_POINT { get; set; }

        #endregion

        #region メソッド
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // 複合キー
            //modelBuilder.Entity<テーブル名>().HasKey(c => new { カラム, カラム });

            // インデックス
            //modelBuilder.Entity<テーブル名>().HasIndex(x => new { カラム名 });

            // 初期データ投入
            CreateSeeds(modelBuilder);
        }
        #endregion

        /// <summary>
        /// create/updateを自動更新するためのオーバーライド
        /// </summary>
        public override int SaveChanges()
        {
            var utc = DateTime.Now;
            var entries = ChangeTracker.Entries().Where(x => (x.State == EntityState.Added
            || x.State == EntityState.Modified)
            && x.Entity != null
            && x.Entity as ITimeStumpEntity != null
            ).Select(x => new { EntityBase = x.Entity as ITimeStumpEntity, x.State });
            
            foreach (var entry in entries) 
            {
                if (entry.State == EntityState.Added) 
                {
                    entry.EntityBase.CREATE_AT = utc;
                }
                entry.EntityBase.UPDATE_AT = utc;
            }

            return base.SaveChanges();
        }

        /// <summary>
        /// 全エンティティの変更追跡解除
        /// </summary>
        /// saveChange()前の情報を全部破棄するために使用する
        /// 使用例 レコードの追加or削除or変更→savechange呼び出しDB反映→反映失敗→
        /// 同一接続で別のテーブルに更新行いたい場合に反映が失敗したデータを削除するために使う
        public void DetachAllEntities() 
        {
            // 変更があったエンティティー
            var changeEntities = this.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added
                || x.State == EntityState.Modified
                || x.State == EntityState.Deleted).ToList();

            foreach (var entry in changeEntities) 
            {
                entry.State = EntityState.Detached;
            }
        }
    }

   
}
