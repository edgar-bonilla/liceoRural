using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class DocenteRepositorio : Repositorio<Docente>, IDocenteRepositorio
    {
        private readonly ApplicationDbContext _db;

        public DocenteRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Docente docente)
        {
            var docenteDb = _db.Docente.FirstOrDefault(b => b.Id == docente.Id);
            if (docenteDb != null)
            {
                docenteDb.Nombres = docente.Nombres;
                docenteDb.Apellidos = docente.Apellidos;
                docenteDb.DocumentoIdentidad = docente.DocumentoIdentidad;
                docenteDb.Ciudad = docente.Ciudad;
                docenteDb.Direccion = docente.Direccion;
                docenteDb.Email = docente.Email;
                docenteDb.NumeroTelefono = docente.NumeroTelefono;
                docenteDb.FechaRegistro = docente.FechaRegistro;
            

            }
        }
    }
}
