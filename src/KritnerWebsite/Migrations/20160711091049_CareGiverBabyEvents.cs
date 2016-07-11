using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KritnerWebsite.Migrations
{
    public partial class CareGiverBabyEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BabyEvents_CareGiverId",
                table: "BabyEvents",
                column: "CareGiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_BabyEvents_People_CareGiverId",
                table: "BabyEvents",
                column: "CareGiverId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BabyEvents_People_CareGiverId",
                table: "BabyEvents");

            migrationBuilder.DropIndex(
                name: "IX_BabyEvents_CareGiverId",
                table: "BabyEvents");
        }
    }
}
