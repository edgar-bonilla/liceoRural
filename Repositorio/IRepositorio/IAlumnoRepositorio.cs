using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IAlumnoRepositorio : IRepositorio<Alumno>
    {
        void Actualizar(Alumno alumno);
    }
}
