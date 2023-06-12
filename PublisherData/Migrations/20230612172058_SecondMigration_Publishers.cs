using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration_Publishers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisherid",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Publisherid",
                table: "Authors",
                column: "Publisherid");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Publishers_Publisherid",
                table: "Authors",
                column: "Publisherid",
                principalTable: "Publishers",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Publishers_Publisherid",
                table: "Authors");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Authors_Publisherid",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Publisherid",
                table: "Authors");
        }
    }
}
