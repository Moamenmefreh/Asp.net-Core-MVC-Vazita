using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hayaat_Karima.Migrations
{
    /// <inheritdoc />
    public partial class addtablepateint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b34e0061-de38-44ac-8f4d-27268db96eb4");

            migrationBuilder.CreateTable(
                name: "Pateints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pateints", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec1fd2fb-17f2-439a-8d6c-e7b411e8b9d6", "f56aceda-89a9-47e7-956e-6607a3b10cbb", "Pateint", "pateint" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pateints");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec1fd2fb-17f2-439a-8d6c-e7b411e8b9d6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b34e0061-de38-44ac-8f4d-27268db96eb4", "e51af654-9e9a-4632-84ba-5c4ab60b19fe", "Pateint", "pateint" });
        }
    }
}
