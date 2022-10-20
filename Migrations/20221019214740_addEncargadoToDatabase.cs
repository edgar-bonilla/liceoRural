using Microsoft.EntityFrameworkCore.Migrations;

namespace LICEORURALJASMINEZB.Migrations
{
    public partial class addEncargadoToDatabase : Migration
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
                name: "FK_Matricula_encargado_IdEncargado",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Nivel_IdNivel",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Periodo_IdPeriodo",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_encargado",
                table: "encargado");

            migrationBuilder.RenameTable(
                name: "encargado",
                newName: "Encargado");

            migrationBuilder.AlterColumn<string>(
                name: "TipoRelacion",
                table: "Encargado",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Encargado",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encargado",
                table: "Encargado",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Alumno_IdAlumno",
                table: "Calificacion",
                column: "IdAlumno",
                principalTable: "Alumno",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Concentrado_IdConcentrado",
                table: "Calificacion",
                column: "IdConcentrado",
                principalTable: "Concentrado",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Concentrado_DocenteCurso_IdDocenteCurso",
                table: "Concentrado",
                column: "IdDocenteCurso",
                principalTable: "DocenteCurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_Docente_IdDocente",
                table: "DocenteCurso",
                column: "IdDocente",
                principalTable: "Docente",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "DocenteCurso",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Horario",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Alumno_IdAlumno",
                table: "Matricula",
                column: "IdAlumno",
                principalTable: "Alumno",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Encargado_IdEncargado",
                table: "Matricula",
                column: "IdEncargado",
                principalTable: "Encargado",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Nivel_IdNivel",
                table: "Matricula",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Periodo_IdPeriodo",
                table: "Matricula",
                column: "IdPeriodo",
                principalTable: "Periodo",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Nivel_Periodo_IdPeriodo",
                table: "Nivel",
                column: "IdPeriodo",
                principalTable: "Periodo",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalle",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_Nivel_IdNivel",
                table: "NivelDetalle",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Curso_IdCurso",
                table: "NivelDetalleCurso",
                column: "IdCurso",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalleCurso",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Nivel_IdNivel",
                table: "NivelDetalleCurso",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_NivelDetalle_IdNivelDetalle",
                table: "NivelDetalleCurso",
                column: "IdNivelDetalle",
                principalTable: "NivelDetalle",
                principalColumn: "Id",
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
                name: "FK_Matricula_Encargado_IdEncargado",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Nivel_IdNivel",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Periodo_IdPeriodo",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Encargado",
                table: "Encargado");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Encargado");

            migrationBuilder.RenameTable(
                name: "Encargado",
                newName: "encargado");

            migrationBuilder.AlterColumn<string>(
                name: "TipoRelacion",
                table: "encargado",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_encargado",
                table: "encargado",
                column: "Id");

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
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificacion_Concentrado_IdConcentrado",
                table: "Calificacion",
                column: "IdConcentrado",
                principalTable: "Concentrado",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Concentrado_DocenteCurso_IdDocenteCurso",
                table: "Concentrado",
                column: "IdDocenteCurso",
                principalTable: "DocenteCurso",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_Docente_IdDocente",
                table: "DocenteCurso",
                column: "IdDocente",
                principalTable: "Docente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocenteCurso_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "DocenteCurso",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Horario_NivelDetalleCurso_IdNivelDetalleCurso",
                table: "Horario",
                column: "IdNivelDetalleCurso",
                principalTable: "NivelDetalleCurso",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Alumno_IdAlumno",
                table: "Matricula",
                column: "IdAlumno",
                principalTable: "Alumno",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_encargado_IdEncargado",
                table: "Matricula",
                column: "IdEncargado",
                principalTable: "encargado",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Nivel_IdNivel",
                table: "Matricula",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Periodo_IdPeriodo",
                table: "Matricula",
                column: "IdPeriodo",
                principalTable: "Periodo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nivel_Periodo_IdPeriodo",
                table: "Nivel",
                column: "IdPeriodo",
                principalTable: "Periodo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalle",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalle_Nivel_IdNivel",
                table: "NivelDetalle",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Curso_IdCurso",
                table: "NivelDetalleCurso",
                column: "IdCurso",
                principalTable: "Curso",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_GradoSeccion_IdGradoSeccion",
                table: "NivelDetalleCurso",
                column: "IdGradoSeccion",
                principalTable: "GradoSeccion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_Nivel_IdNivel",
                table: "NivelDetalleCurso",
                column: "IdNivel",
                principalTable: "Nivel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NivelDetalleCurso_NivelDetalle_IdNivelDetalle",
                table: "NivelDetalleCurso",
                column: "IdNivelDetalle",
                principalTable: "NivelDetalle",
                principalColumn: "Id");
        }
    }
}
