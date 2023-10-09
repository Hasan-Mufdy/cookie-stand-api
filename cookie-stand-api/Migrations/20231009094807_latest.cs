using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cookie_stand_api.Migrations
{
    /// <inheritdoc />
    public partial class latest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cookiestands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minimum_customers_per_hour = table.Column<int>(type: "int", nullable: false),
                    Maximum_customers_per_hour = table.Column<int>(type: "int", nullable: false),
                    Average_cookies_per_sale = table.Column<double>(type: "float", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookiestands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HourlySales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hour = table.Column<int>(type: "int", nullable: false),
                    CookiestandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlySales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourlySales_Cookiestands_CookiestandId",
                        column: x => x.CookiestandId,
                        principalTable: "Cookiestands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cookiestands",
                columns: new[] { "Id", "Average_cookies_per_sale", "Description", "Location", "Maximum_customers_per_hour", "Minimum_customers_per_hour", "Owner" },
                values: new object[] { 1, 0.0, "desc", "amman", 20, 1, "owner1" });

            migrationBuilder.CreateIndex(
                name: "IX_HourlySales_CookiestandId",
                table: "HourlySales",
                column: "CookiestandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HourlySales");

            migrationBuilder.DropTable(
                name: "Cookiestands");
        }
    }
}
