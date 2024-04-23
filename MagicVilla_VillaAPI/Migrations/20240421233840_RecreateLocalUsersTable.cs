using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class RecreateLocalUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
    name: "LocalUsers",
    columns: table => new
    {
        Id = table.Column<int>(nullable: false)
            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
        UserName = table.Column<string>(type: "varchar(255)", nullable: true),
        Name = table.Column<string>(type: "longtext", nullable: true),
        Password = table.Column<string>(type: "longtext", nullable: true),
        Role = table.Column<string>(type: "longtext", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_LocalUsers", x => x.Id);
    });
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 38, 40, 264, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 38, 40, 264, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 38, 40, 264, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 38, 40, 264, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 38, 40, 264, DateTimeKind.Local).AddTicks(9950));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 30, 13, 870, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 30, 13, 870, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 30, 13, 870, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 30, 13, 870, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 0, 30, 13, 870, DateTimeKind.Local).AddTicks(1340));
        }
    }
}
