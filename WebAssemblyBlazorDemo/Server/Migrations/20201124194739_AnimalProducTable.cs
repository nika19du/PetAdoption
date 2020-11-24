using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAssemblyBlazorDemo.Server.Migrations
{
    public partial class AnimalProducTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedAge = table.Column<int>(type: "int", nullable: true),
                    AnimalKind = table.Column<int>(type: "int", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatPercentage = table.Column<int>(type: "int", nullable: false),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalKind", "DateOfBirth", "EstimatedAge", "Gender", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { 1, 0, null, 1, 1, "Max", "https://cdn.pixabay.com/photo/2017/06/24/09/13/dog-2437110__340.jpg" },
                    { 2, 1, new DateTime(2018, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Kitty", "https://cdn.pixabay.com/photo/2014/04/13/20/49/cat-323262__340.jpg" },
                    { 3, 0, null, 2, 0, "Lucy", "https://cdn.pixabay.com/photo/2018/03/18/18/06/australian-shepherd-3237735__340.jpg" },
                    { 4, 0, null, 3, 1, "Charlie", "https://cdn.pixabay.com/photo/2017/10/02/21/56/dog-2810484__340.jpg" },
                    { 5, 1, null, 1, 0, "Simba", "https://cdn.pixabay.com/photo/2017/11/09/21/41/cat-2934720__340.jpg" },
                    { 6, 1, null, 6, 1, "Sammy", "https://cdn.pixabay.com/photo/2017/03/14/14/49/cat-2143332__340.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductImageUrl", "VatPercentage" },
                values: new object[,]
                {
                    { 1, "Dogfood", 10.99m, "https://upload.wikimedia.org/wikipedia/commons/4/4f/Hundefutter.jpg", 21 },
                    { 2, "Catfood", 8.99m, "https://upload.wikimedia.org/wikipedia/commons/1/16/Whiskas_cat%27s_petfood_with_chicken_dry.jpg", 21 },
                    { 3, "Cat litter 50 liter", 15.12m, "https://www.publicdomainpictures.net/pictures/30000/velka/cat-litter.jpg", 21 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
