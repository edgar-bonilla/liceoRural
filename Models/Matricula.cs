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
        public int Id { get; set; }
        public int IdPeriodo { get; set; }
        [ForeignKey(" IdPeriodo")]
        public virtual Periodo Periodo { get; set; }
        public int IdCurso { get; set; }
    
        [ForeignKey("CursoId")]
        public virtual Curso Curso { get; set; }
        public int IdAlumno { get; set; }
        [ForeignKey("IdAlumno")]
        public virtual Alumno Alumno { get; set; }
        public int IdNivel { get; set; }
        [ForeignKey(" IdNivel ")]
        public virtual Nivel Nivel { get; set; }
        public int IdEncargado { get; set; }
        [ForeignKey(" IdEncargado")]
        public virtual Encargado Encargado { get; set; }
        public string InstitucionProcedencia  { get; set; }

        public string EstadoAlumno  { get; set; }
        public enum IsEstadoAlumno { Nuevo = 1, Antiguo = 2 }
    }
}
