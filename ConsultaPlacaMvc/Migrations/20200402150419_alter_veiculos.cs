using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultaPlacaMvc.Migrations
{
    public partial class alter_veiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Veiculos",
                type: "varchar(8)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Veiculos");
        }
    }
}
