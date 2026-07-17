using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheeseRecordsStore.Migrations
{
    /// <inheritdoc />
    public partial class AgregarGenerosMusicales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Beats",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Beats");
        }
    }
}
