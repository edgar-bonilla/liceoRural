using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable
    {
        ICursoRepositorio Curso { get; }
        IAlumnoRepositorio Alumno { get; }
        IPeriodoRepositorio Periodo { get; }
        IGradoSeccionRepositorio GradoSeccion { get; }
     
        IDocenteRepositorio Docente { get; }
        IMatriculaRepositorio Matricula { get; }
 

        void Guardar();
    }
}
