using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductService.API.Migrations
{
    /// <inheritdoc />
    public partial class AddProductData : Migration
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
                    Labels = table.Column<string>(type: "nvarchar(24)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(24)", nullable: false),
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
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorOptions", x => x.ColorOptionId);
                    table.ForeignKey(
                        name: "FK_ColorOptions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Hover_Img", "Img", "Labels", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Ceket", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. \r\nThe point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters.", "https://i.ibb.co/DW63yV8/product10.png", "https://i.ibb.co/txFk7S2/product1.png", "Trending", "Green Dress For Woman", 38.0 },
                    { 2, "Fashion", "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\nProin eget tortor risus. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum ProductId orci porta dapibus.", "https://i.ibb.co/q7BzPCd/product9.png", "https://i.ibb.co/KKbNbV6/product2.png", "Discount45Percent", "T-Shirt For Men", 72.0 },
                    { 3, "Fashion", "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Vestibulum ante ipsum primis in \r\nfaucibus orci luctus et ultrices posuere cubilia Curae;", "https://i.ibb.co/Ttnm3Y1/product7.png", "https://i.ibb.co/1r601Rn/product3.png", "Discount50Percent", "V-Neck Dress", 34.0 },
                    { 4, "Ayakkabi", "Donec velit neque, auctor sit amet aliquam vel, ullamcorper sit amet ligula. Vestibulum ac diam sit \r\namet quam vehicula elementum sed sit amet dui. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim.", "https://i.ibb.co/Qdf0vcX/product6.png", "https://i.ibb.co/CJh01hw/product4.png", "Hot", "Maxi Dress", 43.0 },
                    { 5, "Jeans", "Donec sollicitudin molestie malesuada. Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\nVivamus suscipit tortor eget felis porttitor volutpat. Nulla quis lorem ut libero malesuada feugiat.", "https://i.ibb.co/txFk7S2/product1.png", "https://i.ibb.co/Y04d07J/product5.png", "Upcoming", "Fit-Flare Dress", 52.0 },
                    { 6, "Canta", "Nulla quis lorem ut libero malesuada feugiat. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim. \r\nCurabitur non nulla sit amet nisl tempus convallis quis ac lectus. Donec sollicitudin molestie malesuada", "https://i.ibb.co/CJh01hw/product4.png", "https://i.ibb.co/Qdf0vcX/product6.png", "Upcoming", "Midi Dress", 14.0 },
                    { 7, "Canta", "Donec rutrum congue leo eget malesuada. Curabitur arcu erat, accumsan ProductId imperdiet et, porttitor at sem. \r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque velit nisi, pretium ut lacinia in, elementum ProductId enim.", "https://i.ibb.co/1r601Rn/product3.png", "https://i.ibb.co/Ttnm3Y1/product7.png", "Trending", "Tulip Dress", 41.0 },
                    { 8, "Tshirts", "Nulla quis lorem ut libero malesuada feugiat. Donec sollicitudin molestie malesuada.\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Donec rutrum congue leo eget malesuada.", "https://i.ibb.co/KKbNbV6/product2.png", "https://i.ibb.co/HYLB0HY/product8.png", "BestSelling", "Skater Dress", 21.0 },
                    { 9, "Ayakkabi", " Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. \r\nCras ultricies ligula sed magna dictum porta. Donec sollicitudin molestie malesuada.", "https://i.ibb.co/txFk7S2/product1.png", "https://i.ibb.co/q7BzPCd/product9.png", "Popular", "Boho Tops for Girls", 46.0 },
                    { 10, "Canta", "Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Donec\r\nrutrum congue leo eget malesuada. Sed porttitor lectus nibh. Proin eget tortor risus. Curabitur aliquet quam ProductId dui posuere blandit. ", "https://i.ibb.co/1r601Rn/product3.png", "https://i.ibb.co/DW63yV8/product10.png", "TopChoice", "Skater Dress", 74.0 }
                });

            migrationBuilder.InsertData(
                table: "ColorOptions",
                columns: new[] { "ColorOptionId", "Color", "Image", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, "green", "https://i.ibb.co/HYLB0HY/product8.png", 1, 1 },
                    { 2, "red", "https://i.ibb.co/q7BzPCd/product9.png", 1, 1 },
                    { 3, "blue", "https://i.ibb.co/Ttnm3Y1/product7.png", 1, 1 },
                    { 4, "green", "https://i.ibb.co/Qdf0vcX/product6.png", 2, 1 },
                    { 5, "red", "https://i.ibb.co/DW63yV8/product10.png", 2, 1 },
                    { 6, "blue", "https://i.ibb.co/Y04d07J/product5.png", 2, 1 },
                    { 7, "green", "https://i.ibb.co/Qdf0vcX/product6.png", 3, 1 },
                    { 8, "red", "https://i.ibb.co/Ttnm3Y1/product7.png", 3, 1 },
                    { 9, "blue", "https://i.ibb.co/HYLB0HY/product8.png", 3, 1 },
                    { 10, "green", "https://i.ibb.co/1r601Rn/product3.png", 4, 1 },
                    { 11, "red", "https://i.ibb.co/q7BzPCd/product9.png", 4, 1 },
                    { 12, "blue", "https://i.ibb.co/Y04d07J/product5.png", 4, 1 },
                    { 13, "green", "https://i.ibb.co/DW63yV8/product10.png", 5, 1 },
                    { 14, "red", "https://i.ibb.co/q7BzPCd/product9.png", 5, 1 },
                    { 15, "blue", "https://i.ibb.co/KKbNbV6/product2.png", 5, 1 },
                    { 16, "green", "https://i.ibb.co/Ttnm3Y1/product7.png", 6, 1 },
                    { 17, "red", "https://i.ibb.co/HYLB0HY/product8.png", 6, 1 },
                    { 18, "blue", "https://i.ibb.co/q7BzPCd/product9.png", 6, 1 },
                    { 19, "green", "https://i.ibb.co/KKbNbV6/product2.png", 7, 1 },
                    { 20, "red", "https://i.ibb.co/HYLB0HY/product8.png", 7, 1 },
                    { 21, "blue", "https://i.ibb.co/txFk7S2/product1.png", 7, 1 },
                    { 22, "green", "https://i.ibb.co/q7BzPCd/product9.png", 8, 1 },
                    { 23, "red", "https://i.ibb.co/HYLB0HY/product8.png", 8, 1 },
                    { 24, "blue", "https://i.ibb.co/DW63yV8/product10.png", 8, 1 },
                    { 25, "green", "https://i.ibb.co/Y04d07J/product5.png", 9, 1 },
                    { 26, "red", "https://i.ibb.co/Qdf0vcX/product6.png", 9, 1 },
                    { 27, "blue", "https://i.ibb.co/Ttnm3Y1/product7.png", 9, 1 },
                    { 28, "green", "https://i.ibb.co/KKbNbV6/product2.png", 10, 1 },
                    { 29, "red", "https://i.ibb.co/1r601Rn/product3.png", 10, 1 },
                    { 30, "blue", "https://i.ibb.co/CJh01hw/product4.png", 10, 1 }
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
                unique: true,
                filter: "[ProductId] IS NOT NULL");
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
