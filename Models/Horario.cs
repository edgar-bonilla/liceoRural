
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
        public int Id { get; set; }
   
        [Required]
        [Display(Name = "Dia Semana  ")]
        public string DiaSemana { get; set; }
        public enum IsDiaSemana { Lunes,Martes,Miercoles,Jueves,Viernes }
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
    }
}
