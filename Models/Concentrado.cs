using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class Concentrado
    {
        [Key]
        public int Id { get; set; }

        public int IdDocenteNivelDetalleCurso { get; set; }
        public string Descripcion { get; set; }
     
      
    }
}
