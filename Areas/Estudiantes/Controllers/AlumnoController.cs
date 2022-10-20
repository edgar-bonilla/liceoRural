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

namespace LICEORURALJASMINEZB.Areas.Estudiantes.Controllers
{
    [Area("Estudiantes")]
    public class AlumnoController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public AlumnoController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }


        public IActionResult Index()
        {
            return View();
        }
        


        public IActionResult Upsert(int? id)
        {
            Alumno alumno = new Alumno();
            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(alumno);
            }
            // Esto es para Actualizar
            alumno = _unidadTrabajo.Alumno.Obtener(id.GetValueOrDefault());
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                if (alumno.Id == 0)
                {
                    _unidadTrabajo.Alumno.Agregar(alumno);
                }
                else
                {
                    _unidadTrabajo.Alumno.Actualizar(alumno);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            return View(alumno);
        }



       
        #region API
        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var todos = _unidadTrabajo.Alumno.ObtenerTodos();
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var alumnoDb = _unidadTrabajo.Alumno.Obtener(id);
            if (alumnoDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
            _unidadTrabajo.Alumno.Remover(alumnoDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Alumno Borrado Exitosamente" });
        }

        #endregion
    }

}
