using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGIAMTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGIAMTP.Controllers
{
    public class AdministarParticipanteController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;
        private readonly ModelContex usuarioModel;
        public AdministarParticipanteController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
            usuarioModel = new ModelContex(context);
        }

        public List<IdentityError> AgregarUsuarioParticipante(
           int FkIuDni,
           int FkIcIdConcurso,
           int FkImIdModalidad,
           string IumFase,
           int FkIuDniPareja,
           DateTime DumFechaIns,
           string VmUmArchivoDni,
           string VmUmArchivoB,
           int FkIeEstado)
        {
            return usuarioModel.AgregarParticipante(
                 FkIuDni,
             FkIcIdConcurso,
             FkImIdModalidad,
             IumFase,
             FkIuDniPareja,
             DumFechaIns,
             VmUmArchivoDni,
             VmUmArchivoB,
             FkIeEstado);
        }




        // GET: AdministarParticipante
        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TUsuarioModalidad.Include(t => t.FkIcIdConcursoNavigation).Include(t => t.FkImIdModalidadNavigation).Include(t => t.FkIuDniNavigation).Include(t => t.FkIuDniParejaNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }




        // GET: AdministarParticipante/Details/5
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

        // GET: AdministarParticipante/Create
        public IActionResult Create()
        {

            ViewData["PK_IU_Dni"] = "44910167";
            ViewData["Sexo"] = "Masculino";

            ViewData["DcFechaConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "DcFechaConcurso");
            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "VcLugarCon");
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "VmNombreMod");
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni");
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni");
            return View();
        }

        // POST: AdministarParticipante/Create
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
            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "VcLugarCon", tUsuarioModalidad.FkIcIdConcurso);
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "PkImIdModalidad", tUsuarioModalidad.FkImIdModalidad);
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDni);
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDniPareja);
            return View(tUsuarioModalidad);
        }

        // GET: AdministarParticipante/Edit/5
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
            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "VcLugarCon", tUsuarioModalidad.FkIcIdConcurso);
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "PkImIdModalidad", tUsuarioModalidad.FkImIdModalidad);
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDni);
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDniPareja);
            return View(tUsuarioModalidad);
        }

        // POST: AdministarParticipante/Edit/5
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
            ViewData["FkIcIdConcurso"] = new SelectList(_context.TConcurso, "PkIcIdConcurso", "VcLugarCon", tUsuarioModalidad.FkIcIdConcurso);
            ViewData["FkImIdModalidad"] = new SelectList(_context.TModalidadCon, "PkImIdModalidad", "PkImIdModalidad", tUsuarioModalidad.FkImIdModalidad);
            ViewData["FkIuDni"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDni);
            ViewData["FkIuDniPareja"] = new SelectList(_context.TUsuario, "PkIuDni", "PkIuDni", tUsuarioModalidad.FkIuDniPareja);
            return View(tUsuarioModalidad);
        }

        // GET: AdministarParticipante/Delete/5
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

        // POST: AdministarParticipante/Delete/5
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


        [HttpGet]
        public IActionResult GetConcurso()
        {

            var codigoConcurso = (from c in _context.TConcurso
                                  where c.FkIecIdEstado == 1
                                  select new Concurso()
                                  {
                                      Codigo = c.PkIcIdConcurso,
                                      Nombre = c.VcNombreCon
                                  }).ToList();

            return Json(new { concurso = codigoConcurso });//dos listas vacias
        }

        [HttpGet]
        public IActionResult GetModalidad()
        {

            var codigoModalidad = (from m in _context.TModalidadCon
                                  //where m.PkImIdModalidad == 1
                                  select new Concurso()
                                  {
                                      Codigo = m.PkImIdModalidad,
                                      Nombre = m.VmNombreMod
                                  }).ToList();

            return Json(new { modalidad = codigoModalidad });//dos listas vacias
        }

        [HttpGet]
        public IActionResult GetPareja(string ssexo)
        {

            var pareja = (from u in _context.TUsuario
                              // where u.VuSexo != "Masculino"
                          where u.VuSexo != ssexo
                          select new Pareja()
                          {
                              Codigo = u.PkIuDni,
                              Nombre = u.VuNombre,
                              Paterno = u.VuApaterno,
                              Materno = u.VuAmaterno
                          }).ToList();

            return Json(new { parejaLista = pareja });//dos listas vacias
        }

        [HttpGet]
        public IActionResult GetParticipante()
        {

            var participante = (from u in _context.TUsuario
                                    //where u.VuSexo != ssexo
                                select new Participante()
                                {
                                    Codigo = u.PkIuDni,
                                    Nombre = u.VuNombre,
                                    Paterno = u.VuApaterno,
                                    Materno = u.VuAmaterno
                                }).ToList();

            return Json(new { participanteLista = participante });//dos listas vacias
        }


        public IActionResult GetParticipanteDatos(int ddni)
        {

            var usuarioDatos = (from u in _context.TUsuario
                                where u.PkIuDni == ddni
                                select new Participante()
                                {
                                    Codigo = u.PkIuDni,
                                    Nombre = u.VuNombre,
                                    Paterno = u.VuApaterno,
                                    Materno = u.VuAmaterno,
                                    Sexo = u.VuSexo
                                });

            return Json(new { usuarioDatosRegistro = usuarioDatos });//dos listas vacias
        }

        
    




    public class Concurso
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
        }

        public class Modalidad
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
        }

        public class Pareja
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Paterno { get; set; }
            public string Materno { get; set; }
        }

        public class Participante
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Paterno { get; set; }
            public string Materno { get; set; }
            public string Sexo { get; set; }
        }
    }
}
