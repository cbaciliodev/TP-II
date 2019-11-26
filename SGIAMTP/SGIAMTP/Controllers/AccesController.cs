using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGIAMTP.Models;

namespace SGIAMTP.Controllers
{
    public class AccesController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;
        public AccesController(DB_A4F05E_SGIAMTPContext context)
        {

            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Acces()
        {
            return View();
        }



        //public ViewResult NotFound(System.Web.Mvc.HandleErrorInfo exception)
        //{
        //    ViewBag.Title = "Page Not Found";
        //    return View("Error", exception);
        //}

        public class usr
        {
            public int dniusr { get; set; }
            public string passusr { get; set; }
            public int? tipousr { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(Login user)
        {
            //    bool dni = _context.TUsuario.Any(x => x.PkIuDni == user.Dni);
            //    bool contra = _context.TUsuario.Any(con => con.VuContraseña == user.Contra);


            var us = (from c in _context.TUsuario
                      where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
                      select new usr()
                      {
                          dniusr = c.PkIuDni,

                      }).FirstOrDefault();
            var us1 = (from c in _context.TUsuario
                       where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
                       select new usr()
                       {
                           passusr = c.VuContraseña,

                       }).FirstOrDefault();
            var us2 = (from c in _context.TUsuario
                       where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
                       select new usr()
                       {
                           tipousr = c.FkItuTipoUsuario

                       }).FirstOrDefault();

            if (us == null && us1 == null && us2 == null)
            {
                ModelState.AddModelError("Errores", "Los datos son incorrectos");

                return RedirectToAction("Acces", "Acces");

            }

            else
            {
                bool dni = _context.TUsuario.Any(x => x.PkIuDni == us.dniusr);
                bool contra = _context.TUsuario.Any(con => con.VuContraseña == us1.passusr);

                if (dni == true && contra == true && us2.tipousr == 1)
                {
                    await Task.Delay(100);
                    //HttpContext.Session.SetString("user", "user");
                    return RedirectToAction("About", "Home");
                    //return RedirectToAction("Index", "Home");
                }
                else if (dni == true && contra == true && us2.tipousr == 2) //ariana
                {
                    ViewData["dni"] = user.Dni  ;
                    ViewBag.dni = user.Dni;
                    return RedirectToAction("About", "Home");
                }
                else if (dni == true && contra == true && us2.tipousr == 3) //ariana
                {
                    return RedirectToAction("JuradoView", "Jurado");
                }
                else if (dni == true && contra == true && us2.tipousr == 4) //ariana
                {
                    return RedirectToAction("PresentadorView", "Presentador");
                }
                else if (dni == true && contra == true && us2.tipousr == 5) //ariana
                {
                    return RedirectToAction("GerenteView", "Gerente");
                }
                else
                {
                    return RedirectToAction("LogIn", "Acces");
                }
            }
        }
    }
}