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
    public class GradoSeccionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GradoSeccionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/GradoSeccion
        public async Task<IActionResult> Index()
        {
            return View(await _context.GradoSeccion.ToListAsync());
        }

        // GET: Admin/GradoSeccion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradoSeccion = await _context.GradoSeccion
                .FirstOrDefaultAsync(m => m.IdGradoSeccion == id);
            if (gradoSeccion == null)
            {
                return NotFound();
            }

            return View(gradoSeccion);
        }

        // GET: Admin/GradoSeccion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/GradoSeccion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGradoSeccion,DescripcionGrado,DescripcionSeccion,Estado")] GradoSeccion gradoSeccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gradoSeccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gradoSeccion);
        }

        // GET: Admin/GradoSeccion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradoSeccion = await _context.GradoSeccion.FindAsync(id);
            if (gradoSeccion == null)
            {
                return NotFound();
            }
            return View(gradoSeccion);
        }

        // POST: Admin/GradoSeccion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGradoSeccion,DescripcionGrado,DescripcionSeccion,Estado")] GradoSeccion gradoSeccion)
        {
            if (id != gradoSeccion.IdGradoSeccion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gradoSeccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradoSeccionExists(gradoSeccion.IdGradoSeccion))
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
            return View(gradoSeccion);
        }

        // GET: Admin/GradoSeccion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradoSeccion = await _context.GradoSeccion
                .FirstOrDefaultAsync(m => m.IdGradoSeccion == id);
            if (gradoSeccion == null)
            {
                return NotFound();
            }

            return View(gradoSeccion);
        }

        // POST: Admin/GradoSeccion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gradoSeccion = await _context.GradoSeccion.FindAsync(id);
            _context.GradoSeccion.Remove(gradoSeccion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradoSeccionExists(int id)
        {
            return _context.GradoSeccion.Any(e => e.IdGradoSeccion == id);
        }
    }
}
