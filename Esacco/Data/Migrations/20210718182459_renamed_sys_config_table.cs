using Microsoft.EntityFrameworkCore.Migrations;

namespace Esacco.Data.Migrations
{
    public partial class renamed_sys_config_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sysConfigs",
                table: "sysConfigs");

            migrationBuilder.RenameTable(
                name: "sysConfigs",
                newName: "SysConfigs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SysConfigs",
                table: "SysConfigs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SysConfigs",
                table: "SysConfigs");

            migrationBuilder.RenameTable(
                name: "SysConfigs",
                newName: "sysConfigs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sysConfigs",
                table: "sysConfigs",
                column: "Id");
        }
    }
}
