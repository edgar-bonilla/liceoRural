using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class NivelRepositorio : Repositorio<Nivel>, INivelRepositorio
    {
        private readonly ApplicationDbContext _db;

        public NivelRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Nivel nivel)
        {
            var nivelDb = _db.Nivel.FirstOrDefault(b => b.Id == nivel.Id);
            if (nivelDb != null)
            {
                nivelDb.IdPeriodo = nivel.IdPeriodo;
                nivelDb.DescripcionNivel = nivel.DescripcionNivel;
                nivelDb.DescripcionTurno = nivel.DescripcionTurno;
                nivelDb.HoraInicio = nivel.HoraInicio;
                nivelDb.HoraFin = nivel.HoraFin;
                nivelDb.Estado = nivel.Estado;


            }
        }

    }
}
