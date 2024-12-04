using Microsoft.EntityFrameworkCore.Migrations;

namespace pruebahotel.Migrations
{
    public partial class PublisherAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "habitacionId_habitacion",
                table: "Reservaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_usuario",
                table: "Reservaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioid_usuario",
                table: "Reservaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hotelid_hotel",
                table: "habitaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_hotel",
                table: "habitaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_habitacionId_habitacion",
                table: "Reservaciones",
                column: "habitacionId_habitacion");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_usuarioid_usuario",
                table: "Reservaciones",
                column: "usuarioid_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_habitaciones_hotelid_hotel",
                table: "habitaciones",
                column: "hotelid_hotel");

            migrationBuilder.AddForeignKey(
                name: "FK_habitaciones_hotels_hotelid_hotel",
                table: "habitaciones",
                column: "hotelid_hotel",
                principalTable: "hotels",
                principalColumn: "id_hotel",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_habitaciones_habitacionId_habitacion",
                table: "Reservaciones",
                column: "habitacionId_habitacion",
                principalTable: "habitaciones",
                principalColumn: "Id_habitacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_usuarios_usuarioid_usuario",
                table: "Reservaciones",
                column: "usuarioid_usuario",
                principalTable: "usuarios",
                principalColumn: "id_usuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_habitaciones_hotels_hotelid_hotel",
                table: "habitaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_habitaciones_habitacionId_habitacion",
                table: "Reservaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_usuarios_usuarioid_usuario",
                table: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reservaciones_habitacionId_habitacion",
                table: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reservaciones_usuarioid_usuario",
                table: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_habitaciones_hotelid_hotel",
                table: "habitaciones");

            migrationBuilder.DropColumn(
                name: "habitacionId_habitacion",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "usuarioid_usuario",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "hotelid_hotel",
                table: "habitaciones");

            migrationBuilder.DropColumn(
                name: "id_hotel",
                table: "habitaciones");
        }
    }
}
