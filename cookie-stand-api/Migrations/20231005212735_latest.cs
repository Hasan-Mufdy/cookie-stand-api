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
                    HourlySales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minimum_customers_per_hour = table.Column<int>(type: "int", nullable: false),
                    Maximum_customers_per_hour = table.Column<int>(type: "int", nullable: false),
                    Average_cookies_per_sale = table.Column<double>(type: "float", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookiestands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cookiestands",
                columns: new[] { "Id", "Average_cookies_per_sale", "Description", "HourlySales", "Location", "Maximum_customers_per_hour", "Minimum_customers_per_hour", "Owner" },
                values: new object[] { 1, 0.0, "desc", "", "amman", 20, 1, "owner1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cookiestands");
        }
    }
}
