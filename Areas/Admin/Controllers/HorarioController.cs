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
    public class HorarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HorarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Horario
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Horario.Include(h => h.NivelDetalleCurso);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Horario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario
                .Include(h => h.NivelDetalleCurso)
                .FirstOrDefaultAsync(m => m.IdHorario == id);
            if (horario == null)
            {
                return NotFound();
            }

            return View(horario);
        }

        // GET: Admin/Horario/Create
        public IActionResult Create()
        {
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso");
            return View();
        }

        // POST: Admin/Horario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdHorario,IdNivelDetalleCurso,DiaSemana,HoraInicio,HoraFin,Estado")] Horario horario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(horario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", horario.IdNivelDetalleCurso);
            return View(horario);
        }

        // GET: Admin/Horario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario.FindAsync(id);
            if (horario == null)
            {
                return NotFound();
            }
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", horario.IdNivelDetalleCurso);
            return View(horario);
        }

        // POST: Admin/Horario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdHorario,IdNivelDetalleCurso,DiaSemana,HoraInicio,HoraFin,Estado")] Horario horario)
        {
            if (id != horario.IdHorario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorarioExists(horario.IdHorario))
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
            ViewData["IdNivelDetalleCurso"] = new SelectList(_context.NivelDetalleCurso, "IdNivelDetalleCurso", "IdNivelDetalleCurso", horario.IdNivelDetalleCurso);
            return View(horario);
        }

        // GET: Admin/Horario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario
                .Include(h => h.NivelDetalleCurso)
                .FirstOrDefaultAsync(m => m.IdHorario == id);
            if (horario == null)
            {
                return NotFound();
            }

            return View(horario);
        }

        // POST: Admin/Horario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var horario = await _context.Horario.FindAsync(id);
            _context.Horario.Remove(horario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorarioExists(int id)
        {
            return _context.Horario.Any(e => e.IdHorario == id);
        }
    }
}
