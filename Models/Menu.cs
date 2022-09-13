using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Menu
    {
        [Key]
        public int IdMenu { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        public string Icono { get; set; }
        [NotMapped]
        public List<SubMenu> SubMenu { get; set; }
        public string Estado { get; set; }
        public enum IsEstado { Activo = 0, Inactivo = 1 }
        [Required]
        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro { get; set; }
    }
}
