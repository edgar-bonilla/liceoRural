using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IEncargadoRepositorio : IRepositorio<Encargado>
    {
        void Actualizar(Encargado encagado);
    }
}
