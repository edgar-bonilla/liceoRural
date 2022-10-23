using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Encargado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombres { get; set; }
        [Required]
        [Display(Name = " Primer Apellido")]
        public string PrimerApellido { get; set; }
        [Required]
        [Display(Name = " Segundo Apellido")]
        public string SegundoApellido { get; set; }
        public string EstadoCivil { get; set; }
        public enum IsEstadoCivil { Casado= 1, Divorsiado = 2,Soltero = 3 }
        [Required]
        [Display(Name = "Cedula")]
        public string DocumentoIdentidad { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
        public string TipoRelacion { get; set; }
        public enum IsTipoRelacion { Padre = 0, Madre = 1,Tio =2,Tia = 3,Abuelo = 4,Abuela = 5,Encarcado = 6 }
        [Required]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Required]
        [Display(Name = "Ocupación")]
        public string Ocupación { get; set; }


    }
}
