using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hayaat_Karima.Migrations
{
    /// <inheritdoc />
    public partial class addrolesintablerole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactUSTB");

            migrationBuilder.DropTable(
                name: "DecentLifeDeserversTB");

            migrationBuilder.DropTable(
                name: "DoctorsTB");

            migrationBuilder.DropTable(
                name: "MedicalConstructionTB");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "ReservationCardTB");

            migrationBuilder.DropTable(
                name: "ReservationTB");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "SpecializatinTB");
        }
    }
}
