using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_km2264.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Drama", "Nobuhiro Doi", false, "", "", "PG", "Flying Colors", (short)2015 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Romance", "Nobuhiro Doi", false, "", "", "PG-13", "We Made a Beautiful Bouquet", (short)2021 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Id", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action", "Testuro Kodama", false, "", "", "PG", "Dragonball Super: Super Hero", (short)2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
