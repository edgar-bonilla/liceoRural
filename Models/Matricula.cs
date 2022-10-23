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
        public int IdGradoSeccion { get; set; }
        [ForeignKey(" IdGradoSeccion ")]
        public virtual GradoSeccion GradoSeccion { get; set; }
        public int IdEncargado { get; set; }
        [ForeignKey(" IdEncargado")]
        public virtual Encargado Encargado { get; set; }
        public string InstitucionProcedencia  { get; set; }
        public string TieneExpediente { get; set; }
        public enum IsTieneExpediente { Si = 1, No = 2 }
        public string Repitente  { get; set; }
        public enum IsRepitente { Si = 1, No = 2 }
        public string Adecucion { get; set; }
        public enum IsAdecucion { Nosignificativa = 1, Significativa = 2, DeAcceso = 3,Sinadecuación = 4 }

        public string PadeceAlgunaEnfermedad { get; set; }

        public string ConsumeTratamientos { get; set; }
        public string InstituciónProcedencia { get; set; }

       

    }

}
