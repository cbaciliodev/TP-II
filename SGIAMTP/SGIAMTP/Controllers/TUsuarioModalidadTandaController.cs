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
    public class TUsuarioModalidadTandaController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TUsuarioModalidadTandaController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TUsuarioModalidadTandas
        public async Task<IActionResult> Index()
        {


            var dB_A4F05E_SGIAMTPContext = _context.TUsuarioModalidadTanda.Include(t => t.FkIumtCodPartNavigation).Include(t => t.FkIumtCodTanNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }





        [HttpGet]
        public IActionResult GetComboBox()
        {

            var tandaa = _context.TTanda.ToList();


            return Json(new { tand = tandaa });
        }

        [HttpGet]
        public IActionResult MostrarPuntajes(int idtanda, string des, string des1)
        {
            var puntaje = _context.TPuntaje.ToList();
            var user = _context.TUsuario.ToList();
            var user_mod = _context.TUsuarioModalidad.ToList(); var user_modalidad = _context.TUsuarioModalidadTanda.ToList();
            var tanda = _context.TTanda.ToList();
            var mpuntajes = from p in puntaje
                            join tum in user_modalidad on p.FkVumtCod equals tum.PkVumtCod
                            join ta in tanda on tum.FkIumtCodTan equals ta.PkItCodTan
                            join tmodu in user_mod on tum.FkIumtCodPart equals tmodu.PkIumCodUm
                            join tu in user on tmodu.FkIuDni equals tu.PkIuDni

                            select new MostrarPuntajeT
                            {
                                idPuntaje = p.PkIpCodP,
                                codigo = tum.FkIumtCodPart,
                                nombre = (tu.VuNombre + " " + tu.VuApaterno + " " + tu.VuAmaterno),
                                Categoria = ta.VtDescripcion1,
                                Modalidad = ta.VtDescripcion,
                                Pista = tum.IumtPista,
                                Tanda = tum.FkIumtCodTan,
                                PuntajeTotal = p.IpPuntaje,
                                partTanda = tum.PkVumtCod,

                            };
            var model = mpuntajes.GroupBy(test => test.codigo)
                                     .Select(grp => grp.First())
                                     .ToList();
            var result = (from pu in model
                          where (idtanda == 0 ? true : pu.Tanda == idtanda)
                          select new MostrarPuntajeT
                          {
                              codigo = pu.codigo,
                              nombre = pu.nombre,
                              Categoria = pu.Categoria,
                              Modalidad = pu.Modalidad,
                              Pista = pu.Pista,
                              Tanda = pu.Tanda,
                              PuntajeTotal = (
                                            from p in puntaje
                                            where p.FkVumtCod == pu.partTanda
                                            select p.IpPuntaje
                                           ).ToList().Sum()
                          }
                           ).ToList();
            return Json(new { punta = result });
        }


        // GET: TUsuarioModalidadTandas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidadTanda = await _context.TUsuarioModalidadTanda
                .Include(t => t.FkIumtCodPartNavigation)
                .Include(t => t.FkIumtCodTanNavigation)
                .FirstOrDefaultAsync(m => m.PkVumtCod == id);
            if (tUsuarioModalidadTanda == null)
            {
                return NotFound();
            }

            return View(tUsuarioModalidadTanda);
        }

        // GET: TUsuarioModalidadTandas/Create
        public IActionResult Create()
        {
            ViewData["FkIumtCodPart"] = new SelectList(_context.TUsuarioModalidad, "PkIumCodUm", "VmUmArchivoB");
            ViewData["FkIumtCodTan"] = new SelectList(_context.TTanda, "PkItCodTan", "VtDescripcion");
            return View();
        }

        // POST: TUsuarioModalidadTandas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkVumtCod,FkIumtCodPart,FkIumtCodTan,IumtPuntajeTotal,IumtPista,IumtEstado")] TUsuarioModalidadTanda tUsuarioModalidadTanda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tUsuarioModalidadTanda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkIumtCodPart"] = new SelectList(_context.TUsuarioModalidad, "PkIumCodUm", "VmUmArchivoB", tUsuarioModalidadTanda.FkIumtCodPart);
            ViewData["FkIumtCodTan"] = new SelectList(_context.TTanda, "PkItCodTan", "VtDescripcion", tUsuarioModalidadTanda.FkIumtCodTan);
            return View(tUsuarioModalidadTanda);
        }

        // GET: TUsuarioModalidadTandas/Edit/5
        public async Task<IActionResult> Edit()
        {

            return View();
        }

        // POST: TUsuarioModalidadTandas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PkVumtCod,FkIumtCodPart,FkIumtCodTan,IumtPuntajeTotal,IumtPista,IumtEstado")] TUsuarioModalidadTanda tUsuarioModalidadTanda)
        {
            if (id != tUsuarioModalidadTanda.PkVumtCod)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUsuarioModalidadTanda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUsuarioModalidadTandaExists(tUsuarioModalidadTanda.PkVumtCod))
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
            ViewData["FkIumtCodPart"] = new SelectList(_context.TUsuarioModalidad, "PkIumCodUm", "VmUmArchivoB", tUsuarioModalidadTanda.FkIumtCodPart);
            ViewData["FkIumtCodTan"] = new SelectList(_context.TTanda, "PkItCodTan", "VtDescripcion", tUsuarioModalidadTanda.FkIumtCodTan);
            return View(tUsuarioModalidadTanda);
        }

        // GET: TUsuarioModalidadTandas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUsuarioModalidadTanda = await _context.TUsuarioModalidadTanda
                .Include(t => t.FkIumtCodPartNavigation)
                .Include(t => t.FkIumtCodTanNavigation)
                .FirstOrDefaultAsync(m => m.PkVumtCod == id);
            if (tUsuarioModalidadTanda == null)
            {
                return NotFound();
            }

            return View(tUsuarioModalidadTanda);
        }

        // POST: TUsuarioModalidadTandas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tUsuarioModalidadTanda = await _context.TUsuarioModalidadTanda.FindAsync(id);
            _context.TUsuarioModalidadTanda.Remove(tUsuarioModalidadTanda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUsuarioModalidadTandaExists(string id)
        {
            return _context.TUsuarioModalidadTanda.Any(e => e.PkVumtCod == id);
        }

    }
    public class MostrarPuntajeT
    {
        public int idPuntaje { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string Modalidad { get; set; }
        public string Categoria { get; set; }
        public int? Pista { get; set; }
        public int Tanda { get; set; }
        public int PuntajeTotal { get; set; }
        public string partTanda { get; set; }
    }
}
