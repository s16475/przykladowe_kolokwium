using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przykladowe_kol.Migrations
{
    public partial class create1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    PricePerUnit = table.Column<float>(nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPrzyjecia = table.Column<DateTime>(nullable: false),
                    DataRealizacji = table.Column<DateTime>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: true),
                    IdClient = table.Column<int>(nullable: false),
                    IdEmployee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Order_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Employee_IdEmployee",
                        column: x => x.IdEmployee,
                        principalTable: "Employee",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Product",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false),
                    IdOrder = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: true),
                    OrderIdOrder = table.Column<int>(nullable: true),
                    ProductIdProduct = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Product", x => new { x.IdOrder, x.IdProduct });
                    table.ForeignKey(
                        name: "FK_Order_Product_Order_OrderIdOrder",
                        column: x => x.OrderIdOrder,
                        principalTable: "Order",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Product_Product_ProductIdProduct",
                        column: x => x.ProductIdProduct,
                        principalTable: "Product",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "IdClient", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Adam", "Adamowski" },
                    { 2, "Marian", "Pazdzioch" },
                    { 3, "Ferdynand", "Kiepski" },
                    { 4, "Arnold", "Boczek" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "IdEmployee", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Marcin", "Olejnik" },
                    { 2, "Tomasz", "Pulawski" },
                    { 3, "Tomasz", "Siedlecki" },
                    { 4, "Anna", "Karenina" }
                });

            migrationBuilder.InsertData(
                table: "Order_Product",
                columns: new[] { "IdOrder", "IdProduct", "OrderIdOrder", "ProductIdProduct", "Quantity", "Uwagi" },
                values: new object[,]
                {
                    { 6, 4, null, null, 4, null },
                    { 5, 3, null, null, 2, null },
                    { 4, 2, null, null, 1, null },
                    { 1, 1, null, null, 5, null },
                    { 2, 1, null, null, 10, null },
                    { 3, 2, null, null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "IdProduct", "Name", "PricePerUnit", "Type" },
                values: new object[,]
                {
                    { 3, "Szarotka", 25.5f, "large" },
                    { 1, "Paczek", 3.4f, "small" },
                    { 2, "Tort", 30f, "large" },
                    { 4, "Wuzetka", 1.5f, "small" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "IdOrder", "DataPrzyjecia", "DataRealizacji", "IdClient", "IdEmployee", "Uwagi" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 14, 20, 50, 22, 993, DateTimeKind.Local).AddTicks(6855), new DateTime(2020, 6, 18, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(5739), 1, 1, null },
                    { 2, new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8738), new DateTime(2020, 6, 19, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8770), 1, 1, null },
                    { 3, new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8829), new DateTime(2020, 6, 20, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8835), 2, 2, null },
                    { 4, new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8842), new DateTime(2020, 6, 21, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8848), 3, 3, null },
                    { 5, new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8854), new DateTime(2020, 6, 22, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8859), 4, 3, null },
                    { 6, new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8873), new DateTime(2020, 6, 23, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8879), 4, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdClient",
                table: "Order",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdEmployee",
                table: "Order",
                column: "IdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Product_OrderIdOrder",
                table: "Order_Product",
                column: "OrderIdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Product_ProductIdProduct",
                table: "Order_Product",
                column: "ProductIdProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order_Product");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
