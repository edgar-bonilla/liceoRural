using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICEORURALJASMINEZB.Areas.Admin
{
    [Area("Admin")]
    public class GradoporNivelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GradoporNivelController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult prueba()
        {
            var data = _context.Periodo.ToList();
            return new JsonResult(data);

        }



        public JsonResult Listar(int idnivel = 0)
        {

            List<GradoSeccion> Lista = new List<GradoSeccion>();
           

            List<GradoSeccion> ListaGradoSeccionAsignados = new List<GradoSeccion>();
            List<GradoSeccion> ListaGradoSeccion = _context.GradoSeccion.ToList();
            List<NivelDetalle> ListaNivelDetalle = _context.NivelDetalle.ToList();
            List<Periodo> ListaPeriodo = _context.Periodo.ToList();


            if (ListaNivelDetalle != null)
            {
                ListaNivelDetalle = ListaNivelDetalle.Where(x => x.Nivel.Id == idnivel).ToList();

            }
            foreach (GradoSeccion a in ListaGradoSeccion)
            {
                bool encontrado = false;
                foreach (GradoSeccion b in ListaGradoSeccionAsignados)
                {
                    if (a.Id == b.Id)
                    {
                        encontrado = true;
                        break;
                    }
                }
                a.Asignado = encontrado;
                Lista.Add(a);
            }
            return new JsonResult(Lista);
        }
       
    }
}
