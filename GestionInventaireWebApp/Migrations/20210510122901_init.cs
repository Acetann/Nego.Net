using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionInventaireWebApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Admins_AdminId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Types_TypeId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Admins_AdminId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Admins_AdminId",
                table: "Providers");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Citys_CityId",
                table: "Providers");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Admins_AdminId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "fk_users_admin",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Citys_CityId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Users_AdminID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CityId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_AdminId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Providers_AdminId",
                table: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_Providers_CityId",
                table: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AdminId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AdminId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Articles",
                newName: "CategorieId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_TypeId",
                table: "Articles",
                newName: "IX_Articles_CategorieId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategorieId",
                table: "Articles",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategorieId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategorieId",
                table: "Articles",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CategorieId",
                table: "Articles",
                newName: "IX_Articles_TypeId");

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Stocks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Providers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Providers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Types_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdminID",
                table: "Users",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_AdminId",
                table: "Stocks",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_AdminId",
                table: "Providers",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_CityId",
                table: "Providers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AdminId",
                table: "Orders",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AdminId",
                table: "Articles",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_AdminId",
                table: "Types",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Admins_AdminId",
                table: "Articles",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Types_TypeId",
                table: "Articles",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Admins_AdminId",
                table: "Orders",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_Admins_AdminId",
                table: "Providers",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_Citys_CityId",
                table: "Providers",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Admins_AdminId",
                table: "Stocks",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_users_admin",
                table: "Users",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Citys_CityId",
                table: "Users",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
