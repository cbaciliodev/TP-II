using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SGIAMTP.Models;

namespace SGIAMTP.Controllers
{
    public class RegistarUsuarioAdminController : Controller
    {

        private readonly DB_A4F05E_SGIAMTPContext _context;
        private UsuarioModels usuarioModel;
        public RegistarUsuarioAdminController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
            usuarioModel = new UsuarioModels(context);
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
                                      codigo = c.PkIcCodCat,
                                      nombre = c.VcNomCategoria
                                  }).ToList();

            return Json(new { categoria = listaCategoria });
        }

        public List<IdentityError> agregarUsuario(
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

            Console.WriteLine("DNI este es eñ dmo" + PkIuDni);
            return usuarioModel.agregarUsuario(
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
        public int codigo { get; set; }
        public string nombre { get; set; }
    }
}
