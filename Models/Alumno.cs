using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Alumno
    {

        [Key]
        [Display(Name = "ID")]
        public int IdAlumno { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombres { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string Apellidos { get; set; }
        [Required]
        [Display(Name = "Cedula")]
        public string DocumentoIdentidad { get; set; }
        [Required]
        [Display(Name = "Fecha_Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaNacimiento { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Required]
        [Display(Name = "Direcion")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Correo")]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
  
        public string Estado { get; set; }
        public enum IsEstado {Activo = 0 , Inactivo = 1 , Aplazado = 2 }
        [Required]
        [Display(Name = " Fecha_Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }


    }
}
