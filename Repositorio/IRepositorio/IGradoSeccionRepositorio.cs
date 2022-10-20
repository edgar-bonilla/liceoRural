using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IGradoSeccionRepositorio : IRepositorio<GradoSeccion>
    {
        void Actualizar(GradoSeccion gradoSeccion);
    }
}
