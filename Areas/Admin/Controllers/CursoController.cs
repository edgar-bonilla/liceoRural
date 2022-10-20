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
using LICEORURALJASMINEZ.Utilidades;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace LICEORURALJASMINEZB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = DS.Role_Admin)]
    public class CursoController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public CursoController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }


        public IActionResult Index()
        {
            return View();
        }
        


        public IActionResult Upsert(int? id)
        {
            Curso curso = new Curso();
            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(curso);
            }
            // Esto es para Actualizar
            curso = _unidadTrabajo.Curso.Obtener(id.GetValueOrDefault());
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Curso curso)
        {
            if (ModelState.IsValid)
            {
                if (curso.Id == 0)
                {
                    _unidadTrabajo.Curso.Agregar(curso);
                }
                else
                {
                    _unidadTrabajo.Curso.Actualizar(curso);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            return View(curso);
        }



        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.Curso.ObtenerTodos();
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var cursoDb = _unidadTrabajo.Curso.Obtener(id);
            if (cursoDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
            _unidadTrabajo.Curso.Remover(cursoDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Curso Borrada Exitosamente" });
        }

        #endregion
    }

}
