﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfo.API.Migrations
{
    public partial class CityInfoDbAddPOIDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PointsOfinterest",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PointsOfinterest");
        }
    }
}
