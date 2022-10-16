using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IAlumnoRepositorio : IRepositorio<Alumno>
    {
        void Actualizar(Alumno alumno);
    }
}
