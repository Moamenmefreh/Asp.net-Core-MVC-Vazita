using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hayaat_Karima.Migrations
{
    /// <inheritdoc />
    public partial class addtableappointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f716f49-803f-4764-b0d7-d1b03422653c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ba9db6d-008b-4a93-996a-b7c791385974", "3f8a60c4-819a-4acd-9f4a-3e0694bee8a9", "Pateint", "pateint" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ba9db6d-008b-4a93-996a-b7c791385974");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f716f49-803f-4764-b0d7-d1b03422653c", "dd121021-7d50-459c-9075-f9acfb1788a2", "Pateint", "pateint" });
        }
    }
}
