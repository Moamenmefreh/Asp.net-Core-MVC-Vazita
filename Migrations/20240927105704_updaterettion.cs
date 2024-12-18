using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hayaat_Karima.Migrations
{
    /// <inheritdoc />
    public partial class updaterettion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorsTB_SpecializatinTB_specializationIDFK",
                table: "DoctorsTB");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec1fd2fb-17f2-439a-8d6c-e7b411e8b9d6");

            migrationBuilder.AlterColumn<int>(
                name: "specializationIDFK",
                table: "DoctorsTB",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumberOFCasesMonthly",
                table: "DoctorsTB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocPhone",
                table: "DoctorsTB",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocName",
                table: "DoctorsTB",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bee5797-63a7-4ae7-a1d8-65499c127087", "e20b74ed-3f62-4208-9542-b1f8f42f3966", "Pateint", "pateint" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorsTB_SpecializatinTB_specializationIDFK",
                table: "DoctorsTB",
                column: "specializationIDFK",
                principalTable: "SpecializatinTB",
                principalColumn: "SpecializatinIDPK",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorsTB_SpecializatinTB_specializationIDFK",
                table: "DoctorsTB");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bee5797-63a7-4ae7-a1d8-65499c127087");

            migrationBuilder.AlterColumn<int>(
                name: "specializationIDFK",
                table: "DoctorsTB",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NumberOFCasesMonthly",
                table: "DoctorsTB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DocPhone",
                table: "DoctorsTB",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DocName",
                table: "DoctorsTB",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec1fd2fb-17f2-439a-8d6c-e7b411e8b9d6", "f56aceda-89a9-47e7-956e-6607a3b10cbb", "Pateint", "pateint" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorsTB_SpecializatinTB_specializationIDFK",
                table: "DoctorsTB",
                column: "specializationIDFK",
                principalTable: "SpecializatinTB",
                principalColumn: "SpecializatinIDPK");
        }
    }
}
