using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SGIAMTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGIAMTP.Controllers
{
    public class RegistarUsuarioAdminController : Controller
    {

        private readonly DB_A4F05E_SGIAMTPContext _context;
        private readonly ModelContex usuarioModel;
        public RegistarUsuarioAdminController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
            usuarioModel = new ModelContex(context);
        }

        public IActionResult RegistroUsuarioModal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetListaCategoria()
        {

            var listaCategoria = (from c in _context.TCategoria
                                      // where c.FkIecIdEstado == 1
                                  select new CategoriaUsuario()
                                  {
                                      Codigo = c.PkIcCodCat,
                                      Nombre = c.VcNomCategoria
                                  }).ToList();

            return Json(new { categoria = listaCategoria });
        }

        public List<IdentityError> AgregarUsuario(
            int PkIuDni,
            string VuNombre,
            string VuApaterno,
            string VuAmaterno,
            DateTime DuFechaNacimiento,
            string VuContraseña,
            string VuSexo,
            string VuNacademia,
            int FkIuCodCategoria,
            int FkItuTipoUsuario,
            string VuFoto
            )
        {
            return usuarioModel.AgregarUsuario(
                PkIuDni,
                VuNombre,
                VuApaterno,
                VuAmaterno,
                DuFechaNacimiento,
                VuContraseña,
                VuSexo,
                VuNacademia,
                FkIuCodCategoria,
                FkItuTipoUsuario,
                VuFoto
         );
        }
    }

    public class CategoriaUsuario
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
