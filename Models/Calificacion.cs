using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Calificacion
    {
        [Key]
        public int IdCalificacion { get; set; }
        public int IdConcentrado { get; set; }
        [ForeignKey("IdConcentrado")]
        public virtual Concentrado Concentrado { get; set; }
        public int IdAlumno { get; set; }
        [ForeignKey("IdAlumno")]
        public virtual Alumno Alumno { get; set; }
        public float Nota { get; set; }

    }
}
