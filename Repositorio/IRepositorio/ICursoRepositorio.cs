using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface ICursoRepositorio : IRepositorio<Curso>
    {
        void Actualizar(Curso curso);
    }
}
