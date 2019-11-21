using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SGIAMTP.Controllers.Roles
{
    public class GerenteController : Controller
    {
        public IActionResult GerenteView()
        {
            return View();
        }
    }
}