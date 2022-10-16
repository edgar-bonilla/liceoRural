using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LICEORURALJASMINEZB.Data;
using LICEORURALJASMINEZB.Models;

namespace LICEORURALJASMINEZB.Areas.Docentes.Controllers
{
    [Area("Docentes")]
    public class CalificacionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalificacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Docentes/Calificacion
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Calificacion.Include(c => c.Alumno).Include(c => c.Concentrado);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Docentes/Calificacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion
                .Include(c => c.Alumno)
                .Include(c => c.Concentrado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calificacion == null)
            {
                return NotFound();
            }

            return View(calificacion);
        }

        // GET: Docentes/Calificacion/Create
        public IActionResult Create()
        {
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos");
            ViewData["IdConcentrado"] = new SelectList(_context.Concentrado, "IdConcentrado", "IdConcentrado");
            return View();
        }

        // POST: Docentes/Calificacion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCalificacion,IdConcentrado,IdAlumno,Nota")] Calificacion calificacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calificacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos", calificacion.IdAlumno);
            ViewData["IdConcentrado"] = new SelectList(_context.Concentrado, "IdConcentrado", "IdConcentrado", calificacion.IdConcentrado);
            return View(calificacion);
        }

        // GET: Docentes/Calificacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion.FindAsync(id);
            if (calificacion == null)
            {
                return NotFound();
            }
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos", calificacion.IdAlumno);
            ViewData["IdConcentrado"] = new SelectList(_context.Concentrado, "IdConcentrado", "IdConcentrado", calificacion.IdConcentrado);
            return View(calificacion);
        }

        // POST: Docentes/Calificacion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCalificacion,IdConcentrado,IdAlumno,Nota")] Calificacion calificacion)
        {
            if (id != calificacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalificacionExists(calificacion.Id))
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
            ViewData["IdAlumno"] = new SelectList(_context.Alumno, "IdAlumno", "Apellidos", calificacion.IdAlumno);
            ViewData["IdConcentrado"] = new SelectList(_context.Concentrado, "IdConcentrado", "IdConcentrado", calificacion.IdConcentrado);
            return View(calificacion);
        }

        // GET: Docentes/Calificacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion
                .Include(c => c.Alumno)
                .Include(c => c.Concentrado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calificacion == null)
            {
                return NotFound();
            }

            return View(calificacion);
        }

        // POST: Docentes/Calificacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calificacion = await _context.Calificacion.FindAsync(id);
            _context.Calificacion.Remove(calificacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalificacionExists(int id)
        {
            return _context.Calificacion.Any(e => e.Id == id);
        }
    }
}
