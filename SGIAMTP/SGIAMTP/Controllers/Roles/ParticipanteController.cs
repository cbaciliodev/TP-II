using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SGIAMTP.Controllers.Roles
{
    public class ParticipanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ParticipanteView()
        {
            return View();
        }
    }
}