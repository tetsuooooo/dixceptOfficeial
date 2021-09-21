using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DixseptData.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataProtectionKeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xml = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProtectionKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_PLAYER",
                columns: table => new
                {
                    PLAYER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UNIFORM_NUMBER = table.Column<int>(type: "int", nullable: false),
                    LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_NAME_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRST_NAME_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HEIGHT = table.Column<int>(type: "int", nullable: false),
                    WEIGHT = table.Column<int>(type: "int", nullable: false),
                    BIRTHDAY = table.Column<DateTime>(type: "Date", nullable: false),
                    BIRTH_PLACE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    POSITION_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    PLAYER_IMG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMMENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PLAYER", x => x.PLAYER_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_POSITION",
                columns: table => new
                {
                    POSITION_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    POSITION_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_POSITION", x => x.POSITION_CD);
                });

            migrationBuilder.CreateTable(
                name: "M_TEAM",
                columns: table => new
                {
                    TEAM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TEAM_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMBLEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TEAM", x => x.TEAM_ID);
                });

            migrationBuilder.CreateTable(
                name: "M_TOURNAMENT",
                columns: table => new
                {
                    TOURNAMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TOUNAMENT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SEASON_YEAR = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TOURNAMENT", x => x.TOURNAMENT_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_NEWS",
                columns: table => new
                {
                    NEWS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NEWS_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COMMENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NEWS_IMG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OFFICIAL_SCHEDULE_ID = table.Column<int>(type: "int", nullable: true),
                    PRACTICE_SCHEDULE_ID = table.Column<int>(type: "int", nullable: true),
                    PRACTICE_ID = table.Column<int>(type: "int", nullable: true),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_NEWS", x => x.NEWS_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_OFFICIAL_POINT",
                columns: table => new
                {
                    OFFICIAL_POINT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OFFICIAL_RESULT_ID = table.Column<int>(type: "int", nullable: false),
                    PLAYER_ID = table.Column<int>(type: "int", nullable: false),
                    POINT_CD = table.Column<bool>(type: "bit", nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OFFICIAL_POINT", x => x.OFFICIAL_POINT_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_OFFICIAL_RESULT",
                columns: table => new
                {
                    OFFICIAL_RESULT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    H_FIRST_TIME = table.Column<int>(type: "int", nullable: false),
                    A_FIRST_TIME = table.Column<int>(type: "int", nullable: false),
                    H_SECOND_TIME = table.Column<int>(type: "int", nullable: false),
                    A_SECOND_TIME = table.Column<int>(type: "int", nullable: false),
                    H_EX_FIRST_TIME = table.Column<int>(type: "int", nullable: true),
                    A_EX_FIRST_TIME = table.Column<int>(type: "int", nullable: true),
                    H_EX_LAST_TIME = table.Column<int>(type: "int", nullable: true),
                    A_EX_LAST_TIME = table.Column<int>(type: "int", nullable: true),
                    H_PK = table.Column<int>(type: "int", nullable: true),
                    A_PK = table.Column<int>(type: "int", nullable: true),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OFFICIAL_RESULT", x => x.OFFICIAL_RESULT_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_OFFICIAL_SCHEDULE",
                columns: table => new
                {
                    OFFICIAL_SCHEDULE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TOURNAMENT_ID = table.Column<int>(type: "int", nullable: false),
                    OPPONENT_ID = table.Column<int>(type: "int", nullable: false),
                    DATE = table.Column<DateTime>(type: "Date", nullable: false),
                    TIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLACE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CATEGORY = table.Column<int>(type: "int", nullable: false),
                    SECTION = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OFFICIAL_SCHEDULE", x => x.OFFICIAL_SCHEDULE_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PRACTICE_SCHEDULE",
                columns: table => new
                {
                    PRACTICE_SCHEDULE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE = table.Column<DateTime>(type: "Date", nullable: false),
                    TIME = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CATEGORY = table.Column<int>(type: "int", nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PRACTICE_SCHEDULE", x => x.PRACTICE_SCHEDULE_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PRACTICEGAME_DETAIL",
                columns: table => new
                {
                    PRACTICE_DETAIL_RESULT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRACTICEGAME_ID = table.Column<int>(type: "int", nullable: false),
                    GAME_TIME = table.Column<int>(type: "int", nullable: false),
                    GAME_COUNT = table.Column<int>(type: "int", nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PRACTICEGAME_DETAIL", x => x.PRACTICE_DETAIL_RESULT_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PRACTICEGAME_POINT",
                columns: table => new
                {
                    PRACTICE_POINT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRACTICEGAME_DETAIL_ID = table.Column<int>(type: "int", nullable: false),
                    PLAYER_ID = table.Column<int>(type: "int", nullable: false),
                    POINT_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATE_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PRACTICEGAME_POINT", x => x.PRACTICE_POINT_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PRACTICEGAME_SCHEDULE",
                columns: table => new
                {
                    PRACTICEGAME_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE = table.Column<DateTime>(type: "Date", nullable: false),
                    PLACE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPPONENT_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CATEGORY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PRACTICEGAME_SCHEDULE", x => x.PRACTICEGAME_ID);
                });

            migrationBuilder.InsertData(
                table: "M_POSITION",
                columns: new[] { "POSITION_CD", "CREATE_AT", "CREATE_BY", "POSITION_NAME", "Timestamp", "UPDATE_AT", "UPDATE_BY" },
                values: new object[,]
                {
                    { "1", null, null, "Goleiro", null, null, null },
                    { "2", null, null, "Fixo", null, null, null },
                    { "3", null, null, "Ala", null, null, null },
                    { "4", null, null, "Pivo", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "M_TOURNAMENT",
                columns: new[] { "TOURNAMENT_ID", "CREATE_AT", "CREATE_BY", "SEASON_YEAR", "TOUNAMENT_NAME", "Timestamp", "UPDATE_AT", "UPDATE_BY" },
                values: new object[,]
                {
                    { 1, null, null, "2021", "埼玉県フットサル2部リーグ", null, null, null },
                    { 2, null, null, "2022", "埼玉県フットサル2部リーグ", null, null, null },
                    { 3, null, null, "2023", "埼玉県フットサル2部リーグ", null, null, null },
                    { 4, null, null, "2021", "全日本フットサル選手権大会埼玉県大会", null, null, null },
                    { 5, null, null, "2022", "全日本フットサル選手権大会埼玉県大会", null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataProtectionKeys");

            migrationBuilder.DropTable(
                name: "M_PLAYER");

            migrationBuilder.DropTable(
                name: "M_POSITION");

            migrationBuilder.DropTable(
                name: "M_TEAM");

            migrationBuilder.DropTable(
                name: "M_TOURNAMENT");

            migrationBuilder.DropTable(
                name: "T_NEWS");

            migrationBuilder.DropTable(
                name: "T_OFFICIAL_POINT");

            migrationBuilder.DropTable(
                name: "T_OFFICIAL_RESULT");

            migrationBuilder.DropTable(
                name: "T_OFFICIAL_SCHEDULE");

            migrationBuilder.DropTable(
                name: "T_PRACTICE_SCHEDULE");

            migrationBuilder.DropTable(
                name: "T_PRACTICEGAME_DETAIL");

            migrationBuilder.DropTable(
                name: "T_PRACTICEGAME_POINT");

            migrationBuilder.DropTable(
                name: "T_PRACTICEGAME_SCHEDULE");
        }
    }
}
