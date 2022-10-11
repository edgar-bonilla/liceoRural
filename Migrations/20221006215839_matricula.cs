using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LICEORURALJASMINEZB.Migrations
{
    public partial class matricula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificacion_Alumno_IdAlumno",
                table: "Calificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificacion_Concentrado_IdConcentrado",
                table: "Calificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Concentrado_DocenteCurso_IdDocenteCurso",
                table: "Concentrado");

            migrationBuilder.DropForeignKey(
                name: "FK_DocenteCurso_Docente_IdDocente",
                table: "DocenteCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_DocenteCurso_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "DocenteCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Alumno_IdAlumno",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_NivelDetalle_IdNivelDetalle",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Nivel_Periodo_IdPeriodo",
                table: "Nivel");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalle_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalle_Nivel_IdNivel",
                table: "NivelDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_Curso_IdCurso",
                table: "NivelDetalleCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalleCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_Nivel_IdNivel",
                table: "NivelDetalleCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_NivelDetalle_IdNivelDetalle",
                table: "NivelDetalleCurso");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "encargado");

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Menu",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Menu",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Menu",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentoIdentidad",
                table: "Menu",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Menu",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "Menu",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroTelefono",
                table: "Menu",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Matricula",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Matricula",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Matricula",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentoIdentidad",
                table: "Matricula",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Matricula",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estadoi",
                table: "Matricula",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRegistro",
                table: "Matricula",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "Matricula",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroTelefono",
                table: "Matricula",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estadoi",
                table: "encargado",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Alumno_IdAlumno",
                table: "Calificacion",
                column: "IdAlumno",
                principalTable: "Alumno",
                principalColumn: "IdAlumno",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Concentrado_IdConcentrado",
                table: "Calificacion",
                column: "IdConcentrado",
                principalTable: "Concentrado",
                principalColumn: "IdConcentrado",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Concentrado_DocenteCurso_IdDocenteCurso",
                table: "Concentrado",
                column: "IdDocenteCurso",
                principalTable: "DocenteCurso",
                principalColumn: "IdDocenteCurso",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_Docente_IdDocente",
                table: "DocenteCurso",
                column: "IdDocente",
                principalTable: "Docente",
                principalColumn: "IdDocente",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "DocenteCurso",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "IdNivelDetalleCurso",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Horario",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "IdNivelDetalleCurso",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Alumno_IdAlumno",
                table: "Matricula",
                column: "IdAlumno",
                principalTable: "Alumno",
                principalColumn: "IdAlumno",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_NivelDetalle_IdNivelDetalle",
                table: "Matricula",
                column: "IdNivelDetalle",
                principalTable: "NivelDetalle",
                principalColumn: "IdNivelDetalle",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Matricula",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "IdNivelDetalleCurso",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Nivel_Periodo_IdPeriodo",
                table: "Nivel",
                column: "IdPeriodo",
                principalTable: "Periodo",
                principalColumn: "IdPeriodo",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalle",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "IdGradoSeccion",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_Nivel_IdNivel",
                table: "NivelDetalle",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "IdNivel",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Curso_IdCurso",
                table: "NivelDetalleCurso",
                column: "IdCurso",
                principalTable: "Curso",
                principalColumn: "IdCurso",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalleCurso",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "IdGradoSeccion",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Nivel_IdNivel",
                table: "NivelDetalleCurso",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "IdNivel",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_NivelDetalle_IdNivelDetalle",
                table: "NivelDetalleCurso",
                column: "IdNivelDetalle",
                principalTable: "NivelDetalle",
                principalColumn: "IdNivelDetalle",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificacion_Alumno_IdAlumno",
                table: "Calificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Calificacion_Concentrado_IdConcentrado",
                table: "Calificacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Concentrado_DocenteCurso_IdDocenteCurso",
                table: "Concentrado");

            migrationBuilder.DropForeignKey(
                name: "FK_DocenteCurso_Docente_IdDocente",
                table: "DocenteCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_DocenteCurso_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "DocenteCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_Horario_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Horario");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Alumno_IdAlumno",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_NivelDetalle_IdNivelDetalle",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Nivel_Periodo_IdPeriodo",
                table: "Nivel");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalle_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalle_Nivel_IdNivel",
                table: "NivelDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_Curso_IdCurso",
                table: "NivelDetalleCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalleCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_Nivel_IdNivel",
                table: "NivelDetalleCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_NivelDetalleCurso_NivelDetalle_IdNivelDetalle",
                table: "NivelDetalleCurso");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "DocumentoIdentidad",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "NumeroTelefono",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "DocumentoIdentidad",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "Estadoi",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "FechaRegistro",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "NumeroTelefono",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "Estadoi",
                table: "encargado");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "encargado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Alumno_IdAlumno",
                table: "Calificacion",
                column: "IdAlumno",
                principalTable: "Alumno",
                principalColumn: "IdAlumno");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Concentrado_IdConcentrado",
                table: "Calificacion",
                column: "IdConcentrado",
                principalTable: "Concentrado",
                principalColumn: "IdConcentrado");

            migrationBuilder.AddForeignKey(
                name: "FK_Concentrado_DocenteCurso_IdDocenteCurso",
                table: "Concentrado",
                column: "IdDocenteCurso",
                principalTable: "DocenteCurso",
                principalColumn: "IdDocenteCurso");

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_Docente_IdDocente",
                table: "DocenteCurso",
                column: "IdDocente",
                principalTable: "Docente",
                principalColumn: "IdDocente");

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "DocenteCurso",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "IdNivelDetalleCurso");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Horario",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "IdNivelDetalleCurso");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Alumno_IdAlumno",
                table: "Matricula",
                column: "IdAlumno",
                principalTable: "Alumno",
                principalColumn: "IdAlumno");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_NivelDetalle_IdNivelDetalle",
                table: "Matricula",
                column: "IdNivelDetalle",
                principalTable: "NivelDetalle",
                principalColumn: "IdNivelDetalle");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Matricula",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "IdNivelDetalleCurso");

            migrationBuilder.AddForeignKey(
                name: "FK_Nivel_Periodo_IdPeriodo",
                table: "Nivel",
                column: "IdPeriodo",
                principalTable: "Periodo",
                principalColumn: "IdPeriodo");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalle",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "IdGradoSeccion");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_Nivel_IdNivel",
                table: "NivelDetalle",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "IdNivel");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Curso_IdCurso",
                table: "NivelDetalleCurso",
                column: "IdCurso",
                principalTable: "Curso",
                principalColumn: "IdCurso");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalleCurso",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "IdGradoSeccion");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Nivel_IdNivel",
                table: "NivelDetalleCurso",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "IdNivel");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_NivelDetalle_IdNivelDetalle",
                table: "NivelDetalleCurso",
                column: "IdNivelDetalle",
                principalTable: "NivelDetalle",
                principalColumn: "IdNivelDetalle");
        }
    }
}
