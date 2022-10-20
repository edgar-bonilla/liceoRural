
using System.Linq;
using LICEORURALJASMINEZB.Models;
using LICEORURALJASMINEZB.Models.ViewModels;
using LICEORURALJASMINEZB.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


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
                AlumnoLista = _unidadTrabajo.Alumno.ObtenerTodos().Select(m => new SelectListItem
                {
                    Text = m.Nombres,
                    Value = m.Id.ToString()
                }),
                CursoLista = _unidadTrabajo.Curso.ObtenerTodos().Select(p => new SelectListItem
                {
                    Text = p.Descripcion,
                    Value = p.Id.ToString()
                }),
                  EncargadoLista = _unidadTrabajo.Encargado.ObtenerTodos().Select(p => new SelectListItem
                   {
                       Text = p.Nombres,
                       Value = p.Id.ToString()
                   }),
                    NivelLista = _unidadTrabajo.Nivel.ObtenerTodos().Select(p => new SelectListItem
                     {
                         Text = p.DescripcionTurno,
                         Value = p.Id.ToString()
                     })
            };


            if (id == null)
            {
                // Esto es para Crear nuevo Registro
                return View(matriculaViewModels);
            }
            // Esto es para Actualizar
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
                matriculaViewModels.AlumnoLista = _unidadTrabajo.Alumno.ObtenerTodos().Select(m => new SelectListItem
                {
                    Text = m.Nombres,
                    Value = m.Id.ToString()
                });
                matriculaViewModels.CursoLista = _unidadTrabajo.Curso.ObtenerTodos().Select(p => new SelectListItem
                {
                    Text = p.Descripcion,
                    Value = p.Id.ToString()
                });
                  matriculaViewModels.EncargadoLista = _unidadTrabajo.Encargado.ObtenerTodos().Select(p => new SelectListItem
                  {
                      Text = p.Nombres,
                      Value = p.Id.ToString()
                  });
                    matriculaViewModels.NivelLista = _unidadTrabajo.Nivel.ObtenerTodos().Select(p => new SelectListItem
                    {
                        Text = p.DescripcionTurno,
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
            var todos = _unidadTrabajo.Matricula.ObtenerTodos(incluirPropiedades: "Periodo,Alumno,Curso,Encargado,Nivel");
            return Json(new { data = todos });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var matriculaDb = _unidadTrabajo.Matricula.Obtener(id);
            if (matriculaDb == null)
            {
                return Json(new { success = false, message = "Error al Borrar" });
            }
          
            _unidadTrabajo.Matricula.Remover(matriculaDb);
            _unidadTrabajo.Guardar();
            return Json(new { success = true, message = "Producto Borrado Exitosamente" });
        }

        #endregion
    }
}