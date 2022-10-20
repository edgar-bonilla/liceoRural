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
        [Display(Name = "Apellido")]
        public string Apellidos { get; set; }
        public string EstadoCivil { get; set; }
        public enum IsEstadoCivil { Casado= 1, Divorsiado = 2,Soltero = 3 }

        [Required]
        [Display(Name = "Cedula")]
        public string DocumentoIdentidad { get; set; }
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
        public string TipoRelacion { get; set; }
        public enum IsTipoRelacion { Padre = 0, Madre = 1,Tio=2,Tia = 3,Abuelo = 4,Abuela = 5,Encarcado = 6 }
        [Required]
        [Display(Name = " Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }
       
    }
}
