using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FilmesApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Director", "Duration", "Genre", "Name" },
                values: new object[,]
                {
                    { 1, "Jane Campion", 60, "Suspense", "Blade Runner" },
                    { 2, "Quentin Tarantino", 90, "Documentário", "Trainspotting - Sem Limites" },
                    { 3, "Sofia Coppola", 90, "Romance", "Gênio Indomável" },
                    { 4, "Petra Costa", 120, "Romance", "Titanic" },
                    { 5, "Sofia Coppola", 120, "Desenho", "Aliens, O Resgate" },
                    { 6, "Kathryn Bigelow", 60, "Ficção", "Um Sonho de Liberdade" },
                    { 7, "Jean-Luc Godard", 120, "Policial", "Blade Runner" },
                    { 8, "Alfred Hitchcock", 60, "Romance", "Noivo Neurótico, Noiva Nervosa" },
                    { 9, "Steven Spielberg", 90, "Aventura", "Uma Vida sem Limites" },
                    { 10, "Stanley Kubrick", 90, "Ficção", "Donnie Darko" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
