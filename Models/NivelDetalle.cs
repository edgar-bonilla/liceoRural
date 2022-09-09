using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class NivelDetalle
    {
        [Key]
        public int IdNivelDetalle { get; set; }
        public int IdNivel { get; set; }
        [ForeignKey("IdNivel")]
        public virtual Nivel Nivel { get; set; }
        public int IdGradoSeccion { get; set; }
        [ForeignKey("IdGradoSeccion")]
        public virtual GradoSeccion GradoSeccion { get; set; }
        public int TotalVacantes { get; set; }
        public int VacantesDisponibles { get; set; }
        public int VacantesOcupadas { get; set; }
        public string Estado { get; set; }
        public enum IsEstado { Activo = 0, Inactivo= 1  }
    }
}
