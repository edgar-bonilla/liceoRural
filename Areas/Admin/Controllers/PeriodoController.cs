using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;

namespace LICEORURALJASMINEZB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PeriodoController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public PeriodoController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Upsert(int? id)
        {
            Periodo periodo = new Periodo();
            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(periodo);
            }
            // Esto es para Actualizar
           periodo= _unidadTrabajo.Periodo.Obtener(id.GetValueOrDefault());
            if (periodo == null)
            {
                return NotFound();
            }

            return View(periodo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Periodo periodo)
        {
            if (ModelState.IsValid)
            {
                if (periodo.Id == 0)
                {
                    _unidadTrabajo.Periodo.Agregar(periodo);
                }
                else
                {
                    _unidadTrabajo.Periodo.Actualizar(periodo);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            return View(periodo);
        }



        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.Periodo.ObtenerTodos();
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var periodoDb = _unidadTrabajo.Periodo.Obtener(id);
            if (periodoDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
            _unidadTrabajo.Periodo.Remover(periodoDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Periodo Borrado Exitosamente" });
        }

        #endregion
    }

}
