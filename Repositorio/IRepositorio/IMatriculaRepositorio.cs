using LICEORURALJASMINEZB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LICEORURALJASMINEZB.Repositorio.IRepositorio
{
    public interface IMatriculaRepositorio : IRepositorio<Matricula>
    {
        void Actualizar(Matricula matricula);
    }
}
