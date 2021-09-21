using DixseptData.Entity.Table;
using Microsoft.EntityFrameworkCore;

namespace DixseptData
{
    public partial class DixseptContext: DbContext
    {
        /// <summary>
        /// 初期データ投入
        /// </summary>
        /// マスタデータの投入
        private void CreateSeeds(ModelBuilder modelBuilder) 
        {
            CreatePosition(modelBuilder);
            CreateTournament(modelBuilder);
        }

        /// <summary>
        /// ポジション
        /// </summary>
        private void CreatePosition(ModelBuilder modelBuilder) 
        {
            _ = modelBuilder.Entity<M_POSITION>().HasData(
                new M_POSITION { POSITION_CD = "1", POSITION_NAME = "Goleiro" },
                new M_POSITION { POSITION_CD = "2", POSITION_NAME = "Fixo" },
                new M_POSITION { POSITION_CD = "3", POSITION_NAME = "Ala" },
                new M_POSITION { POSITION_CD = "4", POSITION_NAME = "Pivo" }
                );
        }

        /// <summary>
        /// 大会
        /// </summary>
        private void CreateTournament(ModelBuilder modelBuilder) 
        {
            _ = modelBuilder.Entity<M_TOURNAMENT>().HasData(
                new M_TOURNAMENT { TOURNAMENT_ID = 1, TOUNAMENT_NAME = "埼玉県フットサル2部リーグ", SEASON_YEAR = "2021" },
                new M_TOURNAMENT { TOURNAMENT_ID = 2, TOUNAMENT_NAME = "埼玉県フットサル2部リーグ", SEASON_YEAR = "2022" },
                new M_TOURNAMENT { TOURNAMENT_ID = 3, TOUNAMENT_NAME = "埼玉県フットサル2部リーグ", SEASON_YEAR = "2023" },
                new M_TOURNAMENT { TOURNAMENT_ID = 4, TOUNAMENT_NAME = "全日本フットサル選手権大会埼玉県大会", SEASON_YEAR = "2021" },
                new M_TOURNAMENT { TOURNAMENT_ID = 5, TOUNAMENT_NAME = "全日本フットサル選手権大会埼玉県大会", SEASON_YEAR = "2022" }
                );
        }
    }
}
