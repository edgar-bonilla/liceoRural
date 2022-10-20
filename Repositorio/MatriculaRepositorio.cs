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
                MatriculaDb.IdCurso = matricula.IdCurso;
                MatriculaDb.IdAlumno = matricula.IdAlumno;
                MatriculaDb.IdNivel = matricula.IdNivel;
                MatriculaDb.IdEncargado = matricula.IdEncargado;
                MatriculaDb.InstitucionProcedencia = matricula.InstitucionProcedencia;
                MatriculaDb.EstadoAlumno = matricula.EstadoAlumno;


            }
        }

    }

  
}
