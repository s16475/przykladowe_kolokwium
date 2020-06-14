using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przykladowe_kol.Migrations
{
    public partial class create2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 21, 53, 10, 211, DateTimeKind.Local).AddTicks(8328), new DateTime(2020, 6, 18, 21, 53, 10, 217, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(73), new DateTime(2020, 6, 19, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 3,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(217), new DateTime(2020, 6, 20, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 4,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(232), new DateTime(2020, 6, 21, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 5,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(244), new DateTime(2020, 6, 22, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 6,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(263), new DateTime(2020, 6, 23, 21, 53, 10, 218, DateTimeKind.Local).AddTicks(268) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 20, 50, 22, 993, DateTimeKind.Local).AddTicks(6855), new DateTime(2020, 6, 18, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8738), new DateTime(2020, 6, 19, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 3,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8829), new DateTime(2020, 6, 20, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 4,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8842), new DateTime(2020, 6, 21, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 5,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8854), new DateTime(2020, 6, 22, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 6,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 14, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8873), new DateTime(2020, 6, 23, 20, 50, 22, 997, DateTimeKind.Local).AddTicks(8879) });
        }
    }
}
