using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Horario
    {
        [Key]
        public int IdHorario { get; set; }
        public int IdNivelDetalleCurso { get; set; }
        [ForeignKey("IdNivelDetalleCurso")]
        public virtual NivelDetalleCurso NivelDetalleCurso { get; set; }
        public string DiaSemana { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Estado { get; set; }
        public enum IsEstado { Activo , Inactivo  }
    }
}
