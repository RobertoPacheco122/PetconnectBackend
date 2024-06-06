using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petconnect.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class FifthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalEntityServiceEntity_Animal_ServiceForId",
                table: "AnimalEntityServiceEntity");

            migrationBuilder.RenameColumn(
                name: "ServiceForId",
                table: "AnimalEntityServiceEntity",
                newName: "AnimalsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalEntityServiceEntity_Animal_AnimalsId",
                table: "AnimalEntityServiceEntity",
                column: "AnimalsId",
                principalTable: "Animal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimalEntityServiceEntity_Animal_AnimalsId",
                table: "AnimalEntityServiceEntity");

            migrationBuilder.RenameColumn(
                name: "AnimalsId",
                table: "AnimalEntityServiceEntity",
                newName: "ServiceForId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimalEntityServiceEntity_Animal_ServiceForId",
                table: "AnimalEntityServiceEntity",
                column: "ServiceForId",
                principalTable: "Animal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
