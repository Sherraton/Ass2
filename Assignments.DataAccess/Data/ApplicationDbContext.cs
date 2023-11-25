using Microsoft.EntityFrameworkCore;
using Assignments.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace Assignments.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "All Cars", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Audi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Austin", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Bajaj", DisplayOrder = 4 }
            );

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 1,
                    Make = "Kia",
                    Model = "Sportage",
                    LicenseNo = "PDJ",
                    Year = 2015,
                    EngineSize = "2000 cc",
                    Transmission = "Automatic",
                    Features = "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Drive, Airbags, Projector Lights, HiD Lights, Fog Lamps, USB Deck, DVD Deck / Screen, Bluetooth, Alloy Rims, Chrome Exhaust, Body Kit, Tray Cover, Tint, Alarm, Keyless Entry, Push Button Start, Steering Controls, Reverse Camera, Fabric Interior, Mirror Indicators",
                    AdditionalInformation = "ceramic coating. Dealer Maintained.",
                    Color = "Orange",
                    Mileage = "3300",
                    AskingPrice = 112000,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Vehicle
                {
                    Id = 2,
                    Make = "Nissan",
                    Model = "Altima",
                    LicenseNo = "PDD",
                    Year = 2014,
                    EngineSize = "V6 3500 cc",
                    Transmission = "Automatic",
                    Features = "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Disc Brakes, Airbags, Crystal Lights, Fog Lamps, CD Player, Bluetooth, Alloy Rims, Tint, Alarm, Keyless Entry, Push Button Start, Steering Controls, Reverse Sensors, Reverse Camera, Fabric Interior, Mirror Indicators",
                    AdditionalInformation = "Full package. 10-year ceramic coating. Dealer Maintained.",
                    Color = "Purple",
                    Mileage = "456321",
                    AskingPrice = 132000,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Vehicle
                {
                    Id = 3,
                    Make = "Toyota",
                    Model = "Rav 4",
                    LicenseNo = "PDM",
                    Year = 2015,
                    EngineSize = "2000 cc",
                    Transmission = "Automatic",
                    Features = "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Disc Brakes, Airbags, Crystal Lights, LED Running Lights, Fog Lamps, Chrome Accessories, CD Player, CD Changer, Bluetooth, Alloy Rims, Low Profile Tyres, Chrome Exhaust, Tint, Alarm, Keyless Entry, Intelligent Key, Push Button Start, Steering Controls, Reverse Sensors, Reverse Camera, Leather Interior, Mirror Indicators",
                    AdditionalInformation = "328i M Twin Turbo power. Modified red leather M package. New tyres. New battery. Just done a full service. Low mileage. Quick sale!",
                    Color = "Red",
                    Mileage = "637951",
                    AskingPrice = 225000,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Vehicle
                {
                    Id = 4,
                    Make = "Mitsubishi",
                    Model = "L200 Pickup 4x4",
                    LicenseNo = "TDB",
                    Year = 2014,
                    EngineSize = "2500 cc",
                    Transmission = "Manual, 5 Forward",
                    Features = "Air Condition, Power Windows, Power Locks, Power Mirrors, Power Steering, Anti-Locking Brakes, 4 Wheel Disc Brakes, Airbags, Crystal Lights, LED Running Lights, Fog Lamps, CD Player, USB Deck, Bluetooth, Alloy Rims, Sunroof, Tint, Alarm, Keyless Entry, Intelligent Key, Push Button Start, Steering Controls, Reverse Camera, Leather Interior, Mirror Indicators",
                    AdditionalInformation = "Full AMG package. 10-year ceramic coating. Dealer Maintained.",
                    Color = "Grey",
                    Mileage = "9513",
                    AskingPrice = 68000,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Vehicle
                {
                    Id = 5,
                    Make = "Nissan",
                    Model = "X-Trail Hybrid",
                    LicenseNo = "PDR",
                    Year = 2018,
                    EngineSize = "2000 cc",
                    Transmission = "Automatic",
                    Features = "Air Condition, Power Windows, Power Locks, Anti-Locking Brakes, Airbags, USB Deck, Bluetooth, Alloy Rims, Tint, GPS Tracking, Keyless Entry, Reverse Camera, Fabric Interior",
                    AdditionalInformation = "Owner migrating. Excellent condition. Barely driven due to pandemic. Quick sale!",
                    Color = "Green",
                    Mileage = "7563",
                    AskingPrice = 137000,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Vehicle
                {
                    Id = 6,
                    Make = "Honda",
                    Model = "City (CNG)",
                    LicenseNo = "PDP",
                    Year = 2017,
                    EngineSize = "1500 cc",
                    Transmission = "Automatic",
                    Features = "Air Condition, Power Windows, Power Locks, Power Steering, Anti-Locking Brakes, 4 Wheel Drive, Airbags, Crystal Lights, Fog Lamps, MP3 Deck, Bluetooth, Alloy Rims, Side Steps, Duraliner, Tint, Steering Controls, Reverse Camera, Fabric Interior",
                    AdditionalInformation = "XE 4x4 Nissan Frontier. Excellent condition, absolutely no issues, touch screen deck with Apple Car Play, new tyres.",
                    Color = "Pink",
                    Mileage = "65888",
                    AskingPrice = 100000,
                    CategoryId = 4,
                    ImageUrl = ""
                }
            );
        }

    }

    
}
