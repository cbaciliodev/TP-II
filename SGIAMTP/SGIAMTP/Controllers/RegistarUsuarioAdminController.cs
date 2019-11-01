using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SGIAMTP.Controllers
{
    public class RegistarUsuarioAdminController : Controller
    {
        public IActionResult RegistroUsuarioModal()
        {
            return View();
        }
    }
}