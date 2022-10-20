using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class GradoSeccionRepositorio : Repositorio<GradoSeccion>, IGradoSeccionRepositorio
    {
        private readonly ApplicationDbContext _db;

        public GradoSeccionRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(GradoSeccion gradoSeccion)
        {
            var gradoSeccionDb = _db.GradoSeccion.FirstOrDefault(b => b.Id == gradoSeccion.Id);
            if (gradoSeccionDb != null)
            {
                gradoSeccionDb.DescripcionGrado = gradoSeccion.DescripcionGrado;
                gradoSeccionDb.DescripcionSeccion = gradoSeccion.DescripcionSeccion;
                gradoSeccionDb.Estado = gradoSeccion.Estado;


            }
        }

       
    }
}
