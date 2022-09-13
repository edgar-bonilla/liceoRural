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
        public int IdEncargado { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombres { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string Apellidos { get; set; }
        [Required]
        [Display(Name = "Cedula")]
        public string DocumentoIdentidad { get; set; }
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string NumeroTelefono { get; set; }

        public string Estado { get; set; }
        public enum IsEstado { Activo = 0, Inactivo = 1 }

        [Required]
        [Display(Name = " Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }
       
    }
}
