using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petconnect.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SixthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserWhoRequestedId",
                table: "Evaluation",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_UserWhoRequestedId",
                table: "Evaluation",
                column: "UserWhoRequestedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_CommonUser_UserWhoRequestedId",
                table: "Evaluation",
                column: "UserWhoRequestedId",
                principalTable: "CommonUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_CommonUser_UserWhoRequestedId",
                table: "Evaluation");

            migrationBuilder.DropIndex(
                name: "IX_Evaluation_UserWhoRequestedId",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "UserWhoRequestedId",
                table: "Evaluation");
        }
    }
}
