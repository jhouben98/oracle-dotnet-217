using Microsoft.EntityFrameworkCore.Migrations;

namespace oracle_dotnet_217.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TESTSCHEMA");

            migrationBuilder.CreateTable(
                name: "TEST",
                schema: "TESTSCHEMA",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEST", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEST",
                schema: "TESTSCHEMA");
        }
    }
}
