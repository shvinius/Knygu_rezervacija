using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Knygu_rezervacijos.Data;
using Knygu_rezervacijos.Models;

namespace Knygu_rezervacijos.Controllers
{
    public class SkaitytojasController : Controller
    {
        private readonly Knygu_rezervacijosContext _context;

        public SkaitytojasController(Knygu_rezervacijosContext context)
        {
            _context = context;
        }

        // GET: Skaitytojas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Skaitytojas.ToListAsync());
        }

        // GET: Skaitytojas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Skaitytojas == null)
            {
                return NotFound();
            }

            var skaitytojas = await _context.Skaitytojas
                .FirstOrDefaultAsync(m => m.PazymejimoId == id);
            if (skaitytojas == null)
            {
                return NotFound();
            }

            return View(skaitytojas);
        }

        // GET: Skaitytojas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Skaitytojas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PazymejimoId,Vardas,Pavarde,PazymejimoIsdavimoData,Slaptazodis")] Skaitytojas skaitytojas)
        {
            Console.WriteLine("Slaptazodis:", skaitytojas.Slaptazodis);
            Console.WriteLine("Pakartotinas slaptazodis:", skaitytojas.PakartotiSlaptazodi);

            if (ModelState.IsValid)
            {
                _context.Add(skaitytojas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skaitytojas);
        }

        // GET: Skaitytojas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Skaitytojas == null)
            {
                return NotFound();
            }

            var skaitytojas = await _context.Skaitytojas.FindAsync(id);
            if (skaitytojas == null)
            {
                return NotFound();
            }
            return View(skaitytojas);
        }

        // POST: Skaitytojas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PazymejimoId,Vardas,Pavarde,PazymejimoIsdavimoData,Slaptazodis")] Skaitytojas skaitytojas)
        {
            if (id != skaitytojas.PazymejimoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skaitytojas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkaitytojasExists(skaitytojas.PazymejimoId))
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
            return View(skaitytojas);
        }

        // GET: Skaitytojas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Skaitytojas == null)
            {
                return NotFound();
            }

            var skaitytojas = await _context.Skaitytojas
                .FirstOrDefaultAsync(m => m.PazymejimoId == id);
            if (skaitytojas == null)
            {
                return NotFound();
            }

            return View(skaitytojas);
        }

        // POST: Skaitytojas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Skaitytojas == null)
            {
                return Problem("Entity set 'Knygu_rezervacijosContext.Skaitytojas'  is null.");
            }
            var skaitytojas = await _context.Skaitytojas.FindAsync(id);
            if (skaitytojas != null)
            {
                _context.Skaitytojas.Remove(skaitytojas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkaitytojasExists(int id)
        {
          return _context.Skaitytojas.Any(e => e.PazymejimoId == id);
        }
    }
}
