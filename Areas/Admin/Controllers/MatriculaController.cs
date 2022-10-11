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
           this._context = context;
        }

        // GET: Admin/Matricula
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Matricula.Include(m => m.Alumno).Include(m => m.NivelDetalle).Include(m => m.NivelDetalleCurso);
            return View(await applicationDbContext.ToListAsync());
        }

        public JsonResult ListaMatriculaAlumno()
        {
            var data = _context.Matricula.Include(m => m.Alumno).Include(m => m.NivelDetalle).Include(m => m.NivelDetalleCurso).ToList();
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
                .Include(m => m.NivelDetalle)
                .Include(m => m.NivelDetalleCurso)
                .FirstOrDefaultAsync(m => m.IdMatricula == id);
            if (matricula == null)
            {
                return NotFound();
            }

            return View(matricula);
        }

        // GET: Admin/Matricula/Create
        public IActionResult Create()
        {
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos");
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle");
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso");
            return View();
        }

        // POST: Admin/Matricula/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMatricula,IdNivelDetalleCurso,IdAlumno,IdNivelDetalle")] Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matricula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos", matricula.IdAlumno);
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle", matricula.IdNivelDetalle);
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", matricula.IdNivelDetalleCurso);
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
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle", matricula.IdNivelDetalle);
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", matricula.IdNivelDetalleCurso);
            return View(matricula);
        }

        // POST: Admin/Matricula/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMatricula,IdNivelDetalleCurso,IdAlumno,IdNivelDetalle")] Matricula matricula)
        {
            if (id != matricula.IdMatricula)
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
                    if (!MatriculaExists(matricula.IdMatricula))
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
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle", matricula.IdNivelDetalle);
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", matricula.IdNivelDetalleCurso);
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
                .Include(m => m.NivelDetalle)
                .Include(m => m.NivelDetalleCurso)
                .FirstOrDefaultAsync(m => m.IdMatricula == id);
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
            return _context.Matricula.Any(e => e.IdMatricula == id);
        }
    }
}
