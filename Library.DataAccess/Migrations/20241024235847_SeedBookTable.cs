using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PublicationDate", "Title" },
                values: new object[] { 1, "Edanur kılınç", 100, new DateTime(2024, 10, 25, 2, 58, 47, 206, DateTimeKind.Local).AddTicks(7689), "deneme kitap" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
