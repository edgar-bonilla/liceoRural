using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LICEORURALJASMINEZB.Migrations
{
    public partial class addDocenteToDabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    IdDocente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentoIdentidad = table.Column<string>(nullable: false),
                    Nombres = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    Ciudad = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    NumeroTelefono = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.IdDocente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docente");
        }
    }
}
