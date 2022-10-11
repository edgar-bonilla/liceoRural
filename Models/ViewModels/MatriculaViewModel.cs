using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models.ViewModels
{
    public class MatriculaViewModel
    {
        public Matricula Matricula { get; set; }
        public IEnumerable<Alumno> Alumno { get; set; }
        public IEnumerable<NivelDetalleCurso> nivelDetalleCurso { get; set; }
        public IEnumerable<NivelDetalle> NivelDetalle { get; set; }
    }
}
