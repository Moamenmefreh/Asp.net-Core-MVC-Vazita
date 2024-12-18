using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hayaat_Karima.Migrations
{
    /// <inheritdoc />
    public partial class addrolesintablerole3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b34e0061-de38-44ac-8f4d-27268db96eb4", "e51af654-9e9a-4632-84ba-5c4ab60b19fe", "Pateint", "pateint" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DentelDeserversTB",
                table: "DecentLifeDeserversTB");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b34e0061-de38-44ac-8f4d-27268db96eb4");

            migrationBuilder.AlterColumn<int>(
                name: "SpecializatinIDPK",
                table: "SpecializatinTB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ResvID",
                table: "ReservationTB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CardID",
                table: "ReservationCardTB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "MCIDPK",
                table: "MedicalConstructionTB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "DocIDPK",
                table: "DoctorsTB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "DeserversID",
                table: "DecentLifeDeserversTB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ContactorID",
                table: "ContactUSTB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DecentLifeDeserversTB",
                table: "DecentLifeDeserversTB",
                column: "DeserversID");
        }
    }
}
