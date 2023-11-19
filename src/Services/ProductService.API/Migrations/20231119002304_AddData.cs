using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductService.API.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Labels = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoverImg = table.Column<string>(name: "Hover_Img", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ColorOptions",
                columns: table => new
                {
                    ColorOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorOptions", x => x.ColorOptionId);
                    table.ForeignKey(
                        name: "FK_ColorOptions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Hover_Img", "Img", "Labels", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Fashion", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. \r\nThe point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters.", "img10", "img1", "Trending", "Green Dress For Woman", 38.0 },
                    { 2, "Fashion", "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\nProin eget tortor risus. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum ProductId orci porta dapibus.", "img9", "img2", "45% OFF", "T-Shirt For Men", 72.0 },
                    { 3, "Fashion", "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Vestibulum ante ipsum primis in \r\nfaucibus orci luctus et ultrices posuere cubilia Curae;", "img7", "img3", "50% OFF", "V-Neck Dress", 34.0 },
                    { 4, "Fashion", "Donec velit neque, auctor sit amet aliquam vel, ullamcorper sit amet ligula. Vestibulum ac diam sit \r\namet quam vehicula elementum sed sit amet dui. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim.", "img6", "img4", "Hot", "Maxi Dress", 43.0 },
                    { 5, "Fashion", "Donec sollicitudin molestie malesuada. Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\nVivamus suscipit tortor eget felis porttitor volutpat. Nulla quis lorem ut libero malesuada feugiat.", "img1", "img5", "Upcoming", "Fit-Flare Dress", 52.0 },
                    { 6, "Fashion", "Nulla quis lorem ut libero malesuada feugiat. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim. \r\nCurabitur non nulla sit amet nisl tempus convallis quis ac lectus. Donec sollicitudin molestie malesuada", "img4", "img6", "Upcoming", "Midi Dress", 14.0 },
                    { 7, "Fashion", "Donec rutrum congue leo eget malesuada. Curabitur arcu erat, accumsan ProductId imperdiet et, porttitor at sem. \r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim.", "img3", "img7", "Trending", "Tulip Dress", 41.0 },
                    { 8, "Fashion", "Nulla quis lorem ut libero malesuada feugiat. Donec sollicitudin molestie malesuada.\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rutrum congue leo eget malesuada.", "img2", "img8", "Best Selling", "Skater Dress", 21.0 },
                    { 9, "Fashion", " Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. \r\nCras ultricies ligula sed magna dictum porta. Donec sollicitudin molestie malesuada.", "img1", "img9", "Popular", "Boho Tops for Girls", 46.0 },
                    { 10, "Fashion", "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Donec\r\nrutrum congue leo eget malesuada. Sed porttitor lectus nibh. Proin eget tortor risus. Curabitur aliquet quam ProductId dui posuere blandit. ", "img3", "img10", "Top Choice", "Skater Dress", 74.0 }
                });

            migrationBuilder.InsertData(
                table: "ColorOptions",
                columns: new[] { "ColorOptionId", "Color", "Image", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "green", "img8", 1, 1 },
                    { 2, "red", "img9", 1, 1 },
                    { 3, "blue", "img7", 1, 1 },
                    { 4, "green", "img6", 2, 1 },
                    { 5, "red", "img10", 2, 1 },
                    { 6, "blue", "img5", 2, 1 },
                    { 7, "green", "img6", 3, 1 },
                    { 8, "red", "img7", 3, 1 },
                    { 9, "blue", "img8", 3, 1 },
                    { 10, "green", "img3", 4, 1 },
                    { 11, "red", "img9", 4, 1 },
                    { 12, "blue", "img5", 4, 1 },
                    { 13, "green", "img10", 5, 1 },
                    { 14, "red", "img9", 5, 1 },
                    { 15, "blue", "img2", 5, 1 },
                    { 16, "green", "img7", 6, 1 },
                    { 17, "red", "img8", 6, 1 },
                    { 18, "blue", "img9", 6, 1 },
                    { 19, "green", "img2", 7, 1 },
                    { 20, "red", "img8", 7, 1 },
                    { 21, "blue", "img1", 7, 1 },
                    { 22, "green", "img9", 8, 1 },
                    { 23, "red", "img8", 8, 1 },
                    { 24, "blue", "img10", 8, 1 },
                    { 25, "green", "img5", 9, 1 },
                    { 26, "red", "img6", 9, 1 },
                    { 27, "blue", "img7", 9, 1 },
                    { 28, "green", "img2", 10, 1 },
                    { 29, "red", "img3", 10, 1 },
                    { 30, "blue", "img4", 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "Count", "ProductId", "Rate" },
                values: new object[,]
                {
                    { 1, 30, 1, 3.8999999999999999 },
                    { 2, 80, 2, 3.2999999999999998 },
                    { 3, 156, 3, 4.9000000000000004 },
                    { 4, 190, 4, 1.8999999999999999 },
                    { 5, 20, 5, 3.6000000000000001 },
                    { 6, 120, 6, 3.8999999999999999 },
                    { 7, 10, 7, 1.8999999999999999 },
                    { 8, 20, 8, 2.8999999999999999 },
                    { 9, 120, 9, 3.8999999999999999 },
                    { 10, 220, 10, 3.8999999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColorOptions_ProductId",
                table: "ColorOptions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductId",
                table: "Ratings",
                column: "ProductId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorOptions");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
