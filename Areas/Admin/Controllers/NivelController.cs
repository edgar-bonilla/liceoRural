using Microsoft.AspNetCore.Mvc;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using LICEORURALJASMINEZB.Models.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LICEORURALJASMINEZB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NivelController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public NivelController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Upsert(int? id)
        {
            NIvelViewModels nIvelViewModels = new NIvelViewModels()
            {
                Nivel = new Nivel(),
                PeriodoLista = _unidadTrabajo.Periodo.ObtenerTodos().Select(c => new SelectListItem
                {
                    Text = c.Descripcion,
                    Value = c.Id.ToString()
                }),
              

            };


            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(nIvelViewModels);
            }
            // Esto es para Actualizar
            nIvelViewModels.Nivel = _unidadTrabajo.Nivel.Obtener(id.GetValueOrDefault());
            if (nIvelViewModels.Nivel == null)
            {
                return NotFound();
            }

            return View(nIvelViewModels);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(NIvelViewModels nIvelViewModels)
        {
            if (ModelState.IsValid)
            {
                if (nIvelViewModels.Nivel.Id == 0)
                {
                    _unidadTrabajo.Nivel.Agregar(nIvelViewModels.Nivel);
                }
                else
                {
                    _unidadTrabajo.Nivel.Actualizar(nIvelViewModels.Nivel);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                nIvelViewModels.PeriodoLista = _unidadTrabajo.Periodo.ObtenerTodos().Select(c => new SelectListItem
                {
                    Text = c.Descripcion,
                    Value = c.Id.ToString()
                });
                if (nIvelViewModels.Nivel.Id !=0)
                {
                    nIvelViewModels.Nivel = _unidadTrabajo.Nivel.Obtener(nIvelViewModels.Nivel.Id);
                }
            }
            return View(nIvelViewModels.Nivel);
        }



        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.Nivel.ObtenerTodos(incluirPropiedades: "Periodo");
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var niveloDb = _unidadTrabajo.Nivel.Obtener(id);
            if (niveloDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
            _unidadTrabajo.Nivel.Remover(niveloDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Nivel Borrado Exitosamente" });
        }

        #endregion
    }

}
