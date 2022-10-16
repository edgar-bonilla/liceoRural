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
    public class NivelDetalleCursoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NivelDetalleCursoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/NivelDetalleCurso
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.NivelDetalleCurso.Include(n => n.Curso).Include(n => n.GradoSeccion).Include(n => n.Nivel).Include(n => n.NivelDetalle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/NivelDetalleCurso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDetalleCurso = await _context.NivelDetalleCurso
                .Include(n => n.Curso)
                .Include(n => n.GradoSeccion)
                .Include(n => n.Nivel)
                .Include(n => n.NivelDetalle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nivelDetalleCurso == null)
            {
                return NotFound();
            }

            return View(nivelDetalleCurso);
        }

        // GET: Admin/NivelDetalleCurso/Create
        public IActionResult Create()
        {
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Estado");
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion");
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel");
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle");
            return View();
        }

        // POST: Admin/NivelDetalleCurso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNivelDetalleCurso,IdNivelDetalle,IdNivel,IdGradoSeccion,IdCurso")] NivelDetalleCurso nivelDetalleCurso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nivelDetalleCurso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Estado", nivelDetalleCurso.IdCurso);
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion", nivelDetalleCurso.IdGradoSeccion);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel", nivelDetalleCurso.IdNivel);
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle", nivelDetalleCurso.IdNivelDetalle);
            return View(nivelDetalleCurso);
        }

        // GET: Admin/NivelDetalleCurso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDetalleCurso = await _context.NivelDetalleCurso.FindAsync(id);
            if (nivelDetalleCurso == null)
            {
                return NotFound();
            }
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Estado", nivelDetalleCurso.IdCurso);
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion", nivelDetalleCurso.IdGradoSeccion);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel", nivelDetalleCurso.IdNivel);
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle", nivelDetalleCurso.IdNivelDetalle);
            return View(nivelDetalleCurso);
        }

        // POST: Admin/NivelDetalleCurso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNivelDetalleCurso,IdNivelDetalle,IdNivel,IdGradoSeccion,IdCurso")] NivelDetalleCurso nivelDetalleCurso)
        {
            if (id != nivelDetalleCurso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nivelDetalleCurso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NivelDetalleCursoExists(nivelDetalleCurso.Id))
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
            ViewData["IdCurso"] = new SelectList(_context.Curso, "IdCurso", "Estado", nivelDetalleCurso.IdCurso);
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion", nivelDetalleCurso.IdGradoSeccion);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel", nivelDetalleCurso.IdNivel);
            ViewData["IdNivelDetalle"] = new SelectList(_context.NivelDetalle, "IdNivelDetalle", "IdNivelDetalle", nivelDetalleCurso.IdNivelDetalle);
            return View(nivelDetalleCurso);
        }

        // GET: Admin/NivelDetalleCurso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDetalleCurso = await _context.NivelDetalleCurso
                .Include(n => n.Curso)
                .Include(n => n.GradoSeccion)
                .Include(n => n.Nivel)
                .Include(n => n.NivelDetalle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nivelDetalleCurso == null)
            {
                return NotFound();
            }

            return View(nivelDetalleCurso);
        }

        // POST: Admin/NivelDetalleCurso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nivelDetalleCurso = await _context.NivelDetalleCurso.FindAsync(id);
            _context.NivelDetalleCurso.Remove(nivelDetalleCurso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NivelDetalleCursoExists(int id)
        {
            return _context.NivelDetalleCurso.Any(e => e.Id== id);
        }
    }
}
