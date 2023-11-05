using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date", "TotalPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2016, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 65.91m },
                    { 2, new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 53m },
                    { 3, new DateTime(2014, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), 99.63m },
                    { 4, new DateTime(2017, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 28.03m },
                    { 5, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), 51.25m },
                    { 6, new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 64.06m },
                    { 7, new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 49.8m },
                    { 8, new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 43.21m },
                    { 9, new DateTime(2019, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), 17.13m },
                    { 10, new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 51.37m }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 9, 16, 23, 48, 176, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 19, 13, 2, 21, 812, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 8, 7, 56, 5, 86, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 9, 20, 9, 35, 445, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 9, 21, 27, 47, 174, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 24, 9, 15, 20, 284, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 25, 8, 27, 32, 694, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 17, 23, 42, 0, 382, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 7, 15, 41, 15, 839, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 9, 29, 7, 23, 25, 300, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 29, 0, 37, 29, 442, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 6, 5, 9, 26, 216, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 6, 10, 22, 55, 136, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 30, 23, 35, 33, 623, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 21, 16, 41, 26, 653, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 8, 8, 36, 15, 120, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 17, 22, 57, 46, 698, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 15, 0, 40, 28, 57, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 8, 11, 58, 27, 636, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 1, 13, 29, 12, 119, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 10, 0, 52, 6, 307, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 20, 20, 19, 28, 577, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 22, 14, 9, 35, 895, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 23, 6, 45, 55, 124, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 9, 8, 14, 46, 688, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 4, 1, 51, 6, 812, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 13, 54, 42, 808, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 17, 16, 20, 37, 919, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 11, 2, 51, 31, 912, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 5, 3, 46, 55, 129, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 10, 1, 2, 12, 44, 325, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 11, 22, 0, 10, 264, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 18, 22, 29, 11, 515, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 15, 15, 44, 59, 354, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 3, 20, 37, 17, 349, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 23, 15, 11, 14, 882, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 21, 6, 44, 28, 278, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 31, 4, 46, 8, 597, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 27, 12, 24, 23, 156, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 6, 14, 9, 10, 39, 780, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 27, 16, 16, 1, 928, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 7, 19, 3, 27, 1, 358, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 10, 19, 13, 14, 914, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 14, 16, 53, 40, 73, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 23, 13, 0, 3, 143, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 27, 17, 42, 14, 702, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 31, 12, 41, 49, 4, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 12, 9, 34, 6, 430, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 28, 14, 16, 10, 32, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 8, 15, 3, 25, 9, 212, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 18, 15, 16, 56, 509, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 30, 11, 55, 30, 145, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 19, 6, 49, 13, 418, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 20, 19, 2, 43, 777, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 20, 20, 20, 55, 507, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 4, 8, 8, 28, 617, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 3, 7, 20, 41, 27, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 22, 35, 8, 715, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 18, 14, 34, 24, 172, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 10, 6, 16, 33, 633, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 8, 23, 30, 37, 775, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 17, 4, 2, 34, 549, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 14, 9, 16, 3, 468, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 10, 22, 28, 41, 956, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 1, 15, 34, 34, 985, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 7, 29, 23, 452, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 21, 50, 55, 30, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 23, 33, 36, 390, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 10, 51, 35, 969, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 10, 12, 22, 20, 451, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 18, 23, 45, 14, 640, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 31, 19, 12, 36, 909, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 31, 13, 2, 44, 228, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 1, 5, 39, 3, 457, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 17, 7, 7, 55, 21, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 13, 0, 44, 15, 144, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 3, 12, 47, 51, 140, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 26, 15, 13, 46, 252, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 1, 44, 40, 245, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 16, 2, 40, 3, 461, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 12, 1, 5, 52, 658, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 20, 53, 18, 597, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 27, 21, 22, 19, 848, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 26, 14, 38, 7, 686, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 14, 19, 30, 25, 681, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 14, 4, 23, 214, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 30, 5, 37, 36, 610, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 3, 39, 16, 929, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 5, 11, 17, 31, 489, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 8, 3, 48, 113, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 7, 15, 9, 10, 261, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 27, 2, 20, 9, 690, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 21, 18, 6, 23, 246, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 25, 15, 46, 48, 405, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 11, 53, 11, 475, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 6, 16, 35, 23, 35, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 11, 34, 57, 337, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 23, 8, 27, 14, 763, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 6, 13, 9, 18, 365, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 26, 2, 18, 17, 545, DateTimeKind.Local).AddTicks(1817));
        }
    }
}
