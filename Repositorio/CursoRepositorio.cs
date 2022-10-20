using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class CursoRepositorio : Repositorio<Curso>, ICursoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public CursoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Curso curso)
        {
            var cursoDb = _db.Curso.FirstOrDefault(b => b.Id == curso.Id);
            if (cursoDb != null)
            {
                cursoDb.NombreCurso = curso.NombreCurso;
                cursoDb.Descripcion = curso.Descripcion;
                cursoDb.Estado = curso.Estado;


            }
        }

    }
}
