using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IDocenteRepositorio : IRepositorio<Docente>
    {
        void Actualizar(Docente docente);
    }
}
