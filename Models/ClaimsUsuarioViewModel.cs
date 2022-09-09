using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Models
{
    public class ClaimsUsuarioViewModel
    {

        public ClaimsUsuarioViewModel()
        {
            Claims = new List<ClaimUsuario>();
        }


        public string IdUsuario { get; set; }
        public List<ClaimUsuario> Claims { get; set; }



        public class ClaimUsuario
        {
            public string TipoClaim { get; set; }
            public bool Seleccionado { get; set; }
        }
    }
}
