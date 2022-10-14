    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VrundRug.Data;
using VrundRug.Models;

namespace VrundRug.Controllers
{
    public class RugsController : Controller
    {
        private readonly VrundRugContext _context;

        public RugsController(VrundRugContext context)
        {
            _context = context;
        }

        // GET: Rugs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rug.ToListAsync());
        }

        // GET: Rugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rug = await _context.Rug
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rug == null)
            {
                return NotFound();
            }

            return View(rug);
        }

        // GET: Rugs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rugs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MfgPlace,MfgDate,Designs,Material,Price")] Rug rug)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rug);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rug);
        }

        // GET: Rugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rug = await _context.Rug.FindAsync(id);
            if (rug == null)
            {
                return NotFound();
            }
            return View(rug);
        }

        // POST: Rugs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MfgPlace,MfgDate,Designs,Material,Price")] Rug rug)
        {
            if (id != rug.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rug);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RugExists(rug.Id))
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
            return View(rug);
        }

        // GET: Rugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rug = await _context.Rug
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rug == null)
            {
                return NotFound();
            }

            return View(rug);
        }

        // POST: Rugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rug = await _context.Rug.FindAsync(id);
            _context.Rug.Remove(rug);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RugExists(int id)
        {
            return _context.Rug.Any(e => e.Id == id);
        }
    }
}
