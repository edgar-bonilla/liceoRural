using Microsoft.AspNetCore.Mvc;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using LICEORURALJASMINEZ.Utilidades;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace LICEORURALJASMINEZB.Areas.Docentes.Controllers
{
    [Area("Docentes")]
    [Authorize(Roles = DS.Role_Admin + "," + DS.Role_Docente)]
    public class DocenteController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public DocenteController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Upsert(int? id)
        {
            Docente docente = new Docente();
            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(docente);
            }
            // Esto es para Actualizar
            docente = _unidadTrabajo.Docente.Obtener(id.GetValueOrDefault());
            if (docente == null)
            {
                return NotFound();
            }

            return View(docente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Docente docente)
        {
            if (ModelState.IsValid)
            {
                if (docente.Id == 0)
                {
                    _unidadTrabajo.Docente.Agregar(docente);
                }
                else
                {
                    _unidadTrabajo.Docente.Actualizar(docente);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            return View(docente);
        }




        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.Docente.ObtenerTodos();
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var docenteDb = _unidadTrabajo.Docente.Obtener(id);
            if (docenteDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
            _unidadTrabajo.Docente.Remover(docenteDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Docente Borrado Exitosamente" });
        }

        #endregion
    }
}
