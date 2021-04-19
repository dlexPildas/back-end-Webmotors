using Microsoft.EntityFrameworkCore.Migrations;

namespace teste_webmotors.Data.Migrations
{
    public partial class update_size_field_versao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Versao",
                table: "tb_AnuncioWebmotors",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Versao",
                table: "tb_AnuncioWebmotors",
                type: "varchar(45)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }
    }
}
