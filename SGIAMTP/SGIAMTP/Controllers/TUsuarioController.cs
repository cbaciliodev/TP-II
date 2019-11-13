using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGIAMTP.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SGIAMTP.Controllers
{
    public class TUsuarioController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TUsuarioController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TUsuario
        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TUsuario.Include(t => t.FkItuTipoUsuarioNavigation).Include(t => t.FkIuCodCategoriaNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }

        // GET: TUsuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuario = await _context.TUsuario
                .Include(t => t.FkItuTipoUsuarioNavigation)
                .Include(t => t.FkIuCodCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.PkIuDni == id);
            if (tUsuario == null)
            {
                return NotFound();
            }

            return View(tUsuario);
        }

        // GET: TUsuario/Create
        public IActionResult Create()
        {
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario");
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat");
            return View();
        }

        // POST: TUsuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,DuFechaNacimiento,VuContraseña,VuSexo,VuNacademia,FkIuCodCategoria,FkItuTipoUsuario,VuFoto")] TUsuario tUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario", tUsuario.FkItuTipoUsuario);
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat", tUsuario.FkIuCodCategoria);
            return View(tUsuario);
        }

        // GET: TUsuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuario = await _context.TUsuario.FindAsync(id);
            if (tUsuario == null)
            {
                return NotFound();
            }
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario", tUsuario.FkItuTipoUsuario);
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat", tUsuario.FkIuCodCategoria);
            return View(tUsuario);
        }

        // POST: TUsuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIuDni,VuNombre,VuApaterno,VuAmaterno,DuFechaNacimiento,VuContraseña,VuSexo,VuNacademia,FkIuCodCategoria,FkItuTipoUsuario,VuFoto")] TUsuario tUsuario)
        {
            if (id != tUsuario.PkIuDni)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUsuarioExists(tUsuario.PkIuDni))
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
            ViewData["FkItuTipoUsuario"] = new SelectList(_context.TTipoUsuario, "PkItuTipoUsuario", "PkItuTipoUsuario", tUsuario.FkItuTipoUsuario);
            ViewData["FkIuCodCategoria"] = new SelectList(_context.TCategoria, "PkIcCodCat", "PkIcCodCat", tUsuario.FkIuCodCategoria);
            return View(tUsuario);
        }

        // GET: TUsuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuario = await _context.TUsuario
                .Include(t => t.FkItuTipoUsuarioNavigation)
                .Include(t => t.FkIuCodCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.PkIuDni == id);
            if (tUsuario == null)
            {
                return NotFound();
            }

            return View(tUsuario);
        }

        // POST: TUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tUsuario = await _context.TUsuario.FindAsync(id);
            _context.TUsuario.Remove(tUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUsuarioExists(int id)
        {
            return _context.TUsuario.Any(e => e.PkIuDni == id);
        }
    }
}
