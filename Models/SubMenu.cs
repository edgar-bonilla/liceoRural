using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class SubMenu
    {
        [Key]
        public int IdSubMenu { get; set; }
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string NombreFormulario { get; set; }
        public enum Estado { Activo = 0, Inactivo = 1 }
        public DateTime FechaRegistro { get; set; }
    }
}
