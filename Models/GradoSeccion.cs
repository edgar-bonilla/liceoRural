using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class GradoSeccion
    {
        [Key]
        public int IdGradoSeccion { get; set; }
        [Required]
        [Display(Name = "Grado")]
        public string DescripcionGrado { get; set; }
        [Required]
        [Display(Name = "Seccion ")]
        public string DescripcionSeccion { get; set; }
        public string Estado { get; set; }
        public enum estado { Activo = 0, Inactivo = 1 }
        [NotMapped]
        public List<Curso> ListaCurso { get; set; }
    }
}
