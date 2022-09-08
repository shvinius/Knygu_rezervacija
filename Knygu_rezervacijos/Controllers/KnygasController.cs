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
    public class KnygasController : Controller
    {
        private readonly Knygu_rezervacijosContext _context;

        public KnygasController(Knygu_rezervacijosContext context)
        {
            _context = context;
        }

        // GET: Knygas
        public async Task<IActionResult> Index()
        {
              return _context.Knyga != null ? 
                          View(await _context.Knyga.ToListAsync()) :
                          Problem("Entity set 'Knygu_rezervacijosContext.Knyga'  is null.");
        }

        // GET: Knygas/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || _context.Knyga == null)
            {
                return NotFound();
            }

            var knyga = await _context.Knyga
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knyga == null)
            {
                return NotFound();
            }

            return View(knyga);
        }

        // GET: Knygas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Knygas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pavadinimas,Santrauka,ISBN,Nuotrauka,PuslapiuSkaicius,Kiekis")] Knyga knyga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knyga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(knyga);
        }

        // GET: Knygas/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || _context.Knyga == null)
            {
                return NotFound();
            }

            var knyga = await _context.Knyga.FindAsync(id);
            if (knyga == null)
            {
                return NotFound();
            }
            return View(knyga);
        }

        // POST: Knygas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pavadinimas,Santrauka,ISBN,Nuotrauka,PuslapiuSkaicius,Kiekis")] Knyga knyga)
        {
            if (id != knyga.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knyga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnygaExists(knyga.Id))
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
            return View(knyga);
        }

        // GET: Knygas/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || _context.Knyga == null)
            {
                return NotFound();
            }

            var knyga = await _context.Knyga
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knyga == null)
            {
                return NotFound();
            }

            return View(knyga);
        }

        // POST: Knygas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Knyga == null)
            {
                return Problem("Entity set 'Knygu_rezervacijosContext.Knyga'  is null.");
            }
            var knyga = await _context.Knyga.FindAsync(id);
            if (knyga != null)
            {
                _context.Knyga.Remove(knyga);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnygaExists(int id)
        {
          return (_context.Knyga?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<IActionResult> MyAction(int valueINeed)
        {
            Console.WriteLine("Kiekis:", valueINeed);
            return _context.Knyga != null ?
                View(await _context.Knyga.ToListAsync()) :
                Problem("Entity set 'Knygu_rezervacijosContext.Knyga'  is null.");
        }
    }
}
