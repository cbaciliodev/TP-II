using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGIAMTP.Models
{
    public class Login
    {


        [TempData]
        public String ErrorMessage { get; set; }

        //--------------DNI-------------------
        [Required(ErrorMessage = "<font color='black'>El campo DNI es obligatorio!</font>")]
        public int Dni { get; set; }
        //---------------------------------
        //-------------Pass--------------------
        [Required(ErrorMessage = "<font color='black'>Contraseña es obligatorio!</font>")]
        [DataType(DataType.Password)]
        public string Contra { get; set; }
        //---------------------------------
        [Display(Name = "Remember me")]
        public bool Rememberme { get; set; }
    }
}
