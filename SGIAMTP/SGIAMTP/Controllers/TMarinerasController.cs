using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGIAMTP.Models;

namespace SGIAMTP.Controllers
{
    public class TMarinerasController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TMarinerasController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TMarineras
        public async Task<IActionResult> Index()
        {
            return View(await _context.TMarinera.ToListAsync());
        }

        // GET: TMarineras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tMarinera = await _context.TMarinera
                .FirstOrDefaultAsync(m => m.PkImCod == id);
            if (tMarinera == null)
            {
                return NotFound();
            }

            return View(tMarinera);
        }

        // GET: TMarineras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TMarineras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkImCod,VmNombre")] TMarinera tMarinera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tMarinera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tMarinera);
        }

        // GET: TMarineras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tMarinera = await _context.TMarinera.FindAsync(id);
            if (tMarinera == null)
            {
                return NotFound();
            }
            return View(tMarinera);
        }

        // POST: TMarineras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkImCod,VmNombre")] TMarinera tMarinera)
        {
            if (id != tMarinera.PkImCod)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tMarinera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TMarineraExists(tMarinera.PkImCod))
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
            return View(tMarinera);
        }

        // GET: TMarineras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tMarinera = await _context.TMarinera
                .FirstOrDefaultAsync(m => m.PkImCod == id);
            if (tMarinera == null)
            {
                return NotFound();
            }

            return View(tMarinera);
        }

        // POST: TMarineras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tMarinera = await _context.TMarinera.FindAsync(id);
            _context.TMarinera.Remove(tMarinera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TMarineraExists(int id)
        {
            return _context.TMarinera.Any(e => e.PkImCod == id);
        }
    }
}
