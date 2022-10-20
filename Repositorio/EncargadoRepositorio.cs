using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio
{
    public class EncargadoRepositorio : Repositorio<Encargado>, IEncargadoRepositorio
    {
        private readonly ApplicationDbContext _db;

        public EncargadoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Encargado encargado)
        {
            var encargadoDb = _db.Encargado.FirstOrDefault(b => b.Id == encargado.Id);
            if (encargadoDb != null)
            {
                encargadoDb.Nombres = encargado.Nombres;
                encargadoDb.Apellidos = encargado.Apellidos;
                encargadoDb.EstadoCivil = encargado.EstadoCivil;
                encargadoDb.DocumentoIdentidad = encargado.DocumentoIdentidad;
                encargadoDb.Ciudad = encargado.Ciudad;
                encargadoDb.Direccion = encargado.Direccion;
                encargadoDb.Email = encargado.Email;
                encargadoDb.Telefono = encargado.Telefono;
                encargadoDb.TipoRelacion = encargado.TipoRelacion;
                encargadoDb.FechaRegistro = encargado.FechaRegistro;
            

            }
        }
    }
}
