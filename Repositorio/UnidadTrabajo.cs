

using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public ICursoRepositorio Curso { get; private set; }

        public IAlumnoRepositorio Alumno { get; private set; }

        public IPeriodoRepositorio Periodo { get; private set; }

        public IGradoSeccionRepositorio GradoSeccion { get; private set; }

        public INivelRepositorio Nivel { get; private set; }

        public IDocenteRepositorio Docente { get; private set; }

        public IMatriculaRepositorio Matricula { get; private set; }
        public IEncargadoRepositorio Encargado { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Curso = new CursoRepositorio(_db); // Inicializamos
            Alumno = new AlumnoRepositorio(_db);   
            Periodo = new PeriodoRepositorio(_db);
            GradoSeccion = new GradoSeccionRepositorio(_db);
            Nivel = new NivelRepositorio(_db);
            Docente = new DocenteRepositorio(_db);
           Matricula = new MatriculaRepositorio(_db);
            Encargado = new EncargadoRepositorio(_db);
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
