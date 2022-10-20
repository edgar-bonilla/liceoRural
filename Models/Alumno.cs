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
        public int Id { get; set; }
        [Required(ErrorMessage = " El Nombre es requierido")]
        [Display(Name = "Nombre")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = " El Apellido es requierido")]
        [Display(Name = "Apellido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "La cedula es requierida")]
        [Display(Name = "Cedula")]
        public string DocumentoIdentidad { get; set; }
       
        [Required(ErrorMessage = "La Fecha Nacimiento es requierida ")]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime? FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El Sexo  es requierido")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
         public enum IsSexo { Femenino = 1, Masculino = 2 }
        [Required(ErrorMessage = "La Ciudad es requierida")]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "La Direcion es requierida")]
        [Display(Name = "Direcion")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El Correo es requierido")]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El Telefono es requierido")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{2})$", ErrorMessage = "Insertar el rango de 8 digitos")]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
  
        public string Estado { get; set; }
        public enum IsEstado {Activo = 1 , Inactivo = 2, Aplazado = 3 }
        [Required(ErrorMessage = "La Fecha de Registro es requierida")]
        [Display(Name = " Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime? FechaRegistro { get; set; }


    }
}
