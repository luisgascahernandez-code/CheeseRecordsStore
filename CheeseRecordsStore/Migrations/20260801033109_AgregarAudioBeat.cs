using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheeseRecordsStore.Migrations
{
    /// <inheritdoc />
    public partial class AgregarAudioBeat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AudioUrl",
                table: "Beats",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioUrl",
                table: "Beats");
        }
    }
}
