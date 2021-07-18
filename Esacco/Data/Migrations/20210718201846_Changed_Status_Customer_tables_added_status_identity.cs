using Microsoft.EntityFrameworkCore.Migrations;

namespace Esacco.Data.Migrations
{
    public partial class Changed_Status_Customer_tables_added_status_identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Statuses");

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Statuses",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StatusID",
                table: "Customers",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StatusID",
                table: "AspNetUsers",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusID",
                table: "AspNetUsers",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Statuses_StatusID",
                table: "Customers",
                column: "StatusID",
                principalTable: "Statuses",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Statuses_StatusID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Statuses_StatusID",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Customers_StatusID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StatusID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Statuses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");
        }
    }
}
