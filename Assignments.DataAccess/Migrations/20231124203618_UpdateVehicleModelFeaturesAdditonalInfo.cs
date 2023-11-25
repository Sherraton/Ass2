using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignments.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVehicleModelFeaturesAdditonalInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalInformation",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Features",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalInformation", "Features" },
                values: new object[] { "ceramic coating. Dealer Maintained.", "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Drive, Airbags, Projector Lights, HiD Lights, Fog Lamps, USB Deck, DVD Deck / Screen, Bluetooth, Alloy Rims, Chrome Exhaust, Body Kit, Tray Cover, Tint, Alarm, Keyless Entry, Push Button Start, Steering Controls, Reverse Camera, Fabric Interior, Mirror Indicators" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalInformation", "Features" },
                values: new object[] { "Full package. 10-year ceramic coating. Dealer Maintained.", "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Disc Brakes, Airbags, Crystal Lights, Fog Lamps, CD Player, Bluetooth, Alloy Rims, Tint, Alarm, Keyless Entry, Push Button Start, Steering Controls, Reverse Sensors, Reverse Camera, Fabric Interior, Mirror Indicators" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalInformation", "Features" },
                values: new object[] { "328i M Twin Turbo power. Modified red leather M package. New tyres. New battery. Just done a full service. Low mileage. Quick sale!", "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Disc Brakes, Airbags, Crystal Lights, LED Running Lights, Fog Lamps, Chrome Accessories, CD Player, CD Changer, Bluetooth, Alloy Rims, Low Profile Tyres, Chrome Exhaust, Tint, Alarm, Keyless Entry, Intelligent Key, Push Button Start, Steering Controls, Reverse Sensors, Reverse Camera, Leather Interior, Mirror Indicators" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalInformation", "Features" },
                values: new object[] { "Full AMG package. 10-year ceramic coating. Dealer Maintained.", "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Disc Brakes, Airbags, Crystal Lights, LED Running Lights, Fog Lamps, CD Player, USB Deck, Bluetooth, Alloy Rims, Sunroof, Tint, Alarm, Keyless Entry, Intelligent Key, Push Button Start, Steering Controls, Reverse Camera, Leather Interior, Mirror Indicators" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdditionalInformation", "Features" },
                values: new object[] { "Owner migrating. Excellent condition. Barely driven due to pandemic. Quick sale!", "Air Condition, Power Windows, Power Locks, Anti-Locking Brakes, Airbags, USB Deck, Bluetooth, Alloy Rims, Tint, GPS Tracking, Keyless Entry, Reverse Camera, Fabric Interior" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalInformation", "Features" },
                values: new object[] { "XE 4x4 Nissan Frontier. Excellent condition, absolutely no issues, touch screen deck with Apple Car Play, new tyres.", "Air Condition, Power Windows, Power Locks, Power Steering, Anti-Locking Brakes, 4 Wheel Drive, Airbags, Crystal Lights, Fog Lamps, MP3 Deck, Bluetooth, Alloy Rims, Side Steps, Duraliner, Tint, Steering Controls, Reverse Camera, Fabric Interior" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalInformation",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Features",
                table: "Vehicles");
        }
    }
}
