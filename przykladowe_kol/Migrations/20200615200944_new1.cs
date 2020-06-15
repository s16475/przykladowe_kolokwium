using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace przykladowe_kol.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 1,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 15, 22, 9, 43, 244, DateTimeKind.Local).AddTicks(2704), new DateTime(2020, 6, 19, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 2,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 15, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7845), new DateTime(2020, 6, 20, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 3,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 15, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7939), new DateTime(2020, 6, 21, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 4,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 15, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7953), new DateTime(2020, 6, 22, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 5,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 15, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7964), new DateTime(2020, 6, 23, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "IdOrder",
                keyValue: 6,
                columns: new[] { "DataPrzyjecia", "DataRealizacji" },
                values: new object[] { new DateTime(2020, 6, 15, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7985), new DateTime(2020, 6, 24, 22, 9, 43, 248, DateTimeKind.Local).AddTicks(7991) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
