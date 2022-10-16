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
    public class DocenteCursoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DocenteCursoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/DocenteCurso
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DocenteCurso.Include(d => d.Docente).Include(d => d.NivelDetalleCurso);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/DocenteCurso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docenteCurso = await _context.DocenteCurso
                .Include(d => d.Docente)
                .Include(d => d.NivelDetalleCurso)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docenteCurso == null)
            {
                return NotFound();
            }

            return View(docenteCurso);
        }

        // GET: Admin/DocenteCurso/Create
        public IActionResult Create()
        {
            ViewData["IdDocente"] = new SelectList(_context.Docente, "IdDocente", "Apellidos");
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso");
            return View();
        }

        // POST: Admin/DocenteCurso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDocenteCurso,IdNivelDetalleCurso,IdDocente,Estado")] DocenteCurso docenteCurso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(docenteCurso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDocente"] = new SelectList(_context.Docente, "IdDocente", "Apellidos", docenteCurso.IdDocente);
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", docenteCurso.IdNivelDetalleCurso);
            return View(docenteCurso);
        }

        // GET: Admin/DocenteCurso/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docenteCurso = await _context.DocenteCurso.FindAsync(id);
            if (docenteCurso == null)
            {
                return NotFound();
            }
            ViewData["IdDocente"] = new SelectList(_context.Docente, "IdDocente", "Apellidos", docenteCurso.IdDocente);
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", docenteCurso.IdNivelDetalleCurso);
            return View(docenteCurso);
        }

        // POST: Admin/DocenteCurso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDocenteCurso,IdNivelDetalleCurso,IdDocente,Estado")] DocenteCurso docenteCurso)
        {
            if (id != docenteCurso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(docenteCurso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocenteCursoExists(docenteCurso.Id))
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
            ViewData["IdDocente"] = new SelectList(_context.Docente, "IdDocente", "Apellidos", docenteCurso.IdDocente);
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", docenteCurso.IdNivelDetalleCurso);
            return View(docenteCurso);
        }

        // GET: Admin/DocenteCurso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var docenteCurso = await _context.DocenteCurso
                .Include(d => d.Docente)
                .Include(d => d.NivelDetalleCurso)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (docenteCurso == null)
            {
                return NotFound();
            }

            return View(docenteCurso);
        }

        // POST: Admin/DocenteCurso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var docenteCurso = await _context.DocenteCurso.FindAsync(id);
            _context.DocenteCurso.Remove(docenteCurso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocenteCursoExists(int id)
        {
            return _context.DocenteCurso.Any(e => e.Id == id);
        }
    }
}
