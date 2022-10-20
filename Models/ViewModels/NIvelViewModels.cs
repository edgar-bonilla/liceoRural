using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Transactions;

namespace LICEORURALJASMINEZB.Models.ViewModels
{
    public class NIvelViewModels
    {
        public Nivel Nivel { get; set; }
        public IEnumerable<SelectListItem> PeriodoLista { get; set; }
    }
}
