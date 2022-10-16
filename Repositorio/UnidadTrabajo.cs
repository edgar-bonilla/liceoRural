
using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public ICursoRepositorio Curso { get; private set; }

        public IAlumnoRepositorio Alumno { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Curso = new CursoRepositorio(_db); // Inicializamos

        }

        public void Guardar()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
