using Microsoft.EntityFrameworkCore.Migrations;

namespace pruebahotel.Migrations
{
    public partial class ManyToManyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservaciones_habitaciones_habitacionId_habitacion",
                table: "Reservaciones");

            migrationBuilder.DropIndex(
                name: "IX_Reservaciones_habitacionId_habitacion",
                table: "Reservaciones");

            migrationBuilder.DropColumn(
                name: "habitacionId_habitacion",
                table: "Reservaciones");

            migrationBuilder.CreateTable(
                name: "detalles_Reservas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_reservacion = table.Column<int>(type: "int", nullable: false),
                    Id_habitacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalles_Reservas", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalles_Reservas_habitaciones_Id_habitacion",
                        column: x => x.Id_habitacion,
                        principalTable: "habitaciones",
                        principalColumn: "Id_habitacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalles_Reservas_Reservaciones_id_reservacion",
                        column: x => x.id_reservacion,
                        principalTable: "Reservaciones",
                        principalColumn: "id_reservacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalles_Reservas_Id_habitacion",
                table: "detalles_Reservas",
                column: "Id_habitacion");

            migrationBuilder.CreateIndex(
                name: "IX_detalles_Reservas_id_reservacion",
                table: "detalles_Reservas",
                column: "id_reservacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalles_Reservas");

            migrationBuilder.AddColumn<int>(
                name: "habitacionId_habitacion",
                table: "Reservaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_habitacionId_habitacion",
                table: "Reservaciones",
                column: "habitacionId_habitacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservaciones_habitaciones_habitacionId_habitacion",
                table: "Reservaciones",
                column: "habitacionId_habitacion",
                principalTable: "habitaciones",
                principalColumn: "Id_habitacion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
