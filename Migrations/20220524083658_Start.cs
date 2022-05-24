using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_test_01.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Abu Dabi", "Josh Gomez", "123 456" },
                    { 2, "San Jose", "Miguel Alonso", "234 567" },
                    { 3, "Stockholm", "Andreas Kvarnblom", "345 678" },
                    { 4, "Stockholm", "Tore Kindwall", "456 789" },
                    { 5, "Göteborg", "Helena Danielsson", "567 890" },
                    { 6, "Alvesta", "Maria Persson", "678 901" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
