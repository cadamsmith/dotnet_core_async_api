using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Api.Migrations
{
    public partial class AddAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2002), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2003), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(1991), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2000), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2080), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2079), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2073), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2077), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2075), new DateTime(2022, 10, 6, 13, 40, 37, 461, DateTimeKind.Utc).AddTicks(2075) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24810dfc-2d94-4cc7-aab5-cdf98b83f0c9"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(672), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(679), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(745), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(743), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(739), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(742), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(741), new DateTime(2022, 10, 6, 9, 45, 7, 390, DateTimeKind.Utc).AddTicks(741) });
        }
    }
}
