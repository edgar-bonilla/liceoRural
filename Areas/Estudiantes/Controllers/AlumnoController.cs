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
            return Json(new { success = true, message = "Curso Borrada Exitosamente" });
        }

        #endregion
    }
}
