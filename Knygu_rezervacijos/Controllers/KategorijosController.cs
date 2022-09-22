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
    public class KategorijosController : Controller
    {
        private readonly Knygu_rezervacijosContext _context;

        public KategorijosController(Knygu_rezervacijosContext context)
        {
            _context = context;
        }

        // GET: Kategorijos
        public async Task<IActionResult> Index()
        {
              return View(await _context.Kategorijos.ToListAsync());
        }

        // GET: Kategorijos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kategorijos == null)
            {
                return NotFound();
            }

            var kategorijos = await _context.Kategorijos
                .FirstOrDefaultAsync(m => m.KategorijosId == id);
            if (kategorijos == null)
            {
                return NotFound();
            }

            return View(kategorijos);
        }

        // GET: Kategorijos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kategorijos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Kategorija,KategorijosId")] Kategorijos kategorijos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kategorijos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kategorijos);
        }

        // GET: Kategorijos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kategorijos == null)
            {
                return NotFound();
            }

            var kategorijos = await _context.Kategorijos.FindAsync(id);
            if (kategorijos == null)
            {
                return NotFound();
            }
            return View(kategorijos);
        }

        // POST: Kategorijos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Kategorija,KategorijosId")] Kategorijos kategorijos)
        {
            if (id != kategorijos.KategorijosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kategorijos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KategorijosExists(kategorijos.KategorijosId))
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
            return View(kategorijos);
        }

        // GET: Kategorijos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kategorijos == null)
            {
                return NotFound();
            }

            var kategorijos = await _context.Kategorijos
                .FirstOrDefaultAsync(m => m.KategorijosId == id);
            if (kategorijos == null)
            {
                return NotFound();
            }

            return View(kategorijos);
        }

        // POST: Kategorijos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kategorijos == null)
            {
                return Problem("Entity set 'Knygu_rezervacijosContext.Kategorijos'  is null.");
            }
            var kategorijos = await _context.Kategorijos.FindAsync(id);
            if (kategorijos != null)
            {
                _context.Kategorijos.Remove(kategorijos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KategorijosExists(int id)
        {
          return _context.Kategorijos.Any(e => e.KategorijosId == id);
        }
    }
}
