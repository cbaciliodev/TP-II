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
    public class TPuntajesController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TPuntajesController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TPuntajes
        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TPuntaje.Include(t => t.FkVumtCodNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }


        // GET: TPuntajes/Create
        public IActionResult Create(int idt)
        {
            TempData["tanda"] = idt;


            //@ViewBag.tipo = TempData["desc"];
            //@ViewBag.cat = TempData["desc1"];
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod");
            return View();
        }

        // POST: TPuntajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIpCodP,IpPuntaje,IpNumeroJurado,FkVumtCod")] TPuntaje tPuntaje)
        {
            if (ModelState.IsValid)
            {
                int v = Convert.ToInt16(TempData["tanda"]);
                _context.Add(tPuntaje);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "TPuntajes", new { idt = v });
                //return Redirect("");
            }
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod", tPuntaje.FkVumtCod);
            return View(tPuntaje);
        }

        private bool TPuntajeExists(int id)
        {
            return _context.TPuntaje.Any(e => e.PkIpCodP == id);
        }
        [HttpGet]
        public IActionResult GetParticipante(int codt)
        {

            var codigoPart = (from c in _context.TUsuarioModalidadTanda
                              where (c.FkIumtCodTan == codt) && (c.IumtEstado == 1)
                              select new Participante()
                              {
                                  Codigo = c.FkIumtCodPart
                              }).ToList();

            return Json(new { ParticipanteLista = codigoPart });
        }
        [HttpGet]
        public IActionResult GetModalidad(int codt)
        {
            var mod = (from m in _context.TTanda
                       where (m.PkItCodTan == codt)
                       select new Modalidad()
                       {
                           nombrem = m.VtDescripcion
                       }
                       ).ToList();

            return Json(new { modalidadLista = mod });
        }
        [HttpGet]
        public IActionResult GetCategoria(int codt)
        {

            var cat = (from m in _context.TTanda
                       where (m.PkItCodTan == codt)
                       select new Categoria()
                       {
                           nombrec = m.VtDescripcion1
                       }
                       ).ToList();

            return Json(new { categoriaLista = cat });
        }
        [HttpGet]
        public IActionResult GetPartand(int codt)
        {

            var codigoPartan = (from c in _context.TUsuarioModalidadTanda
                                where (c.FkIumtCodTan == codt) && (c.IumtEstado == 1)
                                select new Partand()
                                {
                                    Codigo = c.PkVumtCod
                                }).ToList();

            return Json(new { partanLista = codigoPartan });
        }
        public class Participante
        {
            public int Codigo { get; set; }
        }
        public class Partand
        {
            public String Codigo { get; set; }
        }
        public class Modalidad
        {
            public string nombrem { get; set; }
        }
        public class Categoria
        {
            public string nombrec { get; set; }
        }
    }
}
