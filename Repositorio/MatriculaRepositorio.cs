using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class MatriculaRepositorio : Repositorio<Matricula>, IMatriculaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public MatriculaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Matricula matricula)
        {
            var MatriculaDb = _db.Matricula.FirstOrDefault(b => b.Id == matricula.Id);
            if (MatriculaDb != null)
            {
                MatriculaDb.IdPeriodo = matricula.IdPeriodo;
                MatriculaDb.Nombre = matricula.Nombre;
                MatriculaDb.PrimerApellido = matricula.PrimerApellido;
                MatriculaDb.SegundoApellido = matricula.SegundoApellido;
                MatriculaDb.Cedula = matricula.Cedula;
                MatriculaDb.Edad  = matricula.Edad;
                MatriculaDb.Sexo = matricula.Sexo;
                MatriculaDb.FechaNacimiento= matricula.FechaNacimiento;
                MatriculaDb.IdGradoSeccion = matricula.IdGradoSeccion;
                MatriculaDb.InstitucionProcedencia = matricula.InstitucionProcedencia;
                MatriculaDb.Nacionalidad = matricula.Nacionalidad;
                MatriculaDb.LugarNacimiento = matricula.LugarNacimiento;
                MatriculaDb.Telefono = matricula.Telefono;
                MatriculaDb.Direccion = matricula.Direccion;
                MatriculaDb.Correo =    matricula.Correo;
                MatriculaDb.TieneExpediente = matricula.TieneExpediente;
                MatriculaDb.Repitente = matricula.Repitente;
                MatriculaDb.Adecucion = matricula.Adecucion;
                MatriculaDb.PadeceAlgunaEnfermedad = matricula.PadeceAlgunaEnfermedad;
                MatriculaDb.ConsumeTratamientos = matricula.ConsumeTratamientos;
               // Datos del encargado
               MatriculaDb.NombreEncargado = matricula.NombreEncargado;
               MatriculaDb.PrimerApellidoEncargado = matricula.PrimerApellidoEncargado;
               MatriculaDb.SegundoApellidoEncargado = matricula.SegundoApellidoEncargado;
               MatriculaDb.CedulaEncargado = matricula.CedulaEncargado;
               MatriculaDb.NacionalidadEncargado = matricula.NacionalidadEncargado;
               MatriculaDb.TelefonoEncargado = matricula.TelefonoEncargado;
               MatriculaDb.Ocupacion  = matricula.Ocupacion;
                MatriculaDb.TipoRelacion = matricula.TipoRelacion;

            }
        }

    }

  
}
