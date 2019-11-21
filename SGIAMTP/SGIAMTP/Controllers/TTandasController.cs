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


    public class TTandasController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TTandasController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetComboBox()
        {

            var tandaa = _context.TTanda.ToList();


            return Json(new { tand = tandaa });
        }
        [HttpGet]
        public IActionResult MostrarTanda(int idtanda, string des, string des1)
        {
            var puntaje = _context.TPuntaje.ToList();
            var user_modalidad = _context.TUsuarioModalidadTanda.ToList();
            var tanda = _context.TTanda.ToList();
            var mpuntajes = from ta in tanda
                                //join tum in user_modalidad on p.FkVumtCod equals tum.PkVumtCod
                                //join ta in tanda on tum.FkIumtCodTan equals ta.PkItCodTan

                            select new MostrarTanda
                            {
                                idTanda = ta.PkItCodTan,
                                Categoria = ta.VtDescripcion1,
                                Modalidad = ta.VtDescripcion,
                                tipo_tanda = ta.VtTipoTanda,
                                estado = ta.ItEstado
                            };
            var model = mpuntajes.GroupBy(test => test.idTanda)
                                     .Select(grp => grp.First())
                                     .ToList();
            var result = (from pu in model
                          where (idtanda == 0 ? true : pu.idTanda == idtanda)
                          select new MostrarTanda
                          {
                              idTanda = pu.idTanda,
                              Categoria = pu.Categoria,
                              Modalidad = pu.Modalidad,
                              tipo_tanda = pu.tipo_tanda,
                              estado = pu.estado
                          }
                           ).ToList();
            return Json(new { punta = result });
        }

        // GET: TTandas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TTanda.ToListAsync());
        }


        // GET: TTandas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TTandas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkItCodTan,VtDescripcion,VtDescripcion1,ItGanador,VtTipoTanda,ItEstado,DtFechaHora")] TTanda tTanda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tTanda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tTanda);
        }
        // POST: TTandas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        private bool TTandaExists(int id)
        {
            return _context.TTanda.Any(e => e.PkItCodTan == id);
        }
        public async Task<IActionResult> Buscar()
        {
            return View(await _context.TTanda.ToListAsync());
        }
        public async Task<IActionResult> BuscarT(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tTanda = await _context.TTanda.FindAsync(id);
            bool Istandaexist = _context.TTanda.Any
              (x => x.PkItCodTan == tTanda.PkItCodTan);
            if (Istandaexist == false)
            {
                ModelState.AddModelError("tanda1", "No existe tanda");
            }

            TempData["idt"] = tTanda.PkItCodTan;
            TempData["desc"] = tTanda.VtDescripcion;
            TempData["desc1"] = tTanda.VtDescripcion1;
            if (tTanda == null)
            {
                return NotFound();
            }

            //tTanda
            return RedirectToAction("Create", "TPuntajes");
        }
    }
    public class MostrarTanda
    {
        public int idTanda { get; set; }
        public string Modalidad { get; set; }
        public string Categoria { get; set; }
        public string tipo_tanda { get; set; }
        public int? estado { get; set; }
    }
}
