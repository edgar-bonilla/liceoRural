using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LICEORURALJASMINEZB.Models.ViewModels
{
    public class MatriculaViewModels
    {
        public Matricula Matricula { get; set; }
        public IEnumerable<SelectListItem> PeriodoLista { get; set; }
        public IEnumerable<SelectListItem> AlumnoLista { get; set; }
        public IEnumerable<SelectListItem> CursoLista { get; set; }
        public IEnumerable<SelectListItem> EncargadoLista { get; set; }
        public IEnumerable<SelectListItem> NivelLista { get; set; }


    }
}
