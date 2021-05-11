using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionInventaireWebApp.Migrations
{
    public partial class mapuseradmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Admins_AdminId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Users",
                newName: "AdminID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AdminId",
                table: "Users",
                newName: "IX_Users_AdminID");

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Admins",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_users_admin",
                table: "Users",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "fk_users_admin",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserId",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "AdminID",
                table: "Users",
                newName: "AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AdminID",
                table: "Users",
                newName: "IX_Users_AdminId");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Admins_AdminId",
                table: "Users",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
