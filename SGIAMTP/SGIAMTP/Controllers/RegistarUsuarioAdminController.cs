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
        private List<IdentityError> identityError;
        private string des = "";
        public RegistarUsuarioAdminController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
            identityError = new List<IdentityError>();
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

        public List<IdentityError> guardarUsuario(List<TUsuario> response, int funcion) 
        {

            var UsuarioRegister = new TUsuario
            {
                PkIuDni = response[0].PkIuDni,
                VuNombre = response[0].VuNombre,
                VuApaterno = response[0].VuApaterno,
                VuAmaterno = response[0].VuAmaterno,
                DuFechaNacimiento = response[0].DuFechaNacimiento,
                VuContraseña = response[0].VuContraseña,
                VuSexo = response[0].VuSexo,
                VuNacademia = response[0].VuNacademia,
                FkIuCodCategoria = response[0].FkIuCodCategoria

            };
            try
            {
                _context.Update(UsuarioRegister);
                _context.SaveChanges();
                des = "Save";
            }
            catch (Exception ex)
            {
                des = ex.Message;
            }
            identityError.Add(new IdentityError
            {
                Description = des
            });

            return identityError;
        }
    }

 


    public class CategoriaUsuario
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
    }
}

