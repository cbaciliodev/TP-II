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
    public class TUsuarioModalidadController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TUsuarioModalidadController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TUsuarioModalidad
        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TUsuarioModalidad.Include(t => t.FkIcIdConcursoNavigation).Include(t => t.FkImIdModalidadNavigation).Include(t => t.FkIuDniNavigation).Include(t => t.FkIuDniParejaNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }

        // GET: TUsuarioModalidad/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidad = await _context.TUsuarioModalidad
                .Include(t => t.FkIcIdConcursoNavigation)
                .Include(t => t.FkImIdModalidadNavigation)
                .Include(t => t.FkIuDniNavigation)
                .Include(t => t.FkIuDniParejaNavigation)
                .FirstOrDefaultAsync(m => m.PkIumCodUm == id);
            if (tUsuarioModalidad == null)
            {
                return NotFound();
            }

            return View(tUsuarioModalidad);
        }

        // GET: TUsuarioModalidad/Create
        public IActionResult Create()
        {

            ViewData["PK_IU_Dni"] = "54321416";
            ViewData["VU_Nombre"] = "Juan Diego";
            ViewData["VU_APaterno"] = "Perez";
            ViewData["VU_AMaterno"] = "velasquez";
            ViewData["DU_FechaNacimiento"] = "1999-02-09";

            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "VcNombreCon");
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "VmNombreMod");
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "VuNombre");
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "VuNombre");
            return View();
        }

        // POST: TUsuarioModalidad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIumCodUm,FkIuDni,FkIcIdConcurso,FkImIdModalidad,IumFase,FkIuDniPareja,DumFechaIns,VmUmArchivoDni,VmUmArchivoB")] TUsuarioModalidad tUsuarioModalidad)
        {
            if (ModelState.IsValid)
            {

                    _context.Add(tUsuarioModalidad);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

               
               
            }
            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "PkIcIdConcurso", tUsuarioModalidad.FkIcIdConcurso);
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "PkImIdModalidad", tUsuarioModalidad.FkImIdModalidad);
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDni);
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDniPareja);
            return View(tUsuarioModalidad);
        }

        // GET: TUsuarioModalidad/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidad = await _context.TUsuarioModalidad.FindAsync(id);
            if (tUsuarioModalidad == null)
            {
                return NotFound();
            }
            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "PkIcIdConcurso", tUsuarioModalidad.FkIcIdConcurso);
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "PkImIdModalidad", tUsuarioModalidad.FkImIdModalidad);
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDni);
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDniPareja);
            return View(tUsuarioModalidad);
        }

        // POST: TUsuarioModalidad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIumCodUm,FkIuDni,FkIcIdConcurso,FkImIdModalidad,IumFase,FkIuDniPareja,DumFechaIns,VmUmArchivoDni,VmUmArchivoB")] TUsuarioModalidad tUsuarioModalidad)
        {
            if (id != tUsuarioModalidad.PkIumCodUm)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUsuarioModalidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUsuarioModalidadExists(tUsuarioModalidad.PkIumCodUm))
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
            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "PkIcIdConcurso", tUsuarioModalidad.FkIcIdConcurso);
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "PkImIdModalidad", tUsuarioModalidad.FkImIdModalidad);
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDni);
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDniPareja);
            return View(tUsuarioModalidad);
        }

        // GET: TUsuarioModalidad/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidad = await _context.TUsuarioModalidad
                .Include(t => t.FkIcIdConcursoNavigation)
                .Include(t => t.FkImIdModalidadNavigation)
                .Include(t => t.FkIuDniNavigation)
                .Include(t => t.FkIuDniParejaNavigation)
                .FirstOrDefaultAsync(m => m.PkIumCodUm == id);
            if (tUsuarioModalidad == null)
            {
                return NotFound();
            }

            return View(tUsuarioModalidad);
        }

        // POST: TUsuarioModalidad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tUsuarioModalidad = await _context.TUsuarioModalidad.FindAsync(id);
            _context.TUsuarioModalidad.Remove(tUsuarioModalidad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUsuarioModalidadExists(int id)
        {
            return _context.TUsuarioModalidad.Any(e => e.PkIumCodUm == id);
        }
    }
}
