
using System.Linq;
using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Models.ViewModels;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace SistemaInventario.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MatriculaController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public MatriculaController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Upsert(int? id)
        {
            MatriculaViewModels matriculaViewModels = new MatriculaViewModels()
            {
                Matricula = new Matricula(),
                PeriodoLista = _unidadTrabajo.Periodo.ObtenerTodos().Select(c => new SelectListItem
                {
                    Text = c.Descripcion,
                    Value = c.Id.ToString()
                }),
                NivelLista = _unidadTrabajo.GradoSeccion.ObtenerTodos().Select(p => new SelectListItem
                {
                    Text = p.DescripcionGrado,
                    Value = p.Id.ToString()
                })
            };


            if (id == null)
            {
                //Esto es para Crear nuevo Registro
                return View(matriculaViewModels);
            }
            //Esto es para Actualizar
            matriculaViewModels.Matricula = _unidadTrabajo.Matricula.Obtener(id.GetValueOrDefault());
            if (matriculaViewModels.Matricula == null)
            {
                return NotFound();
            }

            return View(matriculaViewModels);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(MatriculaViewModels matriculaViewModels)
        {
            if (ModelState.IsValid)
            {
                if (matriculaViewModels.Matricula.Id == 0)
                {
                    _unidadTrabajo.Matricula.Agregar(matriculaViewModels.Matricula);
                }
                else
                {
                    _unidadTrabajo.Matricula.Actualizar(matriculaViewModels.Matricula);
                }
                _unidadTrabajo.Guardar();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                matriculaViewModels.PeriodoLista = _unidadTrabajo.Periodo.ObtenerTodos().Select(c => new SelectListItem
                {
                    Text = c.Descripcion,
                    Value = c.Id.ToString()
                });
             
                matriculaViewModels.NivelLista = _unidadTrabajo.GradoSeccion.ObtenerTodos().Select(p => new SelectListItem
                {
                    Text = p.DescripcionGrado,
                    Value = p.Id.ToString()
                });
                if (matriculaViewModels.Matricula.Id != 0)
                {
                    matriculaViewModels.Matricula = _unidadTrabajo.Matricula.Obtener(matriculaViewModels.Matricula.Id);
                }
            }
            return View(matriculaViewModels.Matricula);
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