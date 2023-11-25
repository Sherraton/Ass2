using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignments.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addVehiclesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    EngineSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AskingPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "AskingPrice", "EngineSize", "LicenseNo", "Make", "Model", "Transmission", "Year" },
                values: new object[,]
                {
                    { 1, 112000.0, "2000 cc", "PDJ", "Kia", "Sportage", "Automatic", 2015 },
                    { 2, 132000.0, "V6 3500 cc", "PDD", "Nissan", "Altima", "Automatic", 2014 },
                    { 3, 225000.0, "2000 cc", "PDM", "Toyota", "Rav 4", "Automatic", 2015 },
                    { 4, 68000.0, "2500 cc", "TDB", "Mitsubishi", "L200 Pickup 4x4", "Manual, 5 Forward", 2014 },
                    { 5, 137000.0, "2000 cc", "PDR", "Nissan", "X-Trail Hybrid", "Automatic", 2018 },
                    { 6, 100000.0, "1500 cc", "PDP", "Honda", "City (CNG)", "Automatic", 2017 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
