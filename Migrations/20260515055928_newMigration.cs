using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteProject.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "EnergyDrinks");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EnergyDrinks",
                newName: "ServingSize");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "EnergyDrinks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "CaffeineContent",
                table: "EnergyDrinks",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Flavor",
                table: "EnergyDrinks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "EnergyDrinks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnergyDrinks",
                table: "EnergyDrinks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnergyDrinks",
                table: "EnergyDrinks");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "EnergyDrinks");

            migrationBuilder.DropColumn(
                name: "CaffeineContent",
                table: "EnergyDrinks");

            migrationBuilder.DropColumn(
                name: "Flavor",
                table: "EnergyDrinks");

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "EnergyDrinks");

            migrationBuilder.RenameTable(
                name: "EnergyDrinks",
                newName: "Items");

            migrationBuilder.RenameColumn(
                name: "ServingSize",
                table: "Items",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");
        }
    }
}
