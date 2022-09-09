using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class DocenteCurso
    {
        [Key]
        public int IdDocenteCurso { get; set; }
        public int IdNivelDetalleCurso { get; set; }
        [ForeignKey("IdNivelDetalleCurso")]
        public virtual NivelDetalleCurso NivelDetalleCurso { get; set; }
        public int IdDocente { get; set; }
        [ForeignKey("IdDocente")]
        public virtual Docente Docente { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        
        public enum IsEstado { Activo = 0, Inactivo = 0  }
    }
}
