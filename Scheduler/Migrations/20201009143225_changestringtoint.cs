using Microsoft.EntityFrameworkCore.Migrations;

namespace Scheduler.Migrations
{
    public partial class changestringtoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shift_AspNetUsers_UserId1",
                table: "Shift");

            migrationBuilder.DropIndex(
                name: "IX_Shift_UserId1",
                table: "Shift");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Shift");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Shift",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_UserId",
                table: "Shift",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shift_AspNetUsers_UserId",
                table: "Shift",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shift_AspNetUsers_UserId",
                table: "Shift");

            migrationBuilder.DropIndex(
                name: "IX_Shift_UserId",
                table: "Shift");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Shift",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Shift",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shift_UserId1",
                table: "Shift",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Shift_AspNetUsers_UserId1",
                table: "Shift",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
