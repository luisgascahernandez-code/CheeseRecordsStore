using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheeseRecordsStore.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCampoArtistas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Se comenta la creacion de la columna Letra porque ya existe en tu base de datos
            // migrationBuilder.AddColumn<string>(
            //     name: "Letra",
            //     table: "Beats",
            //     type: "text",
            //     nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombresArtistas",
                table: "Beats",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Se comenta la eliminacion para evitar conflictos futuros al revertir
            // migrationBuilder.DropColumn(
            //     name: "Letra",
            //     table: "Beats");

            migrationBuilder.DropColumn(
                name: "NombresArtistas",
                table: "Beats");
        }
    }
}