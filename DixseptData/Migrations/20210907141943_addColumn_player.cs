using Microsoft.EntityFrameworkCore.Migrations;

namespace DixseptData.Migrations
{
    public partial class addColumn_player : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PLAYER_IMG_OLD",
                table: "M_PLAYER",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PLAYER_IMG_OLD",
                table: "M_PLAYER");
        }
    }
}
