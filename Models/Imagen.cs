using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Imagen
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
    }
}
