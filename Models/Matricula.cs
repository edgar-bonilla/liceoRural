using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }
        public int IdNivelDetalleCurso { get; set; }
        [ForeignKey(" IdNivelDetalleCurso")]
        public virtual NivelDetalleCurso NivelDetalleCurso { get; set; }

        public int IdAlumno { get; set; }
        [ForeignKey("IdAlumno")]
        public virtual Alumno Alumno { get; set; }
        public int IdNivelDetalle { get; set; }
        [ForeignKey(" IdNivelDetalle ")]
        public virtual NivelDetalle NivelDetalle { get; set; }
    }
}
