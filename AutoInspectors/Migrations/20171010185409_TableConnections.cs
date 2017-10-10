using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AutoInspectors.Migrations
{
    public partial class TableConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inspection",
                table: "Inspection");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Inspection");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Inspection");

            migrationBuilder.AlterColumn<string>(
                name: "VIN",
                table: "Vehicle",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlate",
                table: "Vehicle",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EngineSize",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "VehicleID",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "InspectionID",
                table: "Inspection",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "TransmissionFluid",
                table: "Inspection",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleID",
                table: "Inspection",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "VehicleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inspection",
                table: "Inspection",
                column: "InspectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_VehicleID",
                table: "Inspection",
                column: "VehicleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspection_Vehicle_VehicleID",
                table: "Inspection",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspection_Vehicle_VehicleID",
                table: "Inspection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inspection",
                table: "Inspection");

            migrationBuilder.DropIndex(
                name: "IX_Inspection_VehicleID",
                table: "Inspection");

            migrationBuilder.DropColumn(
                name: "VehicleID",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "InspectionID",
                table: "Inspection");

            migrationBuilder.DropColumn(
                name: "TransmissionFluid",
                table: "Inspection");

            migrationBuilder.DropColumn(
                name: "VehicleID",
                table: "Inspection");

            migrationBuilder.AlterColumn<string>(
                name: "VIN",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlate",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "EngineSize",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Inspection",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "Inspection",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inspection",
                table: "Inspection",
                column: "ID");
        }
    }
}
