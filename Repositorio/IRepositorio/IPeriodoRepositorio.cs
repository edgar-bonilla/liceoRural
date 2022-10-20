using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IPeriodoRepositorio : IRepositorio<Periodo>
    {
        void Actualizar(Periodo periodo);
    }
}
