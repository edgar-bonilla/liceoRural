using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;

namespace LICEORURALJASMINEZB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MatriculaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatriculaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Matricula
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Matricula.Include(m => m.Alumno).Include(m => m.Curso).Include(m => m.Nivel).Include(m => m.Periodo);
            return View(await applicationDbContext.ToListAsync());
        }
        public JsonResult Prueba() {

            var data = _context.Matricula.Include(m => m.Alumno).Include(m => m.Curso).Include(m => m.Nivel).Include(m => m.Periodo).ToList();
            return new JsonResult(data);
        
        }



        // GET: Admin/Matricula/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matricula = await _context.Matricula
                .Include(m => m.Alumno)
                .Include(m => m.Curso)
                .Include(m => m.Nivel)
                .Include(m => m.Periodo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matricula == null)
            {
                return NotFound();
            }

            return View(matricula);
        }
    
        public IActionResult Create()
        {
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Nombres");
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Descripcion","NombreCurso");
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "DescripcionNivel");
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion");
            return View();
        }

        // POST: Admin/Matricula/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMatricula,IdPeriodo,IdCurso,IdAlumno,IdNivel")] Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matricula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos", matricula.IdAlumno);
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Descripcion", matricula.IdCurso);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "DescripcionNivel", matricula.IdNivel);
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion", matricula.IdPeriodo);
            return View(matricula);
        }

        // GET: Admin/Matricula/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matricula = await _context.Matricula.FindAsync(id);
            if (matricula == null)
            {
                return NotFound();
            }
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos", matricula.IdAlumno);
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Descripcion", matricula.IdCurso);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "DescripcionNivel", matricula.IdNivel);
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion", matricula.IdPeriodo);
            return View(matricula);
        }

        // POST: Admin/Matricula/Edit/5
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMatricula,IdPeriodo,IdCurso,IdAlumno,IdNivel")] Matricula matricula)
        {
            if (id != matricula.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matricula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatriculaExists(matricula.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos", matricula.IdAlumno);
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Descripcion", matricula.IdCurso);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "DescripcionNivel", matricula.IdNivel);
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion", matricula.IdPeriodo);
            return View(matricula);
        }

        // GET: Admin/Matricula/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matricula = await _context.Matricula
                .Include(m => m.Alumno)
                .Include(m => m.Curso)
                .Include(m => m.Nivel)
                .Include(m => m.Periodo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matricula == null)
            {
                return NotFound();
            }

            return View(matricula);
        }

        // POST: Admin/Matricula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matricula = await _context.Matricula.FindAsync(id);
            _context.Matricula.Remove(matricula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatriculaExists(int id)
        {
            return _context.Matricula.Any(e => e.Id == id);
        }
    }
}
