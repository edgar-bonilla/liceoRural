using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Nivel
    {
        [Key]
        public int IdNivel { get; set; }
        public int IdPeriodo{ get; set; }
        [ForeignKey("IdPeriodo")]
        public virtual Periodo Periodo { get; set; }
        public string DescripcionNivel { get; set; }
        public string DescripcionTurno { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Estado { get; set; }
        public enum IsEstado { Activo , Inactivo  }
        public List<GradoSeccion> ListaGradoSeccion { get; set; }
    }
}
