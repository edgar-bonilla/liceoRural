using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Periodo
    {
        [Key]
        public int IdPeriodo { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Fecha Incio")]
        public DateTime FechaInicio { get; set; }
        [Required]
        [Display(Name = "Fecha Fin")]
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public enum IsEstado { Activo = 0, Inactivo = 1  }
    }
}
