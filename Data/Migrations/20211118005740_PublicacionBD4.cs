using Microsoft.EntityFrameworkCore.Migrations;

namespace proyect1_Publicaciones.Data.Migrations
{
    public partial class PublicacionBD4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "text",
                table: "Publicacion",
                newName: "texto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "texto",
                table: "Publicacion",
                newName: "text");
        }
    }
}
