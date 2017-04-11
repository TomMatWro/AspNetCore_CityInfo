using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfo.API.Migrations
{
    public partial class FixPOINametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfinterest_Cities_CityId",
                table: "PointsOfinterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfinterest",
                table: "PointsOfinterest");

            migrationBuilder.RenameTable(
                name: "PointsOfinterest",
                newName: "PointsOfInterest");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfinterest_CityId",
                table: "PointsOfInterest",
                newName: "IX_PointsOfInterest_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest");

            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                newName: "PointsOfinterest");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointsOfinterest",
                newName: "IX_PointsOfinterest_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfinterest",
                table: "PointsOfinterest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfinterest_Cities_CityId",
                table: "PointsOfinterest",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
