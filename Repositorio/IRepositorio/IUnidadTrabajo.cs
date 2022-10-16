using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {
        ICursoRepositorio Curso { get; }
        IAlumnoRepositorio Alumno { get; }

        void Guardar();
    }
}
