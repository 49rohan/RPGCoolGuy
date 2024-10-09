using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGCoolGuy.Migrations
{
    public partial class InitialD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attack = table.Column<int>(type: "int", nullable: true),
                    HP = table.Column<int>(type: "int", nullable: true),
                    Defense = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Attack", "Defense", "HP", "Name" },
                values: new object[] { 1, 20, 20, 5, "Dave" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Attack", "Defense", "HP", "Name" },
                values: new object[] { 2, 30, 30, 1, "Tony" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Attack", "Defense", "HP", "Name" },
                values: new object[] { 3, 99, 99, 9999, "Peter Griffin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
