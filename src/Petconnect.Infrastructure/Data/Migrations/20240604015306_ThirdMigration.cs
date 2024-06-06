using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petconnect.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Service_ServiceEntityId",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_ServiceEntityId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "ServiceEntityId",
                table: "Animal");

            migrationBuilder.CreateTable(
                name: "AnimalEntityServiceEntity",
                columns: table => new
                {
                    ServiceForId = table.Column<Guid>(type: "uuid", nullable: false),
                    ServicesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalEntityServiceEntity", x => new { x.ServiceForId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_AnimalEntityServiceEntity_Animal_ServiceForId",
                        column: x => x.ServiceForId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalEntityServiceEntity_Service_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalEntityServiceEntity_ServicesId",
                table: "AnimalEntityServiceEntity",
                column: "ServicesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalEntityServiceEntity");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceEntityId",
                table: "Animal",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animal_ServiceEntityId",
                table: "Animal",
                column: "ServiceEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Service_ServiceEntityId",
                table: "Animal",
                column: "ServiceEntityId",
                principalTable: "Service",
                principalColumn: "Id");
        }
    }
}
