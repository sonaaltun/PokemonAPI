using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviewers_Reviewers_ReviewerId",
                table: "Reviewers");

            migrationBuilder.DropIndex(
                name: "IX_Reviewers_ReviewerId",
                table: "Reviewers");

            migrationBuilder.DropColumn(
                name: "ReviewerId",
                table: "Reviewers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Owners",
                newName: "LastName");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Owners");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Owners",
                newName: "Name");

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewerId",
                table: "Reviewers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviewers_ReviewerId",
                table: "Reviewers",
                column: "ReviewerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviewers_Reviewers_ReviewerId",
                table: "Reviewers",
                column: "ReviewerId",
                principalTable: "Reviewers",
                principalColumn: "Id");
        }
    }
}
