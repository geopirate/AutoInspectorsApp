using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AutoInspectors.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inspection",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirFilter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternatorTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatteryTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrakeFluid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolantLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolantPH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTCCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineOil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontBrakes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RearBrakes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TireRotation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wires = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EngineSize = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransmissionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspection");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
