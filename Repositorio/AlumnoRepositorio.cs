using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class AlumnoRepositorio : Repositorio<Alumno>, IAlumnoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public AlumnoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Alumno alumno)
        {
            var alumnoDb = _db.Alumno.FirstOrDefault(b => b.Id == alumno.Id);
            if (alumnoDb != null)
            {
                alumnoDb.Nombres = alumno.Nombres;
                alumnoDb.Apellidos = alumno.Apellidos;
                alumnoDb.DocumentoIdentidad = alumno.DocumentoIdentidad;
                alumnoDb.FechaNacimiento = alumno.FechaNacimiento;
                alumnoDb.Sexo = alumno.Sexo;
                alumnoDb.Ciudad = alumno.Ciudad;
                alumnoDb.Direccion = alumno.Direccion;
                alumnoDb.Correo = alumno.Correo;
                alumnoDb.Telefono = alumno.Telefono;
                alumnoDb.Estado = alumno.Estado;
                alumnoDb.FechaRegistro = alumno.FechaRegistro;
            

            }
        }
    }
}
