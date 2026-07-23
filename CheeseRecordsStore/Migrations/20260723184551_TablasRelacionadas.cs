using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CheeseRecordsStore.Migrations
{
    /// <inheritdoc />
    public partial class TablasRelacionadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Beats");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Beats",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Beats",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LicenciaId",
                table: "Beats",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreArtistico = table.Column<string>(type: "text", nullable: false),
                    Rol = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    ArtistaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albumes_Artistas_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beats_AlbumId",
                table: "Beats",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Beats_GeneroId",
                table: "Beats",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Beats_LicenciaId",
                table: "Beats",
                column: "LicenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Albumes_ArtistaId",
                table: "Albumes",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beats_Albumes_AlbumId",
                table: "Beats",
                column: "AlbumId",
                principalTable: "Albumes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beats_Generos_GeneroId",
                table: "Beats",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beats_Licencias_LicenciaId",
                table: "Beats",
                column: "LicenciaId",
                principalTable: "Licencias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beats_Albumes_AlbumId",
                table: "Beats");

            migrationBuilder.DropForeignKey(
                name: "FK_Beats_Generos_GeneroId",
                table: "Beats");

            migrationBuilder.DropForeignKey(
                name: "FK_Beats_Licencias_LicenciaId",
                table: "Beats");

            migrationBuilder.DropTable(
                name: "Albumes");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Licencias");

            migrationBuilder.DropTable(
                name: "Artistas");

            migrationBuilder.DropIndex(
                name: "IX_Beats_AlbumId",
                table: "Beats");

            migrationBuilder.DropIndex(
                name: "IX_Beats_GeneroId",
                table: "Beats");

            migrationBuilder.DropIndex(
                name: "IX_Beats_LicenciaId",
                table: "Beats");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Beats");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Beats");

            migrationBuilder.DropColumn(
                name: "LicenciaId",
                table: "Beats");

            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Beats",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
