using Microsoft.EntityFrameworkCore.Migrations;

namespace RedSocialPerros.App.Persistencia.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cedula",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numero_registro",
                table: "Perros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_cedula",
                table: "Personas",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Perros_numero_registro",
                table: "Perros",
                column: "numero_registro",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Personas_cedula",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Perros_numero_registro",
                table: "Perros");

            migrationBuilder.DropColumn(
                name: "cedula",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "numero_registro",
                table: "Perros");
        }
    }
}
