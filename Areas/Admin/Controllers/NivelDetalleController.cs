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
    public class NivelDetalleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NivelDetalleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/NivelDetalle
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.NivelDetalle.Include(n => n.GradoSeccion).Include(n => n.Nivel);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/NivelDetalle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDetalle = await _context.NivelDetalle
                .Include(n => n.GradoSeccion)
                .Include(n => n.Nivel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nivelDetalle == null)
            {
                return NotFound();
            }

            return View(nivelDetalle);
        }

        // GET: Admin/NivelDetalle/Create
        public IActionResult Create()
        {
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion");
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel");
            return View();
        }

        // POST: Admin/NivelDetalle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNivelDetalle,IdNivel,IdGradoSeccion,TotalVacantes,VacantesDisponibles,VacantesOcupadas,Estado")] NivelDetalle nivelDetalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nivelDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion", nivelDetalle.IdGradoSeccion);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel", nivelDetalle.IdNivel);
            return View(nivelDetalle);
        }

        // GET: Admin/NivelDetalle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDetalle = await _context.NivelDetalle.FindAsync(id);
            if (nivelDetalle == null)
            {
                return NotFound();
            }
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion", nivelDetalle.IdGradoSeccion);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel", nivelDetalle.IdNivel);
            return View(nivelDetalle);
        }

        // POST: Admin/NivelDetalle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNivelDetalle,IdNivel,IdGradoSeccion,TotalVacantes,VacantesDisponibles,VacantesOcupadas,Estado")] NivelDetalle nivelDetalle)
        {
            if (id != nivelDetalle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nivelDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NivelDetalleExists(nivelDetalle.Id))
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
            ViewData["IdGradoSeccion"] = new SelectList(_context.GradoSeccion, "IdGradoSeccion", "IdGradoSeccion", nivelDetalle.IdGradoSeccion);
            ViewData["IdNivel"] = new SelectList(_context.Nivel, "IdNivel", "IdNivel", nivelDetalle.IdNivel);
            return View(nivelDetalle);
        }

        // GET: Admin/NivelDetalle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivelDetalle = await _context.NivelDetalle
                .Include(n => n.GradoSeccion)
                .Include(n => n.Nivel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nivelDetalle == null)
            {
                return NotFound();
            }

            return View(nivelDetalle);
        }

        // POST: Admin/NivelDetalle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nivelDetalle = await _context.NivelDetalle.FindAsync(id);
            _context.NivelDetalle.Remove(nivelDetalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NivelDetalleExists(int id)
        {
            return _context.NivelDetalle.Any(e => e.Id == id);
        }
    }
}
