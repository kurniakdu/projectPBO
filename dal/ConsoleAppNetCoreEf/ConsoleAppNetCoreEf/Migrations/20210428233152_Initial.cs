using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppNetCoreEf.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orderan",
                columns: table => new
                {
                    NamaPemesan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelpPemesan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlamatPesanan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanyakPesanan = table.Column<int>(type: "int", nullable: false),
                    DurasiPesanan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orderan");
        }
    }
}
