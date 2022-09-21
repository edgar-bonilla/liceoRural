using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        [Required]
        [Display(Name = "Curso")]
        public string NombreCurso { get; set; }
        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        public enum IsEstado { Activo = 1, Inactivo = 2  }


    }
}
