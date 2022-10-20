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
    public class GradoSeccionController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public GradoSeccionController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Upsert(int? id)
        {
            GradoSeccion gradoSeccion = new GradoSeccion();
            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(gradoSeccion);
            }
            // Esto es para Actualizar
            gradoSeccion = _unidadTrabajo.GradoSeccion.Obtener(id.GetValueOrDefault());
            if (gradoSeccion== null)
            {
                return NotFound();
            }

            return View(gradoSeccion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(GradoSeccion gradoSeccion)
        {
            if (ModelState.IsValid)
            {
                if (gradoSeccion.Id == 0)
                {
                    _unidadTrabajo.GradoSeccion.Agregar(gradoSeccion);
                }
                else
                {
                    _unidadTrabajo.GradoSeccion.Actualizar(gradoSeccion);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            return View(gradoSeccion);
        }



        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.GradoSeccion.ObtenerTodos();
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var gradoSeccionDb = _unidadTrabajo.GradoSeccion.Obtener(id);
            if (gradoSeccionDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
            _unidadTrabajo.GradoSeccion.Remover(gradoSeccionDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Grado Seccion Borrado Exitosamente" });
        }

        #endregion
    }

}
