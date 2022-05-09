using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repuesto",
                columns: table => new
                {
                    RepuestoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuesto", x => x.RepuestoId);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<int>(type: "int", nullable: true),
                    CantidadPuertas = table.Column<int>(type: "int", nullable: true),
                    Cilindrada = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Desperfecto",
                columns: table => new
                {
                    DesperfectoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManoDeObra = table.Column<float>(type: "real", nullable: false),
                    Tiempo = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desperfecto", x => x.DesperfectoId);
                    table.ForeignKey(
                        name: "FK_Desperfecto_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Desperfectos_Repuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesperfectoId = table.Column<int>(type: "int", nullable: false),
                    RepuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desperfectos_Repuestos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desperfectos_Repuestos_Desperfecto_DesperfectoId",
                        column: x => x.DesperfectoId,
                        principalTable: "Desperfecto",
                        principalColumn: "DesperfectoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Desperfectos_Repuestos_Repuesto_RepuestoId",
                        column: x => x.RepuestoId,
                        principalTable: "Repuesto",
                        principalColumn: "RepuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desperfecto_VehiculoId",
                table: "Desperfecto",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Desperfectos_Repuestos_DesperfectoId",
                table: "Desperfectos_Repuestos",
                column: "DesperfectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Desperfectos_Repuestos_RepuestoId",
                table: "Desperfectos_Repuestos",
                column: "RepuestoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desperfectos_Repuestos");

            migrationBuilder.DropTable(
                name: "Desperfecto");

            migrationBuilder.DropTable(
                name: "Repuesto");

            migrationBuilder.DropTable(
                name: "Vehiculo");
        }
    }
}
