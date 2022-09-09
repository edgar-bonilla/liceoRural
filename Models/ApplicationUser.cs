using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Caserio { get; set; }

        [NotMapped]
        public string Role { get; set; }
        //Nuevas propiedades para usar roles y asignación de un rol a un usuario

        [NotMapped]
        [Display(Name = "Rol para el usuario")]
        public string IdRol { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> ListaRoles { get; set; }
    }
}
