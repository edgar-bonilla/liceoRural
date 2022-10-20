using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface INivelRepositorio : IRepositorio<Nivel>
    {
        void Actualizar(Nivel nivel);
    }
}
