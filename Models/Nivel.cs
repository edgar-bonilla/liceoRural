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
        [Required]
        [Display(Name = "Descripcion Nivel")]
        public string DescripcionNivel { get; set; }
        [Display(Name = "Descripcion Turno")]
        public string DescripcionTurno { get; set; }
        [Required]
        [Display(Name = "Fecha inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? HoraInicio { get; set; }
        [Required]
        [Display(Name = "Fecha Fin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? HoraFin { get; set; }
        public string Estado { get; set; }
        public enum IsEstado { Activo , Inactivo  }
        [NotMapped]
        public List<GradoSeccion> ListaGradoSeccion { get; set; }
    }
}
