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
    public class NivelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NivelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Nivel
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Nivel.Include(n => n.Periodo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Nivel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivel = await _context.Nivel
                .Include(n => n.Periodo)
                .FirstOrDefaultAsync(m => m.IdNivel == id);
            if (nivel == null)
            {
                return NotFound();
            }

            return View(nivel);
        }

        // GET: Admin/Nivel/Create
        public IActionResult Create()
        {
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion");
            return View();
        }

        // POST: Admin/Nivel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNivel,IdPeriodo,DescripcionNivel,DescripcionTurno,HoraInicio,HoraFin,Estado")] Nivel nivel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nivel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion", nivel.IdPeriodo);
            return View(nivel);
        }

        // GET: Admin/Nivel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivel = await _context.Nivel.FindAsync(id);
            if (nivel == null)
            {
                return NotFound();
            }
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion", nivel.IdPeriodo);
            return View(nivel);
        }

        // POST: Admin/Nivel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNivel,IdPeriodo,DescripcionNivel,DescripcionTurno,HoraInicio,HoraFin,Estado")] Nivel nivel)
        {
            if (id != nivel.IdNivel)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nivel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NivelExists(nivel.IdNivel))
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
            ViewData["IdPeriodo"] = new SelectList(_context.Periodo, "IdPeriodo", "Descripcion", nivel.IdPeriodo);
            return View(nivel);
        }

        // GET: Admin/Nivel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivel = await _context.Nivel
                .Include(n => n.Periodo)
                .FirstOrDefaultAsync(m => m.IdNivel == id);
            if (nivel == null)
            {
                return NotFound();
            }

            return View(nivel);
        }

        // POST: Admin/Nivel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nivel = await _context.Nivel.FindAsync(id);
            _context.Nivel.Remove(nivel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NivelExists(int id)
        {
            return _context.Nivel.Any(e => e.IdNivel == id);
        }
    }
}
