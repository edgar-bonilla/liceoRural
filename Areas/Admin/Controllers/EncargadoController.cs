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
    public class EncargadoController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public EncargadoController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Encargado encargado = new Encargado();
            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(encargado);
            }
            // Esto es para Actualizar
            encargado = _unidadTrabajo.Encargado.Obtener(id.GetValueOrDefault());
            if (encargado == null)
            {
                return NotFound();
            }

            return View(encargado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Encargado encargado)
        {
            if (ModelState.IsValid)
            {
                if (encargado.Id == 0)
                {
                    _unidadTrabajo.Encargado.Agregar(encargado);
                }
                else
                {
                    _unidadTrabajo.Encargado.Actualizar(encargado);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            return View(encargado);
        }



        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.Encargado.ObtenerTodos();
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var encargadoDb = _unidadTrabajo.Encargado.Obtener(id);
            if (encargadoDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
            _unidadTrabajo.Encargado.Remover(encargadoDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Curso Borrada Exitosamente" });
        }

        #endregion
    }

}
