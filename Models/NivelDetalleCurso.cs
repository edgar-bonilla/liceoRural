using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class NivelDetalleCurso
    {
        [Key]
        public int Id { get; set; }
        public int IdNivelDetalle { get; set; }
        [ForeignKey("IdNivelDetalle")]
        public virtual NivelDetalle NivelDetalle { get; set; }
        public int IdNivel { get; set; }
        [ForeignKey("IdNivel")]
        public virtual  Nivel Nivel { get; set; }
        public int IdGradoSeccion { get; set; }
        [ForeignKey("IdGradoSeccion")]
        public virtual GradoSeccion GradoSeccion { get; set; }
        public int IdCurso { get; set; }
        [ForeignKey("IdCurso")]
        public virtual Curso Curso { get; set; }
    }
}
