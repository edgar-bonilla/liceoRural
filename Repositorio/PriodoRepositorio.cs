using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class PeriodoRepositorio : Repositorio<Periodo>, IPeriodoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public PeriodoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Periodo periodo)
        {
            var periodoDb = _db.Periodo.FirstOrDefault(b => b.Id == periodo.Id);
            if (periodoDb != null)
            {
                periodoDb.Descripcion = periodo.Descripcion;
                periodoDb.FechaInicio = periodo.FechaInicio;
                periodoDb.FechaFin = periodo.FechaFin;
                periodoDb.Estado = periodo.Estado;


            }
        }

    }
}
